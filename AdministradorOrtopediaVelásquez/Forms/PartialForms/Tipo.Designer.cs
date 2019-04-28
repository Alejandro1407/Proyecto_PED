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
            this.panelDesign3 = new AdministradorOrtopediaVelásquez.CustomControls.PanelDesign();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panelDesign2 = new AdministradorOrtopediaVelásquez.CustomControls.PanelDesign();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.Status = new System.Windows.Forms.PictureBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.lblStatus = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.BarraSuperior.SuspendLayout();
            this.pnelContenedor.SuspendLayout();
            this.panelDesign3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panelDesign2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            this.txtBusqueda.Hint = "Busqueda";
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
            this.pnelContenedor.Controls.Add(this.panelDesign2);
            this.pnelContenedor.Name = "pnelContenedor";
            // 
            // btnReload
            // 
            this.btnReload.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnReload, "btnReload");
            this.btnReload.Name = "btnReload";
            this.btnReload.UseVisualStyleBackColor = true;
            // 
            // panelDesign3
            // 
            this.panelDesign3.Controls.Add(this.button2);
            this.panelDesign3.Controls.Add(this.button1);
            this.panelDesign3.Controls.Add(this.materialLabel3);
            this.panelDesign3.Controls.Add(this.richTextBox3);
            this.panelDesign3.Controls.Add(this.label5);
            this.panelDesign3.Controls.Add(this.label6);
            this.panelDesign3.Controls.Add(this.pictureBox5);
            this.panelDesign3.Controls.Add(this.pictureBox6);
            resources.ApplyResources(this.panelDesign3, "panelDesign3");
            this.panelDesign3.Name = "panelDesign3";
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
            // materialLabel3
            // 
            resources.ApplyResources(this.materialLabel3, "materialLabel3");
            this.materialLabel3.Depth = 0;
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            // 
            // richTextBox3
            // 
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.richTextBox3, "richTextBox3");
            this.richTextBox3.Name = "richTextBox3";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
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
            // panelDesign2
            // 
            this.panelDesign2.Controls.Add(this.materialLabel2);
            this.panelDesign2.Controls.Add(this.richTextBox2);
            this.panelDesign2.Controls.Add(this.label1);
            this.panelDesign2.Controls.Add(this.label3);
            this.panelDesign2.Controls.Add(this.pictureBox2);
            this.panelDesign2.Controls.Add(this.pictureBox3);
            resources.ApplyResources(this.panelDesign2, "panelDesign2");
            this.panelDesign2.Name = "panelDesign2";
            // 
            // materialLabel2
            // 
            resources.ApplyResources(this.materialLabel2, "materialLabel2");
            this.materialLabel2.Depth = 0;
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            // 
            // Status
            // 
            this.Status.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Loading;
            resources.ApplyResources(this.Status, "Status");
            this.Status.Name = "Status";
            this.Status.TabStop = false;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.richTextBox2, "richTextBox2");
            this.richTextBox2.Name = "richTextBox2";
            // 
            // lblStatus
            // 
            resources.ApplyResources(this.lblStatus, "lblStatus");
            this.lblStatus.Depth = 0;
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblStatus.Name = "lblStatus";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Descripcion;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Nombre_Objeto;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
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
            this.panelDesign3.ResumeLayout(false);
            this.panelDesign3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panelDesign2.ResumeLayout(false);
            this.panelDesign2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private CustomControls.PanelDesign panelDesign2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}