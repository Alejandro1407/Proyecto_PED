using System;
using System.Runtime.InteropServices;
using AdministradorOrtopediaVelásquez.Forms;
using System.Windows.Forms;
using System.Drawing.Text;
using AdministradorOrtopediaVelásquez.Forms.PartialForms;
using System.Drawing;

namespace AdministradorOrtopediaVelásquez
{
    public partial class MainForm_Secretaria : Form
    {
        private Form formActual; //Guarda el PartialForm que esta abierto en ese momento
        private Button Actual; //Guarda el button que inicio la form actual para darle color
        public int id { get; set; } //Guarda el id del usuario que inicio sesion
        public string email { get; set; } //Guarda el email del usuario que inicio sesion
        public string nombre { get; set; } //Guarad el nombre del usuario
    
        private int UserType { get; set; }
        public MainForm_Secretaria(int Type)
        {
            InitializeComponent();
            UserType = Type;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            Actual = btnHorarios;
            AbrirFormInPanel(new Citas());
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
            Catalogo c = new Catalogo();
            c.id = this.id;
            c.nombre = this.nombre;
            c.email = this.email;
            AbrirFormInPanel(c);
        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {
            Actual.BackColor = Color.White;
            Actual = ((Button)sender);
            Actual.BackColor = Color.LightGray;
            Cuenta c = new Cuenta();
            c.id = this.id;
            c.nombre = this.nombre;
            c.email = this.email;
            AbrirFormInPanel(c);
        }

        private void btnTipo_Click(object sender, EventArgs e)
        {
            Actual.BackColor = Color.White;
            Actual = ((Button)sender);
            Actual.BackColor = Color.LightGray;
            Tipo t = new Tipo();
            t.id = this.id;
            t.nombre = this.nombre;
            t.email = this.email;
            AbrirFormInPanel(t);
        }

        private void btnHorarios_Click(object sender, EventArgs e)
        {
            Actual.BackColor = Color.White;
            Actual = ((Button)sender);
            Actual.BackColor = Color.LightGray;
            Citas c = new Citas();
            c.id = this.id;
            c.nombre = this.nombre;
            c.email = this.email;
            AbrirFormInPanel(c);
        }

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            Actual.BackColor = Color.White;
            Actual = ((Button)sender);
            Actual.BackColor = Color.LightGray;
            Medicos m = new Medicos();
      
            AbrirFormInPanel(m);
        }

        private void btnAdmistradores_Click(object sender, EventArgs e)
        {
            Actual.BackColor = Color.White;
            Actual = ((Button)sender);
            Actual.BackColor = Color.LightGray;
            Usuarios adm = new Usuarios();
            adm.id = this.id;
            adm.nombre = this.nombre;
            adm.email = this.email;
            AbrirFormInPanel(adm);
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            Actual.BackColor = Color.White;
            Actual = ((Button)sender);
            Actual.BackColor = Color.LightGray;
            Pacientes adm = new Pacientes();
            adm.id = this.id;
            adm.nombre = this.nombre;
            adm.email = this.email;
            AbrirFormInPanel(adm);
        }
        /* Codigo para las sombras y redondeo */
        //No comprendo como funciona pero lo hace
        private bool Drag;
        private int MouseX;
        private int MouseY;

        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        private bool m_aeroEnabled;

        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]

        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();
                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW; return cp;
            }
        }
        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0; DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 0,
                            rightWidth = 0,
                            topHeight = 0
                        }; DwmExtendFrameIntoClientArea(this.Handle, ref margins);
                    }
                    break;
                default: break;
            }
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT) m.Result = (IntPtr)HTCAPTION;
        }
        private void BarraSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            Drag = true;
            MouseX = Cursor.Position.X - this.Left;
            MouseY = Cursor.Position.Y - this.Top;
        }
        private void BarraSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            if (Drag)
            {
                this.Top = Cursor.Position.Y - MouseY;
                this.Left = Cursor.Position.X - MouseX;
            }
        }
        private void BarraSuperior_MouseUp(object sender, MouseEventArgs e) { Drag = false; }

    }//Clase
}//NameSpace
