namespace ConsultorioOdontologico
{
    partial class Ingreso
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ingreso));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.txtIngresoContraseña = new System.Windows.Forms.TextBox();
            this.grpIngreso = new System.Windows.Forms.GroupBox();
            this.pctLogoF1 = new System.Windows.Forms.PictureBox();
            this.tltF1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpIngreso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogoF1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(6, 30);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(91, 28);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "&Usuario";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.BackColor = System.Drawing.Color.Transparent;
            this.lblContraseña.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(6, 90);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(126, 28);
            this.lblContraseña.TabIndex = 0;
            this.lblContraseña.Text = "&Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(131, 35);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(246, 29);
            this.txtUsuario.TabIndex = 1;
            this.tltF1.SetToolTip(this.txtUsuario, "Ingrese su usuario");
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnIngresar.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(171, 161);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(122, 48);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnVer
            // 
            this.btnVer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVer.BackgroundImage")));
            this.btnVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVer.Location = new System.Drawing.Point(388, 90);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(38, 26);
            this.btnVer.TabIndex = 3;
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // txtIngresoContraseña
            // 
            this.txtIngresoContraseña.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngresoContraseña.Location = new System.Drawing.Point(134, 95);
            this.txtIngresoContraseña.Name = "txtIngresoContraseña";
            this.txtIngresoContraseña.PasswordChar = '*';
            this.txtIngresoContraseña.Size = new System.Drawing.Size(243, 29);
            this.txtIngresoContraseña.TabIndex = 2;
            this.tltF1.SetToolTip(this.txtIngresoContraseña, "Ingrese su contraseña");
            // 
            // grpIngreso
            // 
            this.grpIngreso.Controls.Add(this.txtIngresoContraseña);
            this.grpIngreso.Controls.Add(this.lblUsuario);
            this.grpIngreso.Controls.Add(this.btnVer);
            this.grpIngreso.Controls.Add(this.lblContraseña);
            this.grpIngreso.Controls.Add(this.btnIngresar);
            this.grpIngreso.Controls.Add(this.txtUsuario);
            this.grpIngreso.Location = new System.Drawing.Point(237, 191);
            this.grpIngreso.Name = "grpIngreso";
            this.grpIngreso.Size = new System.Drawing.Size(440, 227);
            this.grpIngreso.TabIndex = 5;
            this.grpIngreso.TabStop = false;
            // 
            // pctLogoF1
            // 
            this.pctLogoF1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctLogoF1.Image = global::ConsultorioOdontologico.Properties.Resources.LOGO2recorte;
            this.pctLogoF1.Location = new System.Drawing.Point(193, 28);
            this.pctLogoF1.Name = "pctLogoF1";
            this.pctLogoF1.Size = new System.Drawing.Size(520, 103);
            this.pctLogoF1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogoF1.TabIndex = 6;
            this.pctLogoF1.TabStop = false;
            // 
            // tltF1
            // 
            this.tltF1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tltF1.ToolTipTitle = "Atención";
            // 
            // Ingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(912, 490);
            this.Controls.Add(this.pctLogoF1);
            this.Controls.Add(this.grpIngreso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ingreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ingreso";
            this.grpIngreso.ResumeLayout(false);
            this.grpIngreso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogoF1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.TextBox txtIngresoContraseña;
        private System.Windows.Forms.GroupBox grpIngreso;
        private System.Windows.Forms.ToolTip tltF1;
        private System.Windows.Forms.PictureBox pctLogoF1;
    }
}

