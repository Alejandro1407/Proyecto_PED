namespace AdministradorOrtopediaVelásquez.Forms
{
    partial class ShowDialog
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
            this.Contenedor = new System.Windows.Forms.Panel();
            this.InfoImg = new System.Windows.Forms.PictureBox();
            this.panelDesign1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblTitle = new MaterialSkin.Controls.MaterialLabel();
            this.lblMensaje = new System.Windows.Forms.RichTextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.Contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoImg)).BeginInit();
            this.panelDesign1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Contenedor
            // 
            this.Contenedor.Controls.Add(this.InfoImg);
            this.Contenedor.Controls.Add(this.panelDesign1);
            this.Contenedor.Controls.Add(this.lblMensaje);
            this.Contenedor.Controls.Add(this.btnAceptar);
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.Location = new System.Drawing.Point(0, 0);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(302, 263);
            this.Contenedor.TabIndex = 8;
            // 
            // InfoImg
            // 
            this.InfoImg.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Warning;
            this.InfoImg.Location = new System.Drawing.Point(104, 43);
            this.InfoImg.Name = "InfoImg";
            this.InfoImg.Size = new System.Drawing.Size(92, 92);
            this.InfoImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.InfoImg.TabIndex = 15;
            this.InfoImg.TabStop = false;
            // 
            // panelDesign1
            // 
            this.panelDesign1.Controls.Add(this.btnCerrar);
            this.panelDesign1.Controls.Add(this.lblTitle);
            this.panelDesign1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDesign1.Location = new System.Drawing.Point(0, 0);
            this.panelDesign1.Name = "panelDesign1";
            this.panelDesign1.Size = new System.Drawing.Size(302, 35);
            this.panelDesign1.TabIndex = 14;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(267, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(30, 30);
            this.btnCerrar.TabIndex = 15;
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Depth = 0;
            this.lblTitle.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(88, 19);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Advertencia";
            // 
            // lblMensaje
            // 
            this.lblMensaje.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(40, 141);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.ReadOnly = true;
            this.lblMensaje.Size = new System.Drawing.Size(250, 49);
            this.lblMensaje.TabIndex = 13;
            this.lblMensaje.Text = "No puede eliminarse a si mismo";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Image = global::AdministradorOrtopediaVelásquez.Properties.Resources.Aceptar;
            this.btnAceptar.Location = new System.Drawing.Point(92, 200);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(104, 41);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Ok";
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // ShowDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(302, 263);
            this.Controls.Add(this.Contenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowConfirmDialog";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.DarkRed;
            this.Contenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InfoImg)).EndInit();
            this.panelDesign1.ResumeLayout(false);
            this.panelDesign1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Contenedor;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.RichTextBox lblMensaje;
        private System.Windows.Forms.Panel panelDesign1;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox InfoImg;
    }
}