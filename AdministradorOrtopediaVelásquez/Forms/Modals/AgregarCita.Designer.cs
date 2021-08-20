namespace AdministradorOrtopediaVelásquez.Forms.Modals
{
    partial class AgregarCita
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
            this.panelDesign1 = new System.Windows.Forms.Panel();
            this.pnelContenedor = new System.Windows.Forms.Panel();
            this.Status = new System.Windows.Forms.PictureBox();
            this.txtExperencia = new System.Windows.Forms.RichTextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblStatus = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbPaciente = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.cmbMedico = new System.Windows.Forms.ComboBox();
            this.cmbHora = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dateFecha = new System.Windows.Forms.DateTimePicker();
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panelDesign1.SuspendLayout();
            this.pnelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.BarraSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDesign1
            // 
            this.panelDesign1.Controls.Add(this.pnelContenedor);
            this.panelDesign1.Controls.Add(this.BarraSuperior);
            this.panelDesign1.Location = new System.Drawing.Point(0, 0);
            this.panelDesign1.Name = "panelDesign1";
            this.panelDesign1.Size = new System.Drawing.Size(309, 521);
            this.panelDesign1.TabIndex = 7;
            // 
            // pnelContenedor
            // 
            this.pnelContenedor.Controls.Add(this.Status);
            this.pnelContenedor.Controls.Add(this.txtExperencia);
            this.pnelContenedor.Controls.Add(this.pictureBox5);
            this.pnelContenedor.Controls.Add(this.lblStatus);
            this.pnelContenedor.Controls.Add(this.pictureBox1);
            this.pnelContenedor.Controls.Add(this.materialLabel2);
            this.pnelContenedor.Controls.Add(this.cmbPaciente);
            this.pnelContenedor.Controls.Add(this.btnAceptar);
            this.pnelContenedor.Controls.Add(this.pictureBox4);
            this.pnelContenedor.Controls.Add(this.cmbMedico);
            this.pnelContenedor.Controls.Add(this.cmbHora);
            this.pnelContenedor.Controls.Add(this.pictureBox2);
            this.pnelContenedor.Controls.Add(this.pictureBox3);
            this.pnelContenedor.Controls.Add(this.dateFecha);
            this.pnelContenedor.Location = new System.Drawing.Point(10, 46);
            this.pnelContenedor.Name = "pnelContenedor";
            this.pnelContenedor.Size = new System.Drawing.Size(289, 472);
            this.pnelContenedor.TabIndex = 8;
            // 
            // Status
            // 
            this.Status.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Loading;
            this.Status.Location = new System.Drawing.Point(100, 156);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(83, 78);
            this.Status.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Status.TabIndex = 13;
            this.Status.TabStop = false;
            this.Status.Visible = false;
            // 
            // txtExperencia
            // 
            this.txtExperencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExperencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExperencia.ForeColor = System.Drawing.Color.Gray;
            this.txtExperencia.Location = new System.Drawing.Point(100, 317);
            this.txtExperencia.Name = "txtExperencia";
            this.txtExperencia.Size = new System.Drawing.Size(151, 48);
            this.txtExperencia.TabIndex = 26;
            this.txtExperencia.Text = "Observaciones";
            this.txtExperencia.Enter += new System.EventHandler(this.txtExperencia_Enter);
            this.txtExperencia.Leave += new System.EventHandler(this.txtExperencia_Leave_1);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Descripcion;
            this.pictureBox5.Location = new System.Drawing.Point(46, 317);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(48, 48);
            this.pictureBox5.TabIndex = 25;
            this.pictureBox5.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.Depth = 0;
            this.lblStatus.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStatus.Location = new System.Drawing.Point(88, 237);
            this.lblStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(108, 19);
            this.lblStatus.TabIndex = 24;
            this.lblStatus.Text = "Cargando...";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Medicos;
            this.pictureBox1.Location = new System.Drawing.Point(46, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(104, 21);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(92, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Agregar Cita";
            // 
            // cmbPaciente
            // 
            this.cmbPaciente.FormattingEnabled = true;
            this.cmbPaciente.Location = new System.Drawing.Point(100, 146);
            this.cmbPaciente.Name = "cmbPaciente";
            this.cmbPaciente.Size = new System.Drawing.Size(121, 21);
            this.cmbPaciente.TabIndex = 22;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAceptar.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Aceptar;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(90, 403);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(103, 46);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Nombres;
            this.pictureBox4.Location = new System.Drawing.Point(46, 119);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 48);
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // cmbMedico
            // 
            this.cmbMedico.FormattingEnabled = true;
            this.cmbMedico.Location = new System.Drawing.Point(100, 80);
            this.cmbMedico.Name = "cmbMedico";
            this.cmbMedico.Size = new System.Drawing.Size(121, 21);
            this.cmbMedico.TabIndex = 15;
            // 
            // cmbHora
            // 
            this.cmbHora.FormattingEnabled = true;
            this.cmbHora.Items.AddRange(new object[] {
            "07:00",
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "01:00",
            "02:00",
            "03:00",
            "04:00",
            "05:00",
            "06:00"});
            this.cmbHora.Location = new System.Drawing.Point(100, 273);
            this.cmbHora.Name = "cmbHora";
            this.cmbHora.Size = new System.Drawing.Size(121, 21);
            this.cmbHora.TabIndex = 20;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.edad;
            this.pictureBox2.Location = new System.Drawing.Point(46, 185);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.edad;
            this.pictureBox3.Location = new System.Drawing.Point(46, 251);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 48);
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // dateFecha
            // 
            this.dateFecha.Location = new System.Drawing.Point(100, 213);
            this.dateFecha.Name = "dateFecha";
            this.dateFecha.Size = new System.Drawing.Size(114, 20);
            this.dateFecha.TabIndex = 18;
            // 
            // BarraSuperior
            // 
            this.BarraSuperior.Controls.Add(this.materialLabel1);
            this.BarraSuperior.Controls.Add(this.btnCerrar);
            this.BarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.BarraSuperior.Name = "BarraSuperior";
            this.BarraSuperior.Size = new System.Drawing.Size(309, 40);
            this.BarraSuperior.TabIndex = 2;
            this.BarraSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraSuperior_MouseDown);
            this.BarraSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraSuperior_MouseMove);
            this.BarraSuperior.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BarraSuperior_MouseUp);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 9);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(92, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Agregar Cita";
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(264, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(35, 35);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // AgregarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(312, 521);
            this.Controls.Add(this.panelDesign1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarCita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarTipo";
            this.Load += new System.EventHandler(this.AgregarMedico_Load);
            this.panelDesign1.ResumeLayout(false);
            this.pnelContenedor.ResumeLayout(false);
            this.pnelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.BarraSuperior.ResumeLayout(false);
            this.BarraSuperior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraSuperior;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Button btnCerrar;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Panel panelDesign1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.PictureBox Status;
        private System.Windows.Forms.ComboBox cmbMedico;
        private System.Windows.Forms.ComboBox cmbPaciente;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ComboBox cmbHora;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DateTimePicker dateFecha;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel lblStatus;
        private System.Windows.Forms.Panel pnelContenedor;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.RichTextBox txtExperencia;
    }
}