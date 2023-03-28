namespace Comida_Nivel_Mundial
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.uI_ShadowPanel1 = new UIDC.UI_ShadowPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.uI_ShadowPanel2 = new UIDC.UI_ShadowPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.uI_ShadowPanel3 = new UIDC.UI_ShadowPanel();
            this.uI_ShadowPanel4 = new UIDC.UI_ShadowPanel();
            this.BtnVer = new System.Windows.Forms.PictureBox();
            this.btnNover = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uI_CirclePictureBox1 = new UIDC.UI_CirclePictureBox();
            this.uI_Elipse1 = new UIDC.UI_Elipse(this.components);
            this.uI_ShadowPanel1.SuspendLayout();
            this.uI_ShadowPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.uI_ShadowPanel3.SuspendLayout();
            this.uI_ShadowPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnVer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(55, 22);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(284, 28);
            this.txtUsuario.TabIndex = 1;
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrasenia.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F);
            this.txtContrasenia.Location = new System.Drawing.Point(55, 23);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(262, 28);
            this.txtContrasenia.TabIndex = 2;
            this.txtContrasenia.TextChanged += new System.EventHandler(this.txtContrasenia_TextChanged);
            // 
            // uI_ShadowPanel1
            // 
            this.uI_ShadowPanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.uI_ShadowPanel1.Controls.Add(this.label1);
            this.uI_ShadowPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uI_ShadowPanel1.Location = new System.Drawing.Point(96, 427);
            this.uI_ShadowPanel1.Name = "uI_ShadowPanel1";
            this.uI_ShadowPanel1.ParentControl = this;
            this.uI_ShadowPanel1.Radius = 15;
            this.uI_ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel1.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel1.Size = new System.Drawing.Size(221, 71);
            this.uI_ShadowPanel1.TabIndex = 5;
            this.uI_ShadowPanel1.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(25, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Iniciar Sesion";
            this.label1.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // uI_ShadowPanel2
            // 
            this.uI_ShadowPanel2.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel2.Controls.Add(this.label2);
            this.uI_ShadowPanel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uI_ShadowPanel2.Location = new System.Drawing.Point(96, 504);
            this.uI_ShadowPanel2.Name = "uI_ShadowPanel2";
            this.uI_ShadowPanel2.ParentControl = this;
            this.uI_ShadowPanel2.Radius = 15;
            this.uI_ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel2.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel2.Size = new System.Drawing.Size(221, 71);
            this.uI_ShadowPanel2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(33)))));
            this.label2.Location = new System.Drawing.Point(25, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Crear Cuenta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 20F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(33)))));
            this.label3.Location = new System.Drawing.Point(385, -5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 36);
            this.label3.TabIndex = 1;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(1, 619);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 19);
            this.panel1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(33)))));
            this.label5.Location = new System.Drawing.Point(3, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Food go";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(33)))));
            this.label4.Location = new System.Drawing.Point(367, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "V.0.1.1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(-2, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(415, 28);
            this.panel2.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(33)))));
            this.label6.Location = new System.Drawing.Point(4, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Food go";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(127, 580);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(161, 17);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "¿No puedes iniciar sesion?";
            // 
            // uI_ShadowPanel3
            // 
            this.uI_ShadowPanel3.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel3.Controls.Add(this.pictureBox1);
            this.uI_ShadowPanel3.Controls.Add(this.txtUsuario);
            this.uI_ShadowPanel3.Location = new System.Drawing.Point(12, 268);
            this.uI_ShadowPanel3.Name = "uI_ShadowPanel3";
            this.uI_ShadowPanel3.ParentControl = this;
            this.uI_ShadowPanel3.Radius = 12;
            this.uI_ShadowPanel3.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel3.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel3.Size = new System.Drawing.Size(378, 71);
            this.uI_ShadowPanel3.TabIndex = 7;
            this.uI_ShadowPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.uI_ShadowPanel3_Paint);
            // 
            // uI_ShadowPanel4
            // 
            this.uI_ShadowPanel4.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel4.Controls.Add(this.BtnVer);
            this.uI_ShadowPanel4.Controls.Add(this.btnNover);
            this.uI_ShadowPanel4.Controls.Add(this.pictureBox2);
            this.uI_ShadowPanel4.Controls.Add(this.txtContrasenia);
            this.uI_ShadowPanel4.Location = new System.Drawing.Point(12, 345);
            this.uI_ShadowPanel4.Name = "uI_ShadowPanel4";
            this.uI_ShadowPanel4.ParentControl = this;
            this.uI_ShadowPanel4.Radius = 12;
            this.uI_ShadowPanel4.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel4.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel4.Size = new System.Drawing.Size(378, 71);
            this.uI_ShadowPanel4.TabIndex = 8;
            // 
            // BtnVer
            // 
            this.BtnVer.BackColor = System.Drawing.Color.White;
            this.BtnVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVer.Image = global::Comida_Nivel_Mundial.Properties.Resources._3844476_eye_see_show_view_watch_1103391;
            this.BtnVer.Location = new System.Drawing.Point(323, 13);
            this.BtnVer.Name = "BtnVer";
            this.BtnVer.Size = new System.Drawing.Size(36, 46);
            this.BtnVer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnVer.TabIndex = 4;
            this.BtnVer.TabStop = false;
            this.BtnVer.Visible = false;
            this.BtnVer.Click += new System.EventHandler(this.BtnVer_Click);
            // 
            // btnNover
            // 
            this.btnNover.BackColor = System.Drawing.Color.White;
            this.btnNover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNover.Image = global::Comida_Nivel_Mundial.Properties.Resources._3844477_disable_eye_inactive_see_show_view_watch_1103431;
            this.btnNover.Location = new System.Drawing.Point(323, 13);
            this.btnNover.Name = "btnNover";
            this.btnNover.Size = new System.Drawing.Size(36, 46);
            this.btnNover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNover.TabIndex = 5;
            this.btnNover.TabStop = false;
            this.btnNover.Visible = false;
            this.btnNover.Click += new System.EventHandler(this.btnNover_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::Comida_Nivel_Mundial.Properties.Resources.password_5167;
            this.pictureBox2.Location = new System.Drawing.Point(18, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Comida_Nivel_Mundial.Properties.Resources._4092564_about_mobile_ui_profile_ui_user_website_114033;
            this.pictureBox1.Location = new System.Drawing.Point(15, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // uI_CirclePictureBox1
            // 
            this.uI_CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.uI_CirclePictureBox1.Filter = true;
            this.uI_CirclePictureBox1.FilterAlpha = 0;
            this.uI_CirclePictureBox1.FilterAngleAlpha = 0;
            this.uI_CirclePictureBox1.FilterGradiantLeft = System.Drawing.Color.DodgerBlue;
            this.uI_CirclePictureBox1.FilterGradiantRight = System.Drawing.Color.DodgerBlue;
            this.uI_CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("uI_CirclePictureBox1.Image")));
            this.uI_CirclePictureBox1.Location = new System.Drawing.Point(102, 42);
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
            this.uI_CirclePictureBox1.Size = new System.Drawing.Size(220, 220);
            this.uI_CirclePictureBox1.TabIndex = 4;
            this.uI_CirclePictureBox1.Text = "uI_CirclePictureBox1";
            // 
            // uI_Elipse1
            // 
            this.uI_Elipse1.AddControl = this;
            this.uI_Elipse1.ElipseRadius = 20;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(413, 639);
            this.Controls.Add(this.uI_ShadowPanel4);
            this.Controls.Add(this.uI_ShadowPanel3);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uI_ShadowPanel2);
            this.Controls.Add(this.uI_ShadowPanel1);
            this.Controls.Add(this.uI_CirclePictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio Sesion";
            this.Load += new System.EventHandler(this.Login_Load);
            this.uI_ShadowPanel1.ResumeLayout(false);
            this.uI_ShadowPanel1.PerformLayout();
            this.uI_ShadowPanel2.ResumeLayout(false);
            this.uI_ShadowPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.uI_ShadowPanel3.ResumeLayout(false);
            this.uI_ShadowPanel3.PerformLayout();
            this.uI_ShadowPanel4.ResumeLayout(false);
            this.uI_ShadowPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnVer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasenia;
        private UIDC.UI_CirclePictureBox uI_CirclePictureBox1;
        private UIDC.UI_ShadowPanel uI_ShadowPanel1;
        private System.Windows.Forms.Label label1;
        private UIDC.UI_ShadowPanel uI_ShadowPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private UIDC.UI_ShadowPanel uI_ShadowPanel4;
        private UIDC.UI_ShadowPanel uI_ShadowPanel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox BtnVer;
        private System.Windows.Forms.PictureBox btnNover;
        private UIDC.UI_Elipse uI_Elipse1;
    }
}

