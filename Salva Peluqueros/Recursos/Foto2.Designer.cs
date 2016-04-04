namespace Salva_Peluqueros.Recursos
{
    partial class Foto2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Foto2));
            this.PB_imagen = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tb_ubicacion = new System.Windows.Forms.TextBox();
            this.bt_examinar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BT_Cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB_imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_imagen
            // 
            this.PB_imagen.InitialImage = global::Salva_Peluqueros.Properties.Resources.sinfoto;
            this.PB_imagen.Location = new System.Drawing.Point(30, 12);
            this.PB_imagen.Name = "PB_imagen";
            this.PB_imagen.Size = new System.Drawing.Size(276, 183);
            this.PB_imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_imagen.TabIndex = 0;
            this.PB_imagen.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tb_ubicacion
            // 
            this.tb_ubicacion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_ubicacion.Location = new System.Drawing.Point(30, 204);
            this.tb_ubicacion.Name = "tb_ubicacion";
            this.tb_ubicacion.ReadOnly = true;
            this.tb_ubicacion.Size = new System.Drawing.Size(189, 22);
            this.tb_ubicacion.TabIndex = 1;
            // 
            // bt_examinar
            // 
            this.bt_examinar.Location = new System.Drawing.Point(225, 202);
            this.bt_examinar.Name = "bt_examinar";
            this.bt_examinar.Size = new System.Drawing.Size(81, 26);
            this.bt_examinar.TabIndex = 2;
            this.bt_examinar.Text = "Examinar";
            this.bt_examinar.UseVisualStyleBackColor = true;
            this.bt_examinar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 26);
            this.button1.TabIndex = 3;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BT_Cancelar
            // 
            this.BT_Cancelar.Location = new System.Drawing.Point(188, 237);
            this.BT_Cancelar.Name = "BT_Cancelar";
            this.BT_Cancelar.Size = new System.Drawing.Size(81, 26);
            this.BT_Cancelar.TabIndex = 4;
            this.BT_Cancelar.Text = "Cancelar";
            this.BT_Cancelar.UseVisualStyleBackColor = true;
            this.BT_Cancelar.Click += new System.EventHandler(this.BT_Cancelar_Click);
            // 
            // Foto2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 275);
            this.Controls.Add(this.BT_Cancelar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_examinar);
            this.Controls.Add(this.tb_ubicacion);
            this.Controls.Add(this.PB_imagen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Foto2";
            this.Text = "Foto de producto";
            this.Load += new System.EventHandler(this.Foto2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_imagen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tb_ubicacion;
        private System.Windows.Forms.Button bt_examinar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BT_Cancelar;
    }
}