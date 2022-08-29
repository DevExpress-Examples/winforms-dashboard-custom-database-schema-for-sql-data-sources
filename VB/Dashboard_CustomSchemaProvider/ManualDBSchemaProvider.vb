Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.DataAccess.Sql
Imports DevExpress.Xpo.DB
Imports System.Collections.Specialized

Namespace Dashboard_CustomSchemaProvider

    Public Class ManualDBSchemaProvider
        Implements IDBSchemaProviderEx

        Private tables As DBTable()

        Public Sub LoadColumns(ByVal connection As SqlDataConnection, ParamArray tables As DBTable()) Implements IDBSchemaProviderEx.LoadColumns
            ' Loads the specified columns in the Categories and Products tables.
            For Each table As DBTable In tables
                If Equals(table.Name, "Categories") AndAlso table.Columns.Count = 0 Then
                    Dim categoryIdColumn As DBColumn = New DBColumn With {.Name = "CategoryID", .ColumnType = DBColumnType.Int32}
                    table.AddColumn(categoryIdColumn)
                    Dim categoryNameColumn As DBColumn = New DBColumn With {.Name = "CategoryName", .ColumnType = DBColumnType.String}
                    table.AddColumn(categoryNameColumn)
                End If

                If Equals(table.Name, "Products") AndAlso table.Columns.Count = 0 Then
                    Dim categoryIdColumn As DBColumn = New DBColumn With {.Name = "CategoryID", .ColumnType = DBColumnType.Int32}
                    table.AddColumn(categoryIdColumn)
                    Dim productNameColumn As DBColumn = New DBColumn With {.Name = "ProductName", .ColumnType = DBColumnType.String}
                    table.AddColumn(productNameColumn)
                    ' Links the tables by the CategoryID field.
                    Dim foreignKey As DBForeignKey = New DBForeignKey({categoryIdColumn}, "Categories", CreatePrimaryKeys("CategoryID"))
                    table.ForeignKeys.Add(foreignKey)
                End If
            Next
        End Sub

        Public Shared Function CreatePrimaryKeys(ParamArray names As String()) As StringCollection
            Dim collection As StringCollection = New StringCollection()
            collection.AddRange(names)
            Return collection
        End Function

        Public Function GetTables(ByVal connection As SqlDataConnection, ParamArray tableList As String()) As DBTable() Implements IDBSchemaProviderEx.GetTables
            ' Loads only the Categories and Products tables for the NWindConnectionString connection.
            Dim cp = TryCast(connection.ConnectionParameters, Access97ConnectionParameters)
            If cp IsNot Nothing AndAlso cp.FileName.Contains("nwind.mdb") Then
                If tables IsNot Nothing Then
                    Return tables
                End If

                tables = New DBTable(1) {}
                Dim categoriesTable As DBTable = New DBTable("Categories")
                tables(0) = categoriesTable
                Dim productsTable As DBTable = New DBTable("Products")
                tables(1) = productsTable
            Else
                tables = New DBTable(-1) {}
            End If

            LoadColumns(connection, tables)
            Return tables
        End Function

        Public Function GetViews(ByVal connection As SqlDataConnection, ParamArray viewList As String()) As DBTable() Implements IDBSchemaProviderEx.GetViews
            Dim views As DBTable() = New DBTable(-1) {}
            Return views
        End Function

        Public Function GetProcedures(ByVal connection As SqlDataConnection, ParamArray procedureList As String()) As DBStoredProcedure() Implements IDBSchemaProviderEx.GetProcedures
            Dim storedProcedures As DBStoredProcedure() = New DBStoredProcedure(-1) {}
            Return storedProcedures
        End Function
    End Class
End Namespace
