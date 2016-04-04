namespace Salva_Peluqueros
{
    partial class FORM_SeleccionarUbicacionBD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_SeleccionarUbicacionBD));
            this.TB_RUTA = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TB_Aceptar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_RUTA
            // 
            this.TB_RUTA.Location = new System.Drawing.Point(34, 149);
            this.TB_RUTA.Name = "TB_RUTA";
            this.TB_RUTA.Size = new System.Drawing.Size(228, 20);
            this.TB_RUTA.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Salva_Peluqueros.Properties.Resources.database;
            this.pictureBox1.Location = new System.Drawing.Point(111, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // TB_Aceptar
            // 
            this.TB_Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Aceptar.Image = global::Salva_Peluqueros.Properties.Resources.check;
            this.TB_Aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TB_Aceptar.Location = new System.Drawing.Point(134, 175);
            this.TB_Aceptar.Name = "TB_Aceptar";
            this.TB_Aceptar.Size = new System.Drawing.Size(86, 35);
            this.TB_Aceptar.TabIndex = 2;
            this.TB_Aceptar.Text = "Aceptar";
            this.TB_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TB_Aceptar.UseVisualStyleBackColor = true;
            this.TB_Aceptar.Click += new System.EventHandler(this.TB_Aceptar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Salva_Peluqueros.Properties.Resources.data_find;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(268, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Examinar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FORM_SeleccionarUbicacionBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 237);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TB_Aceptar);
            this.Controls.Add(this.TB_RUTA);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FORM_SeleccionarUbicacionBD";
            this.Text = "Buscar Base de datos";
            this.Load += new System.EventHandler(this.FORM_SeleccionarUbicacionBD_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FORM_SeleccionarUbicacionBD_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TB_RUTA;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button TB_Aceptar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}