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
            this.txtCategoriasTodas = new System.Windows.Forms.TextBox();
            this.txtCategoriaFiltrada = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudCategoryID = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCategoryID)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCategorias
            // 
            this.btnCategorias.Location = new System.Drawing.Point(30, 32);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(120, 45);
            this.btnCategorias.TabIndex = 0;
            this.btnCategorias.Text = "Mostrar categorías";
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // txtCategoriasTodas
            // 
            this.txtCategoriasTodas.Location = new System.Drawing.Point(30, 96);
            this.txtCategoriasTodas.Multiline = true;
            this.txtCategoriasTodas.Name = "txtCategoriasTodas";
            this.txtCategoriasTodas.ReadOnly = true;
            this.txtCategoriasTodas.Size = new System.Drawing.Size(498, 151);
            this.txtCategoriasTodas.TabIndex = 1;
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
            this.btnFiltrar.Location = new System.Drawing.Point(408, 24);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(120, 45);
            this.btnFiltrar.TabIndex = 2;
            this.btnFiltrar.Text = "Filtrar categoría";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(30, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Category ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Honeydew;
            this.groupBox1.Controls.Add(this.btnCategorias);
            this.groupBox1.Controls.Add(this.txtCategoriasTodas);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 266);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta sin parámetros:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox2.Controls.Add(this.nudCategoryID);
            this.groupBox2.Controls.Add(this.btnFiltrar);
            this.groupBox2.Controls.Add(this.txtCategoriaFiltrada);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 284);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(567, 154);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consulta con parámetros:";
            // 
            // nudCategoryID
            // 
            this.nudCategoryID.Location = new System.Drawing.Point(136, 38);
            this.nudCategoryID.Maximum = new decimal(new int[] { 8, 0, 0, 0 });
            this.nudCategoryID.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudCategoryID.Name = "nudCategoryID";
            this.nudCategoryID.Size = new System.Drawing.Size(73, 20);
            this.nudCategoryID.TabIndex = 5;
            this.nudCategoryID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudCategoryID.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(591, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPrincipal";
            this.Text = "Conectando SQL Server y C#";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCategoryID)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.NumericUpDown nudCategoryID;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;

        private System.Windows.Forms.TextBox txtCategoriaFiltrada;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox txtCategoriasTodas;

        private System.Windows.Forms.Button btnCategorias;

        #endregion
    }
}