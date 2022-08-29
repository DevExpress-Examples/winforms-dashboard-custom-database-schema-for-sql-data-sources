Imports DevExpress.DataAccess.Sql
Imports DevExpress.Xpo.DB
Imports System.Linq

Namespace Dashboard_CustomSchemaProvider

    Public Class LimitDBSchemaProvider
        Implements IDBSchemaProviderEx

        Private provider As DBSchemaProviderEx

        Public Sub New()
            provider = New DBSchemaProviderEx()
        End Sub

        Public Function GetTables(ByVal connection As SqlDataConnection, ParamArray tableList As String()) As DBTable() Implements IDBSchemaProviderEx.GetTables
            ' Returns only the tables which names start with the letter C.
            Return provider.GetTables(connection, tableList).Where(Function(table) table.Name.StartsWith("C")).ToArray()
        End Function

        Public Function GetViews(ByVal connection As SqlDataConnection, ParamArray viewList As String()) As DBTable() Implements IDBSchemaProviderEx.GetViews
            ' Returns only the views which names start with Order.
            Return provider.GetViews(connection, viewList).Where(Function(view) view.Name.StartsWith("Order")).ToArray()
        End Function

        Public Function GetProcedures(ByVal connection As SqlDataConnection, ParamArray procedureList As String()) As DBStoredProcedure() Implements IDBSchemaProviderEx.GetProcedures
            ' Returns only the stored procedures with zero argumnents.
            Return provider.GetProcedures(connection, procedureList).Where(Function(storedProcedure) storedProcedure.Arguments.Count = 0).ToArray()
        End Function

        Public Sub LoadColumns(ByVal connection As SqlDataConnection, ParamArray tables As DBTable()) Implements IDBSchemaProviderEx.LoadColumns
            ' Loads all columns in tables.
            provider.LoadColumns(connection, tables)
        End Sub
    End Class
End Namespace
