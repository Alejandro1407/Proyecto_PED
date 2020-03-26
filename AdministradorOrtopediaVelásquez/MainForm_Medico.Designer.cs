namespace AdministradorOrtopediaVelásquez
{
    partial class MainForm_Medico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm_Medico));
            this.pnelContenedor = new AdministradorOrtopediaVelásquez.CustomControls.PanelDesign();
            this.BarraSuperior = new AdministradorOrtopediaVelásquez.CustomControls.PanelDesign();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btnOpciones = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.panelDesign1 = new AdministradorOrtopediaVelásquez.CustomControls.PanelDesign();
            this.btnHorarios = new System.Windows.Forms.Button();
            this.btnCuenta = new System.Windows.Forms.Button();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.BarraSuperior.SuspendLayout();
            this.panelDesign1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnelContenedor
            // 
            this.pnelContenedor.Location = new System.Drawing.Point(200, 49);
            this.pnelContenedor.Name = "pnelContenedor";
            this.pnelContenedor.Size = new System.Drawing.Size(824, 589);
            this.pnelContenedor.TabIndex = 4;
            // 
            // BarraSuperior
            // 
            this.BarraSuperior.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BarraSuperior.Controls.Add(this.materialLabel2);
            this.BarraSuperior.Controls.Add(this.btnOpciones);
            this.BarraSuperior.Controls.Add(this.btnMax);
            this.BarraSuperior.Controls.Add(this.btnCerrar);
            this.BarraSuperior.Controls.Add(this.btnMin);
            this.BarraSuperior.Location = new System.Drawing.Point(199, 0);
            this.BarraSuperior.Name = "BarraSuperior";
            this.BarraSuperior.Size = new System.Drawing.Size(824, 49);
            this.BarraSuperior.TabIndex = 2;
            this.BarraSuperior.Paint += new System.Windows.Forms.PaintEventHandler(this.BarraSuperior_Paint);
            this.BarraSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraSuperior_MouseDown);
            this.BarraSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraSuperior_MouseMove);
            this.BarraSuperior.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BarraSuperior_MouseUp);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(3, 21);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(190, 19);
            this.materialLabel2.TabIndex = 7;
            this.materialLabel2.Text = "Sistema de Administración";
            // 
            // btnOpciones
            // 
            this.btnOpciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOpciones.FlatAppearance.BorderSize = 0;
            this.btnOpciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpciones.Image = ((System.Drawing.Image)(resources.GetObject("btnOpciones.Image")));
            this.btnOpciones.Location = new System.Drawing.Point(680, 10);
            this.btnOpciones.Name = "btnOpciones";
            this.btnOpciones.Size = new System.Drawing.Size(30, 30);
            this.btnOpciones.TabIndex = 3;
            this.btnOpciones.UseVisualStyleBackColor = true;
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Image = ((System.Drawing.Image)(resources.GetObject("btnMax.Image")));
            this.btnMax.Location = new System.Drawing.Point(748, 10);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(30, 30);
            this.btnMax.TabIndex = 4;
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(782, 10);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(30, 30);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Minimizar;
            this.btnMin.Location = new System.Drawing.Point(714, 10);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(30, 30);
            this.btnMin.TabIndex = 6;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // panelDesign1
            // 
            this.panelDesign1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelDesign1.Controls.Add(this.btnHorarios);
            this.panelDesign1.Controls.Add(this.btnCuenta);
            this.panelDesign1.Controls.Add(this.materialLabel1);
            this.panelDesign1.Controls.Add(this.pctLogo);
            this.panelDesign1.Location = new System.Drawing.Point(0, 0);
            this.panelDesign1.Name = "panelDesign1";
            this.panelDesign1.Size = new System.Drawing.Size(200, 639);
            this.panelDesign1.TabIndex = 3;
            // 
            // btnHorarios
            // 
            this.btnHorarios.BackColor = System.Drawing.Color.White;
            this.btnHorarios.FlatAppearance.BorderSize = 0;
            this.btnHorarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHorarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHorarios.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHorarios.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Horarios;
            this.btnHorarios.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHorarios.Location = new System.Drawing.Point(5, 174);
            this.btnHorarios.Name = "btnHorarios";
            this.btnHorarios.Size = new System.Drawing.Size(190, 50);
            this.btnHorarios.TabIndex = 7;
            this.btnHorarios.Text = "Citas";
            this.btnHorarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHorarios.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnHorarios.UseVisualStyleBackColor = false;
            this.btnHorarios.Click += new System.EventHandler(this.btnHorarios_Click);
            // 
            // btnCuenta
            // 
            this.btnCuenta.FlatAppearance.BorderSize = 0;
            this.btnCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuenta.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Ajustes;
            this.btnCuenta.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnCuenta.Location = new System.Drawing.Point(5, 230);
            this.btnCuenta.Name = "btnCuenta";
            this.btnCuenta.Size = new System.Drawing.Size(190, 60);
            this.btnCuenta.TabIndex = 6;
            this.btnCuenta.Text = "Cuenta";
            this.btnCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCuenta.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCuenta.UseVisualStyleBackColor = true;
            this.btnCuenta.Click += new System.EventHandler(this.btnCuenta_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(24, 152);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(148, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Ortopedia Velásquez";
            // 
            // pctLogo
            // 
            this.pctLogo.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.LogoOrtopedia;
            this.pctLogo.Location = new System.Drawing.Point(12, 30);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(176, 104);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 0;
            this.pctLogo.TabStop = false;
            // 
            // MainForm_Medico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1024, 640);
            this.Controls.Add(this.pnelContenedor);
            this.Controls.Add(this.BarraSuperior);
            this.Controls.Add(this.panelDesign1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm_Medico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.BarraSuperior.ResumeLayout(false);
            this.BarraSuperior.PerformLayout();
            this.panelDesign1.ResumeLayout(false);
            this.panelDesign1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.PanelDesign panelDesign1;
        private CustomControls.PanelDesign pnelContenedor;
        private CustomControls.PanelDesign BarraSuperior;
        private System.Windows.Forms.Button btnOpciones;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMin;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Button btnCuenta;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Button btnHorarios;
    }
}