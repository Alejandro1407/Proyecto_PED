namespace AdministradorOrtopediaVelásquez.Forms.Modals
{
    partial class EditarProducto
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
            this.Subir = new System.Windows.Forms.OpenFileDialog();
            this.panelDesign1 = new System.Windows.Forms.Panel();
            this.lblStatus = new MaterialSkin.Controls.MaterialLabel();
            this.Status = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.lblImagen = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.txtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new MaterialSkin.Controls.MaterialLabel();
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.NumericUpDown();
            this.panelDesign1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.BarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // Subir
            // 
            this.Subir.Title = "Subir Imagen";
            // 
            // panelDesign1
            // 
            this.panelDesign1.Controls.Add(this.lblStatus);
            this.panelDesign1.Controls.Add(this.Status);
            this.panelDesign1.Controls.Add(this.pictureBox6);
            this.panelDesign1.Controls.Add(this.btnUpload);
            this.panelDesign1.Controls.Add(this.lblImagen);
            this.panelDesign1.Controls.Add(this.pictureBox5);
            this.panelDesign1.Controls.Add(this.btnAceptar);
            this.panelDesign1.Controls.Add(this.cmbTipo);
            this.panelDesign1.Controls.Add(this.pictureBox4);
            this.panelDesign1.Controls.Add(this.pictureBox3);
            this.panelDesign1.Controls.Add(this.txtDescripcion);
            this.panelDesign1.Controls.Add(this.txtNombre);
            this.panelDesign1.Controls.Add(this.pictureBox2);
            this.panelDesign1.Controls.Add(this.lblTitle);
            this.panelDesign1.Controls.Add(this.BarraSuperior);
            this.panelDesign1.Controls.Add(this.txtPrecio);
            this.panelDesign1.Location = new System.Drawing.Point(0, 0);
            this.panelDesign1.Name = "panelDesign1";
            this.panelDesign1.Size = new System.Drawing.Size(324, 503);
            this.panelDesign1.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Depth = 0;
            this.lblStatus.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStatus.Location = new System.Drawing.Point(119, 283);
            this.lblStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(85, 18);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Cargando...";
            // 
            // Status
            // 
            this.Status.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Loading;
            this.Status.Location = new System.Drawing.Point(121, 199);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(83, 78);
            this.Status.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Status.TabIndex = 12;
            this.Status.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.precio;
            this.pictureBox6.Location = new System.Drawing.Point(46, 270);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(48, 48);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 17;
            this.pictureBox6.TabStop = false;
            // 
            // btnUpload
            // 
            this.btnUpload.FlatAppearance.BorderSize = 0;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Upload;
            this.btnUpload.Location = new System.Drawing.Point(212, 210);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(58, 48);
            this.btnUpload.TabIndex = 16;
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Depth = 0;
            this.lblImagen.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblImagen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblImagen.Location = new System.Drawing.Point(96, 224);
            this.lblImagen.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(64, 18);
            this.lblImagen.TabIndex = 15;
            this.lblImagen.Text = "Ninguna";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.imagen;
            this.pictureBox5.Location = new System.Drawing.Point(46, 210);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(48, 48);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAceptar.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Aceptar;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(101, 435);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(103, 46);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "-Eliga un Tipo"});
            this.cmbTipo.Location = new System.Drawing.Point(100, 163);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(170, 21);
            this.cmbTipo.TabIndex = 10;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Categoria;
            this.pictureBox4.Location = new System.Drawing.Point(46, 150);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 48);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Descripcion;
            this.pictureBox3.Location = new System.Drawing.Point(46, 330);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(100, 335);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(170, 70);
            this.txtDescripcion.TabIndex = 7;
            this.txtDescripcion.Text = "Descripcion";
            this.txtDescripcion.Click += new System.EventHandler(this.txtDescripcion_Click);
            this.txtDescripcion.Leave += new System.EventHandler(this.txtDescripcion_Leave);
            // 
            // txtNombre
            // 
            this.txtNombre.Depth = 0;
            this.txtNombre.Hint = "Nombre";
            this.txtNombre.Location = new System.Drawing.Point(100, 115);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.Size = new System.Drawing.Size(170, 23);
            this.txtNombre.TabIndex = 6;
            this.txtNombre.TabStop = false;
            this.txtNombre.UseSystemPasswordChar = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Nombre_Objeto;
            this.pictureBox2.Location = new System.Drawing.Point(46, 90);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Depth = 0;
            this.lblTitle.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(101, 53);
            this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(113, 19);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Editar Producto";
            // 
            // BarraSuperior
            // 
            this.BarraSuperior.Controls.Add(this.materialLabel1);
            this.BarraSuperior.Controls.Add(this.btnCerrar);
            this.BarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.BarraSuperior.Name = "BarraSuperior";
            this.BarraSuperior.Size = new System.Drawing.Size(324, 40);
            this.BarraSuperior.TabIndex = 1;
            this.BarraSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraSuperior_MouseDown);
            this.BarraSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraSuperior_MouseMove);
            this.BarraSuperior.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BarraSuperior_MouseUp);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(3, 12);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(113, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Editar Producto";
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(285, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(35, 35);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecio.DecimalPlaces = 2;
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.txtPrecio.Location = new System.Drawing.Point(100, 283);
            this.txtPrecio.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(120, 22);
            this.txtPrecio.TabIndex = 18;
            // 
            // EditarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(325, 503);
            this.Controls.Add(this.panelDesign1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarProducto";
            this.panelDesign1.ResumeLayout(false);
            this.panelDesign1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.BarraSuperior.ResumeLayout(false);
            this.BarraSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesign1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel BarraSuperior;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombre;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Button btnAceptar;
        private MaterialSkin.Controls.MaterialLabel lblStatus;
        private System.Windows.Forms.PictureBox Status;
        private MaterialSkin.Controls.MaterialLabel lblImagen;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.OpenFileDialog Subir;
        private System.Windows.Forms.NumericUpDown txtPrecio;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}