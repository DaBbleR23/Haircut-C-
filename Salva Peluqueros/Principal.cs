using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Diagnostics;

namespace Salva_Peluqueros
{
    
    public partial class Principal : Form
    {
        OleDbConnection Conexion;
        public string ubicacion;


        public Principal()
        {
            InitializeComponent();
     
        }


        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_ProductosPeluqueria aux = new FORM_ProductosPeluqueria();
            aux.MdiParent = this;
            aux.ubicacion = this.ubicacion;
            aux.Show();
        }
        /// <summary>
        /// Conecta a la base de datos, usa la variable global ubicacion para saber donde está ubicado el archivo
        /// </summary>
        private void Conectarbasededatos()
        {

            Conexion = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + ubicacion + ";Persist Security Info=True");
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();

        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //MostrarSplash
            this.Visible = false;
            FORM_SPLASH formu = new FORM_SPLASH();
            formu.ShowDialog();
            if (formu.correcto == false)
            {

                Application.Exit();

            }

            this.ubicacion = formu.UbicacionBDBuena;
            this.Visible = true;

            //Titulo Academia

            this.Text = "Salva Peluqueros";
            RedimensionarFormulario();
         
        }
        private void RedimensionarFormulario()
        {
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.CenterToScreen();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_agenda aux = new FORM_agenda();
            aux.MdiParent = this;
            aux.ubicacion = this.ubicacion;
            aux.Show();
        }

        private void productosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FORM_ProductosEstetica aux = new FORM_ProductosEstetica();
            aux.MdiParent = this;
            aux.ubicacion = this.ubicacion;
            aux.Show();
        }

        private void comprasDePeluqueriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Compras aux = new Form_Compras();
            aux.fichero = @"Lista de la compra\Peluqueria\lista peluqueria.txt_" + DateTime.Now.ToShortDateString().Replace('/', '-') + ".txt";
            aux.tabla = "ProductosPeluqueria";
            aux.carpetafotos = "Fotos de productos peluqueria";
            aux.tablacompra = "UltimaCompraPeluqueria";
            aux.tituloventana = "Compras Peluqueria";
            aux.seccion = "Peluqueria";
            aux.MdiParent = this;
            aux.ubicacion = this.ubicacion;
            aux.Show();
        }

        private void ventasDePeluqueriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Ventas aux = new Form_Ventas();
            aux.tabla = "ProductosPeluqueria";
            aux.carpetafotos = "Fotos de productos peluqueria";
            aux.tablaventas = "VentasPeluqueria";
            aux.tituloventana = "Ventas peluquería";
            aux.MdiParent = this;
            aux.ubicacion = this.ubicacion;
            aux.Show();
        }

        private void stockDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listado_StockProductosPeluqueria aux = new Listado_StockProductosPeluqueria();
            aux.MdiParent = this;
            aux.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listado_VentasPeluqueria aux = new Listado_VentasPeluqueria();
            aux.MdiParent = this;
            aux.Show();

        }

        private void comprasDeEstéticaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_Compras aux = new Form_Compras();
            aux.fichero = @"Lista de la compra\Estetica\lista estética_" + DateTime.Now.ToShortDateString().Replace('/', '-') + ".txt";
            aux.tabla = "ProductosEstetica";
            aux.carpetafotos = "Fotos de productos estetica";
            aux.tablacompra = "UltimaCompraEstetica";
            aux.tituloventana = "Compras Estetica";
            aux.seccion = "Estetica";
            aux.MdiParent = this;
            aux.ubicacion = this.ubicacion;
            aux.Show();
        }

        private void ventasDeEstéticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Ventas aux = new Form_Ventas();
            aux.tabla = "ProductosEstetica";
            aux.carpetafotos = "Fotos de productos estetica";
            aux.tablaventas = "VentasEstetica";
            aux.tituloventana = "Ventas Estética";
            aux.MdiParent = this;
            aux.ubicacion = this.ubicacion;
            aux.Show();
        }

        private void listasDeLaCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"Lista de la compra\Peluqueria\");
        }

        private void listasDeLaCompraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process.Start(@"Lista de la compra\Estetica\");
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Listado_VentasEstetica aux = new Listado_VentasEstetica();
            aux.MdiParent = this;
            aux.Show();
        }

        private void stockDeProductosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Listado_StockProductosEstetica aux = new Listado_StockProductosEstetica();
            aux.MdiParent = this;
            aux.Show();
        }

        private void Principal_Resize(object sender, EventArgs e)
        {
            RedimensionarFormulario();
        }

        private void Principal_Move(object sender, EventArgs e)
        {
            RedimensionarFormulario();
        }

        private void listadoClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listado_Clientes aux = new Listado_Clientes();
            aux.MdiParent = this;
            aux.Show();
        }




    }
}   
