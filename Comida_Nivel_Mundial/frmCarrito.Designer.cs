namespace Comida_Nivel_Mundial
{
    partial class frmCarrito
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.uI_ShadowPanel3 = new UIDC.UI_ShadowPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.uI_ShadowPanel2 = new UIDC.UI_ShadowPanel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.uI_ShadowPanel1 = new UIDC.UI_ShadowPanel();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.uI_ShadowPanel3.SuspendLayout();
            this.uI_ShadowPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.uI_ShadowPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.uI_ShadowPanel3);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.uI_ShadowPanel2);
            this.panel1.Controls.Add(this.uI_ShadowPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 69);
            this.panel1.TabIndex = 0;
            // 
            // uI_ShadowPanel3
            // 
            this.uI_ShadowPanel3.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel3.Controls.Add(this.textBox1);
            this.uI_ShadowPanel3.Location = new System.Drawing.Point(12, 7);
            this.uI_ShadowPanel3.Name = "uI_ShadowPanel3";
            this.uI_ShadowPanel3.ParentControl = this;
            this.uI_ShadowPanel3.Radius = 9;
            this.uI_ShadowPanel3.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel3.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel3.Size = new System.Drawing.Size(224, 54);
            this.uI_ShadowPanel3.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(23, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 28);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "precio";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(642, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(48, 43);
            this.panel3.TabIndex = 1;
            // 
            // uI_ShadowPanel2
            // 
            this.uI_ShadowPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uI_ShadowPanel2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(75)))));
            this.uI_ShadowPanel2.Controls.Add(this.pictureBox5);
            this.uI_ShadowPanel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uI_ShadowPanel2.Location = new System.Drawing.Point(671, 7);
            this.uI_ShadowPanel2.Name = "uI_ShadowPanel2";
            this.uI_ShadowPanel2.ParentControl = this;
            this.uI_ShadowPanel2.Radius = 9;
            this.uI_ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel2.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel2.Size = new System.Drawing.Size(85, 54);
            this.uI_ShadowPanel2.TabIndex = 13;
            this.uI_ShadowPanel2.Click += new System.EventHandler(this.uI_ShadowPanel2_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(75)))));
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::Comida_Nivel_Mundial.Properties.Resources.abusiness_cash_coin_dollar_finance_money_payment_icon_123244;
            this.pictureBox5.Location = new System.Drawing.Point(21, 5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(41, 44);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.uI_ShadowPanel2_Click);
            // 
            // uI_ShadowPanel1
            // 
            this.uI_ShadowPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uI_ShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel1.Controls.Add(this.txtprecio);
            this.uI_ShadowPanel1.Location = new System.Drawing.Point(453, 7);
            this.uI_ShadowPanel1.Name = "uI_ShadowPanel1";
            this.uI_ShadowPanel1.ParentControl = this;
            this.uI_ShadowPanel1.Radius = 9;
            this.uI_ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel1.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel1.Size = new System.Drawing.Size(224, 54);
            this.uI_ShadowPanel1.TabIndex = 12;
            // 
            // txtprecio
            // 
            this.txtprecio.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtprecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtprecio.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecio.Location = new System.Drawing.Point(23, 12);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(173, 28);
            this.txtprecio.TabIndex = 10;
            this.txtprecio.Text = "precio";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gMapControl1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(814, 431);
            this.panel2.TabIndex = 1;
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(474, 0);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(340, 431);
            this.gMapControl1.TabIndex = 1;
            this.gMapControl1.Zoom = 0D;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(474, 431);
            this.dataGridView1.TabIndex = 0;
            // 
            // frmCarrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(814, 500);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmCarrito";
            this.Text = "frmCarrito";
            this.panel1.ResumeLayout(false);
            this.uI_ShadowPanel3.ResumeLayout(false);
            this.uI_ShadowPanel3.PerformLayout();
            this.uI_ShadowPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.uI_ShadowPanel1.ResumeLayout(false);
            this.uI_ShadowPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private UIDC.UI_ShadowPanel uI_ShadowPanel1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox txtprecio;
        private UIDC.UI_ShadowPanel uI_ShadowPanel2;
        private System.Windows.Forms.Panel panel3;
        private UIDC.UI_ShadowPanel uI_ShadowPanel3;
        private System.Windows.Forms.TextBox textBox1;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
    }
}