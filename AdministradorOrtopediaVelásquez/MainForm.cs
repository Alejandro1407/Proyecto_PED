using System;
using System.Runtime.InteropServices;
using AdministradorOrtopediaVelásquez.Forms;
using System.Windows.Forms;
using System.Drawing.Text;
using AdministradorOrtopediaVelásquez.Forms.PartialForms;
using System.Drawing;

namespace AdministradorOrtopediaVelásquez
{
    public partial class MainForm : Form
    {
        private Form formActual; //Guarda el PartialForm que esta abierto en ese momento
        private Button Actual; //Guarda el button que inicio la form actual para darle color
        private int id = 0;
            
        //Funcion para Arraste del Form
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
        public MainForm(int id)
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.id = id;
            Actual = btnCatalogo;
            AbrirFormInPanel(new Catalogo());
        }

        private void AbrirFormInPanel(object formulario)
        {
            Form fh = formulario as Form; //Se recibio un object generico y se realiza un Parse hacia un objeto Form
            if (pnelContenedor.Controls.Count > 0) //Se comprueba si ya esta otro form instanciado
            {
                pnelContenedor.Controls.RemoveAt(0);//Se eliminan todos los controles si existen
                formActual.Close(); //Se cierra el formulario anterior para poder abrir el nuevo
            }
            else
            {
                formActual = fh; 
            }
            formActual = fh;
            fh.TopLevel = false; 
            fh.Dock = DockStyle.Fill;
            this.pnelContenedor.Controls.Add(fh); //Se instancia fh dentro del pnelContenedor 
            fh.Show(); //Se muestra el form instanciado
        }

        /* Funciones para la barra superior */

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

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;//Si esta maximizada se reduce
            }
            else
            {
                this.WindowState = FormWindowState.Maximized; //Si no, se maximinza
            }
        }//Listener

        private void MainForm_Load(object sender, EventArgs e)
        {
            PrivateFontCollection pF = new PrivateFontCollection();
        }

        private void BarraSuperior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            Actual.BackColor = Color.White;
            Actual = ((Button)sender);
            Actual.BackColor = Color.LightGray;
            AbrirFormInPanel(new Catalogo());
        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {
            Actual.BackColor = Color.White;
            Actual = ((Button)sender);
            Actual.BackColor = Color.LightGray;
            AbrirFormInPanel(new Cuenta(this.id));
        }

        private void btnTipo_Click(object sender, EventArgs e)
        {
            Actual.BackColor = Color.White;
            Actual = ((Button)sender);
            Actual.BackColor = Color.LightGray;
            AbrirFormInPanel(new Tipo());
        }

        private void btnHorarios_Click(object sender, EventArgs e)
        {
            Actual.BackColor = Color.White;
            Actual = ((Button)sender);
            Actual.BackColor = Color.LightGray;
            AbrirFormInPanel(new Horarios());
        }

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            Actual.BackColor = Color.White;
            Actual = ((Button)sender);
            Actual.BackColor = Color.LightGray;
            AbrirFormInPanel(new Medicos());
        }

        private void btnAdmistradores_Click(object sender, EventArgs e)
        {
            Actual.BackColor = Color.White;
            Actual = ((Button)sender);
            Actual.BackColor = Color.LightGray;
            AbrirFormInPanel(new Administradores());
        }
    }//Clase
}//NameSpace
