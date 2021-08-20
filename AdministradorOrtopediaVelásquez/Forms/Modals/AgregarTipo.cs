﻿using AdministradorOrtopediaVelásquez.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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

        public AgregarTipo(String toAdd)
        {
            InitializeComponent();
            this.toAdd = toAdd;
            //this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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
            byte[] ImgBytes = null;
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
            if (Subir.FileName != "")
            {
                Image image = Image.FromFile(Subir.FileName);
                MemoryStream Memory = new MemoryStream();
                image.Save(Memory, ImageFormat.Png);
                ImgBytes = Memory.ToArray();
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una Imagen");
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
                tp.foto = ImgBytes;
                Answer = await catalogoServicio.AgregarTipoProtesisAsync(tp);
            }
            else {
                tipoOrtesis to = new tipoOrtesis();
                to.nombre = txtNombre.Text;
                to.descripcion = txtDescripcion.Text;
                to.foto = ImgBytes;
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

        private void btnUpload_Click(object sender, EventArgs e)
        {
            Subir.ShowDialog();

            if (Subir.FileName != "")
            {
                lblImagen.Text = "¡OK!";
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
