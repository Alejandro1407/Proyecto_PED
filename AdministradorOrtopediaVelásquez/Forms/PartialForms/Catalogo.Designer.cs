namespace AdministradorOrtopediaVelásquez.Forms.PartialForms
{
    partial class Catalogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Catalogo));
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
            this.label5 = new System.Windows.Forms.Label();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ORTDC1 = new MaterialSkin.Controls.MaterialLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.EditTipo = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnel00 = new AdministradorOrtopediaVelásquez.CustomControls.PanelDesign();
            this.pnel01 = new AdministradorOrtopediaVelásquez.CustomControls.PanelDesign();
            this.BarraSuperior.SuspendLayout();
            this.pnelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
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
            this.btnAdd.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Agregar;
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
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // materialLabel6
            // 
            resources.ApplyResources(this.materialLabel6, "materialLabel6");
            this.materialLabel6.Depth = 0;
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // materialLabel1
            // 
            resources.ApplyResources(this.materialLabel1, "materialLabel1");
            this.materialLabel1.Depth = 0;
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            // 
            // materialLabel7
            // 
            resources.ApplyResources(this.materialLabel7, "materialLabel7");
            this.materialLabel7.Depth = 0;
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // materialLabel5
            // 
            resources.ApplyResources(this.materialLabel5, "materialLabel5");
            this.materialLabel5.Depth = 0;
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.richTextBox1, "richTextBox1");
            this.richTextBox1.Name = "richTextBox1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // ORTDC1
            // 
            resources.ApplyResources(this.ORTDC1, "ORTDC1");
            this.ORTDC1.Depth = 0;
            this.ORTDC1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ORTDC1.MouseState = MaterialSkin.MouseState.HOVER;
            this.ORTDC1.Name = "ORTDC1";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // materialLabel3
            // 
            resources.ApplyResources(this.materialLabel3, "materialLabel3");
            this.materialLabel3.Depth = 0;
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // materialLabel2
            // 
            resources.ApplyResources(this.materialLabel2, "materialLabel2");
            this.materialLabel2.Depth = 0;
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Categoria;
            resources.ApplyResources(this.pictureBox6, "pictureBox6");
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Codigo;
            resources.ApplyResources(this.pictureBox7, "pictureBox7");
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Protesis;
            resources.ApplyResources(this.pictureBox8, "pictureBox8");
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Nombre_Objeto;
            resources.ApplyResources(this.pictureBox11, "pictureBox11");
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Descripcion;
            resources.ApplyResources(this.pictureBox9, "pictureBox9");
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.TabStop = false;
            // 
            // EditTipo
            // 
            this.EditTipo.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.EditTipo, "EditTipo");
            this.EditTipo.Name = "EditTipo";
            this.EditTipo.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Codigo;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Protesis;
            resources.ApplyResources(this.pictureBox5, "pictureBox5");
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Descripcion;
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Categoria;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Nombre_Objeto;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pnel00
            // 
            resources.ApplyResources(this.pnel00, "pnel00");
            this.pnel00.Name = "pnel00";
            // 
            // pnel01
            // 
            resources.ApplyResources(this.pnel01, "pnel01");
            this.pnel01.Name = "pnel01";
            // 
            // Catalogo
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.pnelContenedor);
            this.Controls.Add(this.BarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Catalogo";
            this.BarraSuperior.ResumeLayout(false);
            this.BarraSuperior.PerformLayout();
            this.pnelContenedor.ResumeLayout(false);
            this.pnelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private CustomControls.PanelDesign pnel01;
        private CustomControls.PanelDesign pnel00;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel ORTDC1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button EditTipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox11;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnReload;
        private MaterialSkin.Controls.MaterialLabel lblStatus;
        private System.Windows.Forms.PictureBox Status;
    }
}