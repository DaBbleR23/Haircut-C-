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
    public partial class Buscar : Form
    {
        #region Variables
        public string instrcSQL;
        public OleDbConnection Conexion;
        public string tituloventana;
        //Separados por /, el campo con * es el clave,{Entre llaves el titulo}
        public string campos;
        public Control campoclave;
        
        // Añadir al formulario que contiene el Listview. Objeto con visibilidad GLOBAL
        OrdenaListView miOrdenadordeColumnas;


        string[] camposspliteados;
        List<string> titulos= new List<string>();
        List<string> nombredecampos = new List<string>();
        string[] separadorescampos = { "/" };
        string[] separadorestitulos = {"{","}"};
        int ColumnaActiva;
        #endregion

        public Buscar()
        {
            InitializeComponent();
            // Añadir al formulario que contiene el Listview en el constructor del Formulario
            miOrdenadordeColumnas = new OrdenaListView();
            LV_datos.ListViewItemSorter = miOrdenadordeColumnas;
      
        
        }

        private void Buscar_Load(object sender, EventArgs e)
        {
            
            this.Text = tituloventana.ToString();
            ColumnaActiva = 0;

            

            Tratamientodecampos();
            CrearColumnasLV(titulos);
            RellenarColumnasLV();
            ImagenaColumnaActiva(ColumnaActiva);
            RedimensionarColumnas();
            RedimensionarListView();

        }
        private void RedimensionarListView()
        {
            
            int tamañototal = 0;
            foreach (ColumnHeader colu in LV_datos.Columns)
            {
                tamañototal = tamañototal + colu.Width;
            }
            if (LV_datos.Width < tamañototal + 25)
            {
                int diferencia = tamañototal + 25 - LV_datos.Width;
                LV_datos.Width = tamañototal + 25;
                this.Width = this.Width + diferencia;
            }
        }
        private void ImagenaColumnaActiva(int ColActiva)
        {
            for (int i = 0; i < LV_datos.Columns.Count; i++)
            {
                if (i == ColumnaActiva)
                {
                    LV_datos.Columns[i].ImageIndex = 0;
                }
                else
                {
                    LV_datos.Columns[i].ImageIndex = -1;
                }
            }
            RedimensionarColumnas();
         

        }
        private void Tratamientodecampos()
        {
       
            string[] vectoraux;
            

            camposspliteados = campos.Split(separadorescampos,StringSplitOptions.None);
            //Recorremos los campos en busca de llaves
            foreach (String str in camposspliteados)
            {
                if (str.IndexOf("{") > 0)
                {

                    vectoraux = str.Split(separadorestitulos, StringSplitOptions.None);
                    titulos.Add(vectoraux[1]);
                    nombredecampos.Add(vectoraux[0]);
                }
                else
                {
                    titulos.Add(str);
                    nombredecampos.Add(str);
                }

            }

           
        }
        private void CrearColumnasLV(List<string> titulos)
        {
           
            foreach(String str in titulos)
            {
                LV_datos.Columns.Add(str);   
            }
            LV_datos.Columns.Add(campoclave.Name).Width=0;
        
        }
        private void RedimensionarColumnas()
        {
            LV_datos.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            LV_datos.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            LV_datos.Columns[LV_datos.Columns.Count - 1].Width = 0;
        }
        private void RellenarColumnasLV()
        {
            
            OleDbCommand Comando= new OleDbCommand();
            OleDbDataReader Lector;
            ListViewItem lvitem;

            Comando.Connection = Conexion;
            Comando.CommandText = instrcSQL;
            Lector = Comando.ExecuteReader();
            
            while(Lector.Read())
            {
                lvitem = LV_datos.Items.Add(Lector[nombredecampos[0]].ToString());
                

                for (int i = 1; i < nombredecampos.Count; i++)
                {
                    lvitem.SubItems.Add(Lector[nombredecampos[i]].ToString());
                }
                lvitem.SubItems.Add(Lector[campoclave.Name].ToString());
            }
            
        }
        private void LV_datos_DoubleClick(object sender, EventArgs e)
        {
            if (LV_datos.SelectedItems.Count > 0)
            {
                campoclave.Text = LV_datos.SelectedItems[0].SubItems[LV_datos.SelectedItems[0].SubItems.Count - 1].Text;
            }
            this.Close();
        }
        private void BT_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LV_datos_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            

            ColumnaActiva = e.Column;
            ImagenaColumnaActiva(ColumnaActiva);
           
            TB_Contenga.Text = "";
            LV_datos.SelectedItems.Clear();
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
            LV_datos.Sort();

        }

       

        private void BT_BuscarContenga_Click(object sender, EventArgs e)
        {
            LV_datos.Sorting = SortOrder.None;
            
            LV_datos.Items.Clear();
            RellenarColumnasLV();
            foreach (ListViewItem itemlv in LV_datos.Items)
            {
                if (!itemlv.SubItems[ColumnaActiva].Text.ToLower().Contains(TB_Contenga.Text.ToLower()))
                {
                    itemlv.Remove();
                }

            }
            LV_datos.Sorting = SortOrder.Ascending;
        }



    }
}

