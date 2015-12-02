using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.MyNumericUpDown
{
    public class NumericUpDownModified : System.Windows.Forms.NumericUpDown
    {
        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                if (value == "-1")
                    value = "";

                else
                    while (value.Length < 8)
                        value = "0" + value;

                base.Text = value;
            }
        }

    }
}
