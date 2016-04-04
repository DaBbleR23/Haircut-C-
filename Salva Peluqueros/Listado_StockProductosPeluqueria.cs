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
    public partial class Listado_StockProductosPeluqueria : Form
    {
        public Listado_StockProductosPeluqueria()
        {
            InitializeComponent();
        }

        private void Listado_StockProductosPeluqueria_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'PeluqueriaDataSet.ProductosPeluqueria' Puede moverla o quitarla según sea necesario.
            this.ProductosPeluqueriaTableAdapter.Fill(this.PeluqueriaDataSet.ProductosPeluqueria);
            // TODO: esta línea de código carga datos en la tabla 'PeluqueriaDataSet.ProductosPeluqueria' Puede moverla o quitarla según sea necesario.
            this.reportViewer1.RefreshReport();
        }
    }
}
