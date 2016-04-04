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
    public partial class Form_Ventas : Form
    {
        public string ubicacion;
        public int cantidadaresaltar = 3;
        public string tabla;
        public string carpetafotos;
        public OleDbConnection Conexion;
        public string tablaventas;
        public string tituloventana;
        public Form_Ventas()
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
               
                //if (int.Parse(Lector["Cantidad"].ToString()) < int.Parse(Lector["cantidadminima"].ToString()))
                //{
                //    LV_Productos.Items[i].BackColor = Color.RosyBrown;
                //}
                i++;
            }


        }

        private void Form_ComprasPeluqueria_Load(object sender, EventArgs e)
        {
            this.Text = tituloventana;
            DT_FechaVenta.Value = DateTime.Now;
            Conectarbasededatos(); 
            RellenarListView();
        }

        private void LV_Productos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LV_Productos.SelectedItems.Count > 0)
            {
                RellenarDatos();
                
                //if (int.Parse(tb_Cantidadrecomendada.Text) > 0)
                //{
                //    TB_CantidadComprar.Text = tb_Cantidadrecomendada.Text;
                //}
                //else
                //{
                //    TB_CantidadComprar.Text = "";
                //}
                GB_DatosProductoSeleccionado.Enabled = true;
                GB_DatosDeCompra.Enabled = true;
            }
            else
            {
                GB_DatosProductoSeleccionado.Enabled = false;
                GB_DatosDeCompra.Enabled = false;
            }
        }
        //void RellenarCantidadRecomendadaCompra()
        //{
        //     OleDbDataReader Lector;
        //    OleDbCommand comando = new OleDbCommand("SELECT * FROM " + tabla + " WHERE Codigo='"+LV_Productos.SelectedItems[0].SubItems[LV_Productos.Columns.Count-1].Text+"';");
        //    comando.Connection = Conexion;
        //    Lector = comando.ExecuteReader();
        //    if (Lector.Read())
        //    {
        //        if (int.Parse(Lector["Cantidad"].ToString()) < int.Parse(Lector["cantidadminima"].ToString()))
        //        {
        //            tb_Cantidadrecomendada.Text = (int.Parse(Lector["cantidadminima"].ToString()) - int.Parse(Lector["Cantidad"].ToString())).ToString();
        //        }
        //        else
        //        {
        //            tb_Cantidadrecomendada.Text = "0";
        //        }
                

        //    }

        //}
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
        void RellenarDatosModificando()
        {
            OleDbDataReader Lector;
            OleDbCommand comando = new OleDbCommand("SELECT * FROM " + tabla + " WHERE Codigo='" + LV_Ventas.SelectedItems[0].SubItems[LV_Productos.Columns.Count - 1].Text + "';");
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
            
            while (encontrado == false && i<LV_Ventas.Items.Count)
            {


                if (LV_Ventas.Items[i].SubItems[LV_Ventas.Items[i].SubItems.Count - 1].Text == Codigo.Text && DT_FechaVenta.Value.ToShortDateString() == LV_Ventas.Items[i].SubItems[LV_Ventas.Items[i].SubItems.Count - 2].Text)
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

                if (TB_CantidadVender.Text != "")
                {
                    if (int.Parse(Cantidad.Text) >= int.Parse(TB_CantidadVender.Text))
                    {
                    if (TB_CantidadVender.Text != "0")
                    {
                        int j = BuscarDuplicado();
                        if (j >= 0)
                        {
                            LV_Ventas.Items[j].SubItems[3].Text = (int.Parse(LV_Ventas.Items[j].SubItems[3].Text) + int.Parse(TB_CantidadVender.Text)).ToString();
                        }
                        else
                        {
                            LV_Ventas.Sorting = SortOrder.None;
                            LV_Ventas.Items.Add(Nombre.Text);
                            LV_Ventas.Items[LV_Ventas.Items.Count - 1].SubItems.Add(PrecioCompra.Text);
                            LV_Ventas.Items[LV_Ventas.Items.Count - 1].SubItems.Add(PrecioVenta.Text);
                            LV_Ventas.Items[LV_Ventas.Items.Count - 1].SubItems.Add(TB_CantidadVender.Text);
                            LV_Ventas.Items[LV_Ventas.Items.Count - 1].SubItems.Add(DT_FechaVenta.Value.ToShortDateString());
                            LV_Ventas.Items[LV_Ventas.Items.Count - 1].SubItems.Add(Codigo.Text);
                            LV_Ventas.Sorting = SortOrder.Ascending;
                        }
                        LimpiarSeleccionado();
                    }
                    else
                    {
                        MessageBox.Show("La cantidad a vender debe ser mayor a 0", "La cantidad a vender es 0", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                                      else
                     {
                   MessageBox.Show("No se puede vender más de la cantidad disponible", "Error cantidad venta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                   TB_CantidadVender.Text = Cantidad.Text;
                      }

                   }
                else
                {

                    MessageBox.Show("Rellene la cantidad a vender", "Rellenar cantidad a vender", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                    
                  
            
           
            
            
        }
        private void LimpiarSeleccionado()
        {
            LV_Productos.SelectedIndices.Clear();
            TB_CantidadVender.Text = "";
          // tb_Cantidadrecomendada.Text = "";
        }

        private void LV_Compra_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LV_Ventas.SelectedItems.Count > 0)
            {
                RellenarDatosArticuloComprado();
                RellenarDatosModificando();
                GB_ProductoSeleccionado.Enabled = true;
            }
            else
            {
                GB_ProductoSeleccionado.Enabled = false;
            }
        }   
        private void RellenarDatosArticuloComprado()
        {

            TB_NombreArtVendido.Text = LV_Ventas.SelectedItems[0].Text;
            TB_CantidadArtVendido.Text = LV_Ventas.SelectedItems[0].SubItems[3].Text;
            DT_FechaArtVendido.Value = DateTime.Parse(LV_Ventas.SelectedItems[0].SubItems[4].Text);
        }

        private void BT_Modificar_Click(object sender, EventArgs e)
        {
            if (TB_CantidadArtVendido.Text != "")
            {
                if (TB_CantidadArtVendido.Text != "0")
                {
                    if (int.Parse(TB_CantidadArtVendido.Text) <= int.Parse(Cantidad.Text))
                    {
                        LV_Ventas.SelectedItems[0].SubItems[3].Text = TB_CantidadArtVendido.Text;
                        LV_Ventas.SelectedItems[0].SubItems[4].Text = DT_FechaArtVendido.Value.ToShortDateString();
                        LV_Ventas.SelectedItems.Clear();
                    }
                    else
                        MessageBox.Show("No se puede vender más de la cantidad disponible", "Error cantidad venta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    
                }
                else
                {
                    MessageBox.Show("La cantidad a vender debe ser mayor a 0", "La cantidad a vender es 0", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            else
            {
                MessageBox.Show("Rellene la cantidad a vender", "Rellenar cantidad a vender", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }


        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            if (LV_Ventas.SelectedItems.Count > 0)
            {
                LV_Ventas.SelectedItems[0].Remove();
            }
        }

        private void pictureBox_imagen_EnabledChanged(object sender, EventArgs e)
        {
            pictureBox_imagen.Image = Salva_Peluqueros.Properties.Resources.sinfoto;
        }

            //string CantidadMinima2(string Codigo)
            //{

            //    string cantidaddevolver = "0"; ;
            //     OleDbDataReader Lector;
            //    OleDbCommand comando = new OleDbCommand("SELECT * FROM " + tabla + " WHERE Codigo='"+Codigo+"';");
            //    comando.Connection = Conexion;
            //    Lector = comando.ExecuteReader();
            //    if (Lector.Read())
            //    {
            //        if (int.Parse(Lector["Cantidad"].ToString()) < int.Parse(Lector["cantidadminima"].ToString()))
            //        {
            //            cantidaddevolver = (int.Parse(Lector["cantidadminima"].ToString()) - int.Parse(Lector["Cantidad"].ToString())).ToString();
            //        }
            //        else
            //        {
            //            cantidaddevolver = "0";
            //        }
              

            //    }
            //    return cantidaddevolver;
            //}

            private void BT_LimpiarCompra_Click(object sender, EventArgs e)
            {
                LV_Ventas.Items.Clear();
            }

            private void BT_Refrescar_Click(object sender, EventArgs e)
            {
                LV_Productos.Items.Clear();
                RellenarListView();
            }
            //private void GenerarListaTxT()
            //{
            //    if(!Directory.Exists("Lista de la compra"))
            //    {
            //        Directory.CreateDirectory("Lista de la compra");
            //    }
            //    StreamWriter sw = new StreamWriter(fichero,false);
            //    sw.WriteLine("==============================================================");
            //    sw.WriteLine("        Lista de compra Peluqueria salva (Peluqueria) ");
            //    sw.WriteLine("==============================================================");
            //    sw.WriteLine();
            //    sw.WriteLine("Número".PadRight(15) + "Nombre".PadRight(35) + "Cantidad a comprar");
            //    sw.WriteLine("------".PadRight(15) + "------".PadRight(35) + "------------------");
            //    OleDbCommand comando = new OleDbCommand();
            //    OleDbDataReader Lector;
            //    comando.Connection = Conexion;
            //    comando.CommandText = "SELECT B.Codigo as Codigo,B.Nombre as Nombre,B.PrecioCompra as PrecioCompra,A.Cantidad as CantidadComprada, A.Linea as Linea FROM UltimaCompraPeluqueria A INNER JOIN ProductosPeluqueria B ON A.codigo=B.codigo";
            //    Lector = comando.ExecuteReader();
            //    int aux;
            //    while (Lector.Read())
            //    {
            //        if (int.Parse(Lector["CantidadComprada"].ToString()) < 10)
            //        {
            //            aux = 45;
            //        }
            //        else
            //        {
            //            aux = 44;
            //        }
            //        sw.WriteLine(Lector["linea"].ToString() + ".-".PadRight(13) + Lector["Nombre"].ToString().PadRight(aux) + Lector["CantidadComprada"].ToString());
            //    }
            //    sw.Close();
            //}

            private void BT_GenerarCompra_Click(object sender, EventArgs e)
            {
                if (LV_Ventas.Items.Count > 0)
                {
                    OleDbCommand comando = new OleDbCommand();
                    comando.Connection = Conexion;
                   // comando.CommandText = "DELETE FROM " + tablaventas;
                   //  comando.ExecuteNonQuery();

                    for (int i = 0; i < LV_Ventas.Items.Count; i++)
                    {
                        int aux;
                        comando = new OleDbCommand("INSERT INTO " + tablaventas + " (Codigo,Fecha,Cantidad,PrecioVenta) VALUES ('" + LV_Ventas.Items[i].SubItems[LV_Ventas.Items[i].SubItems.Count - 1].Text + "',#" + DateTime.Parse(LV_Ventas.Items[i].SubItems[LV_Ventas.Items[i].SubItems.Count - 2].Text).ToShortDateString() + "#,'" + LV_Ventas.Items[i].SubItems[LV_Ventas.Items[i].SubItems.Count - 3].Text + "','"+LV_Ventas.Items[i].SubItems[LV_Ventas.Items[i].SubItems.Count - 4].Text+"')");
                        comando.Connection = Conexion;
                        comando.ExecuteNonQuery();
                        //LV_Compra.Items[i].SubItems[3].Text; Cantidad
                        //LV_Compra.Items[i].SubItems[LV_Compra.Items[i].SubItems.Count-1].Text; Codigo 
                        comando.CommandText = "SELECT cantidad FROM " + tabla + " WHERE codigo='" + LV_Ventas.Items[i].SubItems[LV_Ventas.Items[i].SubItems.Count - 1].Text+"'";
                        aux = int.Parse(comando.ExecuteScalar().ToString());
                        aux = aux - int.Parse(LV_Ventas.Items[i].SubItems[3].Text);
                        comando.CommandText = "UPDATE " + tabla + " SET cantidad=" + aux.ToString() + " WHERE codigo='" + LV_Ventas.Items[i].SubItems[LV_Ventas.Items[i].SubItems.Count - 1].Text + "'";
                        comando.ExecuteNonQuery();
                    }
                    //if (CB_FicheroTexto.Checked)
                    //{
                    //    GenerarListaTxT();
                    //}
                    MessageBox.Show("Venta realizada con éxito", "Venta completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BT_Refrescar.PerformClick();
                    LV_Ventas.Items.Clear();
                  //  Process.Start(fichero);
                }
                else
                {
                    MessageBox.Show("Debe de haber algún producto en la lista de la venta para ser efectuada", "Lista vacia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            
 }












    }
