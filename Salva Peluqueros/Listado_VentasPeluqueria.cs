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
    public partial class Listado_VentasPeluqueria : Form
    {
        public Listado_VentasPeluqueria()
        {
            InitializeComponent();
        }

        private void Listado_VentasPeluqueria_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'PeluqueriaDataSet.ListadoVentasPeluqueria' Puede moverla o quitarla según sea necesario.
            this.ListadoVentasPeluqueriaTableAdapter.Fill(this.PeluqueriaDataSet.ListadoVentasPeluqueria);

            this.reportViewer1.RefreshReport();
        }
    }
}
