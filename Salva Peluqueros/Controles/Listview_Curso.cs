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
    public partial class Listview_Curso : ListView
    {
        private OleDbConnection _conexion;

        public OleDbConnection Conexion
        {
            get { return _conexion; }
            set { _conexion = value; }
        }
        private string _codigocurso;

        public string Codigocurso
        {
            get { return _codigocurso; }
            set { _codigocurso = value; }
        }


        public Listview_Curso()
        {
            InitializeComponent();
            this.View = View.Details;
            this.GridLines = true;
            this.HideSelection = false;
            this.MultiSelect = true;
            this.FullRowSelect = true;

            // Añadir al formulario que contiene el Listview en el constructor del Formulario
            miOrdenadordeColumnas = new OrdenaListView();
            this.ListViewItemSorter = miOrdenadordeColumnas;
            miOrdenadordeColumnas.SortColumn = 0;
            miOrdenadordeColumnas.Order = SortOrder.Ascending;


            this.ColumnClick += new ColumnClickEventHandler(Listview_Curso_ColumnClick);
           
            
            
        }
        // Añadir al formulario que contiene el Listview. Objeto con visibilidad GLOBAL
        OrdenaListView miOrdenadordeColumnas;

        void Listview_Curso_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            this.SelectedItems.Clear();
            if (e.Column == miOrdenadordeColumnas.SortColumn)
            {
                // Invierte el sentido de la ordenacion
                if (miOrdenadordeColumnas.Order == SortOrder.Ascending)
                {
                    miOrdenadordeColumnas.Order = SortOrder.Descending;
                }
                else
                {
                    miOrdenadordeColumnas.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Selecciona la columna a ordenar asignando ordación ascendente por defecto
                miOrdenadordeColumnas.SortColumn = e.Column;
                miOrdenadordeColumnas.Order = SortOrder.Ascending;
            }

            // Ordena el Listview
            this.Sort();
        }
        public void CrearColumnasLV()
        {
            this.Columns.Add("Nombre");
            this.Columns.Add("DNI");
            this.Columns.Add("Codigo");

            RedimensionarColumnas();
        }
        private void RedimensionarColumnas()
        {
            this.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            this.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            this.Columns[this.Columns.Count - 1].Width = 0;
        }

        public void RellenarLV(string codigocurso)
        {
            if (codigocurso != "")
            {
                CrearColumnasLV();

                ConectarDB();
                OleDbCommand Comando = new OleDbCommand();
                OleDbDataReader Lector;
                Comando.Connection = _conexion;
                Comando.CommandText = "SELECT Alumnos.Nombre as NombreAlumno, Alumnos.DNI as DNIAlumno, Alumnos.Codigo as Codigo FROM ALUMNOS WHERE Alumnos.CodCurso=" + codigocurso + ";";


                Lector = Comando.ExecuteReader();
                ListViewItem aux;
                while (Lector.Read())
                {
                    aux = this.Items.Add(Lector["NombreAlumno"].ToString());
                    aux.SubItems.Add(Lector["DNIAlumno"].ToString());
                    aux.SubItems.Add(Lector["Codigo"].ToString());


                }
                RedimensionarColumnas();
            }
        }
        private void ConectarDB()
        {
            if (_conexion.State == ConnectionState.Closed)
                _conexion.Open();
        }
        
    }
}
