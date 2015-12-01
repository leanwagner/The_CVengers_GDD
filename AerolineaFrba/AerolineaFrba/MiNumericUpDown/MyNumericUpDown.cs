using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.MyNumericUpDown
{
    class MyNumericUpDown : System.Windows.Forms.NumericUpDown
    {
        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                while (value.Length < 8)
                    
                    value = "0" + value;

                base.Text = value;
            }
        }

    }
}
