using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;

namespace AdministradorOrtopediaVelásquez.Forms
{
    public partial class ShowDialog : Form
    {
       public ShowDialog(String Mensaje,String Title = "Informacion")
        {
            InitializeComponent();
            lblMensaje.Text = Mensaje;
            lblTitle.Text = Title;
            switch (Title) {
                case "Informacion":
                    InfoImg.Image = Properties.Resources.Information;
                    break;
                case "Advertencia":
                    InfoImg.Image = Properties.Resources.Warning;
                    break;
                case "Error":
                    InfoImg.Image = Properties.Resources.Error;
                    break;
                case "Success":
                    InfoImg.Image = Properties.Resources.Success;
                    break;
                default:
                    InfoImg.Image = Properties.Resources.Information;
                    break;
            }
        }
   
        //Si se dio click en btnAceptar se devuelve el DialogResult como OK
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
