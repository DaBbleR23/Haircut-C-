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
    public partial class Listado_Clientes : Form
    {
        public Listado_Clientes()
        {
            InitializeComponent();
        }

        private void Listado_Clientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'PeluqueriaDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.ClientesTableAdapter.Fill(this.PeluqueriaDataSet.Clientes);

            this.reportViewer1.RefreshReport();
        }
    }
}
