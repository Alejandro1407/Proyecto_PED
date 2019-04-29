using AdministradorOrtopediaVelásquez.CustomControls;
using AdministradorOrtopediaVelásquez.Forms.Modals;
using AdministradorOrtopediaVelásquez.Servicios;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AdministradorOrtopediaVelásquez.Forms.PartialForms
{
    public partial class Tipo : Form
    {
        List<tipoProtesis> TProtesis = new List<tipoProtesis>();
        List<tipoOrtesis> TOrtesis = new List<tipoOrtesis>();
        CatalogoServicio catalogoServicio = new CatalogoServicio();

        public Tipo()
        {
            InitializeComponent();
            MostrarData("protesis");
        }

        private async void MostrarData(string ToShow, string param = "", bool IsSearch = false) {
            pnelContenedor.Controls.Clear();
            pnelContenedor.Controls.Add(lblStatus);
            pnelContenedor.Controls.Add(Status);
            pnelContenedor.Refresh();
            lblStatus.Location = new Point(360, 292);
            lblStatus.Text = "Cargando...";
            if (ToShow == "protesis")
            {
                TProtesis = await catalogoServicio.ObtenerTiposProtesisAsync(param);
                TOrtesis = new List<tipoOrtesis>();
            }
            else
            {
                TOrtesis = await catalogoServicio.ObtenerTiposOrtesisAsync(param);
                TProtesis = new List<tipoProtesis>();
            }
            if (TProtesis == null || TOrtesis == null)
            {
                Status.Image = Properties.Resources.Error;
                lblStatus.Location = new Point(338, 292);
                lblStatus.Text = "Ha Ocurrido un error";
                btnReload.Visible = true;
                return;
            }
            if ((TProtesis.Count == 0 && TOrtesis.Count == 0) && !IsSearch)
            {
                Status.Image = Properties.Resources.Empty;
                lblStatus.Location = new Point(310, 291);
                lblStatus.Text = "¡Oh No, Aun no hay Tipos!";
                btnReload.Visible = true;
                return;
            }

            if ((TProtesis.Count == 0 && TOrtesis.Count == 0) && IsSearch)
            {
                Status.Image = Properties.Resources.NoResult;
                lblStatus.Location = new Point(307, 292);
                lblStatus.Text = "No hay resultado para " + param;
                return;
            }
            pnelContenedor.Controls.Clear();
            pnelContenedor.Refresh();
            int Y = 25;
            if (ToShow == "protesis")
            {
                foreach (tipoProtesis x in TProtesis)
                {
                    PrintData(x, Y, ToShow);
                    Y += 150;
                }
            }
            else
            {
                foreach (tipoOrtesis x in TOrtesis)
                {
                    PrintData(x, Y, ToShow);
                    Y += 150;
                }
            }
        }

        private void PrintData(object x, int Y, String ToShow) {
            tipoProtesis tp = new tipoProtesis();
            tipoOrtesis to = new tipoOrtesis();

            if (ToShow == "protesis")
            {
                tp = (tipoProtesis)x;
            }
            else
            {
                to = (tipoOrtesis)x;
            }
           
                Panel pnel = new PanelDesign();
                pnel.Size = new Size(757,130);
                pnel.Location = new Point(35, Y);

                /* Nombre */
                PictureBox NombreImg = new PictureBox();
                NombreImg.Image = Properties.Resources.Nombre_Objeto;
                NombreImg.Location = new Point(14, 35);
                NombreImg.Size = new Size(48, 48);
                NombreImg.SizeMode = PictureBoxSizeMode.StretchImage;

                Label lblNombre_Titile = new Label();
                lblNombre_Titile.Location = new Point(68,36);
                lblNombre_Titile.AutoSize = true;
                lblNombre_Titile.Text = "Nombre: ";
                //lblCode_Titile.ForeColor = Color.Gray;14; 35
                lblNombre_Titile.Font = new Font("Times New Roman", 9, FontStyle.Bold);

                MaterialLabel lblNombre = new MaterialLabel();
                lblNombre.Location = new Point(67, 65);
                lblNombre.AutoSize = true;
                lblNombre.Text = ToShow == "protesis" ? tp.nombre : to.nombre;

                PictureBox DescripcionImg = new PictureBox();
                DescripcionImg.Image = Properties.Resources.Descripcion;
                DescripcionImg.Location = new Point(253,35);
                DescripcionImg.Size = new Size(48, 48);
                DescripcionImg.SizeMode = PictureBoxSizeMode.StretchImage;

                Label lblDescripcion_Title = new Label();
                lblDescripcion_Title.Location = new Point(307,36);
                lblDescripcion_Title.AutoSize = true;
                lblDescripcion_Title.Text = "Descripcion: ";
                //lblCode_Titile.ForeColor = Color.Gray;
                lblDescripcion_Title.Font = new Font("Times New Roman", 9, FontStyle.Bold);

                RichTextBox lblDescripcion = new RichTextBox();
                lblDescripcion.Location = new Point(310, 65);
                lblDescripcion.Size = new Size(296,54);
                lblDescripcion.BorderStyle = BorderStyle.None;
                lblDescripcion.Text = ToShow == "protesis" ? tp.descripcion : to.descripcion;
                lblDescripcion.Font = new Font("Times New Roman", 10, FontStyle.Bold);

                
                Button EditBtn = new Button();
                EditBtn.FlatStyle = FlatStyle.Flat;
                EditBtn.FlatAppearance.BorderSize = 0;
                EditBtn.Location = new Point(634,36);
                EditBtn.Size = new Size(48, 48);
                EditBtn.Image = Properties.Resources.Editar;
                EditBtn.Name = ToShow == "protesis" ? tp.id.ToString() : to.id.ToString(); ;
                EditBtn.Click += new System.EventHandler(this.EditarBtn_Click);
                /* Button Eliminar */
                Button EliminarBtn = new Button();
                EliminarBtn.FlatStyle = FlatStyle.Flat;
                EliminarBtn.FlatAppearance.BorderSize = 0;
                EliminarBtn.Location = new Point(688,35);
                EliminarBtn.Size = new Size(48, 48);
                EliminarBtn.Image = Properties.Resources.Eliminar;
                EliminarBtn.Name = ToShow == "protesis" ? tp.id.ToString() : to.id.ToString();
                EliminarBtn.Click += new System.EventHandler(this.EliminarBtn_Click);
               
                pnel.Controls.AddRange(new Control[] { NombreImg, lblNombre_Titile, lblNombre, DescripcionImg, lblDescripcion_Title, lblDescripcion,EditBtn,EliminarBtn });
                pnelContenedor.Controls.Add(pnel);
                
            
        }//Print Data

        private void EditarBtn_Click(object sender, EventArgs e) {
            String IsCheked = RdoProtesis.Checked ? "protesis" : "ortesis";
            int id = int.Parse(((Button)sender).Name);
            EditarTipo editarTipo = new EditarTipo(IsCheked, id);
            editarTipo.Show();
            editarTipo.FormClosed += new FormClosedEventHandler(refresh);
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
                    if (await catalogoServicio.EliminarTipoProtesisAsync(Codigo))
                    {
                        MessageBox.Show("Eliminado Correctamente");
                        this.Enabled = true;
                        MostrarData(Ischecked);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error");
                    }
                }
                else
                {
                    int Codigo = int.Parse(((Button)sender).Name);
                    if (await catalogoServicio.EliminarTipoOrtesisAsync(Codigo))
                    {
                        MessageBox.Show("Eliminado Correctamente");
                        this.Enabled = true;
                        MostrarData(Ischecked);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error");
                    }
                }
            }
            else
            {
                this.Enabled = true; //Si cancelo se habilita el formulario actual
            }
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            string Ischecked = RdoProtesis.Checked ? "protesis" : "ortesis";
            AgregarTipo agregarTipo = new AgregarTipo(Ischecked);
            agregarTipo.Show();
            MostrarData(Ischecked);
            agregarTipo.FormClosed += new FormClosedEventHandler(refresh);
        }
        private void refresh(object sender, EventArgs e)
        {
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
    }
}
