using System.ComponentModel;

namespace TalleresGraficos
{
    partial class frmEncuadernado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEncuadernado));
            this.picTipos = new System.Windows.Forms.PictureBox();
            this.grbPegado = new System.Windows.Forms.GroupBox();
            this.radEngrapado = new System.Windows.Forms.RadioButton();
            this.radAnillado = new System.Windows.Forms.RadioButton();
            this.radHotMelt = new System.Windows.Forms.RadioButton();
            this.grbEmpastado = new System.Windows.Forms.GroupBox();
            this.radRustico = new System.Windows.Forms.RadioButton();
            this.radLujo = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picTipos)).BeginInit();
            this.grbPegado.SuspendLayout();
            this.grbEmpastado.SuspendLayout();
            this.SuspendLayout();
            // 
            // picTipos
            // 
            this.picTipos.Image = ((System.Drawing.Image)(resources.GetObject("picTipos.Image")));
            this.picTipos.Location = new System.Drawing.Point(16, 15);
            this.picTipos.Margin = new System.Windows.Forms.Padding(4);
            this.picTipos.Name = "picTipos";
            this.picTipos.Size = new System.Drawing.Size(162, 343);
            this.picTipos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTipos.TabIndex = 0;
            this.picTipos.TabStop = false;
            // 
            // grbPegado
            // 
            this.grbPegado.Controls.Add(this.radEngrapado);
            this.grbPegado.Controls.Add(this.radAnillado);
            this.grbPegado.Controls.Add(this.radHotMelt);
            this.grbPegado.Location = new System.Drawing.Point(186, 15);
            this.grbPegado.Margin = new System.Windows.Forms.Padding(4);
            this.grbPegado.Name = "grbPegado";
            this.grbPegado.Padding = new System.Windows.Forms.Padding(4);
            this.grbPegado.Size = new System.Drawing.Size(195, 139);
            this.grbPegado.TabIndex = 1;
            this.grbPegado.TabStop = false;
            this.grbPegado.Text = "Pegado:";
            // 
            // radEngrapado
            // 
            this.radEngrapado.Location = new System.Drawing.Point(42, 91);
            this.radEngrapado.Name = "radEngrapado";
            this.radEngrapado.Size = new System.Drawing.Size(104, 24);
            this.radEngrapado.TabIndex = 2;
            this.radEngrapado.Text = "Engrapado";
            this.radEngrapado.UseVisualStyleBackColor = true;
            // 
            // radAnillado
            // 
            this.radAnillado.Location = new System.Drawing.Point(42, 61);
            this.radAnillado.Name = "radAnillado";
            this.radAnillado.Size = new System.Drawing.Size(104, 24);
            this.radAnillado.TabIndex = 1;
            this.radAnillado.Text = "Anillado";
            this.radAnillado.UseVisualStyleBackColor = true;
            // 
            // radHotMelt
            // 
            this.radHotMelt.Checked = true;
            this.radHotMelt.Location = new System.Drawing.Point(42, 31);
            this.radHotMelt.Name = "radHotMelt";
            this.radHotMelt.Size = new System.Drawing.Size(104, 24);
            this.radHotMelt.TabIndex = 0;
            this.radHotMelt.TabStop = true;
            this.radHotMelt.Text = "Hot Melt";
            this.radHotMelt.UseVisualStyleBackColor = true;
            // 
            // grbEmpastado
            // 
            this.grbEmpastado.Controls.Add(this.radRustico);
            this.grbEmpastado.Controls.Add(this.radLujo);
            this.grbEmpastado.Location = new System.Drawing.Point(186, 162);
            this.grbEmpastado.Margin = new System.Windows.Forms.Padding(4);
            this.grbEmpastado.Name = "grbEmpastado";
            this.grbEmpastado.Padding = new System.Windows.Forms.Padding(4);
            this.grbEmpastado.Size = new System.Drawing.Size(195, 106);
            this.grbEmpastado.TabIndex = 3;
            this.grbEmpastado.TabStop = false;
            this.grbEmpastado.Text = "Empastado:";
            // 
            // radRustico
            // 
            this.radRustico.Location = new System.Drawing.Point(42, 61);
            this.radRustico.Name = "radRustico";
            this.radRustico.Size = new System.Drawing.Size(104, 24);
            this.radRustico.TabIndex = 1;
            this.radRustico.Text = "Rústica";
            this.radRustico.UseVisualStyleBackColor = true;
            // 
            // radLujo
            // 
            this.radLujo.Checked = true;
            this.radLujo.Location = new System.Drawing.Point(42, 31);
            this.radLujo.Name = "radLujo";
            this.radLujo.Size = new System.Drawing.Size(104, 24);
            this.radLujo.TabIndex = 0;
            this.radLujo.TabStop = true;
            this.radLujo.Text = "De Lujo";
            this.radLujo.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.MistyRose;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(186, 275);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 83);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Honeydew;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Location = new System.Drawing.Point(277, 276);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(104, 83);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // frmEncuadernado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(394, 371);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grbEmpastado);
            this.Controls.Add(this.grbPegado);
            this.Controls.Add(this.picTipos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEncuadernado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles del Encuadernado";
            ((System.ComponentModel.ISupportInitialize)(this.picTipos)).EndInit();
            this.grbPegado.ResumeLayout(false);
            this.grbEmpastado.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox grbEmpastado;
        private System.Windows.Forms.RadioButton radRustico;
        private System.Windows.Forms.RadioButton radLujo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;

        private System.Windows.Forms.RadioButton radHotMelt;
        private System.Windows.Forms.RadioButton radAnillado;
        private System.Windows.Forms.RadioButton radEngrapado;

        private System.Windows.Forms.GroupBox grbPegado;

        private System.Windows.Forms.PictureBox picTipos;

        #endregion
    }
}