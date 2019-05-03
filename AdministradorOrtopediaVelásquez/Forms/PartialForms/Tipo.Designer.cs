namespace AdministradorOrtopediaVelásquez.Forms.PartialForms
{
    partial class Tipo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tipo));
            this.RdoProtesis = new MaterialSkin.Controls.MaterialRadioButton();
            this.RdoOrtesis = new MaterialSkin.Controls.MaterialRadioButton();
            this.txtBusqueda = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnelContenedor = new System.Windows.Forms.Panel();
            this.btnReload = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.PictureBox();
            this.lblStatus = new MaterialSkin.Controls.MaterialLabel();
            this.panelDesign3 = new AdministradorOrtopediaVelásquez.CustomControls.PanelDesign();
            this.txtNombre = new System.Windows.Forms.RichTextBox();
            this.imagen = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDescrip = new System.Windows.Forms.RichTextBox();
            this.txttiledes = new System.Windows.Forms.Label();
            this.txttitlename = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.BarraSuperior.SuspendLayout();
            this.pnelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Status)).BeginInit();
            this.panelDesign3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // RdoProtesis
            // 
            resources.ApplyResources(this.RdoProtesis, "RdoProtesis");
            this.RdoProtesis.Checked = true;
            this.RdoProtesis.Depth = 0;
            this.RdoProtesis.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RdoProtesis.MouseState = MaterialSkin.MouseState.HOVER;
            this.RdoProtesis.Name = "RdoProtesis";
            this.RdoProtesis.Ripple = true;
            this.RdoProtesis.TabStop = true;
            this.RdoProtesis.UseVisualStyleBackColor = true;
            this.RdoProtesis.Click += new System.EventHandler(this.RdoProtesis_Click);
            // 
            // RdoOrtesis
            // 
            resources.ApplyResources(this.RdoOrtesis, "RdoOrtesis");
            this.RdoOrtesis.Depth = 0;
            this.RdoOrtesis.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RdoOrtesis.MouseState = MaterialSkin.MouseState.HOVER;
            this.RdoOrtesis.Name = "RdoOrtesis";
            this.RdoOrtesis.Ripple = true;
            this.RdoOrtesis.UseVisualStyleBackColor = true;
            this.RdoOrtesis.Click += new System.EventHandler(this.RdoOrtesis_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Depth = 0;
            this.txtBusqueda.Hint = "Busqueda (Nombre)";
            resources.ApplyResources(this.txtBusqueda, "txtBusqueda");
            this.txtBusqueda.MaxLength = 32767;
            this.txtBusqueda.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.PasswordChar = '\0';
            this.txtBusqueda.SelectedText = "";
            this.txtBusqueda.SelectionLength = 0;
            this.txtBusqueda.SelectionStart = 0;
            this.txtBusqueda.TabStop = false;
            this.txtBusqueda.UseSystemPasswordChar = false;
            // 
            // BarraSuperior
            // 
            this.BarraSuperior.Controls.Add(this.btnAdd);
            this.BarraSuperior.Controls.Add(this.RdoProtesis);
            this.BarraSuperior.Controls.Add(this.txtBusqueda);
            this.BarraSuperior.Controls.Add(this.btnSearch);
            this.BarraSuperior.Controls.Add(this.RdoOrtesis);
            resources.ApplyResources(this.BarraSuperior, "BarraSuperior");
            this.BarraSuperior.Name = "BarraSuperior";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.AñadirTipo;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::AdministradorOrtopediaVelásquez.Properties.Resources.Search;
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // pnelContenedor
            // 
            resources.ApplyResources(this.pnelContenedor, "pnelContenedor");
            this.pnelContenedor.Controls.Add(this.btnReload);
            this.pnelContenedor.Controls.Add(this.Status);
            this.pnelContenedor.Controls.Add(this.lblStatus);
            this.pnelContenedor.Controls.Add(this.panelDesign3);
            this.pnelContenedor.Name = "pnelContenedor";
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.White;
            this.btnReload.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnReload, "btnReload");
            this.btnReload.ForeColor = System.Drawing.Color.Gray;
            this.btnReload.Name = "btnReload";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // Status
            // 
            this.Status.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Loading;
            resources.ApplyResources(this.Status, "Status");
            this.Status.Name = "Status";
            this.Status.TabStop = false;
            // 
            // lblStatus
            // 
            resources.ApplyResources(this.lblStatus, "lblStatus");
            this.lblStatus.Depth = 0;
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblStatus.Name = "lblStatus";
            // 
            // panelDesign3
            // 
            this.panelDesign3.Controls.Add(this.txtNombre);
            this.panelDesign3.Controls.Add(this.imagen);
            this.panelDesign3.Controls.Add(this.button2);
            this.panelDesign3.Controls.Add(this.button1);
            this.panelDesign3.Controls.Add(this.txtDescrip);
            this.panelDesign3.Controls.Add(this.txttiledes);
            this.panelDesign3.Controls.Add(this.txttitlename);
            this.panelDesign3.Controls.Add(this.pictureBox5);
            this.panelDesign3.Controls.Add(this.pictureBox6);
            resources.ApplyResources(this.panelDesign3, "panelDesign3");
            this.panelDesign3.Name = "panelDesign3";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtNombre, "txtNombre");
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            // 
            // imagen
            // 
            resources.ApplyResources(this.imagen, "imagen");
            this.imagen.Name = "imagen";
            this.imagen.TabStop = false;
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtDescrip
            // 
            this.txtDescrip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtDescrip, "txtDescrip");
            this.txtDescrip.Name = "txtDescrip";
            // 
            // txttiledes
            // 
            resources.ApplyResources(this.txttiledes, "txttiledes");
            this.txttiledes.Name = "txttiledes";
            // 
            // txttitlename
            // 
            resources.ApplyResources(this.txttitlename, "txttitlename");
            this.txttitlename.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txttitlename.Name = "txttitlename";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Descripcion;
            resources.ApplyResources(this.pictureBox5, "pictureBox5");
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Nombre_Objeto;
            resources.ApplyResources(this.pictureBox6, "pictureBox6");
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.TabStop = false;
            // 
            // Tipo
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.pnelContenedor);
            this.Controls.Add(this.BarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tipo";
            this.BarraSuperior.ResumeLayout(false);
            this.BarraSuperior.PerformLayout();
            this.pnelContenedor.ResumeLayout(false);
            this.pnelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Status)).EndInit();
            this.panelDesign3.ResumeLayout(false);
            this.panelDesign3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRadioButton RdoProtesis;
        private MaterialSkin.Controls.MaterialRadioButton RdoOrtesis;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBusqueda;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel BarraSuperior;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnelContenedor;
        private MaterialSkin.Controls.MaterialLabel lblStatus;
        private System.Windows.Forms.PictureBox Status;
        private CustomControls.PanelDesign panelDesign3;
        private System.Windows.Forms.RichTextBox txtDescrip;
        private System.Windows.Forms.Label txttiledes;
        private System.Windows.Forms.Label txttitlename;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.PictureBox imagen;
        private System.Windows.Forms.RichTextBox txtNombre;
    }
}