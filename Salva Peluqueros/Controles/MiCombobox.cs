using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Salva_Peluqueros
{
    public partial class MiCombobox : ComboBox
    {
        private List<string> codigos= new List<string>();

        private string _campomostrar;
        private string _campocodigo;
        private OleDbConnection _conexion;
        private string _tabla;
        private string _datoClaveSeleccionado;



        public string Campomostrar
        {
            get { return _campomostrar; }
            set { _campomostrar = value; }
        }
        public string Campocodigo
        {
            get { return _campocodigo; }
            set { _campocodigo = value; }
        }
        public OleDbConnection Conexion
        {
            get { return _conexion; }
            set { _conexion = value; }
        }
        public string Tabla
        {
            get { return _tabla; }
            set { _tabla = value; }
        }
        public string DatoClaveSeleccionado
        {
            get { return _datoClaveSeleccionado; }
            set { _datoClaveSeleccionado = value; }
        }

        protected override void OnSelectedItemChanged(EventArgs e)
        {
            _datoClaveSeleccionado = codigos[this.SelectedIndex].ToString();
            base.OnSelectedItemChanged(e);
        }
        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            _datoClaveSeleccionado = codigos[this.SelectedIndex].ToString();
            base.OnSelectedIndexChanged(e);
        }


        public MiCombobox()
        {
            InitializeComponent();
            
            
        }
        
        public void RellenarComboBox()
        {
            if (_conexion.State == ConnectionState.Closed)
            {
                _conexion.Open();
            }

           OleDbCommand Comando= new OleDbCommand();
           Comando.Connection = _conexion;
            OleDbDataReader Lector;
            Comando.CommandText = "SELECT " + _campomostrar + " FROM " + _tabla;
            Lector = Comando.ExecuteReader();

           while (Lector.Read())
            {
                this.Items.Add(Lector[_campomostrar].ToString());
            }

           RellenarClaves();
        }
        private void RellenarClaves()
        {
            if (_conexion.State == ConnectionState.Closed)
            {
                _conexion.Open();
            }

            OleDbCommand Comando = new OleDbCommand();
            Comando.Connection = _conexion;
            OleDbDataReader Lector;
            Comando.CommandText = "SELECT " + _campocodigo + " FROM " + _tabla;
            Lector = Comando.ExecuteReader();
            while (Lector.Read())
            {
                this.codigos.Add(Lector[_campocodigo].ToString());
            }
        }
        
    }
}
