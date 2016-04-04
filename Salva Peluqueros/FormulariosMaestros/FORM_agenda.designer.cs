namespace Salva_Peluqueros
{
    partial class FORM_agenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_agenda));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSBBuscar = new System.Windows.Forms.ToolStripButton();
            this.TSBCodigo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBPrimero = new System.Windows.Forms.ToolStripButton();
            this.TSBAnterior = new System.Windows.Forms.ToolStripButton();
            this.TSBSiguiente = new System.Windows.Forms.ToolStripButton();
            this.TSBUltimo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBGuardarAlMover = new System.Windows.Forms.ToolStripButton();
            this.TSBBorrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBCerrar = new System.Windows.Forms.ToolStripButton();
            this.GB_Profesores = new System.Windows.Forms.GroupBox();
            this.telefono = new Salva_Peluqueros.MiTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Nombre = new Salva_Peluqueros.MiTextBox();
            this.Codigo = new Salva_Peluqueros.MiTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_Cancelar = new System.Windows.Forms.Button();
            this.BT_Guardar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip1.SuspendLayout();
            this.GB_Profesores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSBBuscar,
            this.TSBCodigo,
            this.toolStripSeparator1,
            this.TSBPrimero,
            this.TSBAnterior,
            this.TSBSiguiente,
            this.TSBUltimo,
            this.toolStripSeparator2,
            this.TSBGuardarAlMover,
            this.TSBBorrar,
            this.toolStripSeparator3,
            this.TSBCerrar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(666, 45);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TSBBuscar
            // 
            this.TSBBuscar.Font = new System.Drawing.Font("Tahoma", 8.3F, System.Drawing.FontStyle.Bold);
            this.TSBBuscar.Image = ((System.Drawing.Image)(resources.GetObject("TSBBuscar.Image")));
            this.TSBBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBBuscar.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.TSBBuscar.Name = "TSBBuscar";
            this.TSBBuscar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TSBBuscar.Size = new System.Drawing.Size(51, 42);
            this.TSBBuscar.Text = "Buscar";
            this.TSBBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TSBBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSBBuscar.ToolTipText = "Buscar";
            this.TSBBuscar.Click += new System.EventHandler(this.TSBBuscar_Click);
            // 
            // TSBCodigo
            // 
            this.TSBCodigo.Font = new System.Drawing.Font("Tahoma", 8.3F, System.Drawing.FontStyle.Bold);
            this.TSBCodigo.Image = ((System.Drawing.Image)(resources.GetObject("TSBCodigo.Image")));
            this.TSBCodigo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBCodigo.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.TSBCodigo.Name = "TSBCodigo";
            this.TSBCodigo.Size = new System.Drawing.Size(115, 42);
            this.TSBCodigo.Text = "Proponer Codigo";
            this.TSBCodigo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSBCodigo.ToolTipText = "Proponer Codigo";
            this.TSBCodigo.Click += new System.EventHandler(this.TSBCodigo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 45);
            // 
            // TSBPrimero
            // 
            this.TSBPrimero.Font = new System.Drawing.Font("Tahoma", 8.3F, System.Drawing.FontStyle.Bold);
            this.TSBPrimero.Image = ((System.Drawing.Image)(resources.GetObject("TSBPrimero.Image")));
            this.TSBPrimero.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBPrimero.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.TSBPrimero.Name = "TSBPrimero";
            this.TSBPrimero.Size = new System.Drawing.Size(58, 42);
            this.TSBPrimero.Text = "Primero";
            this.TSBPrimero.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSBPrimero.ToolTipText = "Anterior";
            this.TSBPrimero.Click += new System.EventHandler(this.TSBPrimero_Click);
            // 
            // TSBAnterior
            // 
            this.TSBAnterior.Font = new System.Drawing.Font("Tahoma", 8.3F, System.Drawing.FontStyle.Bold);
            this.TSBAnterior.Image = ((System.Drawing.Image)(resources.GetObject("TSBAnterior.Image")));
            this.TSBAnterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBAnterior.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.TSBAnterior.Name = "TSBAnterior";
            this.TSBAnterior.Size = new System.Drawing.Size(62, 42);
            this.TSBAnterior.Text = "Anterior";
            this.TSBAnterior.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSBAnterior.ToolTipText = "Anterior";
            this.TSBAnterior.Click += new System.EventHandler(this.TSBAnterior_Click);
            // 
            // TSBSiguiente
            // 
            this.TSBSiguiente.Font = new System.Drawing.Font("Tahoma", 8.3F, System.Drawing.FontStyle.Bold);
            this.TSBSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("TSBSiguiente.Image")));
            this.TSBSiguiente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBSiguiente.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.TSBSiguiente.Name = "TSBSiguiente";
            this.TSBSiguiente.Size = new System.Drawing.Size(69, 42);
            this.TSBSiguiente.Text = "Siguiente";
            this.TSBSiguiente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSBSiguiente.ToolTipText = "Siguiente";
            this.TSBSiguiente.Click += new System.EventHandler(this.TSBSiguiente_Click);
            // 
            // TSBUltimo
            // 
            this.TSBUltimo.Font = new System.Drawing.Font("Tahoma", 8.3F, System.Drawing.FontStyle.Bold);
            this.TSBUltimo.Image = ((System.Drawing.Image)(resources.GetObject("TSBUltimo.Image")));
            this.TSBUltimo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBUltimo.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.TSBUltimo.Name = "TSBUltimo";
            this.TSBUltimo.Size = new System.Drawing.Size(50, 42);
            this.TSBUltimo.Text = "Ultimo";
            this.TSBUltimo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSBUltimo.ToolTipText = "Anterior";
            this.TSBUltimo.Click += new System.EventHandler(this.TSBUltimo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 45);
            // 
            // TSBGuardarAlMover
            // 
            this.TSBGuardarAlMover.CheckOnClick = true;
            this.TSBGuardarAlMover.Font = new System.Drawing.Font("Tahoma", 8.3F, System.Drawing.FontStyle.Bold);
            this.TSBGuardarAlMover.Image = ((System.Drawing.Image)(resources.GetObject("TSBGuardarAlMover.Image")));
            this.TSBGuardarAlMover.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBGuardarAlMover.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.TSBGuardarAlMover.Name = "TSBGuardarAlMover";
            this.TSBGuardarAlMover.Size = new System.Drawing.Size(115, 42);
            this.TSBGuardarAlMover.Text = "Guardar al mover";
            this.TSBGuardarAlMover.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSBGuardarAlMover.ToolTipText = "Borrar";
            this.TSBGuardarAlMover.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // TSBBorrar
            // 
            this.TSBBorrar.Font = new System.Drawing.Font("Tahoma", 8.3F, System.Drawing.FontStyle.Bold);
            this.TSBBorrar.Image = ((System.Drawing.Image)(resources.GetObject("TSBBorrar.Image")));
            this.TSBBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBBorrar.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.TSBBorrar.Name = "TSBBorrar";
            this.TSBBorrar.Size = new System.Drawing.Size(49, 45);
            this.TSBBorrar.Text = "Borrar";
            this.TSBBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSBBorrar.ToolTipText = "Borrar";
            this.TSBBorrar.Click += new System.EventHandler(this.TSBBorrar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 48);
            // 
            // TSBCerrar
            // 
            this.TSBCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TSBCerrar.Font = new System.Drawing.Font("Tahoma", 8.3F, System.Drawing.FontStyle.Bold);
            this.TSBCerrar.Image = ((System.Drawing.Image)(resources.GetObject("TSBCerrar.Image")));
            this.TSBCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TSBCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBCerrar.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.TSBCerrar.Name = "TSBCerrar";
            this.TSBCerrar.Size = new System.Drawing.Size(48, 45);
            this.TSBCerrar.Text = "Cerrar";
            this.TSBCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSBCerrar.ToolTipText = "Salir";
            this.TSBCerrar.Click += new System.EventHandler(this.TSBCerrar_Click);
            // 
            // GB_Profesores
            // 
            this.GB_Profesores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GB_Profesores.Controls.Add(this.telefono);
            this.GB_Profesores.Controls.Add(this.label3);
            this.GB_Profesores.Controls.Add(this.Nombre);
            this.GB_Profesores.Controls.Add(this.Codigo);
            this.GB_Profesores.Controls.Add(this.label2);
            this.GB_Profesores.Controls.Add(this.label1);
            this.GB_Profesores.Controls.Add(this.BT_Cancelar);
            this.GB_Profesores.Controls.Add(this.BT_Guardar);
            this.GB_Profesores.Location = new System.Drawing.Point(12, 48);
            this.GB_Profesores.Name = "GB_Profesores";
            this.GB_Profesores.Size = new System.Drawing.Size(642, 101);
            this.GB_Profesores.TabIndex = 0;
            this.GB_Profesores.TabStop = false;
            this.GB_Profesores.Text = "Datos Alumnos";
            // 
            // telefono
            // 
            this.telefono.CaracteresMaximos = 40;
            this.telefono.ColorActivo = System.Drawing.Color.LightSteelBlue;
            this.telefono.Location = new System.Drawing.Point(169, 73);
            this.telefono.MaxLength = 40;
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(247, 20);
            this.telefono.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(22, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 15);
            this.label3.TabIndex = 36;
            this.label3.Text = "Telefono de contacto";
            // 
            // Nombre
            // 
            this.Nombre.CaracteresMaximos = 40;
            this.Nombre.ColorActivo = System.Drawing.Color.LightSteelBlue;
            this.Nombre.Location = new System.Drawing.Point(169, 47);
            this.Nombre.MaxLength = 40;
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(247, 20);
            this.Nombre.TabIndex = 1;
            // 
            // Codigo
            // 
            this.Codigo.ColorActivo = System.Drawing.Color.LightSteelBlue;
            this.Codigo.Location = new System.Drawing.Point(169, 19);
            this.Codigo.MaxLength = 10;
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(67, 20);
            this.Codigo.TabIndex = 0;
            this.Codigo.Leave += new System.EventHandler(this.Código_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(22, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 34;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 33;
            this.label1.Text = "Código";
            // 
            // BT_Cancelar
            // 
            this.BT_Cancelar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BT_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_Cancelar.Font = new System.Drawing.Font("Tahoma", 8.3F, System.Drawing.FontStyle.Bold);
            this.BT_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("BT_Cancelar.Image")));
            this.BT_Cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BT_Cancelar.Location = new System.Drawing.Point(546, 23);
            this.BT_Cancelar.Name = "BT_Cancelar";
            this.BT_Cancelar.Size = new System.Drawing.Size(68, 43);
            this.BT_Cancelar.TabIndex = 13;
            this.BT_Cancelar.Text = "Cancelar";
            this.BT_Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BT_Cancelar.UseVisualStyleBackColor = false;
            this.BT_Cancelar.Click += new System.EventHandler(this.BT_Cancelar_Click);
            // 
            // BT_Guardar
            // 
            this.BT_Guardar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BT_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_Guardar.Font = new System.Drawing.Font("Tahoma", 8.3F, System.Drawing.FontStyle.Bold);
            this.BT_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("BT_Guardar.Image")));
            this.BT_Guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BT_Guardar.Location = new System.Drawing.Point(472, 23);
            this.BT_Guardar.Name = "BT_Guardar";
            this.BT_Guardar.Size = new System.Drawing.Size(68, 43);
            this.BT_Guardar.TabIndex = 12;
            this.BT_Guardar.Text = "Guardar";
            this.BT_Guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BT_Guardar.UseVisualStyleBackColor = false;
            this.BT_Guardar.Click += new System.EventHandler(this.BT_Guardar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FORM_agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 159);
            this.Controls.Add(this.GB_Profesores);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FORM_agenda";
            this.Text = "Agenda de clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FORM_agenda_FormClosing);
            this.Load += new System.EventHandler(this.FORM_agenda_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ControlesFormularioTeclado_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.GB_Profesores.ResumeLayout(false);
            this.GB_Profesores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSBBuscar;
        private System.Windows.Forms.ToolStripButton TSBAnterior;
        private System.Windows.Forms.ToolStripButton TSBSiguiente;
        private System.Windows.Forms.ToolStripButton TSBBorrar;
        private System.Windows.Forms.ToolStripButton TSBCerrar;
        private System.Windows.Forms.ToolStripButton TSBCodigo;
        private System.Windows.Forms.GroupBox GB_Profesores;
        private System.Windows.Forms.ToolStripButton TSBGuardarAlMover;
        private System.Windows.Forms.ToolStripButton TSBPrimero;
        private System.Windows.Forms.ToolStripButton TSBUltimo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Button BT_Guardar;
        private System.Windows.Forms.Button BT_Cancelar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MiTextBox Nombre;
        private MiTextBox Codigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MiControlCruzado codcurso;
        private MiTextBox telefono;
        private System.Windows.Forms.Label label3;
    }
}