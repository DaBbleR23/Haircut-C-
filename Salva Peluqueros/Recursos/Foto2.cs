using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Salva_Peluqueros.Recursos
{
    
    public partial class Foto2 : Form
    {
        public string ubicacionfoto;
        public Image imageninicial;
        public string carpetafotos;
        public string codigoproducto;
        public Foto2()
        {
            InitializeComponent();
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog a = new OpenFileDialog();
            a.Filter = "Archivos de Imagen (*.jpg)|*.jpg";
            if (a.ShowDialog() == DialogResult.OK)
            {
                PB_imagen.ImageLocation = a.FileName;
                tb_ubicacion.Text = a.FileName;
            }
        }

        private void BT_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (PB_imagen.ImageLocation != "")
            {
                ubicacionfoto = PB_imagen.ImageLocation;
                if(!Directory.Exists(carpetafotos))
                {
                Directory.CreateDirectory(carpetafotos);
                }
                if(File.Exists(carpetafotos+@"\"+codigoproducto+ubicacionfoto.Substring(ubicacionfoto.Length-4)))
                {
                    File.Delete(carpetafotos+@"\"+codigoproducto+ubicacionfoto.Substring(ubicacionfoto.Length-4));
                }
                File.Copy(ubicacionfoto, carpetafotos+@"\"+codigoproducto+ubicacionfoto.Substring(ubicacionfoto.Length-4));
            }
            this.Close();
        }

        private void Foto2_Load(object sender, EventArgs e)
        {
            PB_imagen.Image = imageninicial;
            this.CenterToScreen();

        }




    }
}
