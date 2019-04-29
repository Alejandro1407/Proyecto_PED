using AdministradorOrtopediaVelásquez.CustomControls;
using AdministradorOrtopediaVelásquez.Servicios;
using AdministradorOrtopediaVelásquez.Forms.Modals;
using MaterialSkin.Controls;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AdministradorOrtopediaVelásquez.Forms.PartialForms
{
    public partial class Administradores : Form
    {
        SesionServicio sesionServicio = new SesionServicio();
        public Administradores()
        {
            InitializeComponent();
            MostrarData();
        }

        public async void MostrarData(string param = "", bool IsSearch = false)
        {
            pnelContenedor.Controls.Clear();
            pnelContenedor.Controls.Add(lblStatus);
            pnelContenedor.Controls.Add(Status);
            pnelContenedor.Refresh();
            lblStatus.Location = new Point(360, 292);
            lblStatus.Text = "Cargando...";

            List<usuario> administradores = await sesionServicio.ObtenerAdministradoresAsync();

            if (administradores == null)
            {
                Status.Image = Properties.Resources.Error;
                lblStatus.Location = new Point(338, 292);
                lblStatus.Text = "Ha Ocurrido un error";
                //btnReload.Visible = true;
                return;
            }
            if (administradores.Count == 0 && !IsSearch)
            {
                Status.Image = Properties.Resources.Empty;
                lblStatus.Location = new Point(298, 291);
                lblStatus.Text = "¡Oh No, No hay administradores?";
                btnReload.Visible = true;
                return;
            }

            if (administradores.Count == 0  && IsSearch)
            {
                Status.Image = Properties.Resources.NoResult;
                lblStatus.Location = new Point(307, 292);
                lblStatus.Text = "No hay resultado para " + param;
                return;
            }

            pnelContenedor.Controls.Clear();
            pnelContenedor.Refresh();
            int Y = 25;

            foreach (usuario x in administradores) {
                PanelDesign pnel = new PanelDesign();
                pnel.Size = new Size(744, 181);
                pnel.Location = new Point(40,Y);

                /* Codigo */
                PictureBox CodigoImg = new PictureBox();
                CodigoImg.Image = Properties.Resources.Codigo;
                CodigoImg.Location = new Point(27, 26);
                CodigoImg.Size = new Size(48, 48);
                CodigoImg.SizeMode = PictureBoxSizeMode.StretchImage;

                Label lblCodigoTitle = new Label();
                lblCodigoTitle.Location = new Point(82, 26);
                lblCodigoTitle.AutoSize = true;
                lblCodigoTitle.Text = "Codigo: ";
                //lblCodigoTitle.ForeColor = Color.Gray;
                lblCodigoTitle.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);

                MaterialLabel lblCodigo = new MaterialLabel();
                lblCodigo.Location = new Point(81,55);
                lblCodigo.Text = x.codigoUsuario;

                /* Nombre */
                PictureBox NombreImg = new PictureBox();
                NombreImg.Image = Properties.Resources.Nombres;
                NombreImg.Location = new Point(27, 107);
                NombreImg.Size = new Size(48, 48);
                NombreImg.SizeMode = PictureBoxSizeMode.StretchImage;

                Label lblNombreTitle = new Label();
                lblNombreTitle.Location = new Point(82, 107);
                lblNombreTitle.AutoSize = true;
                lblNombreTitle.Text = "Nombres: ";
                //lblNombreTitle.ForeColor = Color.Gray;
                lblNombreTitle.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);

                RichTextBox lblNombre = new RichTextBox();
                lblNombre.ReadOnly = true;
                lblNombre.BackColor = Color.White;
                lblNombre.BorderStyle = BorderStyle.None;
                lblNombre.Location = new Point(85, 135);
                lblNombre.Size = new Size(126, 33);
                lblNombre.Text = x.nombres;
                lblNombre.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);

                /* Apellidos */
                PictureBox ApellidosImg = new PictureBox();
                ApellidosImg.Image = Properties.Resources.Apellidos;
                ApellidosImg.Location = new Point(232, 26);
                ApellidosImg.Size = new Size(48, 48);
                ApellidosImg.SizeMode = PictureBoxSizeMode.StretchImage;

                Label lblApellidosTitle = new Label();
                lblApellidosTitle.Location = new Point(287, 26);
                lblApellidosTitle.AutoSize = true;
                lblApellidosTitle.Text = "Apellidos: ";
                //lblApellidosTitle.ForeColor = Color.Gray;
                lblApellidosTitle.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);

                RichTextBox lblApellidos = new RichTextBox();
                lblApellidos.ReadOnly = true;
                lblApellidos.BackColor = Color.White;
                lblApellidos.BorderStyle = BorderStyle.None;
                lblApellidos.Location = new Point(290, 54);
                lblApellidos.Size = new Size(126, 33);
                lblApellidos.Text = x.apellidos;
                lblApellidos.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);

                /* Sexo */

                PictureBox GeneroImg = new PictureBox();
                GeneroImg.Image = Properties.Resources.Genero;
                GeneroImg.Location = new Point(232, 107);
                GeneroImg.Size = new Size(48, 48);
                GeneroImg.SizeMode = PictureBoxSizeMode.StretchImage;

                Label lblGeneroTitle = new Label();
                lblGeneroTitle.Location = new Point(287, 107);
                lblGeneroTitle.AutoSize = true;
                lblGeneroTitle.Text = "Sexo: ";
                //lblGeneroTitle.ForeColor = Color.Gray;
                lblGeneroTitle.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);

                MaterialLabel lblGenero = new MaterialLabel();
                lblGenero.Location = new Point(286, 135);
                lblGenero.Text = x.sexo == "M" ? "Masculino":"Femenino";

                /* Fecha Nacimiento */

                PictureBox FNacimientoImg = new PictureBox();
                FNacimientoImg.Image = Properties.Resources.cumpleanios;
                FNacimientoImg.Location = new Point(418, 68);
                FNacimientoImg.Size = new Size(48, 48);
                FNacimientoImg.SizeMode = PictureBoxSizeMode.StretchImage;

                Label lblFNacimientoTitle = new Label();
                lblFNacimientoTitle.Location = new Point(472, 68);
                lblFNacimientoTitle.AutoSize = true;
                lblFNacimientoTitle.Text = "Fecha Nacimiento: ";
                //lblTitle.ForeColor = Color.Gray;
                lblFNacimientoTitle.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);

                MaterialLabel lblFNacimiento = new MaterialLabel();
                lblFNacimiento.Location = new Point(472, 95);
                lblFNacimiento.Text = x.fechaNacimiento.ToString();

                pnel.Controls.AddRange(new Control[] { CodigoImg, lblCodigoTitle, lblCodigo, NombreImg, lblNombreTitle,lblNombre, ApellidosImg, lblApellidosTitle, lblApellidos, GeneroImg, lblGeneroTitle, lblGenero, FNacimientoImg,lblFNacimientoTitle ,lblFNacimiento });
                pnelContenedor.Controls.Add(pnel);

                Y += 200;
            }//ForEach
            /*
            /*  
            PictureBox Img = new PictureBox();
            Img.Image = Properties.Resources.Nombre_Objeto;
            Img.Location = new Point();
            Img.Size = new Size(48, 48);
            Img.SizeMode = PictureBoxSizeMode.StretchImage;

            Label lblTitle = new Label();
            lblTitle.Location = new Point(82, 26);
            lblTitle.AutoSize = true;
            lblTitle.Text = "Codigo: ";
            //lblTitle.ForeColor = Color.Gray;
            lblTitle.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);

            MaterialLabel lbl = new MaterialLabel();
            lbl.Location = new Point(68, 36);
            lbl.Text = ": ";
           */
        }//MostrarData

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            AgregarAdministrador ad = new AgregarAdministrador();
            ad.Show();
        }
    }//Clase
}//NameSpace

