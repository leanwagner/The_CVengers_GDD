using AerolineaFrba.MyNumericUpDown;


namespace AerolineaFrba.Abm_Ruta
{
    partial class Abm_Ruta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Abm_Ruta));
            this.button_modificarRuta = new System.Windows.Forms.Button();
            this.dataGridView_listadoRutas = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.numericUpDown_pasajeHasta = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.numericUpDown_pasajeDesde = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.numericUpDown_kgHasta = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDown_kgDesde = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox_filtroDestino = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_filtroOrigen = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.myNumericUpDown_codRuta = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.button_filtrar = new System.Windows.Forms.Button();
            this.button_limpiar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button_eliminarRuta = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox_ciudadDestino = new System.Windows.Forms.ComboBox();
            this.comboBox_ciudadOrigen = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkedListBox_servicios = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_agregarRuta = new System.Windows.Forms.Button();
            this.errorProvider_ciudadOrigen = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_ciudadDestino = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_Servicios = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_precioKg = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_precioPasaje = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_precioKgHasta = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_precioPasajeHasta = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listadoRutas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_pasajeHasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_pasajeDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_kgHasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_kgDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myNumericUpDown_codRuta)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_ciudadOrigen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_ciudadDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Servicios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_precioKg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_precioPasaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_precioKgHasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_precioPasajeHasta)).BeginInit();
            this.SuspendLayout();
            // 
            // button_modificarRuta
            // 
            this.button_modificarRuta.Enabled = false;
            this.button_modificarRuta.Location = new System.Drawing.Point(413, 384);
            this.button_modificarRuta.Name = "button_modificarRuta";
            this.button_modificarRuta.Size = new System.Drawing.Size(75, 23);
            this.button_modificarRuta.TabIndex = 17;
            this.button_modificarRuta.Text = "Modificar";
            this.button_modificarRuta.UseVisualStyleBackColor = true;
            this.button_modificarRuta.Click += new System.EventHandler(this.boton_Modificar_Click);
            // 
            // dataGridView_listadoRutas
            // 
            this.dataGridView_listadoRutas.AllowUserToAddRows = false;
            this.dataGridView_listadoRutas.AllowUserToDeleteRows = false;
            this.dataGridView_listadoRutas.AllowUserToResizeColumns = false;
            this.dataGridView_listadoRutas.AllowUserToResizeRows = false;
            this.dataGridView_listadoRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_listadoRutas.Location = new System.Drawing.Point(19, 185);
            this.dataGridView_listadoRutas.MultiSelect = false;
            this.dataGridView_listadoRutas.Name = "dataGridView_listadoRutas";
            this.dataGridView_listadoRutas.ReadOnly = true;
            this.dataGridView_listadoRutas.RowHeadersVisible = false;
            this.dataGridView_listadoRutas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_listadoRutas.ShowEditingIcon = false;
            this.dataGridView_listadoRutas.Size = new System.Drawing.Size(572, 177);
            this.dataGridView_listadoRutas.TabIndex = 16;
            this.dataGridView_listadoRutas.SelectionChanged += new System.EventHandler(this.dataGridView_listadoRutas_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.numericUpDown_pasajeHasta);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.numericUpDown_pasajeDesde);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.numericUpDown_kgHasta);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.numericUpDown_kgDesde);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.comboBox_filtroDestino);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.comboBox_filtroOrigen);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.myNumericUpDown_codRuta);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.button_filtrar);
            this.groupBox1.Controls.Add(this.button_limpiar);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button_eliminarRuta);
            this.groupBox1.Controls.Add(this.button_modificarRuta);
            this.groupBox1.Controls.Add(this.dataGridView_listadoRutas);
            this.groupBox1.Location = new System.Drawing.Point(35, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 421);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado de Rutas";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(459, 101);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Hasta:";
            // 
            // numericUpDown_pasajeHasta
            // 
            this.numericUpDown_pasajeHasta.DecimalPlaces = 2;
            this.numericUpDown_pasajeHasta.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_pasajeHasta.Location = new System.Drawing.Point(503, 99);
            this.numericUpDown_pasajeHasta.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_pasajeHasta.Name = "numericUpDown_pasajeHasta";
            this.numericUpDown_pasajeHasta.Size = new System.Drawing.Size(88, 20);
            this.numericUpDown_pasajeHasta.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(315, 101);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Desde:";
            // 
            // numericUpDown_pasajeDesde
            // 
            this.numericUpDown_pasajeDesde.DecimalPlaces = 2;
            this.numericUpDown_pasajeDesde.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_pasajeDesde.Location = new System.Drawing.Point(362, 99);
            this.numericUpDown_pasajeDesde.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_pasajeDesde.Name = "numericUpDown_pasajeDesde";
            this.numericUpDown_pasajeDesde.Size = new System.Drawing.Size(88, 20);
            this.numericUpDown_pasajeDesde.TabIndex = 12;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(352, 78);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(102, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "Precio Base Pasaje:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(459, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Hasta:";
            // 
            // numericUpDown_kgHasta
            // 
            this.numericUpDown_kgHasta.DecimalPlaces = 2;
            this.numericUpDown_kgHasta.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_kgHasta.Location = new System.Drawing.Point(503, 41);
            this.numericUpDown_kgHasta.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_kgHasta.Name = "numericUpDown_kgHasta";
            this.numericUpDown_kgHasta.Size = new System.Drawing.Size(88, 20);
            this.numericUpDown_kgHasta.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(315, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Desde:";
            // 
            // numericUpDown_kgDesde
            // 
            this.numericUpDown_kgDesde.DecimalPlaces = 2;
            this.numericUpDown_kgDesde.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_kgDesde.Location = new System.Drawing.Point(362, 41);
            this.numericUpDown_kgDesde.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_kgDesde.Name = "numericUpDown_kgDesde";
            this.numericUpDown_kgDesde.Size = new System.Drawing.Size(88, 20);
            this.numericUpDown_kgDesde.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(352, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Precio Base Kg:";
            // 
            // comboBox_filtroDestino
            // 
            this.comboBox_filtroDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_filtroDestino.FormattingEnabled = true;
            this.comboBox_filtroDestino.Location = new System.Drawing.Point(139, 120);
            this.comboBox_filtroDestino.Name = "comboBox_filtroDestino";
            this.comboBox_filtroDestino.Size = new System.Drawing.Size(153, 21);
            this.comboBox_filtroDestino.Sorted = true;
            this.comboBox_filtroDestino.TabIndex = 9;
            this.comboBox_filtroDestino.SelectedIndexChanged += new System.EventHandler(this.comboBox_filtroDestino_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Ciudad Destino:";
            // 
            // comboBox_filtroOrigen
            // 
            this.comboBox_filtroOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_filtroOrigen.FormattingEnabled = true;
            this.comboBox_filtroOrigen.Location = new System.Drawing.Point(139, 78);
            this.comboBox_filtroOrigen.Name = "comboBox_filtroOrigen";
            this.comboBox_filtroOrigen.Size = new System.Drawing.Size(153, 21);
            this.comboBox_filtroOrigen.Sorted = true;
            this.comboBox_filtroOrigen.TabIndex = 8;
            this.comboBox_filtroOrigen.SelectedIndexChanged += new System.EventHandler(this.comboBox_filtroOrigen_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Ciudad Origen:";
            // 
            // myNumericUpDown_codRuta
            // 
            this.myNumericUpDown_codRuta.Location = new System.Drawing.Point(139, 41);
            this.myNumericUpDown_codRuta.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.myNumericUpDown_codRuta.Name = "myNumericUpDown_codRuta";
            this.myNumericUpDown_codRuta.Size = new System.Drawing.Size(153, 20);
            this.myNumericUpDown_codRuta.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Código Ruta:";
            // 
            // button_filtrar
            // 
            this.button_filtrar.Location = new System.Drawing.Point(503, 144);
            this.button_filtrar.Name = "button_filtrar";
            this.button_filtrar.Size = new System.Drawing.Size(75, 23);
            this.button_filtrar.TabIndex = 14;
            this.button_filtrar.Text = "Filtrar";
            this.button_filtrar.UseVisualStyleBackColor = true;
            this.button_filtrar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button_limpiar
            // 
            this.button_limpiar.Location = new System.Drawing.Point(413, 144);
            this.button_limpiar.Name = "button_limpiar";
            this.button_limpiar.Size = new System.Drawing.Size(75, 23);
            this.button_limpiar.TabIndex = 15;
            this.button_limpiar.Text = "Limpiar";
            this.button_limpiar.UseVisualStyleBackColor = true;
            this.button_limpiar.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Filtrar por:";
            // 
            // button_eliminarRuta
            // 
            this.button_eliminarRuta.Location = new System.Drawing.Point(503, 384);
            this.button_eliminarRuta.Name = "button_eliminarRuta";
            this.button_eliminarRuta.Size = new System.Drawing.Size(75, 23);
            this.button_eliminarRuta.TabIndex = 18;
            this.button_eliminarRuta.Text = "Eliminar";
            this.button_eliminarRuta.UseVisualStyleBackColor = true;
            this.button_eliminarRuta.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDown3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.numericUpDown2);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.comboBox_ciudadDestino);
            this.groupBox2.Controls.Add(this.comboBox_ciudadOrigen);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.checkedListBox_servicios);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button_agregarRuta);
            this.groupBox2.Location = new System.Drawing.Point(35, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(621, 183);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Crear Ruta";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(139, 27);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(153, 20);
            this.numericUpDown3.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Código Ruta:";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 2;
            this.numericUpDown2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown2.Location = new System.Drawing.Point(425, 106);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(153, 20);
            this.numericUpDown2.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown1.Location = new System.Drawing.Point(425, 80);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(153, 20);
            this.numericUpDown1.TabIndex = 4;
            // 
            // comboBox_ciudadDestino
            // 
            this.comboBox_ciudadDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ciudadDestino.FormattingEnabled = true;
            this.comboBox_ciudadDestino.Location = new System.Drawing.Point(139, 79);
            this.comboBox_ciudadDestino.Name = "comboBox_ciudadDestino";
            this.comboBox_ciudadDestino.Size = new System.Drawing.Size(153, 21);
            this.comboBox_ciudadDestino.Sorted = true;
            this.comboBox_ciudadDestino.TabIndex = 2;
            this.comboBox_ciudadDestino.SelectedIndexChanged += new System.EventHandler(this.comboBox_ciudadDestino_SelectedIndexChanged);
            // 
            // comboBox_ciudadOrigen
            // 
            this.comboBox_ciudadOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ciudadOrigen.FormattingEnabled = true;
            this.comboBox_ciudadOrigen.Location = new System.Drawing.Point(139, 53);
            this.comboBox_ciudadOrigen.Name = "comboBox_ciudadOrigen";
            this.comboBox_ciudadOrigen.Size = new System.Drawing.Size(153, 21);
            this.comboBox_ciudadOrigen.Sorted = true;
            this.comboBox_ciudadOrigen.TabIndex = 1;
            this.comboBox_ciudadOrigen.SelectedIndexChanged += new System.EventHandler(this.comboBox_ciudadOrigen_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Precio Base Pasaje:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Precio Base Kg:";
            // 
            // checkedListBox_servicios
            // 
            this.checkedListBox_servicios.FormattingEnabled = true;
            this.checkedListBox_servicios.Location = new System.Drawing.Point(425, 24);
            this.checkedListBox_servicios.Name = "checkedListBox_servicios";
            this.checkedListBox_servicios.Size = new System.Drawing.Size(153, 49);
            this.checkedListBox_servicios.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(359, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Servicios:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ciudad Destino:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ciudad Origen:";
            // 
            // button_agregarRuta
            // 
            this.button_agregarRuta.Location = new System.Drawing.Point(503, 140);
            this.button_agregarRuta.Name = "button_agregarRuta";
            this.button_agregarRuta.Size = new System.Drawing.Size(75, 23);
            this.button_agregarRuta.TabIndex = 6;
            this.button_agregarRuta.Text = "Agregar";
            this.button_agregarRuta.UseVisualStyleBackColor = true;
            this.button_agregarRuta.Click += new System.EventHandler(this.button_agregarRuta_Click);
            // 
            // errorProvider_ciudadOrigen
            // 
            this.errorProvider_ciudadOrigen.ContainerControl = this;
            // 
            // errorProvider_ciudadDestino
            // 
            this.errorProvider_ciudadDestino.ContainerControl = this;
            // 
            // errorProvider_Servicios
            // 
            this.errorProvider_Servicios.ContainerControl = this;
            // 
            // errorProvider_precioKg
            // 
            this.errorProvider_precioKg.ContainerControl = this;
            // 
            // errorProvider_precioPasaje
            // 
            this.errorProvider_precioPasaje.ContainerControl = this;
            // 
            // errorProvider_precioKgHasta
            // 
            this.errorProvider_precioKgHasta.ContainerControl = this;
            this.errorProvider_precioKgHasta.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider_precioKgHasta.Icon")));
            // 
            // errorProvider_precioPasajeHasta
            // 
            this.errorProvider_precioPasajeHasta.ContainerControl = this;
            this.errorProvider_precioPasajeHasta.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider_precioPasajeHasta.Icon")));
            // 
            // Abm_Ruta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(687, 668);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Abm_Ruta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rutas";
            this.Activated += new System.EventHandler(this.Abm_Ruta_Activated);
            this.Load += new System.EventHandler(this.Abm_Ruta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listadoRutas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_pasajeHasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_pasajeDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_kgHasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_kgDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myNumericUpDown_codRuta)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_ciudadOrigen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_ciudadDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Servicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_precioKg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_precioPasaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_precioKgHasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_precioPasajeHasta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_modificarRuta;
        private System.Windows.Forms.DataGridView dataGridView_listadoRutas;
        private System.Windows.Forms.Button button_eliminarRuta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_agregarRuta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox checkedListBox_servicios;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_ciudadDestino;
        private System.Windows.Forms.ComboBox comboBox_ciudadOrigen;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.ErrorProvider errorProvider_ciudadOrigen;
        private System.Windows.Forms.ErrorProvider errorProvider_ciudadDestino;
        private System.Windows.Forms.ErrorProvider errorProvider_Servicios;
        private System.Windows.Forms.ErrorProvider errorProvider_precioKg;
        private System.Windows.Forms.ErrorProvider errorProvider_precioPasaje;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_filtrar;
        private System.Windows.Forms.Button button_limpiar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericUpDown_kgDesde;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox_filtroDestino;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox_filtroOrigen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown myNumericUpDown_codRuta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numericUpDown_pasajeHasta;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numericUpDown_pasajeDesde;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericUpDown_kgHasta;
        private System.Windows.Forms.ErrorProvider errorProvider_precioKgHasta;
        private System.Windows.Forms.ErrorProvider errorProvider_precioPasajeHasta;
    }
}