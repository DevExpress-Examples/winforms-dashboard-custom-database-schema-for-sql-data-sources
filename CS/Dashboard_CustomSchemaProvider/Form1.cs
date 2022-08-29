using DevExpress.DashboardWin;

namespace Dashboard_CustomSchemaProvider {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        public Form1() {
            InitializeComponent();
            dashboardDesigner1.CreateRibbon();
            dashboardDesigner1.LoadDashboard(@"Data\dashboard-with-products.xml");

            // This propery is used to specify the database schema provider.
            // Uncomment one of the following lines depending on the provider.
            dashboardDesigner1.CustomDBSchemaProviderEx = new ManualDBSchemaProvider();
            // dashboardDesigner1.CustomDBSchemaProviderEx = new LimitDBSchemaProvider();
        }
    }
}
