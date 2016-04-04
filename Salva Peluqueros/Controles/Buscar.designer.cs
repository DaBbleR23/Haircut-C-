namespace Salva_Peluqueros
{
    partial class Buscar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buscar));
            this.TB_Contenga = new System.Windows.Forms.TextBox();
            this.LV_datos = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.BT_Cancelar = new System.Windows.Forms.Button();
            this.BT_Aceptar = new System.Windows.Forms.Button();
            this.BT_BuscarContenga = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB_Contenga
            // 
            this.TB_Contenga.Location = new System.Drawing.Point(216, 13);
            this.TB_Contenga.MaxLength = 20;
            this.TB_Contenga.Name = "TB_Contenga";
            this.TB_Contenga.Size = new System.Drawing.Size(129, 20);
            this.TB_Contenga.TabIndex = 1;
            // 
            // LV_datos
            // 
            this.LV_datos.FullRowSelect = true;
            this.LV_datos.GridLines = true;
            this.LV_datos.HideSelection = false;
            this.LV_datos.LargeImageList = this.imageList1;
            this.LV_datos.Location = new System.Drawing.Point(12, 53);
            this.LV_datos.MultiSelect = false;
            this.LV_datos.Name = "LV_datos";
            this.LV_datos.ShowGroups = false;
            this.LV_datos.Size = new System.Drawing.Size(509, 380);
            this.LV_datos.SmallImageList = this.imageList1;
            this.LV_datos.TabIndex = 2;
            this.LV_datos.UseCompatibleStateImageBehavior = false;
            this.LV_datos.View = System.Windows.Forms.View.Details;
            this.LV_datos.DoubleClick += new System.EventHandler(this.LV_datos_DoubleClick);
            this.LV_datos.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.LV_datos_ColumnClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "view.png");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contenga";
            // 
            // BT_Cancelar
            // 
            this.BT_Cancelar.Location = new System.Drawing.Point(292, 439);
            this.BT_Cancelar.Name = "BT_Cancelar";
            this.BT_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.BT_Cancelar.TabIndex = 6;
            this.BT_Cancelar.Text = "Cancelar";
            this.BT_Cancelar.UseVisualStyleBackColor = true;
            this.BT_Cancelar.Click += new System.EventHandler(this.BT_Cancelar_Click);
            // 
            // BT_Aceptar
            // 
            this.BT_Aceptar.Location = new System.Drawing.Point(165, 439);
            this.BT_Aceptar.Name = "BT_Aceptar";
            this.BT_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.BT_Aceptar.TabIndex = 5;
            this.BT_Aceptar.Text = "Aceptar";
            this.BT_Aceptar.UseVisualStyleBackColor = true;
            this.BT_Aceptar.Click += new System.EventHandler(this.LV_datos_DoubleClick);
            // 
            // BT_BuscarContenga
            // 
            this.BT_BuscarContenga.Image = global::Salva_Peluqueros.Properties.Resources.view2;
            this.BT_BuscarContenga.Location = new System.Drawing.Point(349, 11);
            this.BT_BuscarContenga.Name = "BT_BuscarContenga";
            this.BT_BuscarContenga.Size = new System.Drawing.Size(26, 23);
            this.BT_BuscarContenga.TabIndex = 7;
            this.BT_BuscarContenga.UseVisualStyleBackColor = true;
            this.BT_BuscarContenga.Click += new System.EventHandler(this.BT_BuscarContenga_Click);
            // 
            // Buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 477);
            this.Controls.Add(this.BT_BuscarContenga);
            this.Controls.Add(this.BT_Cancelar);
            this.Controls.Add(this.BT_Aceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LV_datos);
            this.Controls.Add(this.TB_Contenga);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Buscar";
            this.Text = "Buscar";
            this.Load += new System.EventHandler(this.Buscar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Contenga;
        private System.Windows.Forms.ListView LV_datos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BT_Aceptar;
        private System.Windows.Forms.Button BT_Cancelar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button BT_BuscarContenga;
    }
}