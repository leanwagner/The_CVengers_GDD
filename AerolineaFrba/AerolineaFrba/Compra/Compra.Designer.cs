namespace AerolineaFrba.Compra
{
    partial class Compra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compra));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_limpiar = new System.Windows.Forms.Button();
            this.comboBox_destino = new System.Windows.Forms.ComboBox();
            this.checkedListBox_servicios = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_buscar = new System.Windows.Forms.Button();
            this.dateTimePicker_fechaViaje = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_origen = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ciudad Origen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ciudad Destino:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_limpiar);
            this.groupBox1.Controls.Add(this.comboBox_destino);
            this.groupBox1.Controls.Add(this.checkedListBox_servicios);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button_buscar);
            this.groupBox1.Controls.Add(this.dateTimePicker_fechaViaje);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox_origen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(41, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 163);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Viajes";
            // 
            // button_limpiar
            // 
            this.button_limpiar.Enabled = false;
            this.button_limpiar.Location = new System.Drawing.Point(375, 125);
            this.button_limpiar.Name = "button_limpiar";
            this.button_limpiar.Size = new System.Drawing.Size(95, 23);
            this.button_limpiar.TabIndex = 5;
            this.button_limpiar.Text = "Limpiar";
            this.button_limpiar.UseVisualStyleBackColor = true;
            this.button_limpiar.Click += new System.EventHandler(this.button_limpiar_Click);
            // 
            // comboBox_destino
            // 
            this.comboBox_destino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_destino.FormattingEnabled = true;
            this.comboBox_destino.Location = new System.Drawing.Point(412, 19);
            this.comboBox_destino.Name = "comboBox_destino";
            this.comboBox_destino.Size = new System.Drawing.Size(159, 21);
            this.comboBox_destino.TabIndex = 1;
            this.comboBox_destino.SelectedIndexChanged += new System.EventHandler(this.comboBox_destino_SelectedIndexChanged_1);
            // 
            // checkedListBox_servicios
            // 
            this.checkedListBox_servicios.FormattingEnabled = true;
            this.checkedListBox_servicios.Location = new System.Drawing.Point(141, 99);
            this.checkedListBox_servicios.Name = "checkedListBox_servicios";
            this.checkedListBox_servicios.Size = new System.Drawing.Size(159, 49);
            this.checkedListBox_servicios.TabIndex = 3;
            this.checkedListBox_servicios.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_servicios_ItemCheck);
            this.checkedListBox_servicios.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_servicios_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Servicios:";
            // 
            // button_buscar
            // 
            this.button_buscar.Location = new System.Drawing.Point(476, 125);
            this.button_buscar.Name = "button_buscar";
            this.button_buscar.Size = new System.Drawing.Size(95, 23);
            this.button_buscar.TabIndex = 4;
            this.button_buscar.Text = "Buscar Viajes";
            this.button_buscar.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_fechaViaje
            // 
            this.dateTimePicker_fechaViaje.Location = new System.Drawing.Point(141, 66);
            this.dateTimePicker_fechaViaje.Name = "dateTimePicker_fechaViaje";
            this.dateTimePicker_fechaViaje.Size = new System.Drawing.Size(159, 20);
            this.dateTimePicker_fechaViaje.TabIndex = 2;
            this.dateTimePicker_fechaViaje.ValueChanged += new System.EventHandler(this.dateTimePicker_fechaViaje_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha Viaje:";
            // 
            // comboBox_origen
            // 
            this.comboBox_origen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_origen.FormattingEnabled = true;
            this.comboBox_origen.Location = new System.Drawing.Point(141, 19);
            this.comboBox_origen.Name = "comboBox_origen";
            this.comboBox_origen.Size = new System.Drawing.Size(159, 21);
            this.comboBox_origen.TabIndex = 0;
            this.comboBox_origen.SelectedIndexChanged += new System.EventHandler(this.comboBox_origen_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(41, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(621, 228);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Viajes Encontrados";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(449, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Continuar Compra";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(580, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 458);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Compra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compra Pasajes / Encomiendas";
            this.Load += new System.EventHandler(this.Compra_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_origen;
        private System.Windows.Forms.Button button_buscar;
        private System.Windows.Forms.DateTimePicker dateTimePicker_fechaViaje;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_limpiar;
        private System.Windows.Forms.ComboBox comboBox_destino;
        private System.Windows.Forms.CheckedListBox checkedListBox_servicios;
        private System.Windows.Forms.Label label4;
    }
}