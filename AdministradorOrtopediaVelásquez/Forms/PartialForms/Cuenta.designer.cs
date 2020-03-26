namespace AdministradorOrtopediaVelásquez.Forms.PartialForms
{
    partial class Cuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cuenta));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.lblStatus = new MaterialSkin.Controls.MaterialLabel();
            this.status = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDesign1 = new AdministradorOrtopediaVelásquez.CustomControls.PanelDesign();
            this.txtEmail = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.txtPass = new MaterialSkin.Controls.MaterialLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtGenero = new MaterialSkin.Controls.MaterialLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApe = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBirthDay = new MaterialSkin.Controls.MaterialLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNames = new System.Windows.Forms.RichTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.status)).BeginInit();
            this.panelDesign1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLogOut);
            this.panel2.Controls.Add(this.btnReload);
            this.panel2.Controls.Add(this.lblStatus);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panelDesign1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(824, 551);
            this.panel2.TabIndex = 42;
            // 
            // btnLogOut
            // 
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.CerrarSesion;
            this.btnLogOut.Location = new System.Drawing.Point(718, 12);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(63, 54);
            this.btnLogOut.TabIndex = 54;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
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
            this.btnReload.Location = new System.Drawing.Point(327, 322);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(150, 53);
            this.btnReload.TabIndex = 53;
            this.btnReload.Text = "Reintentar";
            this.btnReload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Depth = 0;
            this.lblStatus.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStatus.Location = new System.Drawing.Point(344, 300);
            this.lblStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(84, 19);
            this.lblStatus.TabIndex = 52;
            this.lblStatus.Text = "Cargando...";
            // 
            // status
            // 
            this.status.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Loading;
            this.status.Location = new System.Drawing.Point(298, 107);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(114, 111);
            this.status.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.status.TabIndex = 45;
            this.status.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Datos del Usuario";
            // 
            // panelDesign1
            // 
            this.panelDesign1.Controls.Add(this.status);
            this.panelDesign1.Controls.Add(this.txtEmail);
            this.panelDesign1.Controls.Add(this.label7);
            this.panelDesign1.Controls.Add(this.pictureBox4);
            this.panelDesign1.Controls.Add(this.btnChangePass);
            this.panelDesign1.Controls.Add(this.txtPass);
            this.panelDesign1.Controls.Add(this.label6);
            this.panelDesign1.Controls.Add(this.pictureBox3);
            this.panelDesign1.Controls.Add(this.txtGenero);
            this.panelDesign1.Controls.Add(this.label4);
            this.panelDesign1.Controls.Add(this.txtApe);
            this.panelDesign1.Controls.Add(this.label3);
            this.panelDesign1.Controls.Add(this.txtBirthDay);
            this.panelDesign1.Controls.Add(this.label5);
            this.panelDesign1.Controls.Add(this.label2);
            this.panelDesign1.Controls.Add(this.txtNames);
            this.panelDesign1.Controls.Add(this.pictureBox2);
            this.panelDesign1.Controls.Add(this.pictureBox6);
            this.panelDesign1.Controls.Add(this.pictureBox1);
            this.panelDesign1.Controls.Add(this.pictureBox5);
            this.panelDesign1.Location = new System.Drawing.Point(29, 81);
            this.panelDesign1.Name = "panelDesign1";
            this.panelDesign1.Size = new System.Drawing.Size(752, 188);
            this.panelDesign1.TabIndex = 51;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(546, 57);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(138, 42);
            this.txtEmail.TabIndex = 64;
            this.txtEmail.Text = "alejandroalejo714@gmail.com";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(544, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 18);
            this.label7.TabIndex = 63;
            this.label7.Text = "Email:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.email;
            this.pictureBox4.Location = new System.Drawing.Point(493, 26);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 48);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 62;
            this.pictureBox4.TabStop = false;
            // 
            // btnChangePass
            // 
            this.btnChangePass.FlatAppearance.BorderSize = 0;
            this.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePass.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.ChangePass;
            this.btnChangePass.Location = new System.Drawing.Point(625, 105);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(21, 24);
            this.btnChangePass.TabIndex = 61;
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // txtPass
            // 
            this.txtPass.AutoSize = true;
            this.txtPass.Depth = 0;
            this.txtPass.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtPass.Location = new System.Drawing.Point(543, 137);
            this.txtPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(56, 19);
            this.txtPass.TabIndex = 60;
            this.txtPass.Text = "********";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(544, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 18);
            this.label6.TabIndex = 59;
            this.label6.Text = "Contraseña:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Contraseña;
            this.pictureBox3.Location = new System.Drawing.Point(493, 108);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 58;
            this.pictureBox3.TabStop = false;
            // 
            // txtGenero
            // 
            this.txtGenero.AutoSize = true;
            this.txtGenero.Depth = 0;
            this.txtGenero.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtGenero.Location = new System.Drawing.Point(337, 137);
            this.txtGenero.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(78, 19);
            this.txtGenero.TabIndex = 57;
            this.txtGenero.Text = "Masculino";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(337, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 56;
            this.label4.Text = "Sexo:";
            // 
            // txtApe
            // 
            this.txtApe.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtApe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApe.Location = new System.Drawing.Point(340, 56);
            this.txtApe.Name = "txtApe";
            this.txtApe.ReadOnly = true;
            this.txtApe.Size = new System.Drawing.Size(122, 33);
            this.txtApe.TabIndex = 55;
            this.txtApe.Text = "Alejo Gálvez";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(337, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 54;
            this.label3.Text = "Apellidos:";
            // 
            // txtBirthDay
            // 
            this.txtBirthDay.AutoSize = true;
            this.txtBirthDay.Depth = 0;
            this.txtBirthDay.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtBirthDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBirthDay.Location = new System.Drawing.Point(106, 136);
            this.txtBirthDay.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBirthDay.Name = "txtBirthDay";
            this.txtBirthDay.Size = new System.Drawing.Size(80, 19);
            this.txtBirthDay.TabIndex = 53;
            this.txtBirthDay.Text = "2000-07-14";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(103, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 18);
            this.label5.TabIndex = 52;
            this.label5.Text = "Fecha de Nacimiento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 51;
            this.label2.Text = "Nombre:";
            // 
            // txtNames
            // 
            this.txtNames.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNames.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNames.Location = new System.Drawing.Point(106, 56);
            this.txtNames.Name = "txtNames";
            this.txtNames.ReadOnly = true;
            this.txtNames.Size = new System.Drawing.Size(126, 33);
            this.txtNames.TabIndex = 50;
            this.txtNames.Text = "Victor Alejandro";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Nombre;
            this.pictureBox2.Location = new System.Drawing.Point(52, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Apellidos;
            this.pictureBox6.Location = new System.Drawing.Point(286, 26);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(48, 48);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 33;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.cumpleanios;
            this.pictureBox1.Location = new System.Drawing.Point(52, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Genero;
            this.pictureBox5.Location = new System.Drawing.Point(286, 107);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(48, 48);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 41;
            this.pictureBox5.TabStop = false;
            // 
            // Cuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(824, 551);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cuenta";
            this.Text = "CuentaForm";
            this.Load += new System.EventHandler(this.CuentaForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.status)).EndInit();
            this.panelDesign1.ResumeLayout(false);
            this.panelDesign1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox status;
        private CustomControls.PanelDesign panelDesign1;
        private System.Windows.Forms.RichTextBox txtNames;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialLabel txtBirthDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtApe;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialLabel txtGenero;
        private MaterialSkin.Controls.MaterialLabel txtPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.RichTextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox4;
        private MaterialSkin.Controls.MaterialLabel lblStatus;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnLogOut;
    }
}