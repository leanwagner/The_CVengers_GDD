﻿using AerolineaFrba.Llenador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Ruta
{
    public partial class Rol : Form
    {

        public Rol()
        {
            InitializeComponent();
            LlenadorDeTablas lleni = new LlenadorDeTablas();
            lleni.llenarListBox(ref listBox1, "ROL", "ROL_NOMBRE");
            lleni.llenarCheckedListBox(ref checkedListBox1, "FUNCIONALIDAD", "FUNC_NOMBRE");
        }
     
    }
}
