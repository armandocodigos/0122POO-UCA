namespace ConexionNorthwind
{
    partial class frmPrincipal
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
            this.btnCategorias = new System.Windows.Forms.Button();
            this.txtCategoriaFiltrada = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCategorías = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbCategoryName = new System.Windows.Forms.ComboBox();
            this.btnFiltrarNombre = new System.Windows.Forms.Button();
            this.txtFiltroNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudCategoryID = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorías)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCategoryID)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCategorias
            // 
            this.btnCategorias.Location = new System.Drawing.Point(350, 21);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(178, 43);
            this.btnCategorias.TabIndex = 0;
            this.btnCategorias.Text = "Mostrar categorías";
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // txtCategoriaFiltrada
            // 
            this.txtCategoriaFiltrada.Location = new System.Drawing.Point(30, 84);
            this.txtCategoriaFiltrada.Multiline = true;
            this.txtCategoriaFiltrada.Name = "txtCategoriaFiltrada";
            this.txtCategoriaFiltrada.ReadOnly = true;
            this.txtCategoriaFiltrada.Size = new System.Drawing.Size(498, 54);
            this.txtCategoriaFiltrada.TabIndex = 3;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(350, 33);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(178, 45);
            this.btnFiltrar.TabIndex = 2;
            this.btnFiltrar.Text = "Filtrar categoría por ID";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(30, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Category ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Honeydew;
            this.groupBox1.Controls.Add(this.dgvCategorías);
            this.groupBox1.Controls.Add(this.btnCategorias);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 225);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta sin parámetros:";
            // 
            // dgvCategorías
            // 
            this.dgvCategorías.AllowUserToAddRows = false;
            this.dgvCategorías.AllowUserToDeleteRows = false;
            this.dgvCategorías.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorías.Location = new System.Drawing.Point(30, 70);
            this.dgvCategorías.Name = "dgvCategorías";
            this.dgvCategorías.ReadOnly = true;
            this.dgvCategorías.Size = new System.Drawing.Size(498, 134);
            this.dgvCategorías.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox2.Controls.Add(this.cmbCategoryName);
            this.groupBox2.Controls.Add(this.btnFiltrarNombre);
            this.groupBox2.Controls.Add(this.txtFiltroNombre);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.nudCategoryID);
            this.groupBox2.Controls.Add(this.btnFiltrar);
            this.groupBox2.Controls.Add(this.txtCategoriaFiltrada);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(567, 278);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consulta con parámetros:";
            // 
            // cmbCategoryName
            // 
            this.cmbCategoryName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoryName.FormattingEnabled = true;
            this.cmbCategoryName.Location = new System.Drawing.Point(136, 177);
            this.cmbCategoryName.Name = "cmbCategoryName";
            this.cmbCategoryName.Size = new System.Drawing.Size(131, 21);
            this.cmbCategoryName.TabIndex = 9;
            // 
            // btnFiltrarNombre
            // 
            this.btnFiltrarNombre.Location = new System.Drawing.Point(350, 153);
            this.btnFiltrarNombre.Name = "btnFiltrarNombre";
            this.btnFiltrarNombre.Size = new System.Drawing.Size(178, 45);
            this.btnFiltrarNombre.TabIndex = 6;
            this.btnFiltrarNombre.Text = "Filtrar categoría por Nombre";
            this.btnFiltrarNombre.UseVisualStyleBackColor = true;
            this.btnFiltrarNombre.Click += new System.EventHandler(this.btnFiltrarNombre_Click);
            // 
            // txtFiltroNombre
            // 
            this.txtFiltroNombre.Location = new System.Drawing.Point(30, 204);
            this.txtFiltroNombre.Multiline = true;
            this.txtFiltroNombre.Name = "txtFiltroNombre";
            this.txtFiltroNombre.ReadOnly = true;
            this.txtFiltroNombre.Size = new System.Drawing.Size(498, 54);
            this.txtFiltroNombre.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(30, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Category Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudCategoryID
            // 
            this.nudCategoryID.Location = new System.Drawing.Point(136, 58);
            this.nudCategoryID.Maximum = new decimal(new int[] { 8, 0, 0, 0 });
            this.nudCategoryID.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudCategoryID.Name = "nudCategoryID";
            this.nudCategoryID.Size = new System.Drawing.Size(131, 20);
            this.nudCategoryID.TabIndex = 5;
            this.nudCategoryID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudCategoryID.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox3.Controls.Add(this.btnAgregar);
            this.groupBox3.Controls.Add(this.txtDescripcion);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtNombre);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 527);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(567, 130);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Execute Non Query:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(350, 43);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(178, 63);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar nueva categoría";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(136, 86);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(186, 20);
            this.txtDescripcion.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(30, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Description:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(136, 43);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(186, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(30, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Category Name:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(591, 669);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPrincipal";
            this.Text = "Conectando SQL Server y C#";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorías)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCategoryID)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnAgregar;

        private System.Windows.Forms.GroupBox groupBox3;

        private System.Windows.Forms.Button btnFiltrarNombre;
        private System.Windows.Forms.TextBox txtFiltroNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCategoryName;

        private System.Windows.Forms.DataGridView dgvCategorías;

        private System.Windows.Forms.NumericUpDown nudCategoryID;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;

        private System.Windows.Forms.TextBox txtCategoriaFiltrada;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button btnCategorias;

        #endregion
    }
}