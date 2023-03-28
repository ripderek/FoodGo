namespace Comida_Nivel_Mundial
{
    partial class frmInicioRepartidor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicioRepartidor));
            this.uI_TitleBanner1 = new UIDC.UI_TitleBanner();
            this.panel_botones = new System.Windows.Forms.Panel();
            this.btnPediso = new UIDC.UI_ShadowPanel();
            this.uI_ShadowPanel1 = new UIDC.UI_ShadowPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnMapa = new UIDC.UI_ShadowPanel();
            this.panel_pantalla = new System.Windows.Forms.Panel();
            this.uI_ResizeControl2 = new UIDC.UI_ResizeControl();
            this.uI_Elipse1 = new UIDC.UI_Elipse(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.uI_CirclePictureBox1 = new UIDC.UI_CirclePictureBox();
            this.panel_botones.SuspendLayout();
            this.btnPediso.SuspendLayout();
            this.uI_ShadowPanel1.SuspendLayout();
            this.btnMapa.SuspendLayout();
            this.panel_pantalla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // uI_TitleBanner1
            // 
            this.uI_TitleBanner1.Animate = UIDC.UI_TitleBanner.Anim.AnimateON;
            this.uI_TitleBanner1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.uI_TitleBanner1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uI_TitleBanner1.ButtonMenuActive = UIDC.UI_TitleBanner.Active.ActiveOff;
            this.uI_TitleBanner1.ButtonsVisible = UIDC.UI_TitleBanner.ButtonVisible.Close_Minimize;
            this.uI_TitleBanner1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uI_TitleBanner1.FlatAppearance.BorderSize = 0;
            this.uI_TitleBanner1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.uI_TitleBanner1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.uI_TitleBanner1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uI_TitleBanner1.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.uI_TitleBanner1.ForeColor = System.Drawing.Color.White;
            this.uI_TitleBanner1.Location = new System.Drawing.Point(0, 0);
            this.uI_TitleBanner1.MoveActive = true;
            this.uI_TitleBanner1.Name = "uI_TitleBanner1";
            this.uI_TitleBanner1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uI_TitleBanner1.ParentControl = this;
            this.uI_TitleBanner1.Size = new System.Drawing.Size(968, 30);
            this.uI_TitleBanner1.TabIndex = 0;
            this.uI_TitleBanner1.Text = "Inicio";
            this.uI_TitleBanner1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.uI_TitleBanner1.TypeWindows = UIDC.UI_TitleBanner.TypeTheme.Windows;
            this.uI_TitleBanner1.UseVisualStyleBackColor = false;
            // 
            // panel_botones
            // 
            this.panel_botones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.panel_botones.Controls.Add(this.btnPediso);
            this.panel_botones.Controls.Add(this.uI_ShadowPanel1);
            this.panel_botones.Controls.Add(this.btnMapa);
            this.panel_botones.Controls.Add(this.uI_CirclePictureBox1);
            this.panel_botones.Controls.Add(this.uI_TitleBanner1);
            this.panel_botones.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_botones.Location = new System.Drawing.Point(0, 0);
            this.panel_botones.Name = "panel_botones";
            this.panel_botones.Size = new System.Drawing.Size(968, 100);
            this.panel_botones.TabIndex = 2;
            // 
            // btnPediso
            // 
            this.btnPediso.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(75)))));
            this.btnPediso.Controls.Add(this.pictureBox2);
            this.btnPediso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPediso.Location = new System.Drawing.Point(12, 38);
            this.btnPediso.Name = "btnPediso";
            this.btnPediso.ParentControl = this;
            this.btnPediso.Radius = 9;
            this.btnPediso.ShadowColor = System.Drawing.Color.Black;
            this.btnPediso.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.btnPediso.Size = new System.Drawing.Size(54, 54);
            this.btnPediso.TabIndex = 13;
            this.btnPediso.Click += new System.EventHandler(this.btnPediso_Click);
            // 
            // uI_ShadowPanel1
            // 
            this.uI_ShadowPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uI_ShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel1.Controls.Add(this.pictureBox5);
            this.uI_ShadowPanel1.Controls.Add(this.textBox1);
            this.uI_ShadowPanel1.Location = new System.Drawing.Point(704, 35);
            this.uI_ShadowPanel1.Name = "uI_ShadowPanel1";
            this.uI_ShadowPanel1.ParentControl = this;
            this.uI_ShadowPanel1.Radius = 9;
            this.uI_ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel1.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel1.Size = new System.Drawing.Size(252, 54);
            this.uI_ShadowPanel1.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(25, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 28);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Usuario";
            // 
            // btnMapa
            // 
            this.btnMapa.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(75)))));
            this.btnMapa.Controls.Add(this.pictureBox3);
            this.btnMapa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMapa.Location = new System.Drawing.Point(72, 38);
            this.btnMapa.Name = "btnMapa";
            this.btnMapa.ParentControl = this;
            this.btnMapa.Radius = 9;
            this.btnMapa.ShadowColor = System.Drawing.Color.Black;
            this.btnMapa.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.btnMapa.Size = new System.Drawing.Size(54, 54);
            this.btnMapa.TabIndex = 12;
            this.btnMapa.Visible = false;
            // 
            // panel_pantalla
            // 
            this.panel_pantalla.AllowDrop = true;
            this.panel_pantalla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_pantalla.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel_pantalla.Controls.Add(this.uI_ResizeControl2);
            this.panel_pantalla.Location = new System.Drawing.Point(0, 99);
            this.panel_pantalla.Name = "panel_pantalla";
            this.panel_pantalla.Size = new System.Drawing.Size(968, 350);
            this.panel_pantalla.TabIndex = 3;
            // 
            // uI_ResizeControl2
            // 
            this.uI_ResizeControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uI_ResizeControl2.BackColor = System.Drawing.Color.White;
            this.uI_ResizeControl2.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.uI_ResizeControl2.ForeColor = System.Drawing.Color.Black;
            this.uI_ResizeControl2.ForeColorDepth = 255;
            this.uI_ResizeControl2.Location = new System.Drawing.Point(948, 330);
            this.uI_ResizeControl2.Name = "uI_ResizeControl2";
            this.uI_ResizeControl2.Size = new System.Drawing.Size(20, 20);
            this.uI_ResizeControl2.TabIndex = 1;
            this.uI_ResizeControl2.TargetControl = this;
            // 
            // uI_Elipse1
            // 
            this.uI_Elipse1.AddControl = this;
            this.uI_Elipse1.ElipseRadius = 20;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(75)))));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Comida_Nivel_Mundial.Properties.Resources.bgui_shipping_icon_157590;
            this.pictureBox2.Location = new System.Drawing.Point(13, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.btnPediso_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::Comida_Nivel_Mundial.Properties.Resources.r4092564_about_mobile_ui_profile_ui_user_website_114033;
            this.pictureBox5.Location = new System.Drawing.Point(208, 10);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(27, 34);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(75)))));
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::Comida_Nivel_Mundial.Properties.Resources.b3643769_building_home_house_main_menu_start_113416;
            this.pictureBox3.Location = new System.Drawing.Point(13, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // uI_CirclePictureBox1
            // 
            this.uI_CirclePictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.uI_CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.uI_CirclePictureBox1.Filter = true;
            this.uI_CirclePictureBox1.FilterAlpha = 0;
            this.uI_CirclePictureBox1.FilterAngleAlpha = 0;
            this.uI_CirclePictureBox1.FilterGradiantLeft = System.Drawing.Color.DodgerBlue;
            this.uI_CirclePictureBox1.FilterGradiantRight = System.Drawing.Color.DodgerBlue;
            this.uI_CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("uI_CirclePictureBox1.Image")));
            this.uI_CirclePictureBox1.Location = new System.Drawing.Point(360, 35);
            this.uI_CirclePictureBox1.Name = "uI_CirclePictureBox1";
            this.uI_CirclePictureBox1.PicBackColor = System.Drawing.Color.Tomato;
            this.uI_CirclePictureBox1.PicBackColorAlpha = 100;
            this.uI_CirclePictureBox1.RadioAngleAlpha = 180;
            this.uI_CirclePictureBox1.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.uI_CirclePictureBox1.RadioFilter = false;
            this.uI_CirclePictureBox1.RadioFilterAlpha = 80;
            this.uI_CirclePictureBox1.RadioGradiantLeft = System.Drawing.Color.DimGray;
            this.uI_CirclePictureBox1.RadioGradiantRight = System.Drawing.Color.DimGray;
            this.uI_CirclePictureBox1.RadioSize = 6;
            this.uI_CirclePictureBox1.Size = new System.Drawing.Size(58, 58);
            this.uI_CirclePictureBox1.TabIndex = 5;
            this.uI_CirclePictureBox1.Text = "uI_CirclePictureBox1";
            // 
            // frmInicioRepartidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 450);
            this.Controls.Add(this.panel_pantalla);
            this.Controls.Add(this.panel_botones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInicioRepartidor";
            this.Text = "Inicio";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmInicioRepartidor_FormClosed);
            this.panel_botones.ResumeLayout(false);
            this.btnPediso.ResumeLayout(false);
            this.uI_ShadowPanel1.ResumeLayout(false);
            this.uI_ShadowPanel1.PerformLayout();
            this.btnMapa.ResumeLayout(false);
            this.panel_pantalla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UIDC.UI_TitleBanner uI_TitleBanner1;
        private System.Windows.Forms.Panel panel_botones;
        private UIDC.UI_ShadowPanel btnPediso;
        private System.Windows.Forms.PictureBox pictureBox2;
        private UIDC.UI_ShadowPanel uI_ShadowPanel1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox textBox1;
        private UIDC.UI_ShadowPanel btnMapa;
        private System.Windows.Forms.PictureBox pictureBox3;
        private UIDC.UI_CirclePictureBox uI_CirclePictureBox1;
        private System.Windows.Forms.Panel panel_pantalla;
        private UIDC.UI_ResizeControl uI_ResizeControl2;
        private UIDC.UI_Elipse uI_Elipse1;
    }
}