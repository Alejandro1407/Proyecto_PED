using AdministradorOrtopediaVelásquez.Servicios;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace AdministradorOrtopediaVelásquez.Forms.PartialForms
{
    public partial class Cuenta: Form
    {
        private SesionServicio sesionServicio = new SesionServicio();
        public int id { get; set; } //Guarda el id del usuario que inicio sesion
        public string email { get; set; } //Guarda el email del usuario que inicio sesion
        public string nombre { get; set; } //Guarad el nombre del usuario

        public Cuenta()
        {
      
            InitializeComponent();
        }

        private void CuentaForm_Load(object sender, EventArgs e)
        {
           // MostrarData();
        }

        
        private async void MostrarData()
        {
            btnReload.Visible = false;
            List<usuario> administradores = await sesionServicio.ObtenerAdministradorAsync(id);

            if(administradores == null)
            {
                status.Image = Properties.Resources.Error;
                lblStatus.Text = "Ocurrio un Error!";
                btnReload.Visible = true;
                return;
            }
            foreach(usuario x in administradores) { 
                //panel2.Location = new Point(32, 38);
                txtUserName.Text = x.email;
                txtNombre.Text = x.nombres;
                txtPass.Text = "**********";
                status.Visible = false;
                lblStatus.Visible = false;
                btnReload.Visible = false;
                panel2.Visible = true;
            }
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            //MostrarData();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            ShowConfirmDialog showConfirm = new ShowConfirmDialog("¿Volver al Login?", this.Height, this.Width); //Se instancia el formulario
            this.Enabled = false;//Se desabilita el formulario actual
            if (showConfirm.ShowDialog(this) == DialogResult.OK) //Se usa ShowDialog ya que este devuelve lo que se asigne a DialogResult, luego se compara
            {
                LoginForm lf = new LoginForm(); //Si dio aceptar se finaliza el programa
                this.Close();
                lf.Show();
            }
            else
            {
                this.Enabled = true; //Si cancelo se habilita el formulario actual
            }
        }
    }
}
