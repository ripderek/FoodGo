namespace Comida_Nivel_Mundial
{
    partial class frmOrdenes
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
            this.uI_Elipse1 = new UIDC.UI_Elipse(this.components);
            this.uI_ResizeControl1 = new UIDC.UI_ResizeControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.uI_TitleBanner1.TabIndex = 4;
            this.uI_TitleBanner1.Text = "Ordenes";
            this.uI_TitleBanner1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.uI_TitleBanner1.TypeWindows = UIDC.UI_TitleBanner.TypeTheme.Windows;
            this.uI_TitleBanner1.UseVisualStyleBackColor = false;
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
            this.uI_ResizeControl1.Location = new System.Drawing.Point(780, 430);
            this.uI_ResizeControl1.Name = "uI_ResizeControl1";
            this.uI_ResizeControl1.Size = new System.Drawing.Size(20, 20);
            this.uI_ResizeControl1.TabIndex = 5;
            this.uI_ResizeControl1.TargetControl = null;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(163, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(474, 371);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // frmOrdenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uI_ResizeControl1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.uI_TitleBanner1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrdenes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordenes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UIDC.UI_TitleBanner uI_TitleBanner1;
        private UIDC.UI_Elipse uI_Elipse1;
        private UIDC.UI_ResizeControl uI_ResizeControl1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}