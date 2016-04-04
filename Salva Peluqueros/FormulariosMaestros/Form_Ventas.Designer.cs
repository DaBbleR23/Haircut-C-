namespace Salva_Peluqueros
{
    partial class Form_Ventas
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
            this.LV_Productos = new System.Windows.Forms.ListView();
            this.NombreLV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrecioCompraLV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrecioVentaLV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CantidadLV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CodigoLV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GB_DatosProductoSeleccionado = new System.Windows.Forms.GroupBox();
            this.pictureBox_imagen = new System.Windows.Forms.PictureBox();
            this.GB_DatosDeCompra = new System.Windows.Forms.GroupBox();
            this.DT_FechaVenta = new System.Windows.Forms.DateTimePicker();
            this.BT_Agregar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GB_ProductoSeleccionado = new System.Windows.Forms.GroupBox();
            this.DT_FechaArtVendido = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.BT_Modificar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LV_Ventas = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BT_Refrescar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BT_GenerarCompra = new System.Windows.Forms.Button();
            this.BT_LimpiarCompra = new System.Windows.Forms.Button();
            this.TB_NombreArtVendido = new Salva_Peluqueros.MiTextBox();
            this.TB_CantidadArtVendido = new Salva_Peluqueros.MiTextBox();
            this.TB_CantidadVender = new Salva_Peluqueros.MiTextBox();
            this.cantidadminima = new Salva_Peluqueros.MiTextBox();
            this.Codigo = new Salva_Peluqueros.MiTextBox();
            this.Nombre = new Salva_Peluqueros.MiTextBox();
            this.Cantidad = new Salva_Peluqueros.MiTextBox();
            this.PrecioCompra = new Salva_Peluqueros.MiTextBox();
            this.PrecioVenta = new Salva_Peluqueros.MiTextBox();
            this.GB_DatosProductoSeleccionado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_imagen)).BeginInit();
            this.GB_DatosDeCompra.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.GB_ProductoSeleccionado.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LV_Productos
            // 
            this.LV_Productos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NombreLV,
            this.PrecioCompraLV,
            this.PrecioVentaLV,
            this.CantidadLV,
            this.CodigoLV});
            this.LV_Productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LV_Productos.FullRowSelect = true;
            this.LV_Productos.GridLines = true;
            this.LV_Productos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LV_Productos.HideSelection = false;
            this.LV_Productos.Location = new System.Drawing.Point(8, 26);
            this.LV_Productos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LV_Productos.MultiSelect = false;
            this.LV_Productos.Name = "LV_Productos";
            this.LV_Productos.Size = new System.Drawing.Size(556, 107);
            this.LV_Productos.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.LV_Productos.TabIndex = 0;
            this.LV_Productos.UseCompatibleStateImageBehavior = false;
            this.LV_Productos.View = System.Windows.Forms.View.Details;
            this.LV_Productos.SelectedIndexChanged += new System.EventHandler(this.LV_Productos_SelectedIndexChanged);
            // 
            // NombreLV
            // 
            this.NombreLV.Text = "Nombre";
            this.NombreLV.Width = 236;
            // 
            // PrecioCompraLV
            // 
            this.PrecioCompraLV.Text = "Precio de compra";
            this.PrecioCompraLV.Width = 99;
            // 
            // PrecioVentaLV
            // 
            this.PrecioVentaLV.Text = "Precio de venta";
            this.PrecioVentaLV.Width = 87;
            // 
            // CantidadLV
            // 
            this.CantidadLV.Text = "Cantidad disponible";
            this.CantidadLV.Width = 105;
            // 
            // CodigoLV
            // 
            this.CodigoLV.Text = "Codigo";
            this.CodigoLV.Width = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(201, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 78;
            this.label6.Text = "Cantidad mínima";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(8, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 76;
            this.label5.Text = "Cantidad actual";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(205, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 74;
            this.label4.Text = "Precio de venta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(6, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 72;
            this.label3.Text = "Precio de compra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(117, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Código";
            // 
            // GB_DatosProductoSeleccionado
            // 
            this.GB_DatosProductoSeleccionado.Controls.Add(this.cantidadminima);
            this.GB_DatosProductoSeleccionado.Controls.Add(this.label2);
            this.GB_DatosProductoSeleccionado.Controls.Add(this.pictureBox_imagen);
            this.GB_DatosProductoSeleccionado.Controls.Add(this.label1);
            this.GB_DatosProductoSeleccionado.Controls.Add(this.Codigo);
            this.GB_DatosProductoSeleccionado.Controls.Add(this.Nombre);
            this.GB_DatosProductoSeleccionado.Controls.Add(this.label6);
            this.GB_DatosProductoSeleccionado.Controls.Add(this.label3);
            this.GB_DatosProductoSeleccionado.Controls.Add(this.Cantidad);
            this.GB_DatosProductoSeleccionado.Controls.Add(this.PrecioCompra);
            this.GB_DatosProductoSeleccionado.Controls.Add(this.label5);
            this.GB_DatosProductoSeleccionado.Controls.Add(this.label4);
            this.GB_DatosProductoSeleccionado.Controls.Add(this.PrecioVenta);
            this.GB_DatosProductoSeleccionado.Enabled = false;
            this.GB_DatosProductoSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_DatosProductoSeleccionado.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.GB_DatosProductoSeleccionado.Location = new System.Drawing.Point(9, 144);
            this.GB_DatosProductoSeleccionado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GB_DatosProductoSeleccionado.Name = "GB_DatosProductoSeleccionado";
            this.GB_DatosProductoSeleccionado.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GB_DatosProductoSeleccionado.Size = new System.Drawing.Size(574, 99);
            this.GB_DatosProductoSeleccionado.TabIndex = 81;
            this.GB_DatosProductoSeleccionado.TabStop = false;
            this.GB_DatosProductoSeleccionado.Text = "Datos del producto seleccionado";
            // 
            // pictureBox_imagen
            // 
            this.pictureBox_imagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_imagen.Image = global::Salva_Peluqueros.Properties.Resources.sinfoto;
            this.pictureBox_imagen.Location = new System.Drawing.Point(449, 12);
            this.pictureBox_imagen.Name = "pictureBox_imagen";
            this.pictureBox_imagen.Size = new System.Drawing.Size(98, 84);
            this.pictureBox_imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_imagen.TabIndex = 79;
            this.pictureBox_imagen.TabStop = false;
            this.pictureBox_imagen.EnabledChanged += new System.EventHandler(this.pictureBox_imagen_EnabledChanged);
            // 
            // GB_DatosDeCompra
            // 
            this.GB_DatosDeCompra.Controls.Add(this.DT_FechaVenta);
            this.GB_DatosDeCompra.Controls.Add(this.BT_Agregar);
            this.GB_DatosDeCompra.Controls.Add(this.label8);
            this.GB_DatosDeCompra.Controls.Add(this.label7);
            this.GB_DatosDeCompra.Controls.Add(this.TB_CantidadVender);
            this.GB_DatosDeCompra.Enabled = false;
            this.GB_DatosDeCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_DatosDeCompra.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.GB_DatosDeCompra.Location = new System.Drawing.Point(9, 243);
            this.GB_DatosDeCompra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GB_DatosDeCompra.Name = "GB_DatosDeCompra";
            this.GB_DatosDeCompra.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GB_DatosDeCompra.Size = new System.Drawing.Size(461, 41);
            this.GB_DatosDeCompra.TabIndex = 82;
            this.GB_DatosDeCompra.TabStop = false;
            this.GB_DatosDeCompra.Text = "Datos del producto seleccionado";
            // 
            // DT_FechaVenta
            // 
            this.DT_FechaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DT_FechaVenta.Location = new System.Drawing.Point(179, 15);
            this.DT_FechaVenta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DT_FechaVenta.Name = "DT_FechaVenta";
            this.DT_FechaVenta.Size = new System.Drawing.Size(191, 20);
            this.DT_FechaVenta.TabIndex = 85;
            // 
            // BT_Agregar
            // 
            this.BT_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Agregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BT_Agregar.Image = global::Salva_Peluqueros.Properties.Resources.add;
            this.BT_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_Agregar.Location = new System.Drawing.Point(374, 11);
            this.BT_Agregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BT_Agregar.Name = "BT_Agregar";
            this.BT_Agregar.Size = new System.Drawing.Size(82, 23);
            this.BT_Agregar.TabIndex = 84;
            this.BT_Agregar.Text = "Añadir";
            this.BT_Agregar.UseVisualStyleBackColor = true;
            this.BT_Agregar.Click += new System.EventHandler(this.BT_Agregar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(137, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 83;
            this.label8.Text = "Fecha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(8, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 81;
            this.label7.Text = "Cantidad vendida";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GB_ProductoSeleccionado);
            this.groupBox2.Controls.Add(this.LV_Ventas);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(9, 283);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(574, 163);
            this.groupBox2.TabIndex = 83;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de productos vendidos";
            // 
            // GB_ProductoSeleccionado
            // 
            this.GB_ProductoSeleccionado.Controls.Add(this.DT_FechaArtVendido);
            this.GB_ProductoSeleccionado.Controls.Add(this.label11);
            this.GB_ProductoSeleccionado.Controls.Add(this.bt_eliminar);
            this.GB_ProductoSeleccionado.Controls.Add(this.TB_NombreArtVendido);
            this.GB_ProductoSeleccionado.Controls.Add(this.BT_Modificar);
            this.GB_ProductoSeleccionado.Controls.Add(this.label9);
            this.GB_ProductoSeleccionado.Controls.Add(this.label10);
            this.GB_ProductoSeleccionado.Controls.Add(this.TB_CantidadArtVendido);
            this.GB_ProductoSeleccionado.Enabled = false;
            this.GB_ProductoSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_ProductoSeleccionado.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.GB_ProductoSeleccionado.Location = new System.Drawing.Point(4, 110);
            this.GB_ProductoSeleccionado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GB_ProductoSeleccionado.Name = "GB_ProductoSeleccionado";
            this.GB_ProductoSeleccionado.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GB_ProductoSeleccionado.Size = new System.Drawing.Size(558, 50);
            this.GB_ProductoSeleccionado.TabIndex = 86;
            this.GB_ProductoSeleccionado.TabStop = false;
            this.GB_ProductoSeleccionado.Text = "Producto seleccionado";
            // 
            // DT_FechaArtVendido
            // 
            this.DT_FechaArtVendido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DT_FechaArtVendido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DT_FechaArtVendido.Location = new System.Drawing.Point(347, 20);
            this.DT_FechaArtVendido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DT_FechaArtVendido.Name = "DT_FechaArtVendido";
            this.DT_FechaArtVendido.Size = new System.Drawing.Size(70, 20);
            this.DT_FechaArtVendido.TabIndex = 87;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(305, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 86;
            this.label11.Text = "Fecha";
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_eliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_eliminar.Location = new System.Drawing.Point(491, 19);
            this.bt_eliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(59, 20);
            this.bt_eliminar.TabIndex = 86;
            this.bt_eliminar.Text = "Eliminar";
            this.bt_eliminar.UseVisualStyleBackColor = true;
            this.bt_eliminar.Click += new System.EventHandler(this.bt_eliminar_Click);
            // 
            // BT_Modificar
            // 
            this.BT_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Modificar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BT_Modificar.Location = new System.Drawing.Point(421, 19);
            this.BT_Modificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BT_Modificar.Name = "BT_Modificar";
            this.BT_Modificar.Size = new System.Drawing.Size(66, 20);
            this.BT_Modificar.TabIndex = 85;
            this.BT_Modificar.Text = "Modificar";
            this.BT_Modificar.UseVisualStyleBackColor = true;
            this.BT_Modificar.Click += new System.EventHandler(this.BT_Modificar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(4, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 82;
            this.label9.Text = "Nombre";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(176, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 84;
            this.label10.Text = "Cantidad vendida";
            // 
            // LV_Ventas
            // 
            this.LV_Ventas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader5});
            this.LV_Ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LV_Ventas.FullRowSelect = true;
            this.LV_Ventas.GridLines = true;
            this.LV_Ventas.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LV_Ventas.HideSelection = false;
            this.LV_Ventas.Location = new System.Drawing.Point(8, 19);
            this.LV_Ventas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LV_Ventas.MultiSelect = false;
            this.LV_Ventas.Name = "LV_Ventas";
            this.LV_Ventas.Size = new System.Drawing.Size(556, 91);
            this.LV_Ventas.TabIndex = 1;
            this.LV_Ventas.UseCompatibleStateImageBehavior = false;
            this.LV_Ventas.View = System.Windows.Forms.View.Details;
            this.LV_Ventas.SelectedIndexChanged += new System.EventHandler(this.LV_Compra_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            this.columnHeader1.Width = 146;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Precio de compra";
            this.columnHeader2.Width = 97;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Precio de venta";
            this.columnHeader3.Width = 87;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cantidad vendida";
            this.columnHeader4.Width = 97;
            // 
            // columnHeader6
            // 
            this.columnHeader6.DisplayIndex = 5;
            this.columnHeader6.Text = "Fecha";
            this.columnHeader6.Width = 103;
            // 
            // columnHeader5
            // 
            this.columnHeader5.DisplayIndex = 4;
            this.columnHeader5.Text = "Codigo";
            this.columnHeader5.Width = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BT_Refrescar);
            this.groupBox3.Controls.Add(this.LV_Productos);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox3.Location = new System.Drawing.Point(9, 3);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(574, 139);
            this.groupBox3.TabIndex = 84;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Disponibilidad actual de productos";
            // 
            // BT_Refrescar
            // 
            this.BT_Refrescar.Image = global::Salva_Peluqueros.Properties.Resources.refresh1;
            this.BT_Refrescar.Location = new System.Drawing.Point(209, -1);
            this.BT_Refrescar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BT_Refrescar.Name = "BT_Refrescar";
            this.BT_Refrescar.Size = new System.Drawing.Size(25, 24);
            this.BT_Refrescar.TabIndex = 1;
            this.BT_Refrescar.UseVisualStyleBackColor = true;
            this.BT_Refrescar.Click += new System.EventHandler(this.BT_Refrescar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BT_GenerarCompra);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(9, 447);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(574, 46);
            this.groupBox1.TabIndex = 85;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Finalización";
            // 
            // BT_GenerarCompra
            // 
            this.BT_GenerarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_GenerarCompra.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BT_GenerarCompra.Image = global::Salva_Peluqueros.Properties.Resources.sell;
            this.BT_GenerarCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_GenerarCompra.Location = new System.Drawing.Point(223, 11);
            this.BT_GenerarCompra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BT_GenerarCompra.Name = "BT_GenerarCompra";
            this.BT_GenerarCompra.Size = new System.Drawing.Size(182, 27);
            this.BT_GenerarCompra.TabIndex = 1;
            this.BT_GenerarCompra.Text = "Hacer efectiva la venta";
            this.BT_GenerarCompra.UseVisualStyleBackColor = true;
            this.BT_GenerarCompra.Click += new System.EventHandler(this.BT_GenerarCompra_Click);
            // 
            // BT_LimpiarCompra
            // 
            this.BT_LimpiarCompra.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BT_LimpiarCompra.Image = global::Salva_Peluqueros.Properties.Resources.delete1;
            this.BT_LimpiarCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_LimpiarCompra.Location = new System.Drawing.Point(473, 255);
            this.BT_LimpiarCompra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BT_LimpiarCompra.Name = "BT_LimpiarCompra";
            this.BT_LimpiarCompra.Size = new System.Drawing.Size(108, 23);
            this.BT_LimpiarCompra.TabIndex = 86;
            this.BT_LimpiarCompra.Text = "Limpiar lista";
            this.BT_LimpiarCompra.UseVisualStyleBackColor = true;
            this.BT_LimpiarCompra.Click += new System.EventHandler(this.BT_LimpiarCompra_Click);
            // 
            // TB_NombreArtVendido
            // 
            this.TB_NombreArtVendido.BackColor = System.Drawing.SystemColors.Window;
            this.TB_NombreArtVendido.CaracteresMaximos = 40;
            this.TB_NombreArtVendido.ColorActivo = System.Drawing.Color.LightSteelBlue;
            this.TB_NombreArtVendido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_NombreArtVendido.Location = new System.Drawing.Point(58, 18);
            this.TB_NombreArtVendido.MaxLength = 40;
            this.TB_NombreArtVendido.Name = "TB_NombreArtVendido";
            this.TB_NombreArtVendido.ReadOnly = true;
            this.TB_NombreArtVendido.Size = new System.Drawing.Size(112, 20);
            this.TB_NombreArtVendido.TabIndex = 81;
            // 
            // TB_CantidadArtVendido
            // 
            this.TB_CantidadArtVendido.BackColor = System.Drawing.SystemColors.Window;
            this.TB_CantidadArtVendido.CaracteresMaximos = 3;
            this.TB_CantidadArtVendido.CaracteresValidos = Salva_Peluqueros.FiltroCaracteres.Numerico;
            this.TB_CantidadArtVendido.ColorActivo = System.Drawing.Color.LightSteelBlue;
            this.TB_CantidadArtVendido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_CantidadArtVendido.Location = new System.Drawing.Point(272, 20);
            this.TB_CantidadArtVendido.MaxLength = 3;
            this.TB_CantidadArtVendido.Name = "TB_CantidadArtVendido";
            this.TB_CantidadArtVendido.Size = new System.Drawing.Size(27, 20);
            this.TB_CantidadArtVendido.TabIndex = 83;
            // 
            // TB_CantidadVender
            // 
            this.TB_CantidadVender.BackColor = System.Drawing.SystemColors.Window;
            this.TB_CantidadVender.CaracteresMaximos = 3;
            this.TB_CantidadVender.CaracteresValidos = Salva_Peluqueros.FiltroCaracteres.Numerico;
            this.TB_CantidadVender.ColorActivo = System.Drawing.Color.LightSteelBlue;
            this.TB_CantidadVender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_CantidadVender.Location = new System.Drawing.Point(104, 15);
            this.TB_CantidadVender.MaxLength = 3;
            this.TB_CantidadVender.Name = "TB_CantidadVender";
            this.TB_CantidadVender.Size = new System.Drawing.Size(27, 20);
            this.TB_CantidadVender.TabIndex = 81;
            // 
            // cantidadminima
            // 
            this.cantidadminima.BackColor = System.Drawing.SystemColors.Window;
            this.cantidadminima.CaracteresMaximos = 40;
            this.cantidadminima.CaracteresValidos = Salva_Peluqueros.FiltroCaracteres.Numerico;
            this.cantidadminima.ColorActivo = System.Drawing.Color.LightSteelBlue;
            this.cantidadminima.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadminima.Location = new System.Drawing.Point(293, 69);
            this.cantidadminima.MaxLength = 40;
            this.cantidadminima.Name = "cantidadminima";
            this.cantidadminima.ReadOnly = true;
            this.cantidadminima.Size = new System.Drawing.Size(108, 20);
            this.cantidadminima.TabIndex = 81;
            this.cantidadminima.Tag = "N";
            // 
            // Codigo
            // 
            this.Codigo.BackColor = System.Drawing.SystemColors.Window;
            this.Codigo.ColorActivo = System.Drawing.Color.LightSteelBlue;
            this.Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codigo.Location = new System.Drawing.Point(51, 19);
            this.Codigo.MaxLength = 10;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Size = new System.Drawing.Size(58, 20);
            this.Codigo.TabIndex = 67;
            // 
            // Nombre
            // 
            this.Nombre.BackColor = System.Drawing.SystemColors.Window;
            this.Nombre.CaracteresMaximos = 40;
            this.Nombre.ColorActivo = System.Drawing.Color.LightSteelBlue;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(167, 19);
            this.Nombre.MaxLength = 40;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Size = new System.Drawing.Size(234, 20);
            this.Nombre.TabIndex = 68;
            // 
            // Cantidad
            // 
            this.Cantidad.BackColor = System.Drawing.SystemColors.Window;
            this.Cantidad.CaracteresMaximos = 40;
            this.Cantidad.CaracteresValidos = Salva_Peluqueros.FiltroCaracteres.Numerico;
            this.Cantidad.ColorActivo = System.Drawing.Color.LightSteelBlue;
            this.Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cantidad.Location = new System.Drawing.Point(102, 66);
            this.Cantidad.MaxLength = 40;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Size = new System.Drawing.Size(91, 20);
            this.Cantidad.TabIndex = 75;
            this.Cantidad.Tag = "N";
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.BackColor = System.Drawing.SystemColors.Window;
            this.PrecioCompra.CaracteresMaximos = 40;
            this.PrecioCompra.ColorActivo = System.Drawing.Color.LightSteelBlue;
            this.PrecioCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioCompra.Location = new System.Drawing.Point(102, 41);
            this.PrecioCompra.MaxLength = 40;
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            this.PrecioCompra.Size = new System.Drawing.Size(91, 20);
            this.PrecioCompra.TabIndex = 71;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.BackColor = System.Drawing.SystemColors.Window;
            this.PrecioVenta.CaracteresMaximos = 40;
            this.PrecioVenta.ColorActivo = System.Drawing.Color.LightSteelBlue;
            this.PrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioVenta.Location = new System.Drawing.Point(293, 44);
            this.PrecioVenta.MaxLength = 40;
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            this.PrecioVenta.Size = new System.Drawing.Size(108, 20);
            this.PrecioVenta.TabIndex = 73;
            // 
            // Form_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 498);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BT_LimpiarCompra);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GB_DatosDeCompra);
            this.Controls.Add(this.GB_DatosProductoSeleccionado);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_Ventas";
            this.Text = "Ventas peluqueria";
            this.Load += new System.EventHandler(this.Form_ComprasPeluqueria_Load);
            this.GB_DatosProductoSeleccionado.ResumeLayout(false);
            this.GB_DatosProductoSeleccionado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_imagen)).EndInit();
            this.GB_DatosDeCompra.ResumeLayout(false);
            this.GB_DatosDeCompra.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.GB_ProductoSeleccionado.ResumeLayout(false);
            this.GB_ProductoSeleccionado.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LV_Productos;
        private System.Windows.Forms.ColumnHeader NombreLV;
        private System.Windows.Forms.ColumnHeader PrecioCompraLV;
        private System.Windows.Forms.ColumnHeader PrecioVentaLV;
        private System.Windows.Forms.ColumnHeader CantidadLV;
        private System.Windows.Forms.ColumnHeader CodigoLV;
     
        private System.Windows.Forms.Label label6;
        private MiTextBox Cantidad;
        private System.Windows.Forms.Label label5;
        private MiTextBox PrecioVenta;
        private System.Windows.Forms.Label label4;
        private MiTextBox PrecioCompra;
        private System.Windows.Forms.Label label3;
        private MiTextBox Nombre;
        private MiTextBox Codigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_imagen;
        private System.Windows.Forms.GroupBox GB_DatosProductoSeleccionado;
        private System.Windows.Forms.GroupBox GB_DatosDeCompra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private MiTextBox TB_CantidadVender;
        private System.Windows.Forms.Button BT_Agregar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView LV_Ventas;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private MiTextBox TB_NombreArtVendido;
        private System.Windows.Forms.GroupBox GB_ProductoSeleccionado;
        private System.Windows.Forms.Button BT_Modificar;
        private System.Windows.Forms.Label label10;
        private MiTextBox TB_CantidadArtVendido;
        private System.Windows.Forms.Button bt_eliminar;
        private System.Windows.Forms.Button BT_LimpiarCompra;
        private System.Windows.Forms.Button BT_Refrescar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BT_GenerarCompra;
        private MiTextBox cantidadminima;
        private System.Windows.Forms.DateTimePicker DT_FechaVenta;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.DateTimePicker DT_FechaArtVendido;
        private System.Windows.Forms.Label label11;
    }
}