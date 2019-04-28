using AdministradorOrtopediaVelásquez.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministradorOrtopediaVelásquez.Forms.Modals
{
    public partial class AgregarTipo : Form
    {
        private String toAdd;
        CatalogoServicio catalogoServicio = new CatalogoServicio();

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

        public AgregarTipo(String toAdd)
        {
            InitializeComponent();
            this.toAdd = toAdd;
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

        private void txtDescripcion_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "Descripcion") {
                txtDescripcion.ForeColor = Color.Black;
                txtDescripcion.Text = "";
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
            if (txtDescripcion.Text == "Descripcion" || txtDescripcion.Text == "" || IsNumeric(txtDescripcion.Text)) {
                MessageBox.Show("Descripcion Invalida");
                Status.Visible = false;
                btnAceptar.Visible = true;
                return;
            }
            bool Answer;
            if (toAdd == "protesis")
            {
                tipoProtesis tp = new tipoProtesis();
                tp.nombre = txtNombre.Text;
                tp.descripcion = txtDescripcion.Text;
                Answer = await catalogoServicio.AgregarTipoProtesisAsync(tp);
            }
            else {
                tipoOrtesis to = new tipoOrtesis();
                to.nombre = txtNombre.Text;
                to.descripcion = txtDescripcion.Text;
                Answer = await catalogoServicio.AgregarTipoOrtesisAsync(to);
            }
            if (Answer) {
                MessageBox.Show("Se Agrego Correctamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("Lo sentimos ocurrio un error");
                Status.Visible = false;
                btnAceptar.Visible = true;
            }
        }//btnAcepta

        private bool IsNumeric(String param) {
            try{
                int x = int.Parse(param);
                return true;
            }
            catch (Exception e) {
                return false;
            }

        }

        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "") {
                txtDescripcion.ForeColor = Color.Gray;
                txtDescripcion.Text = "Descripcion";
            }
        }
    }
}
