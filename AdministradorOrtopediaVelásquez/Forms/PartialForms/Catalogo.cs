using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using AdministradorOrtopediaVelásquez.CustomControls;
using MaterialSkin.Controls;
using AdministradorOrtopediaVelásquez.Servicios;
using System;
using AdministradorOrtopediaVelásquez.Forms.Modals;

namespace AdministradorOrtopediaVelásquez.Forms.PartialForms
{
    public partial class Catalogo : Form
    {
        List<ortesis> Ortesis = new List<ortesis>(); //Lista con los Objetos
        List<protesis> Protesis = new List<protesis>(); //Lista con las protesis
        CatalogoServicio catalogoServicio = new CatalogoServicio();

        public Catalogo()
        {
            InitializeComponent();
            MostrarData("protesis");
        }
        /* Obtiene la imagen de la base de datos */
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        
        //Cambiar por Async
        private async void MostrarData(string ToShow, string param = "", bool IsSearch = false) {
            pnelContenedor.Controls.Clear();
            pnelContenedor.Controls.Add(lblStatus);
            pnelContenedor.Controls.Add(Status);
            pnelContenedor.Refresh();
            Status.Image = Properties.Resources.Loading;
            lblStatus.Location = new Point(360,292);
            lblStatus.Text = "Cargando...";
           
            if (ToShow == "protesis")
            {
                Protesis =  await catalogoServicio.ObtenerProtesisAsync(param);
                Ortesis = new List<ortesis>();
            }
            else
            {
                Ortesis =  await catalogoServicio.ObtenerOrtesisAsync(param);
                Protesis = new List<protesis>();
            }

            if (Protesis == null || Ortesis == null)
                {
                    Status.Image = Properties.Resources.Error;
                    lblStatus.Location = new Point(338,292);
                    lblStatus.Text = "Ha Ocurrido un error";
                    //btnReload.Visible = true;
                    return;
                }
                if ((Protesis.Count == 0 && Ortesis.Count == 0) && !IsSearch)
                {
                    Status.Image = Properties.Resources.Empty;
                    lblStatus.Location = new Point(298,291);
                    lblStatus.Text = "¡Oh No, El catalogo esta vacio!";
                    btnReload.Visible = true;
                    return;
                }

                if ((Protesis.Count == 0 && Ortesis.Count == 0 ) && IsSearch)
                {
                    Status.Image = Properties.Resources.NoResult;
                    lblStatus.Location = new Point(307,292);
                    lblStatus.Text = "No hay resultado para " + param;
                    return;
                }
            
            pnelContenedor.Controls.Clear();
            pnelContenedor.Refresh();
            int Y = 26;
            if (ToShow == "protesis")
            {
                foreach (protesis x in Protesis)
                {
                    PrintData(x, Y, ToShow);
                    Y += 204;
                }
            }
            else {
                foreach (ortesis x in Ortesis)
                {
                    PrintData(x, Y, ToShow);
                    Y += 204;
                }
            }
        }//Funcion

        private void PrintData(object x,int Y,String ToShow) {
            protesis p = new protesis();
            ortesis o = new ortesis();
            if (ToShow == "protesis")
            {
                p = (protesis) x;
            }
            else {
                o = (ortesis) x;
            }

            Panel pnel = new PanelDesign();
            pnel.Size = new Size(751, 177);
            pnel.Location = new Point(27, Y);

            PictureBox Img = new PictureBox();
            Img.Location = new Point(15, 12);
            Img.SizeMode = PictureBoxSizeMode.StretchImage;
            //Img.Image = Properties.Resources.Protesis;
            Img.Image = byteArrayToImage(ToShow == "protesis" ? p.foto : o.foto);
            Img.Size = new Size(155, 152);
            /* Codigo */
            PictureBox CodeImg = new PictureBox();
            CodeImg.Image = Properties.Resources.Codigo;
            CodeImg.Location = new Point(187, 30);
            CodeImg.Size = new Size(48, 48);
            CodeImg.SizeMode = PictureBoxSizeMode.StretchImage;

            Label lblCode_Titile = new Label();
            lblCode_Titile.Location = new Point(236, 30);
            lblCode_Titile.Size = new Size(48, 13);
            lblCode_Titile.Text = "Codigo: ";
            //lblCode_Titile.ForeColor = Color.Gray;
            lblCode_Titile.Font = new Font("Times New Roman", 9, FontStyle.Bold);

            Label lblCode = new MaterialLabel();
            lblCode.Location = new Point(236, 51);
            lblCode.Size = new Size(70, 18);
            lblCode.Text = ToShow == "protesis" ? p.codigo :o .codigo ;
            /* Nombre */
            PictureBox NombreImg = new PictureBox();
            NombreImg.Image = Properties.Resources.Nombre_Objeto;
            NombreImg.Location = new Point(187, 99);
            NombreImg.Size = new Size(48, 48);
            NombreImg.SizeMode = PictureBoxSizeMode.StretchImage;

            Label lblNombre_Title = new Label();
            lblNombre_Title.Location = new Point(236, 103);
            lblNombre_Title.AutoSize = true;
            lblNombre_Title.Text = "Nombre: ";
            //lblCode_Titile.ForeColor = Color.Gray;
            lblNombre_Title.Font = new Font("Times New Roman", 9, FontStyle.Bold);

            RichTextBox lblNombre = new RichTextBox();
            lblNombre.BorderStyle = BorderStyle.None;
            lblNombre.Location = new Point(236, 124);
            lblNombre.Size = new Size(168, 52);
            //lblNombre.Size = new Size(70, 18);
            lblNombre.Text = ToShow == "protesis" ? p.nombre : o.nombre;
            lblNombre.Font = new Font("Times New Roman", 10, FontStyle.Bold);
            /* Tipo */
            PictureBox TipoImg = new PictureBox();
            TipoImg.Image = Properties.Resources.Categoria;
            TipoImg.Location = new Point(399, 30);
            TipoImg.Size = new Size(48, 48);
            TipoImg.SizeMode = PictureBoxSizeMode.StretchImage;

            Label lblTipo_Titile = new Label();
            lblTipo_Titile.Location = new Point(448, 30);
            lblTipo_Titile.AutoSize = true;
            lblTipo_Titile.Text = "Tipo: ";
            //lblCode_Titile.ForeColor = Color.Gray;
            lblTipo_Titile.Font = new Font("Times New Roman", 9, FontStyle.Bold);

            Label lblTipo = new MaterialLabel();
            lblTipo.Location = new Point(448, 51);
            lblTipo.AutoSize = true;
            lblTipo.Text = ToShow == "protesis" ? p.tipoProtesis.nombre : o.tipoOrtesis.nombre;
            /* Descripcion */
            PictureBox DescripcionImg = new PictureBox();
            DescripcionImg.Image = Properties.Resources.Descripcion;
            DescripcionImg.Location = new Point(399, 99);
            DescripcionImg.Size = new Size(48, 48);
            DescripcionImg.SizeMode = PictureBoxSizeMode.StretchImage;

            Label lblDescripcion_Title = new Label();
            lblDescripcion_Title.Location = new Point(448, 103);
            lblDescripcion_Title.AutoSize = true;
            lblDescripcion_Title.Text = "Descripcion: ";
            //lblCode_Titile.ForeColor = Color.Gray;
            lblDescripcion_Title.Font = new Font("Times New Roman", 9, FontStyle.Bold);

            RichTextBox lblDescripcion = new RichTextBox();
            lblDescripcion.Location = new Point(448, 124);
            lblDescripcion.Size = new Size(135, 52);
            //lblNombre.Size = new Size(70, 18);
            lblDescripcion.BorderStyle = BorderStyle.None;
            lblDescripcion.Text = ToShow == "protesis" ? p.descripcion : o.descripcion;
            lblDescripcion.Font = new Font("Times New Roman", 10, FontStyle.Bold);
            /* Precio */
            PictureBox PrecioImg = new PictureBox();
            PrecioImg.Image = Properties.Resources.precio;
            PrecioImg.Location = new Point(600, 30);
            PrecioImg.Size = new Size(48, 48);
            PrecioImg.SizeMode = PictureBoxSizeMode.StretchImage;

            Label lblPrecio_Title = new Label();
            lblPrecio_Title.Location = new Point(650, 30);
            lblPrecio_Title.AutoSize = true;
            lblPrecio_Title.Text = "Precio: ";
            //lblCode_Titile.ForeColor = Color.Gray;
            lblPrecio_Title.Font = new Font("Times New Roman", 9, FontStyle.Bold);

            Label lblPrecio = new Label();
            lblPrecio.Location = new Point(650, 50);
            lblPrecio.Size = new Size(168, 52);
            //lblNombre.Size = new Size(70, 18);
            lblPrecio.BorderStyle = BorderStyle.None;
            lblPrecio.Text = ToShow == "protesis" ? p.precio.ToString() : o.precio.ToString();
            lblPrecio.Font = new Font("Times New Roman", 10, FontStyle.Bold);
            /* Button Editar */
            Button EditBtn = new Button();
            EditBtn.FlatStyle = FlatStyle.Flat;
            EditBtn.FlatAppearance.BorderSize = 0;
            EditBtn.Location = new Point(600, 99);
            EditBtn.Size = new Size(48, 48);
            EditBtn.Image = Properties.Resources.Editar;
            EditBtn.Name = ToShow == "protesis" ? p.id.ToString() : o.id.ToString(); ;
            EditBtn.Click += new System.EventHandler(this.EditarBtn_Click);
            /* Button Eliminar */
            Button EliminarBtn = new Button();
            EliminarBtn.FlatStyle = FlatStyle.Flat;
            EliminarBtn.FlatAppearance.BorderSize = 0;
            EliminarBtn.Location = new Point(650, 99);
            EliminarBtn.Size = new Size(48, 48);
            EliminarBtn.Image = Properties.Resources.Eliminar;
            EliminarBtn.Name = ToShow == "protesis" ? p.id.ToString() : o.id.ToString();
            EliminarBtn.Click += new System.EventHandler(this.EliminarBtn_Click);
            pnel.Controls.AddRange(new Control[] { Img, CodeImg, lblCode_Titile, lblCode, NombreImg, lblNombre_Title, lblNombre, TipoImg, lblTipo_Titile, lblTipo, DescripcionImg, lblDescripcion_Title, lblDescripcion,PrecioImg,lblPrecio_Title,lblPrecio, EditBtn, EliminarBtn });
            pnelContenedor.Controls.Add(pnel);
            pnelContenedor.Refresh();
            
        }

        private async void EliminarBtn_Click(object sender, EventArgs e) {
            string Ischecked = RdoProtesis.Checked ? "protesis" : "ortesis";
            //Se invoca a ShowConfirmDialog para que muestre al usario un mensaje y dos botones para cerrar y otro para cancelar
            ShowConfirmDialog showConfirm = new ShowConfirmDialog("¿Seguro que desea Eliminar?", this.Height, this.Width); //Se instancia el formulario
            this.Enabled = false;//Se desabilita el formulario actual
            if (showConfirm.ShowDialog(this) == DialogResult.OK) //Se usa ShowDialog ya que este devuelve lo que se asigne a DialogResult, luego se compara
            {
                if (Ischecked == "protesis")
                {
                    int Codigo = int.Parse(((Button)sender).Name);
                    if (await catalogoServicio.EliminarProtesisAsync(Codigo)) {
                            MessageBox.Show("Eliminado Correctamente");
                            this.Enabled = true;
                            MostrarData(Ischecked);
                    } else {
                        MessageBox.Show("Ocurrio un error");
                    }                }
                else {
                    int Codigo = int.Parse(((Button)sender).Name);
                    if (await catalogoServicio.EliminarOrtesisAsync(Codigo)) {
                        MessageBox.Show("Eliminado Correctamente");
                        this.Enabled = true;
                        MostrarData(Ischecked);
                        } else {
                        MessageBox.Show("Ocurrio un error");
                    }
                }
            }
            else
            {
                this.Enabled = true; //Si cancelo se habilita el formulario actual
            }
           
        }//EliminarBtn

        private void EditarBtn_Click(object sender, EventArgs e) {
            String IsCheked = RdoProtesis.Checked ? "protesis" : "ortesis";
            int id = int.Parse(((Button)sender).Name);
            EditarProducto editarProducto = new EditarProducto(IsCheked,id);
            editarProducto.Show();
            editarProducto.FormClosed += new FormClosedEventHandler(refresh);
        }
      
        private void txtBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            string Ischecked = RdoProtesis.Checked ? "protesis" : "ortesis";
            MostrarData(Ischecked, txtBusqueda.Text, true);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string Ischecked = RdoProtesis.Checked ? "protesis" : "ortesis";
            AgregarProducto agregarProducto = new AgregarProducto(Ischecked);
            agregarProducto.Show();
            agregarProducto.FormClosed += new FormClosedEventHandler(refresh);
        }

        private void refresh(object sender, EventArgs e) {
            string Ischecked = RdoProtesis.Checked ? "protesis" : "ortesis";
            MostrarData(Ischecked);
        }

        private void RdoOrtesis_Click(object sender, EventArgs e)
        {
            string Ischecked = RdoProtesis.Checked ? "protesis" : "ortesis";
            txtBusqueda.Text = "";
            MostrarData(Ischecked);
        }

        private void RdoProtesis_Click(object sender, EventArgs e)
        {
            string Ischecked = RdoProtesis.Checked ? "protesis" : "ortesis";
            txtBusqueda.Text = "";
            MostrarData(Ischecked);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            string Ischecked = RdoProtesis.Checked ? "protesis" : "ortesis";
            txtBusqueda.Text = "";
            MostrarData(Ischecked);
        }
    }//Clase
}//NameSpace
