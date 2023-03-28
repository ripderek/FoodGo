namespace Comida_Nivel_Mundial
{
    partial class Ver_DetalleOrden
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
            this.uI_TitleBanner1 = new UIDC.UI_TitleBanner();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uI_Elipse1 = new UIDC.UI_Elipse(this.components);
            this.uI_ResizeControl1 = new UIDC.UI_ResizeControl();
            this.uI_ShadowPanel1 = new UIDC.UI_ShadowPanel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.uI_ShadowPanel1.SuspendLayout();
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
            this.uI_TitleBanner1.Size = new System.Drawing.Size(800, 30);
            this.uI_TitleBanner1.TabIndex = 5;
            this.uI_TitleBanner1.Text = "Detalle Orden";
            this.uI_TitleBanner1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.uI_TitleBanner1.TypeWindows = UIDC.UI_TitleBanner.TypeTheme.Windows;
            this.uI_TitleBanner1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(474, 371);
            this.dataGridView1.TabIndex = 8;
            // 
            // uI_Elipse1
            // 
            this.uI_Elipse1.AddControl = this;
            this.uI_Elipse1.ElipseRadius = 20;
            // 
            // uI_ResizeControl1
            // 
            this.uI_ResizeControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uI_ResizeControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(75)))));
            this.uI_ResizeControl1.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.uI_ResizeControl1.ForeColor = System.Drawing.Color.Black;
            this.uI_ResizeControl1.ForeColorDepth = 255;
            this.uI_ResizeControl1.Location = new System.Drawing.Point(776, 427);
            this.uI_ResizeControl1.Name = "uI_ResizeControl1";
            this.uI_ResizeControl1.Size = new System.Drawing.Size(20, 20);
            this.uI_ResizeControl1.TabIndex = 7;
            this.uI_ResizeControl1.TargetControl = this;
            // 
            // uI_ShadowPanel1
            // 
            this.uI_ShadowPanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.uI_ShadowPanel1.Controls.Add(this.label1);
            this.uI_ShadowPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uI_ShadowPanel1.Location = new System.Drawing.Point(579, 53);
            this.uI_ShadowPanel1.Name = "uI_ShadowPanel1";
            this.uI_ShadowPanel1.ParentControl = this;
            this.uI_ShadowPanel1.Radius = 15;
            this.uI_ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel1.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel1.Size = new System.Drawing.Size(193, 71);
            this.uI_ShadowPanel1.TabIndex = 9;
            this.uI_ShadowPanel1.Click += new System.EventHandler(this.uI_ShadowPanel1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listo para enviar";
            this.label1.Click += new System.EventHandler(this.uI_ShadowPanel1_Click);
            // 
            // Ver_DetalleOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uI_ShadowPanel1);
            this.Controls.Add(this.uI_ResizeControl1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.uI_TitleBanner1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ver_DetalleOrden";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalle Orden";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.uI_ShadowPanel1.ResumeLayout(false);
            this.uI_ShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UIDC.UI_TitleBanner uI_TitleBanner1;
        private UIDC.UI_ResizeControl uI_ResizeControl1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private UIDC.UI_Elipse uI_Elipse1;
        private UIDC.UI_ShadowPanel uI_ShadowPanel1;
        private System.Windows.Forms.Label label1;
    }
}