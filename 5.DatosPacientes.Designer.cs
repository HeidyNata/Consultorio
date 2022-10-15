
namespace ConsultorioOdontologico
{
    partial class frmDatosPacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatosPacientes));
            this.cmbEPS = new System.Windows.Forms.ComboBox();
            this.cmbTratamientoaRealizar = new System.Windows.Forms.ComboBox();
            this.cmbRégimen = new System.Windows.Forms.ComboBox();
            this.cmbOcupación = new System.Windows.Forms.ComboBox();
            this.cmbNivelEscolaridad = new System.Windows.Forms.ComboBox();
            this.txtAntecedetesMédicos = new System.Windows.Forms.TextBox();
            this.lblAntecedentesMédicos = new System.Windows.Forms.Label();
            this.lblTratamientoaRealizar = new System.Windows.Forms.Label();
            this.lblRégimen = new System.Windows.Forms.Label();
            this.lblEPS = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblOcupación = new System.Windows.Forms.Label();
            this.lblNivelEscolaridad = new System.Windows.Forms.Label();
            this.lblTeléfonoContacto = new System.Windows.Forms.Label();
            this.grpContactoEmergencia = new System.Windows.Forms.GroupBox();
            this.mskTeléfonoEmergencia = new System.Windows.Forms.MaskedTextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNúmeroTeléfono = new System.Windows.Forms.Label();
            this.txtNombreContacto = new System.Windows.Forms.TextBox();
            this.lblDatosPaciente = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.mskTélefonoContacto = new System.Windows.Forms.MaskedTextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.tltF5 = new System.Windows.Forms.ToolTip(this.components);
            this.pbxLogoF5 = new System.Windows.Forms.PictureBox();
            this.grbF5 = new System.Windows.Forms.GroupBox();
            this.grpContactoEmergencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoF5)).BeginInit();
            this.grbF5.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbEPS
            // 
            this.cmbEPS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEPS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEPS.FormattingEnabled = true;
            this.cmbEPS.Items.AddRange(new object[] {
            "Coosalud",
            "Nueva-EPS",
            "Salud Total",
            "Sura",
            "Compensar",
            "Savia Salud",
            "Otro",
            "Particular",
            "Ninguno"});
            this.cmbEPS.Location = new System.Drawing.Point(636, 20);
            this.cmbEPS.Name = "cmbEPS";
            this.cmbEPS.Size = new System.Drawing.Size(213, 27);
            this.cmbEPS.TabIndex = 5;
            // 
            // cmbTratamientoaRealizar
            // 
            this.cmbTratamientoaRealizar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTratamientoaRealizar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTratamientoaRealizar.FormattingEnabled = true;
            this.cmbTratamientoaRealizar.Items.AddRange(new object[] {
            "Ortodoncia",
            "Implantes",
            "Estética dental",
            "Blanqueamiento dental"});
            this.cmbTratamientoaRealizar.Location = new System.Drawing.Point(636, 118);
            this.cmbTratamientoaRealizar.Name = "cmbTratamientoaRealizar";
            this.cmbTratamientoaRealizar.Size = new System.Drawing.Size(213, 27);
            this.cmbTratamientoaRealizar.TabIndex = 7;
            // 
            // cmbRégimen
            // 
            this.cmbRégimen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRégimen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRégimen.FormattingEnabled = true;
            this.cmbRégimen.Items.AddRange(new object[] {
            "Subsidiado",
            "Contributivo",
            "Beneficirario",
            "Ninguno"});
            this.cmbRégimen.Location = new System.Drawing.Point(636, 69);
            this.cmbRégimen.Name = "cmbRégimen";
            this.cmbRégimen.Size = new System.Drawing.Size(213, 27);
            this.cmbRégimen.TabIndex = 6;
            // 
            // cmbOcupación
            // 
            this.cmbOcupación.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOcupación.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOcupación.FormattingEnabled = true;
            this.cmbOcupación.Items.AddRange(new object[] {
            "Estudiante",
            "Empleado",
            "Independiente",
            "Jubilado"});
            this.cmbOcupación.Location = new System.Drawing.Point(177, 68);
            this.cmbOcupación.Name = "cmbOcupación";
            this.cmbOcupación.Size = new System.Drawing.Size(213, 27);
            this.cmbOcupación.TabIndex = 2;
            // 
            // cmbNivelEscolaridad
            // 
            this.cmbNivelEscolaridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNivelEscolaridad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNivelEscolaridad.FormattingEnabled = true;
            this.cmbNivelEscolaridad.Items.AddRange(new object[] {
            "Educación básica",
            "Educación media",
            "Eduación superior"});
            this.cmbNivelEscolaridad.Location = new System.Drawing.Point(177, 118);
            this.cmbNivelEscolaridad.Name = "cmbNivelEscolaridad";
            this.cmbNivelEscolaridad.Size = new System.Drawing.Size(213, 27);
            this.cmbNivelEscolaridad.TabIndex = 3;
            // 
            // txtAntecedetesMédicos
            // 
            this.txtAntecedetesMédicos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAntecedetesMédicos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAntecedetesMédicos.Location = new System.Drawing.Point(636, 169);
            this.txtAntecedetesMédicos.Multiline = true;
            this.txtAntecedetesMédicos.Name = "txtAntecedetesMédicos";
            this.txtAntecedetesMédicos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAntecedetesMédicos.Size = new System.Drawing.Size(213, 50);
            this.txtAntecedetesMédicos.TabIndex = 8;
            this.tltF5.SetToolTip(this.txtAntecedetesMédicos, "Ingrese solo letras");
            // 
            // lblAntecedentesMédicos
            // 
            this.lblAntecedentesMédicos.AutoSize = true;
            this.lblAntecedentesMédicos.BackColor = System.Drawing.Color.Transparent;
            this.lblAntecedentesMédicos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAntecedentesMédicos.ForeColor = System.Drawing.Color.Black;
            this.lblAntecedentesMédicos.Location = new System.Drawing.Point(464, 178);
            this.lblAntecedentesMédicos.Name = "lblAntecedentesMédicos";
            this.lblAntecedentesMédicos.Size = new System.Drawing.Size(152, 19);
            this.lblAntecedentesMédicos.TabIndex = 0;
            this.lblAntecedentesMédicos.Text = "Antecedentes Médicos ";
            // 
            // lblTratamientoaRealizar
            // 
            this.lblTratamientoaRealizar.AutoSize = true;
            this.lblTratamientoaRealizar.BackColor = System.Drawing.Color.Transparent;
            this.lblTratamientoaRealizar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTratamientoaRealizar.ForeColor = System.Drawing.Color.Black;
            this.lblTratamientoaRealizar.Location = new System.Drawing.Point(464, 120);
            this.lblTratamientoaRealizar.Name = "lblTratamientoaRealizar";
            this.lblTratamientoaRealizar.Size = new System.Drawing.Size(138, 19);
            this.lblTratamientoaRealizar.TabIndex = 0;
            this.lblTratamientoaRealizar.Text = "Tratamiento a realizar";
            // 
            // lblRégimen
            // 
            this.lblRégimen.AutoSize = true;
            this.lblRégimen.BackColor = System.Drawing.Color.Transparent;
            this.lblRégimen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRégimen.ForeColor = System.Drawing.Color.Black;
            this.lblRégimen.Location = new System.Drawing.Point(464, 70);
            this.lblRégimen.Name = "lblRégimen";
            this.lblRégimen.Size = new System.Drawing.Size(61, 19);
            this.lblRégimen.TabIndex = 0;
            this.lblRégimen.Text = "Régimen";
            // 
            // lblEPS
            // 
            this.lblEPS.AutoSize = true;
            this.lblEPS.BackColor = System.Drawing.Color.Transparent;
            this.lblEPS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEPS.ForeColor = System.Drawing.Color.Black;
            this.lblEPS.Location = new System.Drawing.Point(464, 20);
            this.lblEPS.Name = "lblEPS";
            this.lblEPS.Size = new System.Drawing.Size(36, 19);
            this.lblEPS.TabIndex = 0;
            this.lblEPS.Text = "EPS";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(19, 167);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 19);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "E-mail";
            // 
            // lblOcupación
            // 
            this.lblOcupación.AutoSize = true;
            this.lblOcupación.BackColor = System.Drawing.Color.Transparent;
            this.lblOcupación.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcupación.ForeColor = System.Drawing.Color.Black;
            this.lblOcupación.Location = new System.Drawing.Point(19, 67);
            this.lblOcupación.Name = "lblOcupación";
            this.lblOcupación.Size = new System.Drawing.Size(75, 19);
            this.lblOcupación.TabIndex = 0;
            this.lblOcupación.Text = "Ocupación";
            // 
            // lblNivelEscolaridad
            // 
            this.lblNivelEscolaridad.AutoSize = true;
            this.lblNivelEscolaridad.BackColor = System.Drawing.Color.Transparent;
            this.lblNivelEscolaridad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivelEscolaridad.ForeColor = System.Drawing.Color.Black;
            this.lblNivelEscolaridad.Location = new System.Drawing.Point(19, 120);
            this.lblNivelEscolaridad.Name = "lblNivelEscolaridad";
            this.lblNivelEscolaridad.Size = new System.Drawing.Size(116, 19);
            this.lblNivelEscolaridad.TabIndex = 0;
            this.lblNivelEscolaridad.Text = "Nivel Escolaridad";
            // 
            // lblTeléfonoContacto
            // 
            this.lblTeléfonoContacto.AutoSize = true;
            this.lblTeléfonoContacto.BackColor = System.Drawing.Color.Transparent;
            this.lblTeléfonoContacto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeléfonoContacto.ForeColor = System.Drawing.Color.Black;
            this.lblTeléfonoContacto.Location = new System.Drawing.Point(19, 16);
            this.lblTeléfonoContacto.Name = "lblTeléfonoContacto";
            this.lblTeléfonoContacto.Size = new System.Drawing.Size(121, 19);
            this.lblTeléfonoContacto.TabIndex = 0;
            this.lblTeléfonoContacto.Text = "Teléfono Contacto";
            // 
            // grpContactoEmergencia
            // 
            this.grpContactoEmergencia.BackColor = System.Drawing.Color.Transparent;
            this.grpContactoEmergencia.Controls.Add(this.mskTeléfonoEmergencia);
            this.grpContactoEmergencia.Controls.Add(this.lblNombre);
            this.grpContactoEmergencia.Controls.Add(this.lblNúmeroTeléfono);
            this.grpContactoEmergencia.Controls.Add(this.txtNombreContacto);
            this.grpContactoEmergencia.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpContactoEmergencia.ForeColor = System.Drawing.Color.Black;
            this.grpContactoEmergencia.Location = new System.Drawing.Point(22, 371);
            this.grpContactoEmergencia.Name = "grpContactoEmergencia";
            this.grpContactoEmergencia.Size = new System.Drawing.Size(414, 108);
            this.grpContactoEmergencia.TabIndex = 2;
            this.grpContactoEmergencia.TabStop = false;
            this.grpContactoEmergencia.Text = "Contacto Emergencia";
            // 
            // mskTeléfonoEmergencia
            // 
            this.mskTeléfonoEmergencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskTeléfonoEmergencia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTeléfonoEmergencia.Location = new System.Drawing.Point(183, 68);
            this.mskTeléfonoEmergencia.Mask = "000-000-0000";
            this.mskTeléfonoEmergencia.Name = "mskTeléfonoEmergencia";
            this.mskTeléfonoEmergencia.Size = new System.Drawing.Size(213, 26);
            this.mskTeléfonoEmergencia.TabIndex = 2;
            this.mskTeléfonoEmergencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskTeléfonoEmergencia_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(6, 38);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(60, 19);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblNúmeroTeléfono
            // 
            this.lblNúmeroTeléfono.AutoSize = true;
            this.lblNúmeroTeléfono.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNúmeroTeléfono.Location = new System.Drawing.Point(6, 70);
            this.lblNúmeroTeléfono.Name = "lblNúmeroTeléfono";
            this.lblNúmeroTeléfono.Size = new System.Drawing.Size(152, 19);
            this.lblNúmeroTeléfono.TabIndex = 0;
            this.lblNúmeroTeléfono.Text = "Teléfono de emergencia";
            // 
            // txtNombreContacto
            // 
            this.txtNombreContacto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreContacto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreContacto.Location = new System.Drawing.Point(183, 36);
            this.txtNombreContacto.Name = "txtNombreContacto";
            this.txtNombreContacto.Size = new System.Drawing.Size(213, 26);
            this.txtNombreContacto.TabIndex = 1;
            this.tltF5.SetToolTip(this.txtNombreContacto, "Ingreso solo letras");
            // 
            // lblDatosPaciente
            // 
            this.lblDatosPaciente.AutoSize = true;
            this.lblDatosPaciente.BackColor = System.Drawing.Color.Transparent;
            this.lblDatosPaciente.Font = new System.Drawing.Font("Times New Roman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosPaciente.ForeColor = System.Drawing.Color.Black;
            this.lblDatosPaciente.Location = new System.Drawing.Point(467, 40);
            this.lblDatosPaciente.Name = "lblDatosPaciente";
            this.lblDatosPaciente.Size = new System.Drawing.Size(238, 41);
            this.lblDatosPaciente.TabIndex = 0;
            this.lblDatosPaciente.Text = "Datos Paciente";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(177, 169);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(213, 26);
            this.txtEmail.TabIndex = 4;
            // 
            // mskTélefonoContacto
            // 
            this.mskTélefonoContacto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskTélefonoContacto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTélefonoContacto.Location = new System.Drawing.Point(177, 19);
            this.mskTélefonoContacto.Mask = "000-000-0000";
            this.mskTélefonoContacto.Name = "mskTélefonoContacto";
            this.mskTélefonoContacto.Size = new System.Drawing.Size(213, 26);
            this.mskTélefonoContacto.TabIndex = 1;
            this.mskTélefonoContacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskTélefonoContacto_KeyPress);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnGuardar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(721, 427);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(150, 38);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRegresar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(519, 427);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(150, 38);
            this.btnRegresar.TabIndex = 4;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnAtrás_Click);
            // 
            // tltF5
            // 
            this.tltF5.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tltF5.ToolTipTitle = "Atención";
            // 
            // pbxLogoF5
            // 
            this.pbxLogoF5.BackColor = System.Drawing.Color.White;
            this.pbxLogoF5.Image = global::ConsultorioOdontologico.Properties.Resources.LOGO2recorte;
            this.pbxLogoF5.Location = new System.Drawing.Point(57, 11);
            this.pbxLogoF5.Margin = new System.Windows.Forms.Padding(2);
            this.pbxLogoF5.Name = "pbxLogoF5";
            this.pbxLogoF5.Size = new System.Drawing.Size(276, 94);
            this.pbxLogoF5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogoF5.TabIndex = 41;
            this.pbxLogoF5.TabStop = false;
            // 
            // grbF5
            // 
            this.grbF5.Controls.Add(this.lblTeléfonoContacto);
            this.grbF5.Controls.Add(this.lblNivelEscolaridad);
            this.grbF5.Controls.Add(this.lblOcupación);
            this.grbF5.Controls.Add(this.mskTélefonoContacto);
            this.grbF5.Controls.Add(this.lblEmail);
            this.grbF5.Controls.Add(this.txtEmail);
            this.grbF5.Controls.Add(this.lblEPS);
            this.grbF5.Controls.Add(this.lblRégimen);
            this.grbF5.Controls.Add(this.lblTratamientoaRealizar);
            this.grbF5.Controls.Add(this.lblAntecedentesMédicos);
            this.grbF5.Controls.Add(this.cmbEPS);
            this.grbF5.Controls.Add(this.txtAntecedetesMédicos);
            this.grbF5.Controls.Add(this.cmbTratamientoaRealizar);
            this.grbF5.Controls.Add(this.cmbNivelEscolaridad);
            this.grbF5.Controls.Add(this.cmbRégimen);
            this.grbF5.Controls.Add(this.cmbOcupación);
            this.grbF5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbF5.Location = new System.Drawing.Point(22, 127);
            this.grbF5.Name = "grbF5";
            this.grbF5.Size = new System.Drawing.Size(878, 238);
            this.grbF5.TabIndex = 1;
            this.grbF5.TabStop = false;
            // 
            // frmDatosPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(912, 487);
            this.Controls.Add(this.grbF5);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pbxLogoF5);
            this.Controls.Add(this.lblDatosPaciente);
            this.Controls.Add(this.grpContactoEmergencia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDatosPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos Paciente";
            this.grpContactoEmergencia.ResumeLayout(false);
            this.grpContactoEmergencia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoF5)).EndInit();
            this.grbF5.ResumeLayout(false);
            this.grbF5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEPS;
        private System.Windows.Forms.ComboBox cmbTratamientoaRealizar;
        private System.Windows.Forms.ComboBox cmbRégimen;
        private System.Windows.Forms.ComboBox cmbOcupación;
        private System.Windows.Forms.ComboBox cmbNivelEscolaridad;
        private System.Windows.Forms.TextBox txtAntecedetesMédicos;
        private System.Windows.Forms.Label lblAntecedentesMédicos;
        private System.Windows.Forms.Label lblTratamientoaRealizar;
        private System.Windows.Forms.Label lblRégimen;
        private System.Windows.Forms.Label lblEPS;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblOcupación;
        private System.Windows.Forms.Label lblNivelEscolaridad;
        private System.Windows.Forms.Label lblTeléfonoContacto;
        private System.Windows.Forms.GroupBox grpContactoEmergencia;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNúmeroTeléfono;
        private System.Windows.Forms.TextBox txtNombreContacto;
        private System.Windows.Forms.Label lblDatosPaciente;
        private System.Windows.Forms.PictureBox pbxLogoF5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox mskTeléfonoEmergencia;
        private System.Windows.Forms.MaskedTextBox mskTélefonoContacto;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.ToolTip tltF5;
        private System.Windows.Forms.GroupBox grbF5;
    }
}