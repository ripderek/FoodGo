namespace Comida_Nivel_Mundial
{
    partial class frmCrearComida
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtprecio1 = new System.Windows.Forms.TextBox();
            this.txtprecio2 = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear Comida";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(46, 70);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(372, 20);
            this.txtnombre.TabIndex = 1;
            this.txtnombre.Text = "nombre";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(46, 115);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(372, 20);
            this.txtdescripcion.TabIndex = 2;
            this.txtdescripcion.Text = "descripcion";
            // 
            // txtprecio1
            // 
            this.txtprecio1.Location = new System.Drawing.Point(46, 161);
            this.txtprecio1.Name = "txtprecio1";
            this.txtprecio1.Size = new System.Drawing.Size(97, 20);
            this.txtprecio1.TabIndex = 3;
            this.txtprecio1.Text = "precio general";
            // 
            // txtprecio2
            // 
            this.txtprecio2.Location = new System.Drawing.Point(159, 161);
            this.txtprecio2.Name = "txtprecio2";
            this.txtprecio2.Size = new System.Drawing.Size(97, 20);
            this.txtprecio2.TabIndex = 4;
            this.txtprecio2.Text = "precio general";
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(46, 205);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(372, 20);
            this.txtPais.TabIndex = 5;
            this.txtPais.Text = "id del pais";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(46, 252);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(372, 20);
            this.txtCategoria.TabIndex = 6;
            this.txtCategoria.Text = "id de la categoria";
            // 
            // picFoto
            // 
            this.picFoto.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.picFoto.Location = new System.Drawing.Point(620, 28);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(200, 231);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFoto.TabIndex = 7;
            this.picFoto.TabStop = false;
            this.picFoto.Click += new System.EventHandler(this.picFoto_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(620, 265);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(200, 61);
            this.btnCrear.TabIndex = 8;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ingredientes";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // frmCrearComida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 531);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.picFoto);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.txtprecio2);
            this.Controls.Add(this.txtprecio1);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label1);
            this.Name = "frmCrearComida";
            this.Text = "frmCrearComida";
            this.Load += new System.EventHandler(this.frmCrearComida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox txtprecio1;
        private System.Windows.Forms.TextBox txtprecio2;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label label2;
    }
}