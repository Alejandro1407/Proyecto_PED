using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;

namespace AdministradorOrtopediaVelásquez.Forms
{
    public partial class ShowConfirmDialog : Form
    {
        //Funcion para redondear, no estoy demasiado seguro como funciona
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        //Constructor recibe el Mensaje a mostrar al usuario
        public ShowConfirmDialog(String Mensaje,int heigth,int width)
        {
            InitializeComponent();
            //this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            lblMensaje.Text = Mensaje;
        }

        //Si se dio click en btnAceptar se devuelve el DialogResult como OK
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        //Pero si fue en btnCancelar se devuelve Abort
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
        }

       
    }
}
