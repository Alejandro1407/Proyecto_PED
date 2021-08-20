using AdministradorOrtopediaVelásquez.Forms;
using AdministradorOrtopediaVelásquez.Servicios;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AdministradorOrtopediaVelásquez
{
    public partial class LoginForm : Form
    {
        SesionServicio sesionServicio = new SesionServicio();
       

        public LoginForm()
        {
            InitializeComponent();
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0,0, Width, Height, 20, 20));
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

            usuario p = await sesionServicio.LoguearseAsync(txtUser.Text, txtPassword.Text);
            if (p == null)
            {
                MessageBox.Show("Usuario y/o contraseña incorecto");
                btnIniciar.Visible = true;
                Status.Visible = false;
                return;
            }
            else if (p.nombres == "Exception")
            {
                //Status.Image = Properties.Resources.Error;
                //Status.Visible = true;
                MessageBox.Show("Ocurrio un error");
                btnIniciar.Visible = true;
                Status.Visible = false;
            }
            else {

                if (p.tipoUsuario == 1)
                {
                    MainForm_Administrador mf = new MainForm_Administrador((int)p.tipoUsuario);
                    mf.id = p.id;
                    mf.nombre = p.nombres;
                    mf.email = p.email;
                    mf.Show();
                    this.Close();
                }
                else if(p.tipoUsuario == 2) {
                    MainForm_Medico mf = new MainForm_Medico((int)p.tipoUsuario);
                    mf.id = p.id;
                    mf.nombre = p.nombres;
                    mf.email = p.email;
                    mf.Show();
                    this.Close();
                }
                else if (p.tipoUsuario == 3)
                {
                    MainForm_Secretaria mf = new MainForm_Secretaria((int)p.tipoUsuario);
                    mf.id = p.id;
                    mf.nombre = p.nombres;
                    mf.email = p.email;
                    mf.Show();
                    this.Close();
                }


            }
        }

        /* Codigo para las sombras y redondeo */

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
