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
        public AgregarMedico()
        {
            InitializeComponent();
        
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
            u.contrasenya = "Password01";
            u.sexo = cmbGenero.SelectedIndex == 0 ? "M" : "F";
            u.especialidad = txtEspecialidad.Text == "Especialidad" ? "" : txtEspecialidad.Text;
            u.experiencia = txtExperencia.Text == "Experencia" ? "" : txtExperencia.Text;
            u.tipoUsuario = 2;
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

        private void AgregarMedico_Load(object sender, EventArgs e)
        {
            txtEspecialidad.Font = new System.Drawing.Font("Roboto",11F);
            txtExperencia.Font = new System.Drawing.Font("Roboto",11F);
        }

        private void txtEspecialidad_Leave(object sender, EventArgs e)
        {
            if (txtEspecialidad.Text == "") {
                txtEspecialidad.Text = "Especialidad";
            }
        }

        private void txtExperencia_Leave(object sender, EventArgs e)
        {
            if (txtExperencia.Text == "") {
                txtExperencia.Text = "Experencia";
            }
        }

        private void txtEspecialidad_Click(object sender, EventArgs e)
        {
            if (txtEspecialidad.Text == "Especialidad")
            {
                txtEspecialidad.Text = "";
            }
        }

        private void txtExperencia_Click(object sender, EventArgs e)
        {
            if (txtExperencia.Text == "Experencia")
            {
                txtExperencia.Text = "";
            }
        }
    }//Clase
}//NameSpace
