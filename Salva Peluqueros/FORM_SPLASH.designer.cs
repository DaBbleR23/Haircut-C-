namespace Salva_Peluqueros
{
    partial class FORM_SPLASH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_SPLASH));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LB_Titulo = new System.Windows.Forms.Label();
            this.LB_Version = new System.Windows.Forms.Label();
            this.LB_NomEquipo = new System.Windows.Forms.Label();
            this.LB_NomUsuario = new System.Windows.Forms.Label();
            this.LB_VersionSO = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LB_Titulo
            // 
            this.LB_Titulo.AutoSize = true;
            this.LB_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.LB_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.LB_Titulo.ForeColor = System.Drawing.Color.DarkViolet;
            this.LB_Titulo.Location = new System.Drawing.Point(71, 32);
            this.LB_Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Titulo.Name = "LB_Titulo";
            this.LB_Titulo.Size = new System.Drawing.Size(0, 58);
            this.LB_Titulo.TabIndex = 0;
            // 
            // LB_Version
            // 
            this.LB_Version.AutoSize = true;
            this.LB_Version.BackColor = System.Drawing.Color.Transparent;
            this.LB_Version.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.LB_Version.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LB_Version.Location = new System.Drawing.Point(489, 464);
            this.LB_Version.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Version.Name = "LB_Version";
            this.LB_Version.Size = new System.Drawing.Size(101, 16);
            this.LB_Version.TabIndex = 1;
            this.LB_Version.Text = "Versión: V.1.0";
            // 
            // LB_NomEquipo
            // 
            this.LB_NomEquipo.AutoSize = true;
            this.LB_NomEquipo.BackColor = System.Drawing.Color.Black;
            this.LB_NomEquipo.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.LB_NomEquipo.ForeColor = System.Drawing.Color.White;
            this.LB_NomEquipo.Location = new System.Drawing.Point(81, 387);
            this.LB_NomEquipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_NomEquipo.Name = "LB_NomEquipo";
            this.LB_NomEquipo.Size = new System.Drawing.Size(150, 16);
            this.LB_NomEquipo.TabIndex = 2;
            this.LB_NomEquipo.Text = "Nombre de equipo:  ";
            // 
            // LB_NomUsuario
            // 
            this.LB_NomUsuario.AutoSize = true;
            this.LB_NomUsuario.BackColor = System.Drawing.Color.Black;
            this.LB_NomUsuario.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.LB_NomUsuario.ForeColor = System.Drawing.Color.White;
            this.LB_NomUsuario.Location = new System.Drawing.Point(79, 32);
            this.LB_NomUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_NomUsuario.Name = "LB_NomUsuario";
            this.LB_NomUsuario.Size = new System.Drawing.Size(225, 26);
            this.LB_NomUsuario.TabIndex = 3;
            this.LB_NomUsuario.Text = "Nombre de usuario:  ";
            this.LB_NomUsuario.Visible = false;
            // 
            // LB_VersionSO
            // 
            this.LB_VersionSO.AutoSize = true;
            this.LB_VersionSO.BackColor = System.Drawing.Color.Black;
            this.LB_VersionSO.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.LB_VersionSO.ForeColor = System.Drawing.Color.White;
            this.LB_VersionSO.Location = new System.Drawing.Point(81, 415);
            this.LB_VersionSO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_VersionSO.Name = "LB_VersionSO";
            this.LB_VersionSO.Size = new System.Drawing.Size(93, 16);
            this.LB_VersionSO.TabIndex = 4;
            this.LB_VersionSO.Text = "Versión SO: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Salva_Peluqueros.Properties.Resources.splash1;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(623, 461);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FORM_SPLASH_MouseClick);
            // 
            // FORM_SPLASH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(616, 461);
            this.ControlBox = false;
            this.Controls.Add(this.LB_VersionSO);
            this.Controls.Add(this.LB_NomUsuario);
            this.Controls.Add(this.LB_NomEquipo);
            this.Controls.Add(this.LB_Version);
            this.Controls.Add(this.LB_Titulo);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FORM_SPLASH";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FORM_SPLASH_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FORM_SPLASH_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LB_Titulo;
        private System.Windows.Forms.Label LB_Version;
        private System.Windows.Forms.Label LB_NomEquipo;
        private System.Windows.Forms.Label LB_NomUsuario;
        private System.Windows.Forms.Label LB_VersionSO;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}