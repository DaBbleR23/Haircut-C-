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
    public partial class Listado_VentasEstetica : Form
    {
        public Listado_VentasEstetica()
        {
            InitializeComponent();
        }

        private void Listado_VentasEstetica_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'PeluqueriaDataSet.ListadoVentasEstetica' Puede moverla o quitarla según sea necesario.
            this.ListadoVentasEsteticaTableAdapter.Fill(this.PeluqueriaDataSet.ListadoVentasEstetica);

            this.reportViewer1.RefreshReport();
        }
    }
}
