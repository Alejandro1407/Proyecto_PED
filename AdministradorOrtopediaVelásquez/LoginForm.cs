using AdministradorOrtopediaVelásquez.Forms;
using AdministradorOrtopediaVelásquez.Servicios;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AdministradorOrtopediaVelásquez
{
    public partial class LoginForm : Form
    {
        SesionServicio sesionServicio = new SesionServicio();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
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
        public LoginForm()
        {
            InitializeComponent();
            //this.Region = Region.FromHrgn(CreateRoundRectRgn(0,0, Width, Height, 20, 20));
        }

        private void BarraSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture(); //Arrastre
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Listener para btnCerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {   //Se invoca a ShowConfirmDialog para que muestre al usario un mensaje y dos botones para cerrar y otro para cancelar
            ShowConfirmDialog showConfirm = new ShowConfirmDialog("¿Seguro que desea Salir?", this.Height, this.Width); //Se instancia el formulario
            this.Enabled = false;//Se desabilita el formulario actual
            if (showConfirm.ShowDialog(this) == DialogResult.OK) //Se usa ShowDialog ya que este devuelve lo que se asigne a DialogResult, luego se compara
            {
                Application.Exit(); //Si dio aceptar se finaliza el programa
            }
            else
            {
                this.Enabled = true; //Si cancelo se habilita el formulario actual
            }

        }

        //Listener para minimizar el formulario
        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }//Listener

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void BarraSuperior_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void btnIniciar_Click(object sender, EventArgs e)
        {
            btnIniciar.Visible = false;
            Status.Image = Properties.Resources.Loading;
            Status.Visible = true;
            List<usuario> p = await sesionServicio.LoguearseAsync(txtUser.Text, txtPassword.Text);
            if (p == null) {
                Status.Image = Properties.Resources.Error;
                Status.Visible = true;
                MessageBox.Show("Ocurrio un error");
            }
            if (p.Count > 0)
            {
                MainForm mf = new MainForm();
                mf.id = p[0].id;
                mf.nombre = p[0].nombres;
                mf.email = p[0].email;
                mf.Show();
                this.Close();
            }
            else {
                MessageBox.Show("Usuario y/o contraseña incorecto");
                btnIniciar.Visible = true;
                Status.Visible = false;
            }
        }

        private void Status_Click(object sender, EventArgs e)
        {

        }
    }
}
