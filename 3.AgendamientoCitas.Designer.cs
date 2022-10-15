
namespace ConsultorioOdontologico
{
    partial class frmAgendamiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgendamiento));
            this.lblNombresCompletos = new System.Windows.Forms.Label();
            this.lblIdentificación = new System.Windows.Forms.Label();
            this.lblTeléfono = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHoraCita = new System.Windows.Forms.Label();
            this.lblProcedimiento = new System.Windows.Forms.Label();
            this.txtNombresCompletos = new System.Windows.Forms.TextBox();
            this.txtIdentificación = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbHora = new System.Windows.Forms.ComboBox();
            this.cmbMinutos = new System.Windows.Forms.ComboBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblMinutos = new System.Windows.Forms.Label();
            this.cmbProcedimiento = new System.Windows.Forms.ComboBox();
            this.lblAgendamientodecitas = new System.Windows.Forms.Label();
            this.grpDatosPersonales = new System.Windows.Forms.GroupBox();
            this.mskTeléfono = new System.Windows.Forms.MaskedTextBox();
            this.grpDatosCita = new System.Windows.Forms.GroupBox();
            this.tltF3 = new System.Windows.Forms.ToolTip(this.components);
            this.pctLogoF3 = new System.Windows.Forms.PictureBox();
            this.grpDatosPersonales.SuspendLayout();
            this.grpDatosCita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogoF3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombresCompletos
            // 
            this.lblNombresCompletos.AutoSize = true;
            this.lblNombresCompletos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombresCompletos.Location = new System.Drawing.Point(5, 41);
            this.lblNombresCompletos.Name = "lblNombresCompletos";
            this.lblNombresCompletos.Size = new System.Drawing.Size(132, 19);
            this.lblNombresCompletos.TabIndex = 0;
            this.lblNombresCompletos.Text = "Nombres completos";
            // 
            // lblIdentificación
            // 
            this.lblIdentificación.AutoSize = true;
            this.lblIdentificación.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificación.Location = new System.Drawing.Point(5, 88);
            this.lblIdentificación.Name = "lblIdentificación";
            this.lblIdentificación.Size = new System.Drawing.Size(89, 19);
            this.lblIdentificación.TabIndex = 0;
            this.lblIdentificación.Text = "Identificación";
            // 
            // lblTeléfono
            // 
            this.lblTeléfono.AutoSize = true;
            this.lblTeléfono.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeléfono.Location = new System.Drawing.Point(5, 128);
            this.lblTeléfono.Name = "lblTeléfono";
            this.lblTeléfono.Size = new System.Drawing.Size(61, 19);
            this.lblTeléfono.TabIndex = 0;
            this.lblTeléfono.Text = "Teléfono";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(5, 38);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(46, 19);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha";
            // 
            // lblHoraCita
            // 
            this.lblHoraCita.AutoSize = true;
            this.lblHoraCita.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraCita.Location = new System.Drawing.Point(5, 86);
            this.lblHoraCita.Name = "lblHoraCita";
            this.lblHoraCita.Size = new System.Drawing.Size(40, 19);
            this.lblHoraCita.TabIndex = 0;
            this.lblHoraCita.Text = "Hora";
            // 
            // lblProcedimiento
            // 
            this.lblProcedimiento.AutoSize = true;
            this.lblProcedimiento.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcedimiento.Location = new System.Drawing.Point(5, 128);
            this.lblProcedimiento.Name = "lblProcedimiento";
            this.lblProcedimiento.Size = new System.Drawing.Size(96, 19);
            this.lblProcedimiento.TabIndex = 0;
            this.lblProcedimiento.Text = "Procedimiento";
            // 
            // txtNombresCompletos
            // 
            this.txtNombresCompletos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombresCompletos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombresCompletos.Location = new System.Drawing.Point(181, 41);
            this.txtNombresCompletos.Name = "txtNombresCompletos";
            this.txtNombresCompletos.Size = new System.Drawing.Size(234, 26);
            this.txtNombresCompletos.TabIndex = 1;
            this.tltF3.SetToolTip(this.txtNombresCompletos, "Solo se permiten letras");
            // 
            // txtIdentificación
            // 
            this.txtIdentificación.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdentificación.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificación.Location = new System.Drawing.Point(181, 86);
            this.txtIdentificación.Name = "txtIdentificación";
            this.txtIdentificación.Size = new System.Drawing.Size(234, 26);
            this.txtIdentificación.TabIndex = 2;
            this.tltF3.SetToolTip(this.txtIdentificación, "Solo se permiten números");
            this.txtIdentificación.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdentificación_KeyPress);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.FlatAppearance.BorderSize = 2;
            this.btnGuardar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(260, 352);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(151, 52);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRegresar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRegresar.FlatAppearance.BorderSize = 2;
            this.btnRegresar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(421, 352);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(151, 52);
            this.btnRegresar.TabIndex = 4;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "yyyy-MM-dd";
            this.dtpFecha.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(140, 36);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(268, 26);
            this.dtpFecha.TabIndex = 1;
            // 
            // cmbHora
            // 
            this.cmbHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHora.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHora.FormattingEnabled = true;
            this.cmbHora.Items.AddRange(new object[] {
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19"});
            this.cmbHora.Location = new System.Drawing.Point(188, 78);
            this.cmbHora.Name = "cmbHora";
            this.cmbHora.Size = new System.Drawing.Size(73, 27);
            this.cmbHora.TabIndex = 2;
            // 
            // cmbMinutos
            // 
            this.cmbMinutos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMinutos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMinutos.FormattingEnabled = true;
            this.cmbMinutos.Items.AddRange(new object[] {
            "00",
            "30"});
            this.cmbMinutos.Location = new System.Drawing.Point(337, 77);
            this.cmbMinutos.Name = "cmbMinutos";
            this.cmbMinutos.Size = new System.Drawing.Size(71, 27);
            this.cmbMinutos.TabIndex = 3;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(137, 83);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(34, 16);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "Hora";
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutos.Location = new System.Drawing.Point(278, 84);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(53, 16);
            this.lblMinutos.TabIndex = 0;
            this.lblMinutos.Text = "Minutos";
            // 
            // cmbProcedimiento
            // 
            this.cmbProcedimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProcedimiento.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProcedimiento.FormattingEnabled = true;
            this.cmbProcedimiento.Items.AddRange(new object[] {
            "Ortodoncia",
            "Implantes",
            "Estética dental",
            "Blanqueamiento dental"});
            this.cmbProcedimiento.Location = new System.Drawing.Point(140, 119);
            this.cmbProcedimiento.Name = "cmbProcedimiento";
            this.cmbProcedimiento.Size = new System.Drawing.Size(268, 27);
            this.cmbProcedimiento.TabIndex = 4;
            // 
            // lblAgendamientodecitas
            // 
            this.lblAgendamientodecitas.AutoSize = true;
            this.lblAgendamientodecitas.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgendamientodecitas.Location = new System.Drawing.Point(459, 51);
            this.lblAgendamientodecitas.Name = "lblAgendamientodecitas";
            this.lblAgendamientodecitas.Size = new System.Drawing.Size(365, 43);
            this.lblAgendamientodecitas.TabIndex = 0;
            this.lblAgendamientodecitas.Text = "Agendamiento de citas";
            // 
            // grpDatosPersonales
            // 
            this.grpDatosPersonales.Controls.Add(this.mskTeléfono);
            this.grpDatosPersonales.Controls.Add(this.lblNombresCompletos);
            this.grpDatosPersonales.Controls.Add(this.lblIdentificación);
            this.grpDatosPersonales.Controls.Add(this.lblTeléfono);
            this.grpDatosPersonales.Controls.Add(this.txtNombresCompletos);
            this.grpDatosPersonales.Controls.Add(this.txtIdentificación);
            this.grpDatosPersonales.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatosPersonales.Location = new System.Drawing.Point(19, 146);
            this.grpDatosPersonales.Margin = new System.Windows.Forms.Padding(2);
            this.grpDatosPersonales.Name = "grpDatosPersonales";
            this.grpDatosPersonales.Padding = new System.Windows.Forms.Padding(2);
            this.grpDatosPersonales.Size = new System.Drawing.Size(442, 169);
            this.grpDatosPersonales.TabIndex = 1;
            this.grpDatosPersonales.TabStop = false;
            this.grpDatosPersonales.Text = "Datos Personales";
            // 
            // mskTeléfono
            // 
            this.mskTeléfono.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTeléfono.Location = new System.Drawing.Point(181, 128);
            this.mskTeléfono.Mask = "000-000-0000";
            this.mskTeléfono.Name = "mskTeléfono";
            this.mskTeléfono.Size = new System.Drawing.Size(234, 26);
            this.mskTeléfono.TabIndex = 3;
            this.mskTeléfono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBox1_KeyPress);
            // 
            // grpDatosCita
            // 
            this.grpDatosCita.Controls.Add(this.lblFecha);
            this.grpDatosCita.Controls.Add(this.dtpFecha);
            this.grpDatosCita.Controls.Add(this.lblHoraCita);
            this.grpDatosCita.Controls.Add(this.cmbMinutos);
            this.grpDatosCita.Controls.Add(this.lblMinutos);
            this.grpDatosCita.Controls.Add(this.cmbProcedimiento);
            this.grpDatosCita.Controls.Add(this.lblHora);
            this.grpDatosCita.Controls.Add(this.cmbHora);
            this.grpDatosCita.Controls.Add(this.lblProcedimiento);
            this.grpDatosCita.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatosCita.Location = new System.Drawing.Point(479, 148);
            this.grpDatosCita.Margin = new System.Windows.Forms.Padding(2);
            this.grpDatosCita.Name = "grpDatosCita";
            this.grpDatosCita.Padding = new System.Windows.Forms.Padding(2);
            this.grpDatosCita.Size = new System.Drawing.Size(422, 169);
            this.grpDatosCita.TabIndex = 2;
            this.grpDatosCita.TabStop = false;
            this.grpDatosCita.Text = "Datos Cita";
            // 
            // tltF3
            // 
            this.tltF3.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tltF3.ToolTipTitle = "Atención";
            // 
            // pctLogoF3
            // 
            this.pctLogoF3.Image = global::ConsultorioOdontologico.Properties.Resources.LOGO2recorte;
            this.pctLogoF3.Location = new System.Drawing.Point(55, 25);
            this.pctLogoF3.Margin = new System.Windows.Forms.Padding(2);
            this.pctLogoF3.Name = "pctLogoF3";
            this.pctLogoF3.Size = new System.Drawing.Size(321, 86);
            this.pctLogoF3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogoF3.TabIndex = 11;
            this.pctLogoF3.TabStop = false;
            // 
            // frmAgendamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(912, 487);
            this.Controls.Add(this.pctLogoF3);
            this.Controls.Add(this.grpDatosCita);
            this.Controls.Add(this.grpDatosPersonales);
            this.Controls.Add(this.lblAgendamientodecitas);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAgendamiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendamiento de citas";
            this.grpDatosPersonales.ResumeLayout(false);
            this.grpDatosPersonales.PerformLayout();
            this.grpDatosCita.ResumeLayout(false);
            this.grpDatosCita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogoF3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombresCompletos;
        private System.Windows.Forms.Label lblIdentificación;
        private System.Windows.Forms.Label lblTeléfono;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHoraCita;
        private System.Windows.Forms.Label lblProcedimiento;
        private System.Windows.Forms.TextBox txtNombresCompletos;
        private System.Windows.Forms.TextBox txtIdentificación;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cmbHora;
        private System.Windows.Forms.ComboBox cmbMinutos;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblMinutos;
        private System.Windows.Forms.ComboBox cmbProcedimiento;
        private System.Windows.Forms.Label lblAgendamientodecitas;
        private System.Windows.Forms.GroupBox grpDatosPersonales;
        private System.Windows.Forms.GroupBox grpDatosCita;
        private System.Windows.Forms.PictureBox pctLogoF3;
        private System.Windows.Forms.ToolTip tltF3;
        private System.Windows.Forms.MaskedTextBox mskTeléfono;
    }
}