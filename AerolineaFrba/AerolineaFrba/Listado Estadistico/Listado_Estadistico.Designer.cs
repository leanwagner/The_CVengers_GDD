namespace AerolineaFrba.Listado_Estadistico
{
    partial class Listado_Estadistico
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboLista = new System.Windows.Forms.ComboBox();
            this.comboAnio = new System.Windows.Forms.ComboBox();
            this.comboSem = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Año:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Semestre:";
            // 
            // comboLista
            // 
            this.comboLista.FormattingEnabled = true;
            this.comboLista.Location = new System.Drawing.Point(59, 6);
            this.comboLista.Name = "comboLista";
            this.comboLista.Size = new System.Drawing.Size(286, 21);
            this.comboLista.TabIndex = 3;
            this.comboLista.SelectedIndexChanged += new System.EventHandler(this.comboLista_SelectedIndexChanged);
            // 
            // comboAnio
            // 
            this.comboAnio.DropDownHeight = 100;
            this.comboAnio.FormattingEnabled = true;
            this.comboAnio.IntegralHeight = false;
            this.comboAnio.Location = new System.Drawing.Point(167, 42);
            this.comboAnio.Name = "comboAnio";
            this.comboAnio.Size = new System.Drawing.Size(69, 21);
            this.comboAnio.TabIndex = 4;
            this.comboAnio.SelectedIndexChanged += new System.EventHandler(this.comboLista_SelectedIndexChanged);
            // 
            // comboSem
            // 
            this.comboSem.FormattingEnabled = true;
            this.comboSem.Location = new System.Drawing.Point(302, 42);
            this.comboSem.Name = "comboSem";
            this.comboSem.Size = new System.Drawing.Size(43, 21);
            this.comboSem.TabIndex = 5;
            this.comboSem.SelectedIndexChanged += new System.EventHandler(this.comboLista_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 99);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(333, 147);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // Listado_Estadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 253);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboSem);
            this.Controls.Add(this.comboAnio);
            this.Controls.Add(this.comboLista);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Listado_Estadistico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado estadistico";
            this.Load += new System.EventHandler(this.Listado_Estadistico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboLista;
        private System.Windows.Forms.ComboBox comboAnio;
        private System.Windows.Forms.ComboBox comboSem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}