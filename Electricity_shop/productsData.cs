using System.Windows.Forms;

namespace Electricity_shop
{
    public partial class Frm_productsData : Form
    {
        private readonly DBSQL mySQL;
        public Frm_productsData()
        {
            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;
        }

        private void Frm_productsData_Load(object sender, System.EventArgs e)
        {
            Lbl_outOfStockNumber.Text= mySQL.countOutStockProducts().ToString();
            Lbl_aboutToRunOutNumber.Text= mySQL.countAboutToEnd().ToString();
            Lbl_totalProductsNumber.Text ="";
        }
    }
}
