namespace AdministradorOrtopediaVelásquez.Forms.PartialForms
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            this.lblStatus = new MaterialSkin.Controls.MaterialLabel();
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBusqueda = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnelContenedor = new System.Windows.Forms.Panel();
            this.Status = new System.Windows.Forms.PictureBox();
            this.panelDesign1 = new AdministradorOrtopediaVelásquez.CustomControls.PanelDesign();
            this.txtEmail = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPass = new MaterialSkin.Controls.MaterialLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.BarraSuperior.SuspendLayout();
            this.pnelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Status)).BeginInit();
            this.panelDesign1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Depth = 0;
            this.lblStatus.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStatus.Location = new System.Drawing.Point(349, 288);
            this.lblStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(85, 19);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Cargando...";
            // 
            // BarraSuperior
            // 
            this.BarraSuperior.Controls.Add(this.btnAdd);
            this.BarraSuperior.Controls.Add(this.txtBusqueda);
            this.BarraSuperior.Controls.Add(this.btnSearch);
            this.BarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.BarraSuperior.Name = "BarraSuperior";
            this.BarraSuperior.Size = new System.Drawing.Size(824, 49);
            this.BarraSuperior.TabIndex = 22;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Agregar;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAdd.Location = new System.Drawing.Point(506, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 40);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Depth = 0;
            this.txtBusqueda.Hint = "Busqueda (Nombre)";
            this.txtBusqueda.Location = new System.Drawing.Point(610, 16);
            this.txtBusqueda.MaxLength = 32767;
            this.txtBusqueda.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.PasswordChar = '\0';
            this.txtBusqueda.SelectedText = "";
            this.txtBusqueda.SelectionLength = 0;
            this.txtBusqueda.SelectionStart = 0;
            this.txtBusqueda.Size = new System.Drawing.Size(137, 23);
            this.txtBusqueda.TabIndex = 2;
            this.txtBusqueda.TabStop = false;
            this.txtBusqueda.UseSystemPasswordChar = false;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::AdministradorOrtopediaVelásquez.Properties.Resources.Search;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearch.Location = new System.Drawing.Point(753, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(39, 38);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // pnelContenedor
            // 
            this.pnelContenedor.AutoScroll = true;
            this.pnelContenedor.Controls.Add(this.Status);
            this.pnelContenedor.Controls.Add(this.panelDesign1);
            this.pnelContenedor.Controls.Add(this.btnReload);
            this.pnelContenedor.Controls.Add(this.lblStatus);
            this.pnelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnelContenedor.Location = new System.Drawing.Point(0, 49);
            this.pnelContenedor.Name = "pnelContenedor";
            this.pnelContenedor.Size = new System.Drawing.Size(824, 502);
            this.pnelContenedor.TabIndex = 23;
            // 
            // Status
            // 
            this.Status.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Loading;
            this.Status.Location = new System.Drawing.Point(331, 162);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(114, 111);
            this.Status.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Status.TabIndex = 2;
            this.Status.TabStop = false;
            // 
            // panelDesign1
            // 
            this.panelDesign1.Controls.Add(this.txtEmail);
            this.panelDesign1.Controls.Add(this.label7);
            this.panelDesign1.Controls.Add(this.pictureBox1);
            this.panelDesign1.Controls.Add(this.txtPass);
            this.panelDesign1.Controls.Add(this.label6);
            this.panelDesign1.Controls.Add(this.pictureBox6);
            this.panelDesign1.Controls.Add(this.button1);
            this.panelDesign1.Controls.Add(this.richTextBox2);
            this.panelDesign1.Controls.Add(this.richTextBox1);
            this.panelDesign1.Controls.Add(this.materialLabel5);
            this.panelDesign1.Controls.Add(this.label5);
            this.panelDesign1.Controls.Add(this.pictureBox5);
            this.panelDesign1.Controls.Add(this.materialLabel4);
            this.panelDesign1.Controls.Add(this.label4);
            this.panelDesign1.Controls.Add(this.pictureBox4);
            this.panelDesign1.Controls.Add(this.label3);
            this.panelDesign1.Controls.Add(this.pictureBox3);
            this.panelDesign1.Controls.Add(this.label2);
            this.panelDesign1.Controls.Add(this.pictureBox2);
            this.panelDesign1.Location = new System.Drawing.Point(39, 24);
            this.panelDesign1.Name = "panelDesign1";
            this.panelDesign1.Size = new System.Drawing.Size(744, 181);
            this.panelDesign1.TabIndex = 22;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(473, 55);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(138, 42);
            this.txtEmail.TabIndex = 71;
            this.txtEmail.Text = "alejandroalejo714@gmail.com";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(473, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 18);
            this.label7.TabIndex = 70;
            this.label7.Text = "Email:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.email;
            this.pictureBox1.Location = new System.Drawing.Point(419, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // txtPass
            // 
            this.txtPass.AutoSize = true;
            this.txtPass.Depth = 0;
            this.txtPass.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtPass.Location = new System.Drawing.Point(473, 138);
            this.txtPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(57, 19);
            this.txtPass.TabIndex = 67;
            this.txtPass.Text = "********";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(473, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 18);
            this.label6.TabIndex = 66;
            this.label6.Text = "Contraseña:";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Contraseña;
            this.pictureBox6.Location = new System.Drawing.Point(419, 108);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(48, 48);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 65;
            this.pictureBox6.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Eliminar;
            this.button1.Location = new System.Drawing.Point(649, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 61);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(280, 55);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(126, 33);
            this.richTextBox2.TabIndex = 16;
            this.richTextBox2.Text = "Alejo Gálvez";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(84, 56);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(126, 33);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "Victor Alejandro";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(81, 135);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(81, 19);
            this.materialLabel5.TabIndex = 14;
            this.materialLabel5.Text = "2000-07-14";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(81, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Cumpleaños:";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.cumpleanios;
            this.pictureBox5.Location = new System.Drawing.Point(27, 108);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(48, 48);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(276, 137);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(79, 19);
            this.materialLabel4.TabIndex = 11;
            this.materialLabel4.Text = "Masculino";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(277, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sexo:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Genero;
            this.pictureBox4.Location = new System.Drawing.Point(222, 109);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 48);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(276, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apellidos:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Apellidos;
            this.pictureBox3.Location = new System.Drawing.Point(222, 28);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Nombres;
            this.pictureBox2.Location = new System.Drawing.Point(27, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.White;
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnReload.ForeColor = System.Drawing.Color.Gray;
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReload.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnReload.Location = new System.Drawing.Point(316, 318);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(150, 53);
            this.btnReload.TabIndex = 20;
            this.btnReload.Text = "Reintentar";
            this.btnReload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Visible = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(824, 551);
            this.Controls.Add(this.pnelContenedor);
            this.Controls.Add(this.BarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Usuarios";
            this.Text = "Administradores";
            this.BarraSuperior.ResumeLayout(false);
            this.pnelContenedor.ResumeLayout(false);
            this.pnelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Status)).EndInit();
            this.panelDesign1.ResumeLayout(false);
            this.panelDesign1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblStatus;
        private System.Windows.Forms.PictureBox Status;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Panel BarraSuperior;
        private System.Windows.Forms.Button btnAdd;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBusqueda;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnelContenedor;
        private CustomControls.PanelDesign panelDesign1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RichTextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel txtPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}