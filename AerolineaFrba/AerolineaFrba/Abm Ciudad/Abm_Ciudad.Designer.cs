namespace AerolineaFrba.Abm_Ciudad
{
    partial class Abm_Ciudad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Abm_Ciudad));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.boton_Cerrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.boton_Modificar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.boton_Agregar_Ciudad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(64, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(236, 177);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // boton_Cerrar
            // 
            this.boton_Cerrar.Location = new System.Drawing.Point(334, 379);
            this.boton_Cerrar.Name = "boton_Cerrar";
            this.boton_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.boton_Cerrar.TabIndex = 1;
            this.boton_Cerrar.Text = "Cerrar";
            this.boton_Cerrar.UseVisualStyleBackColor = true;
            this.boton_Cerrar.Click += new System.EventHandler(this.boton_Agregar_Ciudad_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.boton_Modificar);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(32, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 255);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado de Ciudades";
            // 
            // boton_Modificar
            // 
            this.boton_Modificar.Enabled = false;
            this.boton_Modificar.Location = new System.Drawing.Point(264, 226);
            this.boton_Modificar.Name = "boton_Modificar";
            this.boton_Modificar.Size = new System.Drawing.Size(75, 23);
            this.boton_Modificar.TabIndex = 1;
            this.boton_Modificar.Text = "Modificar";
            this.boton_Modificar.UseVisualStyleBackColor = true;
            this.boton_Modificar.Click += new System.EventHandler(this.boton_Modificar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.boton_Agregar_Ciudad);
            this.groupBox2.Location = new System.Drawing.Point(32, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 63);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar Ciudad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // boton_Agregar_Ciudad
            // 
            this.boton_Agregar_Ciudad.Enabled = false;
            this.boton_Agregar_Ciudad.Location = new System.Drawing.Point(264, 21);
            this.boton_Agregar_Ciudad.Name = "boton_Agregar_Ciudad";
            this.boton_Agregar_Ciudad.Size = new System.Drawing.Size(75, 23);
            this.boton_Agregar_Ciudad.TabIndex = 0;
            this.boton_Agregar_Ciudad.Text = "Agregar";
            this.boton_Agregar_Ciudad.UseVisualStyleBackColor = true;
            // 
            // Abm_Ciudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 414);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.boton_Cerrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Abm_Ciudad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Ciudad";
            this.Load += new System.EventHandler(this.Abm_Ciudad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button boton_Cerrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button boton_Agregar_Ciudad;
        private System.Windows.Forms.Button boton_Modificar;

    }
}