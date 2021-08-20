namespace AdministradorOrtopediaVelásquez.Forms.PartialForms
{
    partial class Citas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Citas));
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBusqueda = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnelContenedor = new System.Windows.Forms.Panel();
            this.Status = new System.Windows.Forms.PictureBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.lblStatus = new MaterialSkin.Controls.MaterialLabel();
            this.pnel = new AdministradorOrtopediaVelásquez.CustomControls.PanelDesign();
            this.lblExperencia = new System.Windows.Forms.RichTextBox();
            this.lblExperenciaTitle = new System.Windows.Forms.Label();
            this.ExperenciaImg = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblMedico = new System.Windows.Forms.RichTextBox();
            this.lblPaciente = new System.Windows.Forms.RichTextBox();
            this.lblFecha = new MaterialSkin.Controls.MaterialLabel();
            this.lblTitleCumpleaños = new System.Windows.Forms.Label();
            this.CumpleañosImg = new System.Windows.Forms.PictureBox();
            this.lblHora = new MaterialSkin.Controls.MaterialLabel();
            this.lblGeneroTitle = new System.Windows.Forms.Label();
            this.GeneroImg = new System.Windows.Forms.PictureBox();
            this.lblTitleApellidos = new System.Windows.Forms.Label();
            this.ApellidosImg = new System.Windows.Forms.PictureBox();
            this.lblTitleNombre = new System.Windows.Forms.Label();
            this.NombreImg = new System.Windows.Forms.PictureBox();
            this.BarraSuperior.SuspendLayout();
            this.pnelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Status)).BeginInit();
            this.pnel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExperenciaImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CumpleañosImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneroImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApellidosImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NombreImg)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraSuperior
            // 
            this.BarraSuperior.Controls.Add(this.btnAdd);
            this.BarraSuperior.Controls.Add(this.txtBusqueda);
            this.BarraSuperior.Controls.Add(this.btnSearch);
            this.BarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.BarraSuperior.Name = "BarraSuperior";
            this.BarraSuperior.Size = new System.Drawing.Size(824, 49);
            this.BarraSuperior.TabIndex = 21;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Medicos;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAdd.Location = new System.Drawing.Point(506, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 40);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Depth = 0;
            this.txtBusqueda.Hint = "Busqueda (Nombre)";
            this.txtBusqueda.Location = new System.Drawing.Point(610, 16);
            this.txtBusqueda.MaxLength = 32767;
            this.txtBusqueda.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.PasswordChar = '\0';
            this.txtBusqueda.SelectedText = "";
            this.txtBusqueda.SelectionLength = 0;
            this.txtBusqueda.SelectionStart = 0;
            this.txtBusqueda.Size = new System.Drawing.Size(137, 23);
            this.txtBusqueda.TabIndex = 2;
            this.txtBusqueda.TabStop = false;
            this.txtBusqueda.UseSystemPasswordChar = false;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::AdministradorOrtopediaVelásquez.Properties.Resources.Search;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearch.Location = new System.Drawing.Point(753, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(39, 38);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // pnelContenedor
            // 
            this.pnelContenedor.AutoScroll = true;
            this.pnelContenedor.Controls.Add(this.Status);
            this.pnelContenedor.Controls.Add(this.pnel);
            this.pnelContenedor.Controls.Add(this.btnReload);
            this.pnelContenedor.Controls.Add(this.lblStatus);
            this.pnelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnelContenedor.Location = new System.Drawing.Point(0, 49);
            this.pnelContenedor.Name = "pnelContenedor";
            this.pnelContenedor.Size = new System.Drawing.Size(824, 551);
            this.pnelContenedor.TabIndex = 22;
            // 
            // Status
            // 
            this.Status.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Loading;
            this.Status.Location = new System.Drawing.Point(321, 177);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(114, 111);
            this.Status.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Status.TabIndex = 21;
            this.Status.TabStop = false;
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.White;
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnReload.ForeColor = System.Drawing.Color.Gray;
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReload.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnReload.Location = new System.Drawing.Point(297, 333);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(150, 53);
            this.btnReload.TabIndex = 23;
            this.btnReload.Text = "Reintentar";
            this.btnReload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Visible = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Depth = 0;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStatus.Location = new System.Drawing.Point(275, 303);
            this.lblStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(210, 27);
            this.lblStatus.TabIndex = 22;
            this.lblStatus.Text = "Cargando...";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnel
            // 
            this.pnel.Controls.Add(this.lblExperencia);
            this.pnel.Controls.Add(this.lblExperenciaTitle);
            this.pnel.Controls.Add(this.ExperenciaImg);
            this.pnel.Controls.Add(this.btnEliminar);
            this.pnel.Controls.Add(this.lblMedico);
            this.pnel.Controls.Add(this.lblPaciente);
            this.pnel.Controls.Add(this.lblFecha);
            this.pnel.Controls.Add(this.lblTitleCumpleaños);
            this.pnel.Controls.Add(this.CumpleañosImg);
            this.pnel.Controls.Add(this.lblHora);
            this.pnel.Controls.Add(this.lblGeneroTitle);
            this.pnel.Controls.Add(this.GeneroImg);
            this.pnel.Controls.Add(this.lblTitleApellidos);
            this.pnel.Controls.Add(this.ApellidosImg);
            this.pnel.Controls.Add(this.lblTitleNombre);
            this.pnel.Controls.Add(this.NombreImg);
            this.pnel.Location = new System.Drawing.Point(12, 24);
            this.pnel.Name = "pnel";
            this.pnel.Size = new System.Drawing.Size(767, 181);
            this.pnel.TabIndex = 24;
            // 
            // lblExperencia
            // 
            this.lblExperencia.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblExperencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblExperencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExperencia.Location = new System.Drawing.Point(429, 91);
            this.lblExperencia.Name = "lblExperencia";
            this.lblExperencia.ReadOnly = true;
            this.lblExperencia.Size = new System.Drawing.Size(138, 42);
            this.lblExperencia.TabIndex = 77;
            this.lblExperencia.Text = "";
            // 
            // lblExperenciaTitle
            // 
            this.lblExperenciaTitle.AutoSize = true;
            this.lblExperenciaTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExperenciaTitle.Location = new System.Drawing.Point(429, 64);
            this.lblExperenciaTitle.Name = "lblExperenciaTitle";
            this.lblExperenciaTitle.Size = new System.Drawing.Size(108, 18);
            this.lblExperenciaTitle.TabIndex = 76;
            this.lblExperenciaTitle.Text = "Observaciones";
            // 
            // ExperenciaImg
            // 
            this.ExperenciaImg.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Descripcion;
            this.ExperenciaImg.Location = new System.Drawing.Point(375, 65);
            this.ExperenciaImg.Name = "ExperenciaImg";
            this.ExperenciaImg.Size = new System.Drawing.Size(48, 48);
            this.ExperenciaImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExperenciaImg.TabIndex = 75;
            this.ExperenciaImg.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Eliminar;
            this.btnEliminar.Location = new System.Drawing.Point(696, 59);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(59, 61);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblMedico
            // 
            this.lblMedico.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMedico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedico.Location = new System.Drawing.Point(285, 49);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.ReadOnly = true;
            this.lblMedico.Size = new System.Drawing.Size(104, 33);
            this.lblMedico.TabIndex = 16;
            this.lblMedico.Text = "Alejo Gálvez";
            // 
            // lblPaciente
            // 
            this.lblPaciente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPaciente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaciente.Location = new System.Drawing.Point(85, 50);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.ReadOnly = true;
            this.lblPaciente.Size = new System.Drawing.Size(109, 33);
            this.lblPaciente.TabIndex = 15;
            this.lblPaciente.Text = "Victor Alejandro";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Depth = 0;
            this.lblFecha.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFecha.Location = new System.Drawing.Point(82, 129);
            this.lblFecha.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(81, 19);
            this.lblFecha.TabIndex = 14;
            this.lblFecha.Text = "2000-07-14";
            // 
            // lblTitleCumpleaños
            // 
            this.lblTitleCumpleaños.AutoSize = true;
            this.lblTitleCumpleaños.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleCumpleaños.Location = new System.Drawing.Point(82, 102);
            this.lblTitleCumpleaños.Name = "lblTitleCumpleaños";
            this.lblTitleCumpleaños.Size = new System.Drawing.Size(53, 18);
            this.lblTitleCumpleaños.TabIndex = 13;
            this.lblTitleCumpleaños.Text = "Fecha:";
            // 
            // CumpleañosImg
            // 
            this.CumpleañosImg.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.edad;
            this.CumpleañosImg.Location = new System.Drawing.Point(28, 102);
            this.CumpleañosImg.Name = "CumpleañosImg";
            this.CumpleañosImg.Size = new System.Drawing.Size(48, 48);
            this.CumpleañosImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CumpleañosImg.TabIndex = 12;
            this.CumpleañosImg.TabStop = false;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Depth = 0;
            this.lblHora.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHora.Location = new System.Drawing.Point(281, 131);
            this.lblHora.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(79, 19);
            this.lblHora.TabIndex = 11;
            this.lblHora.Text = "Masculino";
            // 
            // lblGeneroTitle
            // 
            this.lblGeneroTitle.AutoSize = true;
            this.lblGeneroTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneroTitle.Location = new System.Drawing.Point(282, 103);
            this.lblGeneroTitle.Name = "lblGeneroTitle";
            this.lblGeneroTitle.Size = new System.Drawing.Size(46, 18);
            this.lblGeneroTitle.TabIndex = 10;
            this.lblGeneroTitle.Text = "Sexo:";
            // 
            // GeneroImg
            // 
            this.GeneroImg.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.edad;
            this.GeneroImg.Location = new System.Drawing.Point(228, 102);
            this.GeneroImg.Name = "GeneroImg";
            this.GeneroImg.Size = new System.Drawing.Size(48, 48);
            this.GeneroImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GeneroImg.TabIndex = 9;
            this.GeneroImg.TabStop = false;
            // 
            // lblTitleApellidos
            // 
            this.lblTitleApellidos.AutoSize = true;
            this.lblTitleApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleApellidos.Location = new System.Drawing.Point(281, 22);
            this.lblTitleApellidos.Name = "lblTitleApellidos";
            this.lblTitleApellidos.Size = new System.Drawing.Size(57, 18);
            this.lblTitleApellidos.TabIndex = 6;
            this.lblTitleApellidos.Text = "Medico";
            // 
            // ApellidosImg
            // 
            this.ApellidosImg.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Medicos;
            this.ApellidosImg.Location = new System.Drawing.Point(227, 22);
            this.ApellidosImg.Name = "ApellidosImg";
            this.ApellidosImg.Size = new System.Drawing.Size(48, 48);
            this.ApellidosImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ApellidosImg.TabIndex = 5;
            this.ApellidosImg.TabStop = false;
            // 
            // lblTitleNombre
            // 
            this.lblTitleNombre.AutoSize = true;
            this.lblTitleNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleNombre.Location = new System.Drawing.Point(82, 22);
            this.lblTitleNombre.Name = "lblTitleNombre";
            this.lblTitleNombre.Size = new System.Drawing.Size(65, 18);
            this.lblTitleNombre.TabIndex = 4;
            this.lblTitleNombre.Text = "Paciente";
            // 
            // NombreImg
            // 
            this.NombreImg.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Nombres;
            this.NombreImg.Location = new System.Drawing.Point(28, 22);
            this.NombreImg.Name = "NombreImg";
            this.NombreImg.Size = new System.Drawing.Size(48, 48);
            this.NombreImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NombreImg.TabIndex = 3;
            this.NombreImg.TabStop = false;
            // 
            // Citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(824, 600);
            this.Controls.Add(this.pnelContenedor);
            this.Controls.Add(this.BarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Citas";
            this.Text = "Medicos";
            this.BarraSuperior.ResumeLayout(false);
            this.pnelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Status)).EndInit();
            this.pnel.ResumeLayout(false);
            this.pnel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExperenciaImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CumpleañosImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneroImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApellidosImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NombreImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel BarraSuperior;
        private System.Windows.Forms.Button btnAdd;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBusqueda;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnelContenedor;
        private System.Windows.Forms.Button btnReload;
        private MaterialSkin.Controls.MaterialLabel lblStatus;
        private System.Windows.Forms.PictureBox Status;
        private CustomControls.PanelDesign pnel;
        private System.Windows.Forms.RichTextBox lblMedico;
        private System.Windows.Forms.RichTextBox lblPaciente;
        private MaterialSkin.Controls.MaterialLabel lblFecha;
        private System.Windows.Forms.Label lblTitleCumpleaños;
        private System.Windows.Forms.PictureBox CumpleañosImg;
        private MaterialSkin.Controls.MaterialLabel lblHora;
        private System.Windows.Forms.Label lblGeneroTitle;
        private System.Windows.Forms.PictureBox GeneroImg;
        private System.Windows.Forms.Label lblTitleApellidos;
        private System.Windows.Forms.PictureBox ApellidosImg;
        private System.Windows.Forms.Label lblTitleNombre;
        private System.Windows.Forms.PictureBox NombreImg;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.RichTextBox lblExperencia;
        private System.Windows.Forms.Label lblExperenciaTitle;
        private System.Windows.Forms.PictureBox ExperenciaImg;
    }
}