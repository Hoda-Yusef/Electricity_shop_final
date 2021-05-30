using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Electricity_shop
{
    public partial class orders_management : Form
    {
        bool drag = false;
        Point sp = new Point(0, 0);

        orders or = new orders("הודא", "חיר", "אבו סנאן", "02546654", 15000, true);
        public orders_management()
        {
            InitializeComponent();

           

            orders_grid.Rows.Add(new object[]
            {
                    or.Name,
                    or.Last_name,
                    or.Address,
                    or.Phone_number,
                    null,
                    or.Summ,
                    or.Status?imageList1.Images[1]:imageList1.Images[0]

            });

            orders_grid.Rows.Add(new object[]
                {
                    "יוסף",
                    "אבורוקן",
                    "0525487855",
                    "עיספיא",
                    "אין",
                    "2000",
                   imageList1.Images[0]

                });

            for(int i=0;i<50;i++)
            {
                orders_grid.Rows.Add(new object[]
                {
                    
                });
            }

        }

      


        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor= Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(34, 36, 49);
        }

        

        private void orders_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void update_grid_row()
        {
           
        }

        private void update_row_Click(object sender, EventArgs e)
        {
            update_order upOr = new update_order();

            upOr.update_name.Text = orders_grid.CurrentRow.Cells[0].Value.ToString();
            upOr.update_lastName.Text = orders_grid.CurrentRow.Cells[1].Value.ToString();
            upOr.update_phone_number.Text = orders_grid.CurrentRow.Cells[2].Value.ToString();
            upOr.update_address.Text = orders_grid.CurrentRow.Cells[3].Value.ToString();
            upOr.update_total.Text = orders_grid.CurrentRow.Cells[5].Value.ToString();
            if (orders_grid.CurrentRow.Cells[6].Value.Equals(imageList1.Images[0]))
                upOr.update_status.Text = "סופק";
            else
                upOr.update_status.Text = "לא סופק";

            upOr.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th;
            th = new Thread(openMain);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void openMain(object obj)
        {
            Application.Run(new main());
        }

        private void panel8_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            sp = new Point(e.X, e.Y);
        }

        private void panel8_MouseMove(object sender, MouseEventArgs e)
        {
            if(drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - sp.X, p.Y - sp.Y);
            }
        }

        private void panel8_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.BackColor = Color.White;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(34, 36, 49);
        }






        //private void orders_grid_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    if (e.RowIndex > -1)
        //        orders_grid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(0, 90, 184);
        //}

        //private void orders_grid_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex > -1)
        //    {
        //        orders_grid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(34, 36, 70);
        //        orders_grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(34, 36, 49);
        //    }
        //}
    }
}
