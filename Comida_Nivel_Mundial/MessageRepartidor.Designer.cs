namespace Comida_Nivel_Mundial
{
    partial class MessageRepartidor
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
            this.uI_ShadowPanel2 = new UIDC.UI_ShadowPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.uI_ShadowPanel1 = new UIDC.UI_ShadowPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uI_Elipse1 = new UIDC.UI_Elipse(this.components);
            this.uI_ShadowPanel2.SuspendLayout();
            this.uI_ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uI_ShadowPanel2
            // 
            this.uI_ShadowPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uI_ShadowPanel2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.uI_ShadowPanel2.Controls.Add(this.label2);
            this.uI_ShadowPanel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uI_ShadowPanel2.Location = new System.Drawing.Point(276, 103);
            this.uI_ShadowPanel2.Name = "uI_ShadowPanel2";
            this.uI_ShadowPanel2.ParentControl = this;
            this.uI_ShadowPanel2.Radius = 10;
            this.uI_ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel2.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel2.Size = new System.Drawing.Size(173, 55);
            this.uI_ShadowPanel2.TabIndex = 14;
            this.uI_ShadowPanel2.Click += new System.EventHandler(this.uI_ShadowPanel2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(30, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cancelar";
            this.label2.Click += new System.EventHandler(this.uI_ShadowPanel2_Click);
            // 
            // uI_ShadowPanel1
            // 
            this.uI_ShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel1.Controls.Add(this.label3);
            this.uI_ShadowPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uI_ShadowPanel1.Location = new System.Drawing.Point(56, 103);
            this.uI_ShadowPanel1.Name = "uI_ShadowPanel1";
            this.uI_ShadowPanel1.ParentControl = this;
            this.uI_ShadowPanel1.Radius = 10;
            this.uI_ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel1.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel1.Size = new System.Drawing.Size(173, 55);
            this.uI_ShadowPanel1.TabIndex = 15;
            this.uI_ShadowPanel1.Click += new System.EventHandler(this.label3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.label3.Location = new System.Drawing.Point(42, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Aceptar";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            this.label3.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.label3_ChangeUICues);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Display", 25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(473, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 46);
            this.label4.TabIndex = 12;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(36, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 46);
            this.label1.TabIndex = 13;
            this.label1.Text = "¿Desea realizar este envio?";
            // 
            // uI_Elipse1
            // 
            this.uI_Elipse1.AddControl = this;
            this.uI_Elipse1.ElipseRadius = 20;
            // 
            // MessageRepartidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(86)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(514, 178);
            this.Controls.Add(this.uI_ShadowPanel2);
            this.Controls.Add(this.uI_ShadowPanel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageRepartidor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageRepartidor";
            this.uI_ShadowPanel2.ResumeLayout(false);
            this.uI_ShadowPanel2.PerformLayout();
            this.uI_ShadowPanel1.ResumeLayout(false);
            this.uI_ShadowPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UIDC.UI_ShadowPanel uI_ShadowPanel2;
        private System.Windows.Forms.Label label2;
        private UIDC.UI_ShadowPanel uI_ShadowPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private UIDC.UI_Elipse uI_Elipse1;
    }
}