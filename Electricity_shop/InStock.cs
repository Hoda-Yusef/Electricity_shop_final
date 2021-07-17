using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;

using System.IO;

namespace Electricity_shop
{
    public partial class Frm_InStock : Form
    {
        Thread th;
        private DBSQL mySQL;
        Product[] product;
        Document doc = new Document();

        public Frm_InStock()
        {
            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;
        }

        private void opennewform(object obj)
        {
            Application.Run(new Frm_main());
        }
        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void Btn_saveDocument_Click(object sender, EventArgs e)
        {

            iTextSharp.text.pdf.PdfWriter.GetInstance(doc, new FileStream("products.pdf", FileMode.Create));
            doc.Open();


            PdfPTable table = new PdfPTable(Grd_products_stock.Columns.Count);

            table.RunDirection = PdfWriter.RUN_DIRECTION_NO_BIDI;



            for (int j = 0; j < Grd_products_stock.Columns.Count; j++)
            {
                table.AddCell(new Phrase(Grd_products_stock.Columns[j].HeaderText));
            }

            table.HeaderRows = 1;

            for (int i = 0; i < Grd_products_stock.Rows.Count; i++)
            {
                for (int k = 0; k < Grd_products_stock.Columns.Count; k++)
                {
                    if (Grd_products_stock[k, i].Value != null)
                    {
                        //table.AddCell(new Phrase(Grd_products_stock[k, i].Value.ToString()));
                        table.AddCell(new Phrase("שלום"));
                    }
                }
            }

            doc.Add(table);

            doc.Close();

            MessageBox.Show("נוצר דוח בהצלחה");

        }

        private void Frm_InStock_Load(object sender, EventArgs e)
        {
            Product[] Product = mySQL.GetProductData();

            for (int i = 0; i < Product.Length; i++)
            {
                Grd_products_stock.Rows.Add(new object[]
                {
                    Product[i].Category,
                    Product[i].Manufacturer,
                    Product[i].Model,
                    Product[i].Barcode,
                    Product[i].Supplier,
                    Product[i].Amount,
                    Product[i].Product_info
                });
            }
        }
    }
}
