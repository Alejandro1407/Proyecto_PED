using AdministradorOrtopediaVelásquez.Servicios;
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
        }

        public async void MostrarData(string param = "",bool IsSearch = false) {

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

            if (administradores.Count == 0 && IsSearch)
            {
                Status.Image = Properties.Resources.NoResult;
                lblStatus.Location = new Point(307, 292);
                lblStatus.Text = "No hay resultado para " + param;
                return;
            }


        }
    }
}
