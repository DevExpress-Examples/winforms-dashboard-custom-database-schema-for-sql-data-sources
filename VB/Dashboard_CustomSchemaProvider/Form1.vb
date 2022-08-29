Namespace Dashboard_CustomSchemaProvider

    Public Partial Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()
            dashboardDesigner1.CreateRibbon()
            dashboardDesigner1.LoadDashboard("Data\dashboard-with-products.xml")
            ' This propery is used to specify the database schema provider.
            ' Uncomment one of the following lines depending on the provider.
            dashboardDesigner1.CustomDBSchemaProviderEx = New ManualDBSchemaProvider()
        ' dashboardDesigner1.CustomDBSchemaProviderEx = new LimitDBSchemaProvider();
        End Sub
    End Class
End Namespace
