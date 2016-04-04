using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace Salva_Peluqueros
{
    public partial class FORM_SPLASH : Form
    {
        public string UbicacionBDBuena;
        public bool correcto;
        public FORM_SPLASH()
        {
            InitializeComponent();
            
        }

        private void FORM_SPLASH_Load(object sender, EventArgs e)
        {
            correcto = true;
            LB_NomEquipo.Text = LB_NomEquipo.Text + Environment.MachineName;
            LB_NomUsuario.Text = LB_NomUsuario.Text + Environment.UserName;
            LB_VersionSO.Text = LB_VersionSO.Text + Environment.OSVersion.ToString().Substring(0,25)+"...";
            this.CenterToScreen();
            timer1.Interval = 3000;
            timer1.Start();
        }

        private void ExisteBD()
        {
            timer1.Stop();

            if (!File.Exists(Salva_Peluqueros.Properties.Settings.Default.UbicacionBD))
            {
                SeleccionarUbicacionBD();
            }
            else
            {
                this.UbicacionBDBuena = Salva_Peluqueros.Properties.Settings.Default.UbicacionBD;
            }
        }
        private void SeleccionarUbicacionBD()
        {
            this.TopMost = false;
            FORM_SeleccionarUbicacionBD form = new FORM_SeleccionarUbicacionBD();            
            form.guardar = true;
            form.ShowDialog();
            this.correcto = form.correcto;
            this.UbicacionBDBuena = form.UbicacionBDBuena;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            ExisteBD();
            this.Close();
        }

        private void FORM_SPLASH_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                SeleccionarUbicacionBD();
            }
            else
            {
                timer1_Tick(null, null);
            }
        }


    }
}
