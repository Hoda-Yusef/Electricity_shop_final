﻿//Hoda Khier + Yusef Aborokon 44/5

using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;


namespace Electricity_shop
{
    //מחלקה לניהול והצגת פרטים של ספקים
    public partial class Frm_suppliersManagement : Form
    {
        bool drag = false;
        Point sp = new Point(0, 0);
        Thread th;
        private DBSQL mySQL;
        private supplier[] Supplier;
        AutoCompleteStringCollection firstNameAuto = new AutoCompleteStringCollection();
        AutoCompleteStringCollection last_nameAuto = new AutoCompleteStringCollection();
        int usersRole;
        string userName;
        public Frm_suppliersManagement(int role,string username)
        {
            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;
            usersRole = role;
            userName = username;
        }

        private void Btn_exit_Click(object sender, EventArgs e)//כפתור ליציאה מחלון
        {
            if (usersRole == 1)
            {
                Thread th;
                this.Close();
                th = new Thread(OpenMain);
                th.TrySetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
            {
                Thread th;
                this.Close();
                th = new Thread(OpenEmployeesMain);
                th.TrySetApartmentState(ApartmentState.STA);
                th.Start();
            }

        }

        private void OpenMain(object obj)
        {
            Application.Run(new Frm_main(usersRole, userName));//פתיחת דף ראשי
        }
        private void OpenEmployeesMain(object obj)
        {
            Application.Run(new Frm_mainForEmployees(usersRole,userName));//פתיחת דף ראשי
        }


        private void Btn_updateSupplier_Click(object sender, EventArgs e)//כפתור לעידכון ספק
        {
            Frm_updateSupplier uSupplier = new Frm_updateSupplier(usersRole,userName);
            uSupplier.Txt_firstName.Text = Grd_suppliers.CurrentRow.Cells[0].Value.ToString();
            uSupplier.Txt_lastName.Text = Grd_suppliers.CurrentRow.Cells[1].Value.ToString();
            uSupplier.Txt_address.Text = Grd_suppliers.CurrentRow.Cells[3].Value.ToString();
            uSupplier.Txt_phoneNumber.Text = Grd_suppliers.CurrentRow.Cells[2].Value.ToString();
            uSupplier.Txt_supplierDept.Text = Grd_suppliers.CurrentRow.Cells[5].Value.ToString();
            uSupplier.Txt_paidToSupplier.Text = Grd_suppliers.CurrentRow.Cells[4].Value.ToString();
            uSupplier.ShowDialog();//עובר לדף העידכון

            this.Close();
            th = new Thread(OpenSelf);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenSelf(object obj)//רענון חלון
        {
            Application.Run(new Frm_suppliersManagement(usersRole,userName));
        }

        private void Btn_toMainPage_Click(object sender, EventArgs e)//עובר לחלון ראשי
        {
            if (usersRole == 1)
            {
                Thread th;
                this.Close();
                th = new Thread(OpenMain);
                th.TrySetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
            {
                Thread th;
                this.Close();
                th = new Thread(OpenEmployeesMain);
                th.TrySetApartmentState(ApartmentState.STA);
                th.Start();
            }
        }

        //מילוי טבלה בעת פתיחה
        private void Frm_suppliersManagement_Load(object sender, EventArgs e) 
        {
            supplier[] Supplier = mySQL.GetSupplierData();

            if (Supplier != null)
            {
                fillGrid(Supplier);

                fillCollection(Supplier);
            }
        }

        private void fillCollection(supplier[] supplier)
        {
            for (int i = 0; i < supplier.Length; i++)
            {
                firstNameAuto.Add(supplier[i].FirstName.ToString());
                last_nameAuto.Add(supplier[i].Phone_number.ToString());
            }

            Txt_firstName.AutoCompleteCustomSource = firstNameAuto;
            Txt_lastName.AutoCompleteCustomSource = last_nameAuto;
        }

        private void fillGrid(supplier[] supplier)
        {
            for (int i = 0; i < supplier.Length; i++)
            {
                Grd_suppliers.Rows.Add(new object[]
                    {
                        supplier[i].FirstName,
                        supplier[i].LasttName,
                        supplier[i].Phone_number,
                        supplier[i].Address,
                        supplier[i].Dept,
                        supplier[i].Paid
                    });
            }
        }

        private void Btn_clearTextBoxes_Click(object sender, EventArgs e)//כפתור ניקוי שדות
        {
            Txt_firstName.Text = "";
            Txt_lastName.Text = "";

        }

        private void Txt_firstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Only characters are welcomed :)
            char ch = e.KeyChar;

            if (char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void Txt_lastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Only characters are welcomed :)
            char ch = e.KeyChar;

            if (char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void Fill_grid(supplier[] Sup)//כשעושים חיפוש לספק מסווים הטבלה מתעדכנת מחדש
        {
            Grd_suppliers.Rows.Clear();

            if (Sup != null)
            {
                for (int i = 0; i < Sup.Length; i++)
                {
                    Grd_suppliers.Rows.Add(new object[]
                    {
                    Sup[i].FirstName,
                    Sup[i].LasttName,
                    Sup[i].Phone_number,
                    Sup[i].Address,
                    Sup[i].Dept,
                    Sup[i].Paid
                    });
                }
            }
            else
                Grd_suppliers.Rows.Clear();//מוחק מה שהיה קודם
        }

        private void Fill_grid_by_firstName()//מעדכן את הטבלה לפי שם פרטי שהמשתמש מזין
        {
            Supplier = mySQL.GetSupplierDataByFN(Txt_firstName.Text);
            Fill_grid(Supplier);
            if (Grd_suppliers.Rows.Count != 0)
                Grd_suppliers.Rows[0].Cells[0].Selected = false;
        }

        private void Fill_grid_by_lastName()//מעדכן את הטבלה לפי שם משפחה של ספק שהמשתמש מזין
        {
            Supplier = mySQL.GetSupplierDataByLN(Txt_lastName.Text);
            Fill_grid(Supplier);
            if (Grd_suppliers.Rows.Count != 0)
                Grd_suppliers.Rows[0].Cells[0].Selected = false;
        }

        //כאשר משתמש מחפש שם פרטי של ספק
        private void Txt_firstName_TextChanged(object sender, EventArgs e)
        {
            Fill_grid_by_firstName();
        }

        //כאשר משתמש מחפש שם משפחה של ספק
        private void Txt_lastName_TextChanged(object sender, EventArgs e)
        {
            Fill_grid_by_lastName();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            sp = new Point(e.X, e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - sp.X, p.Y - sp.Y);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        //לחיצה פעמיים בעכבר עובר לעידכון ספק של שורה ספציפית
        private void Grd_suppliers_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Frm_updateSupplier uSupplier = new Frm_updateSupplier(usersRole,userName);
            uSupplier.Txt_firstName.Text = Grd_suppliers.CurrentRow.Cells[0].Value.ToString();
            uSupplier.Txt_lastName.Text = Grd_suppliers.CurrentRow.Cells[1].Value.ToString();
            uSupplier.Txt_address.Text = Grd_suppliers.CurrentRow.Cells[3].Value.ToString();
            uSupplier.Txt_phoneNumber.Text = Grd_suppliers.CurrentRow.Cells[2].Value.ToString();
            uSupplier.Txt_supplierDept.Text = Grd_suppliers.CurrentRow.Cells[5].Value.ToString();
            uSupplier.Txt_paidToSupplier.Text = Grd_suppliers.CurrentRow.Cells[4].Value.ToString();
            uSupplier.ShowDialog();//עובר לדף העידכון

            this.Close();
            th = new Thread(OpenSelf);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
