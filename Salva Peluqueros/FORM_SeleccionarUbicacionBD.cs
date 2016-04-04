using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Configuration;


namespace Salva_Peluqueros
{
    public partial class FORM_SeleccionarUbicacionBD : Form
    {
        public bool correcto;
        public string UbicacionBDBuena;
        public bool guardar;

        public FORM_SeleccionarUbicacionBD()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Base de datos de Academia | *.mdb";
            openFileDialog1.FileName = "academia.mdb";
            openFileDialog1.ShowDialog();
            TB_RUTA.Text = openFileDialog1.FileName;
        }

        private void TB_Aceptar_Click(object sender, EventArgs e)
        {
            if(File.Exists(TB_RUTA.Text))
            {
                UbicacionBDBuena = TB_RUTA.Text;
                if (guardar == true)
                {
                    ModificarConfig();
                }
                this.Close();
            }
            else
            {
                
                if(TB_RUTA.Text!="")
                {
                    MessageBox.Show("Error al localizar bd", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        private void ModificarConfig()
        {

            Salva_Peluqueros.Properties.Settings.Default.UbicacionBD = UbicacionBDBuena;
            Salva_Peluqueros.Properties.Settings.Default.Save();

        }
        private void FORM_SeleccionarUbicacionBD_Load(object sender, EventArgs e)
        {
            correcto = true;
            this.TopMost = true;
            CenterToScreen();
        }

   

        private void FORM_SeleccionarUbicacionBD_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!File.Exists(TB_RUTA.Text))
            {
                MessageBox.Show("Error no se encontró base de datos, la aplicación se cerrará.", "Error al localizar base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                correcto = false;
                this.Close();
            }

        }
    }
}
