namespace MiPrimeraGUI
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnSaludar = new System.Windows.Forms.Button();
            this.lblSaludo = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.chkCarne = new System.Windows.Forms.CheckBox();
            this.chkHongos = new System.Windows.Forms.CheckBox();
            this.chkAceitunas = new System.Windows.Forms.CheckBox();
            this.chkPina = new System.Windows.Forms.CheckBox();
            this.radPersonal = new System.Windows.Forms.RadioButton();
            this.radFamiliar = new System.Windows.Forms.RadioButton();
            this.radGrande = new System.Windows.Forms.RadioButton();
            this.radGigante = new System.Windows.Forms.RadioButton();
            this.radAlta = new System.Windows.Forms.RadioButton();
            this.radDelgada = new System.Windows.Forms.RadioButton();
            this.grpTamano = new System.Windows.Forms.GroupBox();
            this.grpMasa = new System.Windows.Forms.GroupBox();
            this.grpIngredientes = new System.Windows.Forms.GroupBox();
            this.picPizza = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.grpTamano.SuspendLayout();
            this.grpMasa.SuspendLayout();
            this.grpIngredientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPizza)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Sienna;
            this.lblNombre.Location = new System.Drawing.Point(26, 45);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(99, 26);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(131, 43);
            this.txtNombre.MaxLength = 30;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(144, 29);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // btnSaludar
            // 
            this.btnSaludar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSaludar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaludar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaludar.Location = new System.Drawing.Point(297, 38);
            this.btnSaludar.Name = "btnSaludar";
            this.btnSaludar.Size = new System.Drawing.Size(166, 41);
            this.btnSaludar.TabIndex = 2;
            this.btnSaludar.Text = "Saludar";
            this.btnSaludar.UseVisualStyleBackColor = false;
            this.btnSaludar.Click += new System.EventHandler(this.btnSaludar_Click);
            // 
            // lblSaludo
            // 
            this.lblSaludo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaludo.ForeColor = System.Drawing.Color.Sienna;
            this.lblSaludo.Location = new System.Drawing.Point(469, 45);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(198, 26);
            this.lblSaludo.TabIndex = 3;
            this.lblSaludo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEdad
            // 
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.ForeColor = System.Drawing.Color.Sienna;
            this.lblEdad.Location = new System.Drawing.Point(26, 176);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(99, 26);
            this.lblEdad.TabIndex = 4;
            this.lblEdad.Text = "Edad:";
            this.lblEdad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudEdad
            // 
            this.nudEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudEdad.Location = new System.Drawing.Point(131, 175);
            this.nudEdad.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            this.nudEdad.Minimum = new decimal(new int[] { 16, 0, 0, 0 });
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(144, 29);
            this.nudEdad.TabIndex = 5;
            this.nudEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudEdad.Value = new decimal(new int[] { 16, 0, 0, 0 });
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(297, 169);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(264, 41);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "¿Mayor de edad?";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // chkCarne
            // 
            this.chkCarne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCarne.Location = new System.Drawing.Point(34, 44);
            this.chkCarne.Name = "chkCarne";
            this.chkCarne.Size = new System.Drawing.Size(130, 24);
            this.chkCarne.TabIndex = 7;
            this.chkCarne.Text = "Carne";
            this.chkCarne.UseVisualStyleBackColor = true;
            // 
            // chkHongos
            // 
            this.chkHongos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHongos.Location = new System.Drawing.Point(34, 83);
            this.chkHongos.Name = "chkHongos";
            this.chkHongos.Size = new System.Drawing.Size(130, 24);
            this.chkHongos.TabIndex = 8;
            this.chkHongos.Text = "Hongos";
            this.chkHongos.UseVisualStyleBackColor = true;
            // 
            // chkAceitunas
            // 
            this.chkAceitunas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAceitunas.Location = new System.Drawing.Point(34, 123);
            this.chkAceitunas.Name = "chkAceitunas";
            this.chkAceitunas.Size = new System.Drawing.Size(130, 24);
            this.chkAceitunas.TabIndex = 9;
            this.chkAceitunas.Text = "Aceitunas";
            this.chkAceitunas.UseVisualStyleBackColor = true;
            // 
            // chkPina
            // 
            this.chkPina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPina.Location = new System.Drawing.Point(34, 163);
            this.chkPina.Name = "chkPina";
            this.chkPina.Size = new System.Drawing.Size(130, 24);
            this.chkPina.TabIndex = 10;
            this.chkPina.Text = "Piña";
            this.chkPina.UseVisualStyleBackColor = true;
            // 
            // radPersonal
            // 
            this.radPersonal.Checked = true;
            this.radPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPersonal.Location = new System.Drawing.Point(25, 42);
            this.radPersonal.Name = "radPersonal";
            this.radPersonal.Size = new System.Drawing.Size(139, 24);
            this.radPersonal.TabIndex = 11;
            this.radPersonal.Text = "Personal";
            this.radPersonal.UseVisualStyleBackColor = true;
            // 
            // radFamiliar
            // 
            this.radFamiliar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFamiliar.Location = new System.Drawing.Point(25, 121);
            this.radFamiliar.Name = "radFamiliar";
            this.radFamiliar.Size = new System.Drawing.Size(139, 24);
            this.radFamiliar.TabIndex = 12;
            this.radFamiliar.Text = "Familiar";
            this.radFamiliar.UseVisualStyleBackColor = true;
            // 
            // radGrande
            // 
            this.radGrande.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGrande.Location = new System.Drawing.Point(25, 80);
            this.radGrande.Name = "radGrande";
            this.radGrande.Size = new System.Drawing.Size(139, 24);
            this.radGrande.TabIndex = 13;
            this.radGrande.Text = "Grande";
            this.radGrande.UseVisualStyleBackColor = true;
            // 
            // radGigante
            // 
            this.radGigante.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGigante.Location = new System.Drawing.Point(25, 161);
            this.radGigante.Name = "radGigante";
            this.radGigante.Size = new System.Drawing.Size(139, 24);
            this.radGigante.TabIndex = 14;
            this.radGigante.Text = "Gigante";
            this.radGigante.UseVisualStyleBackColor = true;
            // 
            // radAlta
            // 
            this.radAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAlta.Location = new System.Drawing.Point(172, 47);
            this.radAlta.Name = "radAlta";
            this.radAlta.Size = new System.Drawing.Size(139, 24);
            this.radAlta.TabIndex = 16;
            this.radAlta.Text = "Alta";
            this.radAlta.UseVisualStyleBackColor = true;
            // 
            // radDelgada
            // 
            this.radDelgada.Checked = true;
            this.radDelgada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDelgada.Location = new System.Drawing.Point(27, 47);
            this.radDelgada.Name = "radDelgada";
            this.radDelgada.Size = new System.Drawing.Size(139, 24);
            this.radDelgada.TabIndex = 15;
            this.radDelgada.TabStop = true;
            this.radDelgada.Text = "Delgada";
            this.radDelgada.UseVisualStyleBackColor = true;
            // 
            // grpTamano
            // 
            this.grpTamano.Controls.Add(this.radPersonal);
            this.grpTamano.Controls.Add(this.radFamiliar);
            this.grpTamano.Controls.Add(this.radGrande);
            this.grpTamano.Controls.Add(this.radGigante);
            this.grpTamano.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTamano.Location = new System.Drawing.Point(245, 279);
            this.grpTamano.Name = "grpTamano";
            this.grpTamano.Size = new System.Drawing.Size(165, 204);
            this.grpTamano.TabIndex = 17;
            this.grpTamano.TabStop = false;
            this.grpTamano.Text = "Tamaño:";
            // 
            // grpMasa
            // 
            this.grpMasa.Controls.Add(this.radDelgada);
            this.grpMasa.Controls.Add(this.radAlta);
            this.grpMasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMasa.Location = new System.Drawing.Point(39, 507);
            this.grpMasa.Name = "grpMasa";
            this.grpMasa.Size = new System.Drawing.Size(370, 92);
            this.grpMasa.TabIndex = 18;
            this.grpMasa.TabStop = false;
            this.grpMasa.Text = "Tipo de masa:";
            // 
            // grpIngredientes
            // 
            this.grpIngredientes.Controls.Add(this.chkCarne);
            this.grpIngredientes.Controls.Add(this.chkHongos);
            this.grpIngredientes.Controls.Add(this.chkAceitunas);
            this.grpIngredientes.Controls.Add(this.chkPina);
            this.grpIngredientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpIngredientes.Location = new System.Drawing.Point(39, 279);
            this.grpIngredientes.Name = "grpIngredientes";
            this.grpIngredientes.Size = new System.Drawing.Size(167, 204);
            this.grpIngredientes.TabIndex = 19;
            this.grpIngredientes.TabStop = false;
            this.grpIngredientes.Text = "Ingredientes:";
            // 
            // picPizza
            // 
            this.picPizza.BackColor = System.Drawing.Color.LightSkyBlue;
            this.picPizza.Image = ((System.Drawing.Image)(resources.GetObject("picPizza.Image")));
            this.picPizza.Location = new System.Drawing.Point(441, 279);
            this.picPizza.Name = "picPizza";
            this.picPizza.Size = new System.Drawing.Size(203, 320);
            this.picPizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPizza.TabIndex = 20;
            this.picPizza.TabStop = false;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(674, 626);
            this.Controls.Add(this.picPizza);
            this.Controls.Add(this.grpIngredientes);
            this.Controls.Add(this.grpMasa);
            this.Controls.Add(this.grpTamano);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.nudEdad);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblSaludo);
            this.Controls.Add(this.btnSaludar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenidos a mi primer GUI en C#!";
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.grpTamano.ResumeLayout(false);
            this.grpMasa.ResumeLayout(false);
            this.grpIngredientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPizza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.PictureBox picPizza;

        private System.Windows.Forms.GroupBox grpIngredientes;

        private System.Windows.Forms.GroupBox grpMasa;

        private System.Windows.Forms.GroupBox grpTamano;

        private System.Windows.Forms.RadioButton radAlta;
        private System.Windows.Forms.RadioButton radDelgada;

        private System.Windows.Forms.RadioButton radFamiliar;
        private System.Windows.Forms.RadioButton radGrande;
        private System.Windows.Forms.RadioButton radGigante;

        private System.Windows.Forms.RadioButton radPersonal;

        private System.Windows.Forms.CheckBox chkCarne;
        private System.Windows.Forms.CheckBox chkHongos;
        private System.Windows.Forms.CheckBox chkAceitunas;
        private System.Windows.Forms.CheckBox chkPina;

        private System.Windows.Forms.Button btnCalcular;

        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.NumericUpDown nudEdad;

        private System.Windows.Forms.Label lblSaludo;

        private System.Windows.Forms.Button btnSaludar;

        private System.Windows.Forms.TextBox txtNombre;

        private System.Windows.Forms.Label lblNombre;

        #endregion
    }
}