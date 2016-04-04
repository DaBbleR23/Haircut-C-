using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Salva_Peluqueros
{
    public partial class Listado_StockProductosEstetica : Form
    {
        public Listado_StockProductosEstetica()
        {
            InitializeComponent();
        }

        private void Listado_StockProductosEstetica_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'PeluqueriaDataSet.ProductosEstetica' Puede moverla o quitarla según sea necesario.
            this.ProductosEsteticaTableAdapter.Fill(this.PeluqueriaDataSet.ProductosEstetica);
            // TODO: esta línea de código carga datos en la tabla 'PeluqueriaDataSet.ListadoVentasEstetica' Puede moverla o quitarla según sea necesario.
            this.ListadoVentasEsteticaTableAdapter.Fill(this.PeluqueriaDataSet.ListadoVentasEstetica);

            this.reportViewer1.RefreshReport();
        }
    }
}
