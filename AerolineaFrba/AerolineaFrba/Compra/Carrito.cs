﻿using AerolineaFrba.Objetos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AerolineaFrba.MyNumericUpDown;

namespace AerolineaFrba.Compra
{
    public partial class Carrito : Form
    {
        int id;
        public static Collection<Cliente> ListaClientes = new Collection<Cliente>();


        public Carrito(int id_viaje)
        {
            InitializeComponent();
            id = id_viaje;
            dateTimePicker_nacimiento.Format = DateTimePickerFormat.Custom;
            dateTimePicker_nacimiento.CustomFormat = "dd/MM/yyyy";

        }

        private void button_aEncomienda_Click(object sender, EventArgs e)
        {
            AgregarPasajeEncomienda ventana = new AgregarPasajeEncomienda(id,TipoCompra.Encomienda);
            ventana.Show();
        }

        private void button_aPasaje_Click(object sender, EventArgs e)
        {
            AgregarPasajeEncomienda ventana = new AgregarPasajeEncomienda(id,TipoCompra.Pasaje);
            ventana.Show();
        }

        public static void agregarCliente(Cliente cliente) 
        {
            ListaClientes.Add(cliente);
        }

        public float calcularPrecioTotal()
        {
            float retu = 0f;
            foreach (Cliente cli in ListaClientes)
            {
               retu += cli.getItem().calcularPrecio();
            }
            return retu;
        }

        private void Carrito_Activated(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Cliente cli in ListaClientes)
            {
                listBox1.Items.Add(cli);
            }

            labelMonto.Text = calcularPrecioTotal().ToString();
        }

        private void button_eliminarItem_Click(object sender, EventArgs e)
        {
            ListaClientes.Remove((Cliente)listBox1.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItem);
            labelMonto.Text = calcularPrecioTotal().ToString("0.00");
        }
       
    }
}
