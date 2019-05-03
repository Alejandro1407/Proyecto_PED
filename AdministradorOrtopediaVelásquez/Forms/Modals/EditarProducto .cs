using AdministradorOrtopediaVelásquez.Forms;
using AdministradorOrtopediaVelásquez.Servicios;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AdministradorOrtopediaVelásquez.Forms.Modals
{
    public partial class EditarProducto : Form
    {
        private CatalogoServicio catalogoServicio = new CatalogoServicio();
        private List<tipoOrtesis> TipoOrtesis = new List<tipoOrtesis>();
        private List<tipoProtesis> TipoProtesis = new List<tipoProtesis>();
        private String toEdit;
        private int id;
        private protesis p;
        private ortesis o;
        private bool ImgChanged = false;

        public EditarProducto(String toEdit,int id)
        {
            InitializeComponent();
            this.toEdit = toEdit;
            this.id = id;
            //this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            setData();
        }

        private async void setData() {
            this.Controls.Clear();
            this.Controls.AddRange(new Control[] { BarraSuperior, Status, lblStatus });
            this.Refresh();

            if (toEdit == "protesis")
            {
                p = await catalogoServicio.ObtenerProtesiAsync(this.id);
                o = new ortesis();
                TipoProtesis = await catalogoServicio.ObtenerTiposProtesisAsync("");
                TipoOrtesis = new List<tipoOrtesis>();
            }
            else {
                o = await catalogoServicio.ObtenerOrtesiAsync(this.id);
                p = new protesis();
                TipoOrtesis = await catalogoServicio.ObtenerTiposOrtesisAsync("");
                TipoProtesis = new List<tipoProtesis>();
               
            }
            if (TipoProtesis == null || TipoOrtesis == null || o == null || p == null)
            {
                Status.Image = Properties.Resources.Error;
                lblStatus.Location = new Point(95, 271);
                lblStatus.Text = "Ha Ocurrido un error";
                return;
            }

            if (toEdit == "protesis")
            {
                txtNombre.Text = p.nombre;
                txtDescripcion.Text = p.descripcion;
                txtPrecio.Value = (decimal) p.precio;
                lblImagen.Text = "¡OK!";
                cmbTipo.DataSource = TipoProtesis;
                cmbTipo.SelectedItem = p.tipoProtesis;

            }
            else
            {
                txtNombre.Text = o.nombre;
                txtDescripcion.Text = o.descripcion;
                txtPrecio.Value = (decimal)o.precio;
                lblImagen.Text = "¡OK!";
                cmbTipo.DataSource = TipoOrtesis;
                cmbTipo.SelectedItem = o.tipoOrtesis;
            }
            cmbTipo.DisplayMember = "nombre";


            this.Controls.Clear();
            panelDesign1.Controls.AddRange(new Control[] { BarraSuperior, lblTitle, pictureBox2, pictureBox3, pictureBox4, pictureBox5, txtNombre, txtDescripcion, cmbTipo, btnAceptar, lblImagen, btnUpload });
            this.Controls.Add(panelDesign1);
        }//setData

     

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
            txtDescripcion.Text = "";
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            Subir.ShowDialog();
            
            if (Subir.FileName != "") {
                lblImagen.Text = "¡OK!";
                ImgChanged = true;
            }
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            byte[] ImgBytes = null;
            btnAceptar.Visible = false;
            panelDesign1.Controls.Add(Status);
            this.Status.Visible = true;
            Status.Location = new Point(118,410);

            if (txtNombre.Text == "" || IsNumeric(txtNombre.Text))
            {
                MessageBox.Show("Debe Ingresar un Nombre");
                Status.Visible = false;
                btnAceptar.Visible = true;
                return;
            }
            if (cmbTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Categoria no seleccionada");
                Status.Visible = false;
                btnAceptar.Visible = true;
                return;
            }
            if (Subir.FileName != "" )
            {
                Image image = Image.FromFile(Subir.FileName);
                MemoryStream Memory = new MemoryStream();
                image.Save(Memory, ImageFormat.Png);
                ImgBytes = Memory.ToArray();
            }
            if (txtPrecio.Value <= 0) {
                MessageBox.Show("Precio Invalido");
                Status.Visible = false;
                btnAceptar.Visible = true;
                return;
            }
            if (txtDescripcion.Text == "Descripcion" || txtDescripcion.Text == "" || IsNumeric(txtDescripcion.Text)) {
                MessageBox.Show("Debe Ingresar una descripcion");
                Status.Visible = false;
                btnAceptar.Visible = true;
                return;
            }
            bool answer = false;
            if (toEdit == "protesis")
            {
                protesis p = new protesis();
                p.nombre = txtNombre.Text;
                p.tipo = (cmbTipo.SelectedItem as tipoProtesis).id;
                p.precio = txtPrecio.Value;
                p.descripcion = txtDescripcion.Text;
                if (ImgChanged) { p.foto = ImgBytes; } else { p.foto = this.p.foto; }
                
                answer = await catalogoServicio.EditarProtesisAsync(p,this.id);
            }
            else {
                ortesis o = new ortesis();
                o.nombre = txtNombre.Text;
                o.tipo = (cmbTipo.SelectedItem as tipoOrtesis).id;
                o.precio = txtPrecio.Value;
                o.descripcion = txtDescripcion.Text;
                if (ImgChanged) { o.foto = ImgBytes; } else { o.foto = this.o.foto; }
                answer = await catalogoServicio.EditarOrtesisAsync(o,this.id);
            }

            if (answer)
            {
                MessageBox.Show("Actulizado Exitosamente");
                this.Close();
            }
            else {
                MessageBox.Show("Lo sentimos ocurrio un error");
                Status.Visible = false;
                btnAceptar.Visible = true;
            }

        }//btnAceptar

        private bool IsNumeric(String y)
        {
            try
            {
                int x = int.Parse(y);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "")
            {
                txtDescripcion.ForeColor = Color.Gray;
                txtDescripcion.Text = "Descripcion";
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
    }//Clase
}//NameSpace
