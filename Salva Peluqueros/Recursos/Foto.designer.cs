namespace Salva_Peluqueros
{
    partial class Foto
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Foto));
            this.PbxImagen = new System.Windows.Forms.PictureBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.CbxCamaras = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // PbxImagen
            // 
            this.PbxImagen.Location = new System.Drawing.Point(12, 41);
            this.PbxImagen.Name = "PbxImagen";
            this.PbxImagen.Size = new System.Drawing.Size(268, 181);
            this.PbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxImagen.TabIndex = 0;
            this.PbxImagen.TabStop = false;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(103, 12);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 4;
            this.BtnGuardar.Text = "Capturar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // CbxCamaras
            // 
            this.CbxCamaras.FormattingEnabled = true;
            this.CbxCamaras.Location = new System.Drawing.Point(12, 50);
            this.CbxCamaras.Name = "CbxCamaras";
            this.CbxCamaras.Size = new System.Drawing.Size(10, 21);
            this.CbxCamaras.TabIndex = 1;
            this.CbxCamaras.Visible = false;
            // 
            // Foto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 233);
            this.Controls.Add(this.PbxImagen);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.CbxCamaras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Foto";
            this.Text = "Foto";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbxImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PbxImagen;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.ComboBox CbxCamaras;
    }
}

