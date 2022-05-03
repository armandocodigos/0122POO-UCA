namespace CuadrosDialogo
{
    partial class frmUno
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
            this.trbValor = new System.Windows.Forms.TrackBar();
            this.lblValor = new System.Windows.Forms.Label();
            this.cmbPaises = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.btnPregunta = new System.Windows.Forms.Button();
            this.cldColor = new System.Windows.Forms.ColorDialog();
            this.btnColor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trbValor)).BeginInit();
            this.SuspendLayout();
            // 
            // trbValor
            // 
            this.trbValor.Location = new System.Drawing.Point(36, 40);
            this.trbValor.Minimum = 1;
            this.trbValor.Name = "trbValor";
            this.trbValor.Size = new System.Drawing.Size(221, 45);
            this.trbValor.TabIndex = 0;
            this.trbValor.Value = 1;
            this.trbValor.Scroll += new System.EventHandler(this.trbValor_Scroll);
            // 
            // lblValor
            // 
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(263, 40);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(100, 29);
            this.lblValor.TabIndex = 1;
            this.lblValor.Text = "Valor: 1";
            // 
            // cmbPaises
            // 
            this.cmbPaises.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaises.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaises.FormattingEnabled = true;
            this.cmbPaises.Items.AddRange(new object[] { "Guatemala", "Belice", "El Salvador", "Honduras", "Nicaragua", "Costa Rica", "Panamá" });
            this.cmbPaises.Location = new System.Drawing.Point(223, 120);
            this.cmbPaises.Name = "cmbPaises";
            this.cmbPaises.Size = new System.Drawing.Size(140, 32);
            this.cmbPaises.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione un país:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Marca elegida:";
            // 
            // cmbProducto
            // 
            this.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(223, 183);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(236, 32);
            this.cmbProducto.TabIndex = 4;
            // 
            // btnPregunta
            // 
            this.btnPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPregunta.Location = new System.Drawing.Point(506, 23);
            this.btnPregunta.Name = "btnPregunta";
            this.btnPregunta.Size = new System.Drawing.Size(153, 83);
            this.btnPregunta.TabIndex = 6;
            this.btnPregunta.Text = "Clic aquí para responder una pregunta";
            this.btnPregunta.UseVisualStyleBackColor = true;
            this.btnPregunta.Click += new System.EventHandler(this.btnPregunta_Click);
            // 
            // btnColor
            // 
            this.btnColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColor.Location = new System.Drawing.Point(506, 112);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(153, 46);
            this.btnColor.TabIndex = 7;
            this.btnColor.Text = "Color de fondo";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // frmUno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 261);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnPregunta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPaises);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.trbValor);
            this.Name = "frmUno";
            this.Text = "Probando más controles!";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.trbValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnColor;

        private System.Windows.Forms.ColorDialog cldColor;

        private System.Windows.Forms.Button btnPregunta;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbProducto;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.ComboBox cmbPaises;

        private System.Windows.Forms.Label lblValor;

        private System.Windows.Forms.TrackBar trbValor;

        #endregion
    }
}