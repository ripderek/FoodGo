namespace Comida_Nivel_Mundial
{
    partial class frmMapaRepartidor
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
            this.button1 = new System.Windows.Forms.Button();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.txtEntregar = new System.Windows.Forms.TextBox();
            this.txtLlamar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(75)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Variable Small", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.button1.Location = new System.Drawing.Point(0, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(800, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Finalizar Envio";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gMapControl1
            // 
            this.gMapControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(12, 117);
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
            this.gMapControl1.Size = new System.Drawing.Size(776, 148);
            this.gMapControl1.TabIndex = 1;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load);
            // 
            // txtEntregar
            // 
            this.txtEntregar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEntregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.txtEntregar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEntregar.Font = new System.Drawing.Font("Segoe UI Variable Display", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.txtEntregar.Location = new System.Drawing.Point(96, 16);
            this.txtEntregar.Name = "txtEntregar";
            this.txtEntregar.Size = new System.Drawing.Size(604, 39);
            this.txtEntregar.TabIndex = 2;
            this.txtEntregar.Text = "Entregar a:";
            this.txtEntregar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLlamar
            // 
            this.txtLlamar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLlamar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.txtLlamar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLlamar.Font = new System.Drawing.Font("Segoe UI Variable Display", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLlamar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.txtLlamar.Location = new System.Drawing.Point(96, 72);
            this.txtLlamar.Name = "txtLlamar";
            this.txtLlamar.Size = new System.Drawing.Size(604, 39);
            this.txtLlamar.TabIndex = 3;
            this.txtLlamar.Text = "Llamar a:";
            this.txtLlamar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmMapaRepartidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 334);
            this.Controls.Add(this.txtLlamar);
            this.Controls.Add(this.txtEntregar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gMapControl1);
            this.Name = "frmMapaRepartidor";
            this.Text = "frmMapaRepartidor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.TextBox txtEntregar;
        private System.Windows.Forms.TextBox txtLlamar;
    }
}