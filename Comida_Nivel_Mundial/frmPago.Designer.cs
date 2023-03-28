namespace Comida_Nivel_Mundial
{
    partial class frmPago
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uI_ShadowPanel1 = new UIDC.UI_ShadowPanel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.uI_ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Comida_Nivel_Mundial.Properties.Resources.ejemplo_cobro_tarjeta4;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(619, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // uI_ShadowPanel1
            // 
            this.uI_ShadowPanel1.BaseColor = System.Drawing.Color.Red;
            this.uI_ShadowPanel1.Controls.Add(this.label3);
            this.uI_ShadowPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uI_ShadowPanel1.Location = new System.Drawing.Point(475, 387);
            this.uI_ShadowPanel1.Name = "uI_ShadowPanel1";
            this.uI_ShadowPanel1.ParentControl = this;
            this.uI_ShadowPanel1.Radius = 10;
            this.uI_ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel1.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel1.Size = new System.Drawing.Size(132, 51);
            this.uI_ShadowPanel1.TabIndex = 12;
            this.uI_ShadowPanel1.Click += new System.EventHandler(this.uI_ShadowPanel1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Aceptar";
            this.label3.Click += new System.EventHandler(this.uI_ShadowPanel1_Click);
            // 
            // frmPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 450);
            this.Controls.Add(this.uI_ShadowPanel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pago";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.uI_ShadowPanel1.ResumeLayout(false);
            this.uI_ShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private UIDC.UI_ShadowPanel uI_ShadowPanel1;
        private System.Windows.Forms.Label label3;
    }
}