using AdministradorOrtopediaVelásquez.Servicios;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace AdministradorOrtopediaVelásquez.Forms.Modals
{
    public partial class AgregarMedico : Form
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

        public AgregarMedico()
        {
            InitializeComponent();
            //this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void BarraSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture(); //Arrastre
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            ShowConfirmDialog showConfirm = new ShowConfirmDialog("¿Seguro que desea Cancelar?", this.Height, this.Width); //Se instancia el formulario
            this.Enabled = false;//Se desabilita el formulario actual
            if (showConfirm.ShowDialog(this) == DialogResult.OK) //Se usa ShowDialog ya que este devuelve lo que se asigne a DialogResult, luego se compara
            {
                this.Close(); //Si dio aceptar se finaliza el programa
            }
            else
            {
                this.Enabled = true; //Si cancelo se habilita el formulario actual
            }

        }

      
        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            btnAceptar.Visible = false;
            Status.Visible = true;

            if (txtNombre.Text == "" || IsNumeric(txtNombre.Text)) {
                MessageBox.Show("Nombre Invalido");
                Status.Visible = false;
                btnAceptar.Visible = true;
                return;
            }
            if (txtApellidos.Text == "" || IsNumeric(txtApellidos.Text)) {
                MessageBox.Show("Apellidos Invalidos");
                Status.Visible = false;
                btnAceptar.Visible = true;
                return;
            }
            string pattern = @"^\w{5,}@\w{3,}((\.)[A-Za-z]{2,3}){1,}$";
            if (!Regex.IsMatch(txtEmail.Text,pattern) ||  txtEmail.Text == "") {
                MessageBox.Show("Correo ingesado invalido");
                Status.Visible = false;
                btnAceptar.Visible = true;
                return;
            }
            if (cmbGenero.SelectedIndex == -1) {
                MessageBox.Show("Debe seleccionar un genero");
                Status.Visible = false;
                btnAceptar.Visible = true;
                return;
            }
            DateTime dt = FNacimiento.Value;
            double edad = ((DateTime.Now - dt).Days / 365.25);
            if (edad <= 18) {
                MessageBox.Show("No puede ser menor de edad!");
                Status.Visible = false;
                btnAceptar.Visible = true;
                return;
            }
            usuario u = new usuario();
            u.nombres = txtNombre.Text;
            u.apellidos = txtApellidos.Text;
            u.email = txtEmail.Text;
            u.contrasenya = "administrador";
            u.sexo = cmbGenero.SelectedIndex == 0 ? "M" : "F";
            u.tipoUsuario = 1;
            u.fechaNacimiento = FNacimiento.Value;

            bool Answer = await sesionServicio.AgregarAdministrador(u);
            if (Answer) {
                MessageBox.Show("Se agrego exitosamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ocurrio un error");
                btnAceptar.Visible = true;
            }
        }//btnAceptar

        private bool IsNumeric(String param) {
            try{
                int x = int.Parse(param);
                return true;
            }
            catch (Exception e) {
                return false;
            }

        }
    }
}
