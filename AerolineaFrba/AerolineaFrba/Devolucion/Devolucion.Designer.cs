namespace AerolineaFrba.Devolucion
{
    partial class Devolucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Devolucion));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nombreCombo = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.errorDniDup = new System.Windows.Forms.ErrorProvider(this.components);
            this.dniBox = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.buttonDev = new System.Windows.Forms.Button();
            this.razonText = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errorRazon = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorList = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDniDup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dniBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorRazon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido:";
            this.label2.Visible = false;
            // 
            // nombreCombo
            // 
            this.nombreCombo.FormattingEnabled = true;
            this.nombreCombo.Location = new System.Drawing.Point(65, 38);
            this.nombreCombo.Name = "nombreCombo";
            this.nombreCombo.Size = new System.Drawing.Size(93, 21);
            this.nombreCombo.TabIndex = 4;
            this.nombreCombo.Visible = false;
            this.nombreCombo.SelectedIndexChanged += new System.EventHandler(this.nombreCombo_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 19);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(184, 191);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // errorDniDup
            // 
            this.errorDniDup.ContainerControl = this;
            this.errorDniDup.Icon = ((System.Drawing.Icon)(resources.GetObject("errorDniDup.Icon")));
            // 
            // dniBox
            // 
            this.dniBox.Location = new System.Drawing.Point(65, 6);
            this.dniBox.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.dniBox.Name = "dniBox";
            this.dniBox.Size = new System.Drawing.Size(93, 20);
            this.dniBox.TabIndex = 6;
            this.dniBox.TextChanged += new System.EventHandler(this.dniBox_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 216);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compras";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.razonText);
            this.groupBox2.Controls.Add(this.buttonDev);
            this.groupBox2.Controls.Add(this.checkedListBox1);
            this.groupBox2.Location = new System.Drawing.Point(218, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 272);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle de compra";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(6, 19);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(240, 154);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // buttonDev
            // 
            this.buttonDev.Enabled = false;
            this.buttonDev.Location = new System.Drawing.Point(27, 243);
            this.buttonDev.Name = "buttonDev";
            this.buttonDev.Size = new System.Drawing.Size(202, 23);
            this.buttonDev.TabIndex = 1;
            this.buttonDev.Text = "Confirmar devolucion";
            this.buttonDev.UseVisualStyleBackColor = true;
            this.buttonDev.Click += new System.EventHandler(this.buttonDev_Click);
            // 
            // razonText
            // 
            this.razonText.Location = new System.Drawing.Point(6, 193);
            this.razonText.MaxLength = 100;
            this.razonText.Name = "razonText";
            this.razonText.Size = new System.Drawing.Size(240, 44);
            this.razonText.TabIndex = 2;
            this.razonText.Text = "";
            this.razonText.TextChanged += new System.EventHandler(this.razonText_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "¿Cual es el motivo de la devolucion?";
            // 
            // errorRazon
            // 
            this.errorRazon.ContainerControl = this;
            // 
            // errorList
            // 
            this.errorList.ContainerControl = this;
            // 
            // Devolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 293);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dniBox);
            this.Controls.Add(this.nombreCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Devolucion";
            this.Text = "Devolucion";
            this.Load += new System.EventHandler(this.Devolucion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDniDup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dniBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorRazon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox nombreCombo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ErrorProvider errorDniDup;
        private System.Windows.Forms.NumericUpDown dniBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.RichTextBox razonText;
        private System.Windows.Forms.Button buttonDev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorRazon;
        private System.Windows.Forms.ErrorProvider errorList;

    }
}