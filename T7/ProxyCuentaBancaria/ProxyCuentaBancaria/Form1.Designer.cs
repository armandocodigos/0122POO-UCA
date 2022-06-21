namespace ProxyCuentaBancaria
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConsultarBalance = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudMonto = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkBandera = new System.Windows.Forms.CheckBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExtraña = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonto)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConsultarBalance);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acción 01:";
            // 
            // btnConsultarBalance
            // 
            this.btnConsultarBalance.Location = new System.Drawing.Point(25, 33);
            this.btnConsultarBalance.Name = "btnConsultarBalance";
            this.btnConsultarBalance.Size = new System.Drawing.Size(305, 41);
            this.btnConsultarBalance.TabIndex = 0;
            this.btnConsultarBalance.Text = "Consultar Balance";
            this.btnConsultarBalance.UseVisualStyleBackColor = true;
            this.btnConsultarBalance.Click += new System.EventHandler(this.btnConsultarBalance_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudMonto);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnIngresar);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acción 02:";
            // 
            // nudMonto
            // 
            this.nudMonto.DecimalPlaces = 1;
            this.nudMonto.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            this.nudMonto.Location = new System.Drawing.Point(82, 45);
            this.nudMonto.Name = "nudMonto";
            this.nudMonto.Size = new System.Drawing.Size(73, 20);
            this.nudMonto.TabIndex = 2;
            this.nudMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(25, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Monto:";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(177, 33);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(153, 41);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.Text = "Ingresar dinero";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkBandera);
            this.groupBox3.Controls.Add(this.txtApellido);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.nudCantidad);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnExtraña);
            this.groupBox3.Location = new System.Drawing.Point(12, 224);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(360, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Acción 02:";
            // 
            // chkBandera
            // 
            this.chkBandera.Location = new System.Drawing.Point(82, 19);
            this.chkBandera.Name = "chkBandera";
            this.chkBandera.Size = new System.Drawing.Size(73, 24);
            this.chkBandera.TabIndex = 6;
            this.chkBandera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkBandera.UseVisualStyleBackColor = true;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(82, 67);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(73, 20);
            this.txtApellido.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(25, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(25, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bandera:";
            // 
            // nudCantidad
            // 
            this.nudCantidad.DecimalPlaces = 2;
            this.nudCantidad.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            this.nudCantidad.Location = new System.Drawing.Point(82, 45);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(73, 20);
            this.nudCantidad.TabIndex = 2;
            this.nudCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(25, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cant:";
            // 
            // btnExtraña
            // 
            this.btnExtraña.Location = new System.Drawing.Point(177, 33);
            this.btnExtraña.Name = "btnExtraña";
            this.btnExtraña.Size = new System.Drawing.Size(153, 41);
            this.btnExtraña.TabIndex = 0;
            this.btnExtraña.Text = "Promoción extraña";
            this.btnExtraña.UseVisualStyleBackColor = true;
            this.btnExtraña.Click += new System.EventHandler(this.btnExtraña_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Patrón de Diseño Proxy - Ejemplo 02";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudMonto)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.CheckBox chkBandera;

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExtraña;

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudMonto;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConsultarBalance;

        #endregion
    }
}