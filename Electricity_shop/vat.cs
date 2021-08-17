using System;
using System.Collections.Generic;
using System.Text;

namespace Electricity_shop
{
    //מחלקה לשמירת ערך של מעמ
    public class vat
    {
        double vat_percentage;

        public vat()
        {
            vat_percentage = 17;
        }

        public double Vat { get => vat_percentage; set => vat_percentage = value; }
    }
}
