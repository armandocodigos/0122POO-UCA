namespace Decorador
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
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnNitrogeno = new System.Windows.Forms.Button();
            this.btnSonido = new System.Windows.Forms.Button();
            this.btnSuspension = new System.Windows.Forms.Button();
            this.grbCosto = new System.Windows.Forms.GroupBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.grbDescripcion = new System.Windows.Forms.GroupBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnSolicitar = new System.Windows.Forms.Button();
            this.grbCosto.SuspendLayout();
            this.grbDescripcion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAuto
            // 
            this.btnAuto.Location = new System.Drawing.Point(52, 48);
            this.btnAuto.Margin = new System.Windows.Forms.Padding(4);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(165, 46);
            this.btnAuto.TabIndex = 0;
            this.btnAuto.Text = "Crear Auto";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // btnNitrogeno
            // 
            this.btnNitrogeno.Location = new System.Drawing.Point(52, 134);
            this.btnNitrogeno.Margin = new System.Windows.Forms.Padding(4);
            this.btnNitrogeno.Name = "btnNitrogeno";
            this.btnNitrogeno.Size = new System.Drawing.Size(165, 46);
            this.btnNitrogeno.TabIndex = 1;
            this.btnNitrogeno.Text = "Añadir Nitrógeno";
            this.btnNitrogeno.UseVisualStyleBackColor = true;
            this.btnNitrogeno.Visible = false;
            this.btnNitrogeno.Click += new System.EventHandler(this.btnNitrogeno_Click);
            // 
            // btnSonido
            // 
            this.btnSonido.Location = new System.Drawing.Point(271, 48);
            this.btnSonido.Margin = new System.Windows.Forms.Padding(4);
            this.btnSonido.Name = "btnSonido";
            this.btnSonido.Size = new System.Drawing.Size(165, 46);
            this.btnSonido.TabIndex = 2;
            this.btnSonido.Text = "Añadir Sistema Sonido";
            this.btnSonido.UseVisualStyleBackColor = true;
            this.btnSonido.Visible = false;
            this.btnSonido.Click += new System.EventHandler(this.btnSonido_Click);
            // 
            // btnSuspension
            // 
            this.btnSuspension.Location = new System.Drawing.Point(271, 134);
            this.btnSuspension.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuspension.Name = "btnSuspension";
            this.btnSuspension.Size = new System.Drawing.Size(165, 46);
            this.btnSuspension.TabIndex = 3;
            this.btnSuspension.Text = "Añadir Suspensión";
            this.btnSuspension.UseVisualStyleBackColor = true;
            this.btnSuspension.Visible = false;
            this.btnSuspension.Click += new System.EventHandler(this.btnSuspension_Click);
            // 
            // grbCosto
            // 
            this.grbCosto.Controls.Add(this.lblCosto);
            this.grbCosto.Controls.Add(this.btnCalcular);
            this.grbCosto.Location = new System.Drawing.Point(28, 223);
            this.grbCosto.Name = "grbCosto";
            this.grbCosto.Size = new System.Drawing.Size(429, 100);
            this.grbCosto.TabIndex = 4;
            this.grbCosto.TabStop = false;
            this.grbCosto.Text = "Costo:";
            this.grbCosto.Visible = false;
            // 
            // lblCosto
            // 
            this.lblCosto.Location = new System.Drawing.Point(195, 32);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(213, 46);
            this.lblCosto.TabIndex = 2;
            this.lblCosto.Text = "Costo: $0";
            this.lblCosto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(24, 32);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(136, 46);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // grbDescripcion
            // 
            this.grbDescripcion.Controls.Add(this.lblDescripcion);
            this.grbDescripcion.Controls.Add(this.btnSolicitar);
            this.grbDescripcion.Location = new System.Drawing.Point(28, 341);
            this.grbDescripcion.Name = "grbDescripcion";
            this.grbDescripcion.Size = new System.Drawing.Size(429, 100);
            this.grbDescripcion.TabIndex = 5;
            this.grbDescripcion.TabStop = false;
            this.grbDescripcion.Text = "Descripción:";
            this.grbDescripcion.Visible = false;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Location = new System.Drawing.Point(195, 18);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(213, 70);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción: ";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSolicitar
            // 
            this.btnSolicitar.Location = new System.Drawing.Point(24, 32);
            this.btnSolicitar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSolicitar.Name = "btnSolicitar";
            this.btnSolicitar.Size = new System.Drawing.Size(136, 46);
            this.btnSolicitar.TabIndex = 1;
            this.btnSolicitar.Text = "Solicitar";
            this.btnSolicitar.UseVisualStyleBackColor = true;
            this.btnSolicitar.Click += new System.EventHandler(this.btnSolicitar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(494, 471);
            this.Controls.Add(this.grbDescripcion);
            this.Controls.Add(this.grbCosto);
            this.Controls.Add(this.btnSuspension);
            this.Controls.Add(this.btnSonido);
            this.Controls.Add(this.btnNitrogeno);
            this.Controls.Add(this.btnAuto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Intro. a los Patrones de Diseño";
            this.grbCosto.ResumeLayout(false);
            this.grbDescripcion.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox grbDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnSolicitar;

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblCosto;

        private System.Windows.Forms.GroupBox grbCosto;

        private System.Windows.Forms.Button btnSuspension;

        private System.Windows.Forms.Button btnSonido;

        private System.Windows.Forms.Button btnNitrogeno;

        private System.Windows.Forms.Button btnAuto;

        #endregion
    }
}