//Hoda Khier + Yusef Aborokon 44/5

using System;
using System.Threading;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Font = iTextSharp.text.Font;
using System.Drawing;

namespace Electricity_shop
{
    public partial class Frm_InStock : Form
    {
        Thread th;
        private DBSQL mySQL;
        readonly Product[] product;
        Document doc = new Document();
        bool drag = false;
        Point sp = new Point(0, 0);

        public Frm_InStock()
        {
            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;
        }

        private void Opennewform(object obj)
        {
            Application.Run(new Frm_main(1));
        }

        // לחיצה על כפתור ה X

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(Opennewform);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }
        // יוצרים דו'ח ספירת מלאי עדכני לגבי מוצרים בחנות
        private void Btn_saveDocument_Click(object sender, EventArgs e)
        {

            //בודקים אם קובץ נוצר לפי התאריך שנבחר
            if (File.Exists(dateTimePicker1.Text.ToString() + ".pdf"))
            {
                MessageBox.Show("דוח קיים");
            }

            else
            {
                //string ARIALUNI_TFF = Path.Combine("C:\\Users\\hp\\source\\repos\\Electricity_shop_final\\Electricity_shop\\bin\\Debug\\netcoreapp3.1\\", "ARIAL.TTF");

                // יוצרים קובץ בשם
                iTextSharp.text.pdf.PdfWriter.GetInstance(doc, new FileStream(dateTimePicker1.Text.ToString() + ".pdf", FileMode.Create));
                doc.Open();
                // יוצרים טבלה
                PdfPTable table = new PdfPTable(Grd_products_stock.Columns.Count);
                table.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                table.HorizontalAlignment = Element.ALIGN_CENTER;
               // BaseFont bf = BaseFont.CreateFont(ARIALUNI_TFF, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

                //מגדירים גופן
                Font font = new Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN);
                Font headerFont = new Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN);
                Font headerFont2 = new Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 24);
              Paragraph myPar1 = new Paragraph("Inventory Count Report\n", headerFont2);
                //Paragraph myPar1 = new Paragraph("שלום\n", headerFont2);
                myPar1.Alignment = Element.ALIGN_CENTER;
                //מגדירים כותרת ראשונה
                Paragraph myPar = new Paragraph("Trade In Electricity Shop\n", headerFont2);
                myPar.Alignment = Element.ALIGN_CENTER;
                //כותרת שנייה
                Paragraph myPar2 = new Paragraph("Dalyat Al-Carmel", headerFont2);
                myPar2.Alignment = Element.ALIGN_CENTER;

                Paragraph myPar3 = new Paragraph("Since 2005\n\n\n\n\n", headerFont);
                myPar3.Alignment = Element.ALIGN_CENTER;

                doc.Add(myPar1);
                doc.Add(myPar);
                doc.Add(myPar2);
                doc.Add(myPar3);

                // הגדרת כותרות בטבלה + צבע 
                for (int j = 0; j < Grd_products_stock.Columns.Count; j++)
                {
                    headerFont.Color = BaseColor.RED;
                    PdfPCell headerCell = new PdfPCell();
                    headerCell.FixedHeight = 20;
                    headerCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    headerCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                    headerCell.Phrase = new Phrase(Grd_products_stock.Columns[j].HeaderText, headerFont);
                    table.AddCell(headerCell);
                }

                table.HeaderRows = 1;

                // הגדרת תוכן הטבלה
                for (int i = 0; i < Grd_products_stock.Rows.Count; i++)
                {
                    for (int k = 0; k < Grd_products_stock.Columns.Count; k++)
                    {
                        if (Grd_products_stock[k, i].Value != null)
                        {
                            font.Color = BaseColor.BLACK;
                            table.WidthPercentage = 90;
                            table.HorizontalAlignment = Element.ALIGN_MIDDLE;
                            PdfPCell myCell = new PdfPCell();
                            myCell.FixedHeight = 20;
                            myCell.HorizontalAlignment = Element.ALIGN_CENTER;
                            myCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                            myCell.Phrase = new Phrase(Grd_products_stock[k, i].Value.ToString(), font);
                            table.AddCell(myCell);
                        }
                    }
                }

                doc.Add(table);

                doc.Close();

                MessageBox.Show("נוצר דוח בהצלחה");
            }

        }
        // לחיצה על כפתור צור דו'ח
        // יוצרים קובץ PDF וכותבים לו מידע עדכני לגבי כמות מוצרים 
        // דו'ח ספירת מלאי
        private void Frm_InStock_Load(object sender, EventArgs e)
        {
            Product[] Product = mySQL.GetProductData();

            if (Product != null)
            {
                for (int i = 0; i < Product.Length; i++)
                {
                    Grd_products_stock.Rows.Add(new object[]
                    {
                    Product[i].Barcode,
                    Product[i].Manufacturer,
                    Product[i].Model,
                    Product[i].Amount,
                    Product[i].Cost_price,
                    Product[i].Selling_price,

                    });
                }
            }
        }
        // לחיצה על כפתור הצג דו'ח
        // מגדירים מסלול שנמצאים בו הדוחות
        //מחפשים שם דוח בשם התאריך שנבחר: אם קיים אז המשתמש יכול לפתוח אותו
        // אחרת תופיע תיקייה ריקה
        private void Btn_showDocument_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\Users\\hp\\source\\repos\\Electricity_shop_final\\Electricity_shop\\bin\\Debug\\netcoreapp3.1\\";
                // מציג דוח ספיציפי בעל שם של התאריך שנבחר
                openFileDialog.Filter = "txt files ("+dateTimePicker1.Text.ToString()+ ".pdf)|" + dateTimePicker1.Text.ToString() + ".pdf";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            //MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            sp = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - sp.X, p.Y - sp.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
    }
}
