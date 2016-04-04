using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Salva_Peluqueros
{
    public partial class Forumula : Form
    {
        public OleDbConnection Conexion;
        public Forumula()
        {
            InitializeComponent();
        }

        private void Forumula_Load(object sender, EventArgs e)
        {
            richTextBox_formula.Text = "Formula aplicada para conocer el numero de alumnos totales de cada profesor\n\n";
            richTextBox_formula.Text = richTextBox_formula.Text + "*****************************************\n\n";
            if (Conexion.State == ConnectionState.Closed)
            {
                Conexion.Open();
            }
            OleDbDataReader Lector;
            OleDbCommand comando = new OleDbCommand("SELECT * FROM TiposIncidencias",Conexion);
            Lector = comando.ExecuteReader();
            richTextBox_formula.Text = richTextBox_formula.Text + "Formula = ";

            while (Lector.Read())
            {
                richTextBox_formula.Text = richTextBox_formula.Text +"( "+ Lector["Multiplicador"].ToString() +" ) * " + Lector["Nombre"].ToString()+ " + ";
                
            }
            richTextBox_formula.Text = richTextBox_formula.Text.Substring(0, richTextBox_formula.Text.Length - 2);
            richTextBox_formula.Text = richTextBox_formula.Text.Replace("( -1 ) *", "-");
            richTextBox_formula.Text = richTextBox_formula.Text.Replace("+ -", "-");
            richTextBox_formula.Text = richTextBox_formula.Text.Replace("( 1 ) *", "");
        }
    }
}
