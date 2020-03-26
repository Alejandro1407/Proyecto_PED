using AdministradorOrtopediaVelásquez.Servicios;
using Desafio.Clases;
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
           MostrarData();
        }

        
        private async void MostrarData()
        {
            btnReload.Visible = false;
            Lista<usuario> administradores = await sesionServicio.ObtenerUsuarioAsync(id);

            if(administradores == null)
            {
                status.Image = Properties.Resources.Error;
                lblStatus.Text = "Ocurrio un Error!";
                btnReload.Visible = true;
                return;
            }
            foreach(usuario x in administradores) { 
                //panel2.Location = new Point(32, 38);
                txtNames.Text = x.nombres;
                txtApe.Text = x.apellidos;
                txtBirthDay.Text = ((DateTime)x.fechaNacimiento).ToString("dd MMM yyyy");
                txtEmail.Text = x.email;
                txtPass.Text = "**********";
                txtGenero.Text = x.sexo == "M" ? "Masculino" :"Femenino";
                status.Visible = false;
                lblStatus.Visible = false;
                btnReload.Visible = false;
                panel2.Visible = true;
            }
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            MostrarData();
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

        private async void btnChangePass_Click(object sender, EventArgs e)
        {
            ShowInputDialog sid = new ShowInputDialog("Ingrese contraseña actual","Cambiar Contraseña","********","password");
            var result = sid.ShowDialog();
            if (result == DialogResult.OK) {
                string oldpass = sid.data;
                usuario u = await sesionServicio.LoguearseAsync(this.email, oldpass);
                if (u == null)
                {
                    ShowDialog swd = new ShowDialog("Contraseña no coincide", "Error");
                    swd.ShowDialog();
                }
                else if (u.nombres == "Exception")
                {
                    ShowDialog swd = new ShowDialog("Ocurrio un error", "Error");
                    swd.ShowDialog();
                }
                else {
                    ShowInputDialog sd_ = new ShowInputDialog("Ingrese nueva contraseña", "Cambiar Contraseña", "********", "password");
                    var rs_ = sd_.ShowDialog();
                    if (rs_ == DialogResult.OK)
                    { 
                        ShowInputDialog sd = new ShowInputDialog("Confirme conraseña", "Cambiar Contraseña", "********", "password");
                        var rs = sd.ShowDialog();
                        if (rs == DialogResult.OK) {
                            if (sd_.data != sd.data) { MessageBox.Show("¡Error! Contraseñas no coinciden"); return; }
                            string newpass = sd.data;
                            bool answer = await sesionServicio.ChangePass(this.id,newpass);
                            if (answer)
                            {
                                ShowDialog swd = new ShowDialog("Contraseña actualizada", "Success");
                                swd.ShowDialog();
                            }
                            else {
                                ShowDialog swd = new ShowDialog("Ocurrio un error", "Error");
                                swd.ShowDialog();
                            }
                        }
                    }
                }
            }//result
        }//btnChange

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            ShowConfirmDialog shcd = new ShowConfirmDialog("¿Cerrar Sesión?",this.Height,this.Width);
            var result = shcd.ShowDialog();
            if (result == DialogResult.OK) {
                Application.Restart();
            }

        }
    }//Clase
}//NameSpace
