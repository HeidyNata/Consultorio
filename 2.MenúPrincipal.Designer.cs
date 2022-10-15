
namespace ConsultorioOdontologico
{
    partial class MenúPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenúPrincipal));
            this.btnAgendamientodeCitas = new System.Windows.Forms.Button();
            this.btnInformaciónBasicadeUsuarios = new System.Windows.Forms.Button();
            this.btnTratamientos = new System.Windows.Forms.Button();
            this.btnBeneficiosPromocionales = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblMenú = new System.Windows.Forms.Label();
            this.pctForm2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctForm2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgendamientodeCitas
            // 
            this.btnAgendamientodeCitas.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendamientodeCitas.Location = new System.Drawing.Point(209, 238);
            this.btnAgendamientodeCitas.Name = "btnAgendamientodeCitas";
            this.btnAgendamientodeCitas.Size = new System.Drawing.Size(240, 71);
            this.btnAgendamientodeCitas.TabIndex = 1;
            this.btnAgendamientodeCitas.Text = "Agendamiento de Citas";
            this.btnAgendamientodeCitas.UseVisualStyleBackColor = true;
            this.btnAgendamientodeCitas.Click += new System.EventHandler(this.AgendamientodeCitas_Click);
            // 
            // btnInformaciónBasicadeUsuarios
            // 
            this.btnInformaciónBasicadeUsuarios.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformaciónBasicadeUsuarios.Location = new System.Drawing.Point(482, 238);
            this.btnInformaciónBasicadeUsuarios.Name = "btnInformaciónBasicadeUsuarios";
            this.btnInformaciónBasicadeUsuarios.Size = new System.Drawing.Size(240, 71);
            this.btnInformaciónBasicadeUsuarios.TabIndex = 2;
            this.btnInformaciónBasicadeUsuarios.Text = "Información básica de usuarios";
            this.btnInformaciónBasicadeUsuarios.UseVisualStyleBackColor = true;
            this.btnInformaciónBasicadeUsuarios.Click += new System.EventHandler(this.btnInformaciónbasicadeusuarios_Click);
            // 
            // btnTratamientos
            // 
            this.btnTratamientos.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTratamientos.Location = new System.Drawing.Point(209, 324);
            this.btnTratamientos.Name = "btnTratamientos";
            this.btnTratamientos.Size = new System.Drawing.Size(240, 71);
            this.btnTratamientos.TabIndex = 3;
            this.btnTratamientos.Text = "Tratamientos";
            this.btnTratamientos.UseVisualStyleBackColor = true;
            this.btnTratamientos.Click += new System.EventHandler(this.btnTratamientos_Click);
            // 
            // btnBeneficiosPromocionales
            // 
            this.btnBeneficiosPromocionales.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeneficiosPromocionales.Location = new System.Drawing.Point(482, 324);
            this.btnBeneficiosPromocionales.Name = "btnBeneficiosPromocionales";
            this.btnBeneficiosPromocionales.Size = new System.Drawing.Size(240, 71);
            this.btnBeneficiosPromocionales.TabIndex = 4;
            this.btnBeneficiosPromocionales.Text = "Beneficios promocionales";
            this.btnBeneficiosPromocionales.UseVisualStyleBackColor = true;
            this.btnBeneficiosPromocionales.Click += new System.EventHandler(this.btnBeneficiospromocionales_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSalir.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(349, 422);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(237, 45);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblMenú
            // 
            this.lblMenú.AutoSize = true;
            this.lblMenú.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenú.Location = new System.Drawing.Point(396, 145);
            this.lblMenú.Name = "lblMenú";
            this.lblMenú.Size = new System.Drawing.Size(141, 54);
            this.lblMenú.TabIndex = 0;
            this.lblMenú.Text = "Menú";
            this.lblMenú.UseMnemonic = false;
            // 
            // pctForm2
            // 
            this.pctForm2.Image = global::ConsultorioOdontologico.Properties.Resources.LOGO2recorte;
            this.pctForm2.Location = new System.Drawing.Point(338, 28);
            this.pctForm2.Name = "pctForm2";
            this.pctForm2.Size = new System.Drawing.Size(291, 101);
            this.pctForm2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctForm2.TabIndex = 6;
            this.pctForm2.TabStop = false;
            // 
            // MenúPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(912, 487);
            this.Controls.Add(this.pctForm2);
            this.Controls.Add(this.lblMenú);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBeneficiosPromocionales);
            this.Controls.Add(this.btnTratamientos);
            this.Controls.Add(this.btnInformaciónBasicadeUsuarios);
            this.Controls.Add(this.btnAgendamientodeCitas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenúPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Menú";
            ((System.ComponentModel.ISupportInitialize)(this.pctForm2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgendamientodeCitas;
        private System.Windows.Forms.Button btnInformaciónBasicadeUsuarios;
        private System.Windows.Forms.Button btnTratamientos;
        private System.Windows.Forms.Button btnBeneficiosPromocionales;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblMenú;
        private System.Windows.Forms.PictureBox pctForm2;
    }
}