namespace Salva_Peluqueros
{
    partial class FORM_ProductosPeluqueria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_ProductosPeluqueria));
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
            this.cantidadminima = new Salva_Peluqueros.MiTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cantidad = new Salva_Peluqueros.MiTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ubicacionfoto = new Salva_Peluqueros.MiTextBox();
            this.PrecioVenta = new Salva_Peluqueros.MiTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PrecioCompra = new Salva_Peluqueros.MiTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox_imagen = new System.Windows.Forms.PictureBox();
            this.BT_Foto = new System.Windows.Forms.Button();
            this.Nombre = new Salva_Peluqueros.MiTextBox();
            this.Codigo = new Salva_Peluqueros.MiTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_Cancelar = new System.Windows.Forms.Button();
            this.BT_Guardar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip1.SuspendLayout();
            this.GB_Profesores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_imagen)).BeginInit();
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
            this.TSBGuardarAlMover.Image = global::Salva_Peluqueros.Properties.Resources.disk_blue_ok;
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
            this.GB_Profesores.Controls.Add(this.cantidadminima);
            this.GB_Profesores.Controls.Add(this.label6);
            this.GB_Profesores.Controls.Add(this.cantidad);
            this.GB_Profesores.Controls.Add(this.label5);
            this.GB_Profesores.Controls.Add(this.ubicacionfoto);
            this.GB_Profesores.Controls.Add(this.PrecioVenta);
            this.GB_Profesores.Controls.Add(this.label4);
            this.GB_Profesores.Controls.Add(this.PrecioCompra);
            this.GB_Profesores.Controls.Add(this.label3);
            this.GB_Profesores.Controls.Add(this.pictureBox_imagen);
            this.GB_Profesores.Controls.Add(this.BT_Foto);
            this.GB_Profesores.Controls.Add(this.Nombre);
            this.GB_Profesores.Controls.Add(this.Codigo);
            this.GB_Profesores.Controls.Add(this.label2);
            this.GB_Profesores.Controls.Add(this.label1);
            this.GB_Profesores.Controls.Add(this.BT_Cancelar);
            this.GB_Profesores.Controls.Add(this.BT_Guardar);
            this.GB_Profesores.Location = new System.Drawing.Point(12, 48);
            this.GB_Profesores.Name = "GB_Profesores";
            this.GB_Profesores.Size = new System.Drawing.Size(642, 191);
            this.GB_Profesores.TabIndex = 0;
            this.GB_Profesores.TabStop = false;
            this.GB_Profesores.Text = "Datos Alumnos";
            // 
            // cantidadminima
            // 
            this.cantidadminima.CaracteresMaximos = 40;
            this.cantidadminima.CaracteresValidos = Salva_Peluqueros.FiltroCaracteres.Numerico;
            this.cantidadminima.ColorActivo = System.Drawing.Color.LightSteelBlue;
            this.cantidadminima.Location = new System.Drawing.Point(151, 144);
            this.cantidadminima.MaxLength = 40;
            this.cantidadminima.Name = "cantidadminima";
            this.cantidadminima.Size = new System.Drawing.Size(247, 20);
            this.cantidadminima.TabIndex = 65;
            this.cantidadminima.Tag = "N";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(22, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 15);
            this.label6.TabIndex = 66;
            this.label6.Text = "Cantidad mínima";
            // 
            // cantidad
            // 
            this.cantidad.CaracteresMaximos = 40;
            this.cantidad.CaracteresValidos = Salva_Peluqueros.FiltroCaracteres.Numerico;
            this.cantidad.ColorActivo = System.Drawing.Color.LightSteelBlue;
            this.cantidad.Location = new System.Drawing.Point(151, 119);
            this.cantidad.MaxLength = 40;
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(247, 20);
            this.cantidad.TabIndex = 63;
            this.cantidad.Tag = "N";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(22, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 15);
            this.label5.TabIndex = 64;
            this.label5.Text = "Cantidad actual";
            // 
            // ubicacionfoto
            // 
            this.ubicacionfoto.CaracteresMaximos = 255;
            this.ubicacionfoto.ColorActivo = System.Drawing.Color.LightSteelBlue;
            this.ubicacionfoto.Location = new System.Drawing.Point(483, 122);
            this.ubicacionfoto.MaxLength = 255;
            this.ubicacionfoto.Name = "ubicacionfoto";
            this.ubicacionfoto.Size = new System.Drawing.Size(76, 20);
            this.ubicacionfoto.TabIndex = 62;
            this.ubicacionfoto.Visible = false;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.CaracteresMaximos = 40;
            this.PrecioVenta.ColorActivo = System.Drawing.Color.LightSteelBlue;
            this.PrecioVenta.Location = new System.Drawing.Point(151, 95);
            this.PrecioVenta.MaxLength = 40;
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.Size = new System.Drawing.Size(247, 20);
            this.PrecioVenta.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(22, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 15);
            this.label4.TabIndex = 61;
            this.label4.Text = "Precio de venta";
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.CaracteresMaximos = 40;
            this.PrecioCompra.ColorActivo = System.Drawing.Color.LightSteelBlue;
            this.PrecioCompra.Location = new System.Drawing.Point(151, 71);
            this.PrecioCompra.MaxLength = 40;
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.Size = new System.Drawing.Size(247, 20);
            this.PrecioCompra.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(22, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 15);
            this.label3.TabIndex = 59;
            this.label3.Text = "Precio de compra";
            // 
            // pictureBox_imagen
            // 
            this.pictureBox_imagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_imagen.Image = global::Salva_Peluqueros.Properties.Resources.sinfoto;
            this.pictureBox_imagen.Location = new System.Drawing.Point(465, 82);
            this.pictureBox_imagen.Name = "pictureBox_imagen";
            this.pictureBox_imagen.Size = new System.Drawing.Size(121, 98);
            this.pictureBox_imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_imagen.TabIndex = 55;
            this.pictureBox_imagen.TabStop = false;
            // 
            // BT_Foto
            // 
            this.BT_Foto.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BT_Foto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_Foto.Font = new System.Drawing.Font("Tahoma", 8.3F, System.Drawing.FontStyle.Bold);
            this.BT_Foto.Image = global::Salva_Peluqueros.Properties.Resources.photo_portrait;
            this.BT_Foto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BT_Foto.Location = new System.Drawing.Point(564, 19);
            this.BT_Foto.Name = "BT_Foto";
            this.BT_Foto.Size = new System.Drawing.Size(68, 43);
            this.BT_Foto.TabIndex = 14;
            this.BT_Foto.Text = "Foto";
            this.BT_Foto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BT_Foto.UseVisualStyleBackColor = false;
            this.BT_Foto.Click += new System.EventHandler(this.button_foto_Click);
            // 
            // Nombre
            // 
            this.Nombre.CaracteresMaximos = 40;
            this.Nombre.ColorActivo = System.Drawing.Color.LightSteelBlue;
            this.Nombre.Location = new System.Drawing.Point(151, 46);
            this.Nombre.MaxLength = 40;
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(247, 20);
            this.Nombre.TabIndex = 1;
            // 
            // Codigo
            // 
            this.Codigo.ColorActivo = System.Drawing.Color.LightSteelBlue;
            this.Codigo.Location = new System.Drawing.Point(151, 20);
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
            this.BT_Cancelar.Image = global::Salva_Peluqueros.Properties.Resources.disk_blue_error;
            this.BT_Cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BT_Cancelar.Location = new System.Drawing.Point(490, 19);
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
            this.BT_Guardar.Image = global::Salva_Peluqueros.Properties.Resources.save_as;
            this.BT_Guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BT_Guardar.Location = new System.Drawing.Point(416, 19);
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
            // FORM_ProductosPeluqueria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 249);
            this.Controls.Add(this.GB_Profesores);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FORM_ProductosPeluqueria";
            this.Text = "Productos de peluqueria";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FORM_ProductosPeluqueria_FormClosing);
            this.Load += new System.EventHandler(this.FORM_ProductosPeluqueria_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ControlesFormularioTeclado_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.GB_Profesores.ResumeLayout(false);
            this.GB_Profesores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_imagen)).EndInit();
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
        private System.Windows.Forms.Button BT_Foto;
        private System.Windows.Forms.PictureBox pictureBox_imagen;
        private MiTextBox PrecioVenta;
        private System.Windows.Forms.Label label4;
        private MiTextBox PrecioCompra;
        private System.Windows.Forms.Label label3;
        private MiTextBox ubicacionfoto;
        private MiTextBox cantidad;
        private System.Windows.Forms.Label label5;
        private MiTextBox cantidadminima;
        private System.Windows.Forms.Label label6;
    }
}