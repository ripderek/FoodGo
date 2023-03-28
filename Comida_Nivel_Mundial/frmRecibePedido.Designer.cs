namespace Comida_Nivel_Mundial
{
    partial class frmRecibePedido
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
            this.txtLlamar = new System.Windows.Forms.TextBox();
            this.txtEntregar = new System.Windows.Forms.TextBox();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.SuspendLayout();
            // 
            // txtLlamar
            // 
            this.txtLlamar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLlamar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.txtLlamar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLlamar.Font = new System.Drawing.Font("Segoe UI Variable Display", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLlamar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.txtLlamar.Location = new System.Drawing.Point(92, 73);
            this.txtLlamar.Name = "txtLlamar";
            this.txtLlamar.Size = new System.Drawing.Size(604, 39);
            this.txtLlamar.TabIndex = 6;
            this.txtLlamar.Text = "Llamar a:";
            this.txtLlamar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEntregar
            // 
            this.txtEntregar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEntregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.txtEntregar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEntregar.Font = new System.Drawing.Font("Segoe UI Variable Display", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.txtEntregar.Location = new System.Drawing.Point(92, 17);
            this.txtEntregar.Name = "txtEntregar";
            this.txtEntregar.Size = new System.Drawing.Size(604, 39);
            this.txtEntregar.TabIndex = 5;
            this.txtEntregar.Text = "Entregar a:";
            this.txtEntregar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.gMapControl1.Location = new System.Drawing.Point(10, 122);
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
            this.gMapControl1.Size = new System.Drawing.Size(776, 226);
            this.gMapControl1.TabIndex = 4;
            this.gMapControl1.Zoom = 0D;
            // 
            // frmRecibePedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 378);
            this.Controls.Add(this.txtLlamar);
            this.Controls.Add(this.txtEntregar);
            this.Controls.Add(this.gMapControl1);
            this.Name = "frmRecibePedido";
            this.Text = "frmRecibePedido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLlamar;
        private System.Windows.Forms.TextBox txtEntregar;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
    }
}