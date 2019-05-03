using AdministradorOrtopediaVelásquez.Servicios;
using AdministradorOrtopediaVelásquez.Forms.Modals;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AdministradorOrtopediaVelásquez.Forms.PartialForms
{
    public partial class Medicos : Form
    {
        SesionServicio sesionServicio = new SesionServicio();
        public int id { get; set; } //Guarda el id del usuario que inicio sesion
        public string email { get; set; } //Guarda el email del usuario que inicio sesion
        public string nombre { get; set; } //Guarad el nombre del usuario

        public Medicos()
        {
            InitializeComponent();
            MostrarData();
        }
        public async void MostrarData(string param = "", bool IsSearch = false)
        {
            pnelContenedor.Controls.Clear();
            pnelContenedor.Controls.Add(lblStatus);
            pnelContenedor.Controls.Add(Status);
            pnelContenedor.Controls.Add(btnReload);
            pnelContenedor.Refresh();
            Status.Image = Properties.Resources.Loading;
            lblStatus.Location = new Point(360, 292);
            lblStatus.Text = "Cargando...";

            List<usuario> medicos = await sesionServicio.ObtenerMedicosAsync(param);
            if (medicos == null)
            {
                Status.Image = Properties.Resources.Error;
                lblStatus.Location = new Point(338, 292);
                lblStatus.Text = "Ha Ocurrido un error";
                btnReload.Location = new Point(327, 322);
                btnReload.Visible = true;
                return;
            }
            if (medicos.Count == 0 && !IsSearch)
            {
                Status.Image = Properties.Resources.Empty;
                lblStatus.Location = new Point(293, 291);
                lblStatus.Text = "¡Oh No, Aun no hay ningun medico!";
                btnReload.Location = new Point(327, 322);
                btnReload.Visible = true;
                return;
            }

            if (medicos.Count == 0 && IsSearch)
            {
                Status.Image = Properties.Resources.NoResult;
                lblStatus.Location = new Point(307, 292);
                btnReload.Location = new Point(327, 322);
                lblStatus.Text = "No hay resultado para " + param;
                btnReload.Visible = true;
                return;
            }

            pnelContenedor.Controls.Clear();
            pnelContenedor.Refresh();

            int Y = 24;
            foreach (usuario m in medicos) {
                //
                // pnel
                //
            CustomControls.PanelDesign pnel = new CustomControls.PanelDesign();
            pnel.Location = new System.Drawing.Point(12,Y);
            pnel.Size = new System.Drawing.Size(800, 181);
            pnel.TabIndex = 24;
            // 
            // NombreImg
            // 
            PictureBox NombreImg = new PictureBox();
            NombreImg.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Nombres;
            NombreImg.Location = new System.Drawing.Point(13, 28);
            NombreImg.Name = "NombreImg";
            NombreImg.Size = new System.Drawing.Size(48, 48);
            NombreImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            NombreImg.TabIndex = 3;
            NombreImg.TabStop = false;
            // 
            // lblTitleNombre
            // 
            Label lblTitleNombre = new Label();
            lblTitleNombre.AutoSize = true;
            lblTitleNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitleNombre.Location = new System.Drawing.Point(67, 28);
            lblTitleNombre.Name = "lblTitleNombre";
            lblTitleNombre.Size = new System.Drawing.Size(66, 18);
            lblTitleNombre.TabIndex = 4;
            lblTitleNombre.Text = "Nombre:";
            // 
            // lblNombre
            // 
            RichTextBox lblNombre = new RichTextBox();
            lblNombre.BackColor = System.Drawing.SystemColors.ControlLightLight;
            lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNombre.Location = new System.Drawing.Point(70, 56);
            lblNombre.Name = "lblNombre";
            lblNombre.ReadOnly = true;
            lblNombre.Size = new System.Drawing.Size(109, 33);
            lblNombre.TabIndex = 15;
            lblNombre.Text = m.nombres;
            // 
            // ApellidosImg
            // 
            PictureBox ApellidosImg = new PictureBox();
            ApellidosImg.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Apellidos;
            ApellidosImg.Location = new System.Drawing.Point(185, 28);
            ApellidosImg.Name = "ApellidosImg";
            ApellidosImg.Size = new System.Drawing.Size(48, 48);
            ApellidosImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            ApellidosImg.TabIndex = 5;
            ApellidosImg.TabStop = false;
            // 
            // lblTitleApellidos
            // 
            Label lblTitleApellidos = new Label();
            lblTitleApellidos.AutoSize = true;
            lblTitleApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitleApellidos.Location = new System.Drawing.Point(239, 28);
            lblTitleApellidos.Name = "lblTitleApellidos";
            lblTitleApellidos.Size = new System.Drawing.Size(71, 18);
            lblTitleApellidos.TabIndex = 6;
            lblTitleApellidos.Text = "Apellidos:";
            // 
            // lblApellidos
            // 
            RichTextBox lblApellidos = new RichTextBox();
            lblApellidos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            lblApellidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            lblApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblApellidos.Location = new System.Drawing.Point(243, 55);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.ReadOnly = true;
            lblApellidos.Size = new System.Drawing.Size(104, 33);
            lblApellidos.TabIndex = 16;
            lblApellidos.Text = m.apellidos;
            // 
            // EmailImg
            // 
            PictureBox EmailImg = new PictureBox();
            EmailImg.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.email;
            EmailImg.Location = new System.Drawing.Point(353, 28);
            EmailImg.Name = "EmailImg";
            EmailImg.Size = new System.Drawing.Size(48, 48);
            EmailImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            EmailImg.TabIndex = 69;
            EmailImg.TabStop = false;
            // 
            // lblEmailTitle
            // 
            Label lblEmailTitle = new Label();
            lblEmailTitle.AutoSize = true;
            lblEmailTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblEmailTitle.Location = new System.Drawing.Point(407, 28);
            lblEmailTitle.Name = "lblEmailTitle";
            lblEmailTitle.Size = new System.Drawing.Size(49, 18);
            lblEmailTitle.TabIndex = 70;
            lblEmailTitle.Text = "Email:";
            // 
            // lblEmail
            //
            RichTextBox lblEmail = new RichTextBox();
            lblEmail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblEmail.Location = new System.Drawing.Point(407, 55);
            lblEmail.Name = "lblEmail";
            lblEmail.ReadOnly = true;
            lblEmail.Size = new System.Drawing.Size(129, 42);
            lblEmail.TabIndex = 71;
            lblEmail.Text = m.email;
            // 
            // EspecialidadImg
            // 
            PictureBox EspecialidadImg = new PictureBox();
            EspecialidadImg.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Especialidad;
            EspecialidadImg.Location = new System.Drawing.Point(542, 28);
            EspecialidadImg.Name = "EspecialidadImg";
            EspecialidadImg.Size = new System.Drawing.Size(48, 48);
            EspecialidadImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            EspecialidadImg.TabIndex = 72;
            EspecialidadImg.TabStop = false;
            // 
            // lblTitleEspecialidad
            // 
            Label lblTitleEspecialidad = new Label();
            lblTitleEspecialidad.AutoSize = true;
            lblTitleEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitleEspecialidad.Location = new System.Drawing.Point(596, 28);
            lblTitleEspecialidad.Name = "lblTitleEspecialidad";
            lblTitleEspecialidad.Size = new System.Drawing.Size(95, 18);
            lblTitleEspecialidad.TabIndex = 73;
            lblTitleEspecialidad.Text = "Especialidad:";
            // 
            // lblEspecialidad
            //
            RichTextBox lblEspecialidad = new RichTextBox();
            lblEspecialidad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            lblEspecialidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            lblEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblEspecialidad.Location = new System.Drawing.Point(596, 55);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.ReadOnly = true;
            lblEspecialidad.Size = new System.Drawing.Size(138, 42);
            lblEspecialidad.TabIndex = 74;
            lblEspecialidad.Text = m.especialidad;
            // 
            // CumpleañosImg
            // 
            PictureBox CumpleañosImg = new PictureBox();
            CumpleañosImg.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.cumpleanios;
            CumpleañosImg.Location = new System.Drawing.Point(13, 108);
            CumpleañosImg.Name = "CumpleañosImg";
            CumpleañosImg.Size = new System.Drawing.Size(48, 48);
            CumpleañosImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            CumpleañosImg.TabIndex = 12;
            CumpleañosImg.TabStop = false;
            // 
            // lblTitleCumpleaños
            // 
            Label lblTitleCumpleaños = new Label();
            lblTitleCumpleaños.AutoSize = true;
            lblTitleCumpleaños.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitleCumpleaños.Location = new System.Drawing.Point(67, 108);
            lblTitleCumpleaños.Name = "lblTitleCumpleaños";
            lblTitleCumpleaños.Size = new System.Drawing.Size(96, 18);
            lblTitleCumpleaños.TabIndex = 13;
            lblTitleCumpleaños.Text = "Cumpleaños:";
            // 
            // lblCumpleaños
            // 
            MaterialSkin.Controls.MaterialLabel lblCumpleaños = new MaterialSkin.Controls.MaterialLabel();
            lblCumpleaños.AutoSize = true;
            lblCumpleaños.Depth = 0;
            lblCumpleaños.Font = new System.Drawing.Font("Roboto", 11F);
            lblCumpleaños.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            lblCumpleaños.Location = new System.Drawing.Point(67, 135);
            lblCumpleaños.MouseState = MaterialSkin.MouseState.HOVER;
            lblCumpleaños.Name = "lblCumpleaños";
            lblCumpleaños.Size = new System.Drawing.Size(81, 19);
            lblCumpleaños.TabIndex = 14;
            lblCumpleaños.Text = ((DateTime)m.fechaNacimiento).ToString("dd MMM yyyy");
            // 
            // GeneroImg
            // 
            PictureBox GeneroImg = new PictureBox();
            GeneroImg.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Genero;
            GeneroImg.Location = new System.Drawing.Point(186, 108);
            GeneroImg.Name = "GeneroImg";
            GeneroImg.Size = new System.Drawing.Size(48, 48);
            GeneroImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            GeneroImg.TabIndex = 9;
            GeneroImg.TabStop = false;
            // 
            // lblGeneroTitle
            // 
            Label lblGeneroTitle = new Label();
            lblGeneroTitle.AutoSize = true;
            lblGeneroTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblGeneroTitle.Location = new System.Drawing.Point(240, 109);
            lblGeneroTitle.Name = "lblGeneroTitle";
            lblGeneroTitle.Size = new System.Drawing.Size(46, 18);
            lblGeneroTitle.TabIndex = 10;
            lblGeneroTitle.Text = "Sexo:";
            // 
            // lblGenero
            // 
            MaterialSkin.Controls.MaterialLabel lblGenero = new MaterialSkin.Controls.MaterialLabel();
            lblGenero.AutoSize = true;
            lblGenero.Depth = 0;
            lblGenero.Font = new System.Drawing.Font("Roboto", 11F);
            lblGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            lblGenero.Location = new System.Drawing.Point(239, 137);
            lblGenero.MouseState = MaterialSkin.MouseState.HOVER;
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new System.Drawing.Size(79, 19);
            lblGenero.TabIndex = 11;
            lblGenero.Text = m.sexo == "M" ? "Masculino" : "Femenino";
            // 
            // ContraseñaImg
            // 
            PictureBox ContraseñaImg = new PictureBox();
            ContraseñaImg.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Contraseña;
            ContraseñaImg.Location = new System.Drawing.Point(353, 108);
            ContraseñaImg.Name = "ContraseñaImg";
            ContraseñaImg.Size = new System.Drawing.Size(48, 48);
            ContraseñaImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            ContraseñaImg.TabIndex = 65;
            ContraseñaImg.TabStop = false;
            // 
            // lblContraseñaTitle
            // 
            Label lblContraseñaTitle = new Label();
            lblContraseñaTitle.AutoSize = true;
            lblContraseñaTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblContraseñaTitle.Location = new System.Drawing.Point(407, 108);
            lblContraseñaTitle.Name = "lblContraseñaTitle";
            lblContraseñaTitle.Size = new System.Drawing.Size(89, 18);
            lblContraseñaTitle.TabIndex = 66;
            lblContraseñaTitle.Text = "Contraseña:";
            // 
            // lblContraseña
            //
            MaterialSkin.Controls.MaterialLabel lblContraseña = new MaterialSkin.Controls.MaterialLabel();
            lblContraseña.AutoSize = true;
            lblContraseña.Depth = 0;
            lblContraseña.Font = new System.Drawing.Font("Roboto", 11F);
            lblContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            lblContraseña.Location = new System.Drawing.Point(407, 138);
            lblContraseña.MouseState = MaterialSkin.MouseState.HOVER;
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new System.Drawing.Size(57, 19);
            lblContraseña.TabIndex = 67;
            lblContraseña.Text = "********";
            // 
            // ExperenciaImg
            // 
            PictureBox ExperenciaImg = new PictureBox();
            ExperenciaImg.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Experience;
            ExperenciaImg.Location = new System.Drawing.Point(542, 109);
            ExperenciaImg.Name = "ExperenciaImg";
            ExperenciaImg.Size = new System.Drawing.Size(48, 48);
            ExperenciaImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            ExperenciaImg.TabIndex = 75;
            ExperenciaImg.TabStop = false;
            // 
            // lblExperenciaTitle
            // 
            Label lblExperenciaTitle = new Label();
            lblExperenciaTitle.AutoSize = true;
            lblExperenciaTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblExperenciaTitle.Location = new System.Drawing.Point(596, 108);
            lblExperenciaTitle.Name = "lblExperenciaTitle";
            lblExperenciaTitle.Size = new System.Drawing.Size(88, 18);
            lblExperenciaTitle.TabIndex = 76;
            lblExperenciaTitle.Text = "Experiencia:";
            // 
            // lblExperencia
            // 
            RichTextBox lblExperencia = new RichTextBox();
            lblExperencia.BackColor = System.Drawing.SystemColors.ControlLightLight;
            lblExperencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            lblExperencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblExperencia.Location = new System.Drawing.Point(596, 135);
            lblExperencia.Name = "lblExperencia";
            lblExperencia.ReadOnly = true;
            lblExperencia.Size = new System.Drawing.Size(138, 42);
            lblExperencia.TabIndex = 77;
            lblExperencia.Text = m.experiencia;
            // 
            // btnEliminar
            // 
            Button btnEliminar = new Button();
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEliminar.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Eliminar;
            btnEliminar.Location = new System.Drawing.Point(735, 64);
            btnEliminar.Name = m.id.ToString();
            btnEliminar.Size = new System.Drawing.Size(59, 61);
            btnEliminar.TabIndex = 17;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += new EventHandler(this.btnEliminar_Click);

            pnel.Controls.AddRange(new Control[] {NombreImg, lblTitleNombre, lblNombre, ApellidosImg, lblTitleApellidos, lblApellidos, EmailImg, lblEmailTitle, lblEmail, EspecialidadImg, lblTitleEspecialidad, lblEspecialidad, CumpleañosImg, lblTitleCumpleaños, lblCumpleaños, GeneroImg, lblGeneroTitle, lblGenero, ContraseñaImg, lblContraseñaTitle, lblContraseña, ExperenciaImg, lblExperenciaTitle, lblExperencia, btnEliminar});
            this.pnelContenedor.Controls.Add(pnel);
            this.pnelContenedor.Refresh();
            Y += 205;

            }//ForEach
        }//MostrarData

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AgregarMedico ag = new AgregarMedico();
            ag.FormClosed += new FormClosedEventHandler(this.btnReload_Click);
            ag.Show();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            MostrarData();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(((Button)sender).Name);
            ShowConfirmDialog showConfirm = new ShowConfirmDialog("¿Seguro que desea Eliminar?", this.Height, this.Width); //Se instancia el formulario
            this.Enabled = false;//Se desabilita el formulario actual
            if (showConfirm.ShowDialog(this) == DialogResult.OK) //Se usa ShowDialog ya que este devuelve lo que se asigne a DialogResult, luego se compara
            {
                if (await sesionServicio.EliminarAdministrador(id))
                {
                    ShowDialog swd = new ShowDialog("Eliminado Exitosamente", "Success");
                    swd.ShowDialog(this);
                    this.Enabled = true;
                    MostrarData();
                }
                else
                {
                    ShowDialog swd = new ShowDialog("Ocurrio un error :c", "Error");
                    swd.ShowDialog(this);
                    this.Enabled = true;
                }
            }
            else
            {
                this.Enabled = true; //Si cancelo se habilita el formulario actual
            }
        }
    }//Clase
}//NameSpace
