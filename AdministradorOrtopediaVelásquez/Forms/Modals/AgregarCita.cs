using AdministradorOrtopediaVelásquez.Servicios;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Desafio.Clases;
using System.Linq;
using System.Drawing;

namespace AdministradorOrtopediaVelásquez.Forms.Modals
{
    public partial class AgregarCita : Form
    {
        SesionServicio sesionServicio = new SesionServicio();

        public AgregarCita()
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

            if (cmbMedico.SelectedIndex == -1 || cmbPaciente.SelectedIndex == -1) {
                MessageBox.Show("¡Error! Seleccione un paciente y un ortopedista");
                Status.Visible = false;
                btnAceptar.Visible = true;
                return;
            }

            if (dateFecha.Value <= DateTime.Now) {
                MessageBox.Show("¡Error! Seleccione una fecha valida");
                Status.Visible = false;
                btnAceptar.Visible = true;
                return;
            }

            if (cmbHora.SelectedIndex == -1)
            {
                MessageBox.Show("¡Error! Seleccione un horario valido");
                Status.Visible = false;
                btnAceptar.Visible = true;
                return;
            }

            Horarios horario = new Horarios();
            horario.Fecha = dateFecha.Value;
            horario.Hora = cmbHora.Text;

            cita cita = new cita();
            cita.idPaciente =((usuario)cmbPaciente.SelectedItem).id;
            cita.idMedico = ((usuario)cmbMedico.SelectedItem).id;
            cita.Horarios = (Horarios)horario;
            cita.observaciones = txtExperencia.Text == "Observaciones" ? "" : txtExperencia.Text;
            if (!await sesionServicio.AgregarCita(cita))
            {
                MessageBox.Show("¡Error! Horario no disponible");
                Status.Visible = false;
                btnAceptar.Visible = true;
                return;
            }
            else {
                MessageBox.Show("¡Exito! Cita registrada");
                this.Close();
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

        private async void AgregarMedico_Load(object sender, EventArgs e)
        {

            pnelContenedor.Controls.Clear();
            pnelContenedor.Controls.AddRange(new Control[] { Status, lblStatus });

            Lista<usuario> usuarios = await sesionServicio.ObtenerPacientesAsync("");

            Lista<usuario> medicos = await sesionServicio.ObtenerMedicosAsync();

            if(usuarios == null || medicos == null)
            {
                Status.Image = Properties.Resources.Error;
                lblStatus.Text = "¡Error! Ha ocurrido un error";
                return;
            }

            if (usuarios.Count == 0 || medicos.Count == 0)
            {
                Status.Image = Properties.Resources.Empty;
                lblStatus.Text = "¡Vacio! No hay ningun medico o paciente";
                return;
            }


           

            cmbPaciente.DataSource = usuarios.ToList();
            cmbPaciente.DisplayMember = "nombres";
            cmbMedico.DataSource = medicos.ToList();
            cmbMedico.DisplayMember = "nombres";
            pnelContenedor.Controls.Clear();
            pnelContenedor.Controls.AddRange(new Control[] { Status, pictureBox1, pictureBox2, pictureBox3, pictureBox4, cmbMedico, cmbHora, cmbPaciente, btnAceptar,materialLabel2,pictureBox5,txtExperencia,dateFecha});
            Status.Location = new System.Drawing.Point(107,372);

        }


        private void txtExperencia_Enter(object sender, EventArgs e)
        {
            if (txtExperencia.Text == "Observaciones")
            {
                txtExperencia.Text = "";
                txtExperencia.ForeColor = Color.Black;
            }
        }

        private void txtExperencia_Leave_1(object sender, EventArgs e)
        {
            if (txtExperencia.Text == "")
            {
                txtExperencia.Text = "Observaciones";
                txtExperencia.ForeColor = Color.Gray;
            }
        }

        /*
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
        */

    }//Clase
}//NameSpace
