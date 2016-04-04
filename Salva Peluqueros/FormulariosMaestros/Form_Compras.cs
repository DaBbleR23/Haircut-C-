using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Diagnostics;

namespace Salva_Peluqueros
{
    public partial class Form_Compras : Form
    {
        public string ubicacion;
        public string fichero = @"Lista de la compra\lista peluqueria.txt";
        public int cantidadaresaltar = 3;
        public string tabla = "ProductosPeluqueria";
        public string carpetafotos = "Fotos de productos peluqueria";
        public OleDbConnection Conexion;
        public string tablacompra = "UltimaCompraPeluqueria";
        public string tituloventana = "";
        public string seccion = "";//Peluqueria o Estética
        public Form_Compras()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Conecta a la base de datos, usa la variable global ubicacion para saber donde está ubicado el archivo
        /// </summary>
        private void Conectarbasededatos()
        {
            Conexion = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + ubicacion + ";Persist Security Info=True");
            Conexion.Open();
        }
        void RellenarListView()
        {
            OleDbDataReader Lector; 
            OleDbCommand comando = new OleDbCommand("SELECT * FROM "+tabla+";");
            comando.Connection = Conexion;
            Lector = comando.ExecuteReader();
            int i = 0;
           
            while (Lector.Read())
            {
                LV_Productos.Items.Add(Lector["Nombre"].ToString());
                LV_Productos.Items[i].SubItems.Add(Lector["PrecioCompra"].ToString());
                LV_Productos.Items[i].SubItems.Add(Lector["PrecioVenta"].ToString());
                LV_Productos.Items[i].SubItems.Add(Lector["Cantidad"].ToString());
                LV_Productos.Items[i].SubItems.Add(Lector["Codigo"].ToString());
               
                if (int.Parse(Lector["Cantidad"].ToString()) < int.Parse(Lector["cantidadminima"].ToString()))
                {
                    LV_Productos.Items[i].BackColor = Color.RosyBrown;
                }
                i++;
            }


        }

        private void Form_ComprasPeluqueria_Load(object sender, EventArgs e)
        {
            this.Text = tituloventana;
            Conectarbasededatos(); 
            RellenarListView();
        }

        private void LV_Productos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LV_Productos.SelectedItems.Count > 0)
            {
                RellenarDatos();
                RellenarCantidadRecomendadaCompra();
                if (int.Parse(tb_Cantidadrecomendada.Text) > 0)
                {
                    TB_CantidadComprar.Text = tb_Cantidadrecomendada.Text;
                }
                else
                {
                    TB_CantidadComprar.Text = "";
                }
                GB_DatosProductoSeleccionado.Enabled = true;
                GB_DatosDeCompra.Enabled = true;
            }
            else
            {
                GB_DatosProductoSeleccionado.Enabled = false;
                GB_DatosDeCompra.Enabled = false;
            }
        }
        void RellenarCantidadRecomendadaCompra()
        {
             OleDbDataReader Lector;
            OleDbCommand comando = new OleDbCommand("SELECT * FROM " + tabla + " WHERE Codigo='"+LV_Productos.SelectedItems[0].SubItems[LV_Productos.Columns.Count-1].Text+"';");
            comando.Connection = Conexion;
            Lector = comando.ExecuteReader();
            if (Lector.Read())
            {
                if (int.Parse(Lector["Cantidad"].ToString()) < int.Parse(Lector["cantidadminima"].ToString()))
                {
                    tb_Cantidadrecomendada.Text = (int.Parse(Lector["cantidadminima"].ToString()) - int.Parse(Lector["Cantidad"].ToString())).ToString();
                }
                else
                {
                    tb_Cantidadrecomendada.Text = "0";
                }
                

            }

        }
        void RellenarDatos()
        {
            OleDbDataReader Lector;
            OleDbCommand comando = new OleDbCommand("SELECT * FROM " + tabla + " WHERE Codigo='"+LV_Productos.SelectedItems[0].SubItems[LV_Productos.Columns.Count-1].Text+"';");
            comando.Connection = Conexion;
            Lector = comando.ExecuteReader();
            if (Lector.Read())
            {
                Codigo.Text = Lector["Codigo"].ToString();
                Nombre.Text = Lector["Nombre"].ToString();
                PrecioCompra.Text = Lector["PrecioCompra"].ToString();
                PrecioVenta.Text = Lector["PrecioVenta"].ToString();
                Cantidad.Text = Lector["Cantidad"].ToString();
                cantidadminima.Text = Lector["Cantidadminima"].ToString();
                CargarFoto(Codigo.Text);
            }

        }
        void CargarFoto(string codigo)
        {
            pictureBox_imagen.Enabled = true;
            if (File.Exists(carpetafotos + @"\" + codigo + ".jpg"))
            {
                pictureBox_imagen.ImageLocation = carpetafotos + @"\" + codigo + ".jpg";
            }
            else
            {
                pictureBox_imagen.Image = global::Salva_Peluqueros.Properties.Resources.sinfoto;
            }
        }

        private int BuscarDuplicado()
        {
            
            int i = 0;
            int j = -1;
            bool encontrado = false;
            
            while (encontrado == false && i<LV_Compra.Items.Count)
            {
                
               
                    if (LV_Compra.Items[i].SubItems[LV_Compra.Items[i].SubItems.Count-1].Text == Codigo.Text)
                    {
                        encontrado = true;
                        j = i;
                    }
                    else
                    {
                        i++;
                    }
                
              
                
            }
            return j;
        }
        private void BT_Agregar_Click(object sender, EventArgs e)
        {
            
            if (TB_CantidadComprar.Text != "")
            {
                if (TB_CantidadComprar.Text != "0")
                {
                    int j = BuscarDuplicado();
                    if ( j >= 0)
                    {
                        LV_Compra.Items[j].SubItems[3].Text = (int.Parse(LV_Compra.Items[j].SubItems[3].Text) + int.Parse(TB_CantidadComprar.Text)).ToString();
                    }
                    else
                    {
                        LV_Compra.Sorting = SortOrder.None;
                        LV_Compra.Items.Add(Nombre.Text);
                        LV_Compra.Items[LV_Compra.Items.Count - 1].SubItems.Add(PrecioCompra.Text);
                        LV_Compra.Items[LV_Compra.Items.Count - 1].SubItems.Add(PrecioVenta.Text);
                        LV_Compra.Items[LV_Compra.Items.Count - 1].SubItems.Add(TB_CantidadComprar.Text);
                        LV_Compra.Items[LV_Compra.Items.Count - 1].SubItems.Add(Codigo.Text);
                        LV_Compra.Sorting = SortOrder.Ascending;
                    }
                    LimpiarSeleccionado();
                }
                else
                {
                    MessageBox.Show("La cantidad a comprar debe ser mayor a 0", "La cantidad a comprar es 0", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            else
            {
                MessageBox.Show("Rellene la cantidad a comprar", "Rellenar cantidad a comprar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void LimpiarSeleccionado()
        {
            LV_Productos.SelectedIndices.Clear();
            TB_CantidadComprar.Text = "";
            tb_Cantidadrecomendada.Text = "";
        }

        private void LV_Compra_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LV_Compra.SelectedItems.Count > 0)
            {
                RellenarDatosArticuloComprado();
                GB_ProductoSeleccionado.Enabled = true;
            }
            else
            {
                GB_ProductoSeleccionado.Enabled = false;
            }
        }
        private void RellenarDatosArticuloComprado()
        {

            TB_NombreArtComprado.Text = LV_Compra.SelectedItems[0].Text;
            TB_CantidadArtComprado.Text = LV_Compra.SelectedItems[0].SubItems[3].Text;
        }

        private void BT_Modificar_Click(object sender, EventArgs e)
        {
            if (TB_CantidadArtComprado.Text != "")
            {
                if (TB_CantidadArtComprado.Text != "0")
                {
                    LV_Compra.SelectedItems[0].SubItems[3].Text = TB_CantidadArtComprado.Text;
                    LV_Compra.SelectedItems.Clear();
                }
                else
                {
                    MessageBox.Show("La cantidad a comprar debe ser mayor a 0", "La cantidad a comprar es 0", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            else
            {
                MessageBox.Show("Rellene la cantidad a comprar", "Rellenar cantidad a comprar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }


        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            if (LV_Compra.SelectedItems.Count > 0)
            {
                LV_Compra.SelectedItems[0].Remove();
            }
        }

        private void pictureBox_imagen_EnabledChanged(object sender, EventArgs e)
        {
            pictureBox_imagen.Image = Salva_Peluqueros.Properties.Resources.sinfoto;
        }

        private void BT_ListaAutomatica_Click(object sender, EventArgs e)
        {
            bool creada = false;
            if (LV_Compra.Items.Count != 0)
            {
                MessageBox.Show("La lista de la compra debe estar vacia para poder generar la lista automáticamente", "Lista automática", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                    string aux2;
                   
                    for (int i = 0; i < LV_Productos.Items.Count; i++)
                    {
                        aux2 = "0";
                        aux2 = (int.Parse(CantidadMinima2(LV_Productos.Items[i].SubItems[LV_Productos.Columns.Count - 1].Text))).ToString();
                        if (int.Parse(aux2) > 0)
                        {
                            creada = true;
                            LV_Compra.Items.Add(LV_Productos.Items[i].SubItems[0].Text);
                            LV_Compra.Items[LV_Compra.Items.Count - 1].SubItems.Add(LV_Productos.Items[i].SubItems[1].Text);
                            LV_Compra.Items[LV_Compra.Items.Count - 1].SubItems.Add(LV_Productos.Items[i].SubItems[2].Text);
                            LV_Compra.Items[LV_Compra.Items.Count - 1].SubItems.Add(aux2.ToString());
                            LV_Compra.Items[LV_Compra.Items.Count - 1].SubItems.Add(LV_Productos.Items[i].SubItems[4].Text);
                    
                        }
                    }
                    if (!creada)
                        MessageBox.Show("Todos los productos están por encima de la cantidad mínima, no se generó lista automática de la compra", "Lista no generada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
              

            }
        }
            string CantidadMinima2(string Codigo)
            {

                string cantidaddevolver = "0"; ;
                 OleDbDataReader Lector;
                OleDbCommand comando = new OleDbCommand("SELECT * FROM " + tabla + " WHERE Codigo='"+Codigo+"';");
                comando.Connection = Conexion;
                Lector = comando.ExecuteReader();
                if (Lector.Read())
                {
                    if (int.Parse(Lector["Cantidad"].ToString()) < int.Parse(Lector["cantidadminima"].ToString()))
                    {
                        cantidaddevolver = (int.Parse(Lector["cantidadminima"].ToString()) - int.Parse(Lector["Cantidad"].ToString())).ToString();
                    }
                    else
                    {
                        cantidaddevolver = "0";
                    }
              

                }
                return cantidaddevolver;
            }

            private void BT_LimpiarCompra_Click(object sender, EventArgs e)
            {
                LV_Compra.Items.Clear();
            }

            private void BT_Refrescar_Click(object sender, EventArgs e)
            {
                LV_Productos.Items.Clear();
                RellenarListView();
            }
            private void GenerarListaTxT()
            {
                if (!Directory.Exists(fichero.Substring(fichero.LastIndexOf('\\'))))
                {
                    Directory.CreateDirectory(fichero.Substring(fichero.LastIndexOf('\\')));
                }
                StreamWriter sw = new StreamWriter(fichero,false);
                sw.WriteLine("==============================================================");
                sw.WriteLine("        Lista de compra "+seccion+" Salva ( "+seccion+" )");
                sw.WriteLine("==============================================================");
                sw.WriteLine();
                sw.WriteLine("Número".PadRight(15) + "Nombre".PadRight(35) + "Cantidad a comprar".PadRight(20) + "Coste");
                sw.WriteLine("------".PadRight(15) + "------".PadRight(35) + "------------------".PadRight(20) + "-----");
                OleDbCommand comando = new OleDbCommand();
                OleDbDataReader Lector;
                comando.Connection = Conexion;
                comando.CommandText = "SELECT B.Codigo as Codigo,B.Nombre as Nombre,B.PrecioCompra as PrecioCompra,A.Cantidad as CantidadComprada, A.Linea as Linea FROM "+tablacompra+"  A INNER JOIN "+tabla+" B ON A.codigo=B.codigo";
                Lector = comando.ExecuteReader();
                int aux;
                int preciototal = 0;
                while (Lector.Read())
                {
                    if (int.Parse(Lector["CantidadComprada"].ToString()) < 10)
                    {
                        aux = 45;
                    }
                    else
                    {
                        aux = 44;
                    }
                    sw.WriteLine(Lector["linea"].ToString() + ".-".PadRight(13) + Lector["Nombre"].ToString().PadRight(aux) + Lector["CantidadComprada"].ToString().PadRight(12) + Lector["PrecioCompra"].ToString());
                    preciototal = preciototal + (int.Parse(Lector["PrecioCompra"].ToString()) * int.Parse(Lector["CantidadComprada"].ToString()));
                }
                sw.WriteLine();
                sw.WriteLine("____________________");
                sw.WriteLine("Total dinero gastado: " + preciototal);
                sw.Close();
            }

            private void BT_GenerarCompra_Click(object sender, EventArgs e)
            {
                if (LV_Compra.Items.Count > 0)
                {
                    OleDbCommand comando = new OleDbCommand();
                    comando.Connection = Conexion;
                    comando.CommandText = "DELETE FROM " + tablacompra;
                    comando.ExecuteNonQuery();

                    for (int i = 0; i < LV_Compra.Items.Count; i++)
                    {
                        int aux;
                        comando = new OleDbCommand("INSERT INTO " + tablacompra + " (Codigo,Cantidad,Linea,PrecioCompra) VALUES ('" + LV_Compra.Items[i].SubItems[LV_Compra.Items[i].SubItems.Count - 1].Text + "','" + LV_Compra.Items[i].SubItems[3].Text+"','"+ (i+1).ToString() +"','"+LV_Compra.Items[i].SubItems[LV_Compra.Items[i].SubItems.Count - 4].Text+"')");
                        comando.Connection = Conexion;
                        comando.ExecuteNonQuery();
                        //LV_Compra.Items[i].SubItems[3].Text; Cantidad
                        //LV_Compra.Items[i].SubItems[LV_Compra.Items[i].SubItems.Count-1].Text; Codigo 
                        comando.CommandText = "SELECT cantidad FROM " + tabla + " WHERE codigo='" + LV_Compra.Items[i].SubItems[LV_Compra.Items[i].SubItems.Count - 1].Text+"'";
                        aux = int.Parse(comando.ExecuteScalar().ToString());
                        aux = aux + int.Parse(LV_Compra.Items[i].SubItems[3].Text);
                        comando.CommandText = "UPDATE " + tabla + " SET cantidad=" + aux.ToString() + " WHERE codigo='" + LV_Compra.Items[i].SubItems[LV_Compra.Items[i].SubItems.Count - 1].Text + "'";
                        comando.ExecuteNonQuery();
                    }
                    if (CB_FicheroTexto.Checked)
                    {
                        GenerarListaTxT();
                    }
                    MessageBox.Show("Compra realizada con éxito", "Compra completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BT_Refrescar.PerformClick();
                    LV_Compra.Items.Clear();
                    Process.Start(fichero);
                }
                else
                {
                    MessageBox.Show("Debe de haber algún producto en la lista de la compra para efectuar la compra", "Lista vacia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            
 }












    }
