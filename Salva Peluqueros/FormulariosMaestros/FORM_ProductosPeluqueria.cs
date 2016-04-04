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

////////////////////////////////////////////////////////////////////////////////////////
//Si en el tag pone D significa que es un DATE si pone N significa que es un INT entero, sino pone nada un string
////////////////////////////////////////////////////////////////////////////////////////

namespace Salva_Peluqueros
{
    public partial class FORM_ProductosPeluqueria : Form
    {


        public FORM_ProductosPeluqueria()
        {
            InitializeComponent();
            
        }

        #region Variables para cambiar (globales)
        //Formulario
        enum Estado {Codigo,Nuevo,Modificando};
        Estado estadoformulario = new Estado();
        string carpetafotos = "Fotos de productos peluqueria";

        //DB
        OleDbConnection Conexion;
        
        string tabla = "ProductosPeluqueria";
        public string ubicacion;
        Control controlclave = new Control();
        List<string> Nombredecampos = new List<string>();
        List<string> ValoresCampos = new List<string>();
        string CampoParaAgregar;
       // int numerocerosaizquierda = 6;
        string SQLBUSQUEDA = "Nombre/PrecioCompra/PrecioVenta";
        string TITULOBUSQUEDA = "Buscar Productos";

        public string Codigoexterno;
        #endregion     

        #region Esqueleto
        private void FORM_ProductosPeluqueria_Load(object sender, EventArgs e)
        {

            estadoformulario = Estado.Codigo;
            this.KeyPreview = true;
            //Asigno el control clave al texbox de codigo
            controlclave = Codigo;
            CambiarEstadoFormulario();
            //Cambio el estado a codigo puesto que esta a la espera de introducir un codigo
            estadoformulario = Estado.Codigo;
            Conectarbasededatos();
            controlclave.Text = Codigoexterno;
            SendKeys.Send("{TAB}");
            controlclave.Focus();
           
        }

        /// <summary>
        /// Rellena todos los controles del formulario
        /// </summary>
        /// <param name="contenedor">This, Formulario que estemos</param>
        private void RellenarFicha(Control contenedor)
        {
            foreach (Control ctrl in contenedor.Controls)
            {
                if (ctrl is TextBox)
                {
                    if ((string)ctrl.Tag != "D")
                    {
                        ctrl.Text = LeerDato(tabla, controlclave.Name, controlclave.Text, ctrl.Name);

                    }
                    else
                    {
                        if ((string)ctrl.Tag == "D")
                        {
                            if ((LeerDato(tabla, controlclave.Name, controlclave.Text, ctrl.Name)).ToString() != "")
                            {
                                ctrl.Text = Convert.ToDateTime(LeerDato(tabla, controlclave.Name, controlclave.Text, ctrl.Name)).ToShortDateString();
                            }
                            else
                            {
                                ctrl.Text = "";
                            }
                        }
                    }
                }                
                if (ctrl.HasChildren)
                {
                    RellenarFicha(ctrl);
                }
            }
        }

        /// <summary>
        /// Lee un campo pasandole el valor de la clave principal
        /// </summary>
        /// <param name="tabla">Nombre de tabla</param>
        /// <param name="nombrecampocodigo">Nombre del campo clave</param>
        /// <param name="valorcampocodigo">Valor del campo clave</param>
        /// <param name="nombrecampoadevolver">Nombre del campo a consultar</param>
        /// <returns></returns>
        private string LeerDato(string tabla, string nombrecampocodigo, string valorcampocodigo, string nombrecampoadevolver)
        {
            OleDbDataReader Lector;
            OleDbCommand Comando = new OleDbCommand();
            Comando.Connection = Conexion;
            Comando.CommandText = "SELECT " + nombrecampoadevolver + " FROM " + tabla + " WHERE " + nombrecampocodigo + "='" + valorcampocodigo + "';";
            Lector = Comando.ExecuteReader();
            Lector.Read();
            return (Lector[nombrecampoadevolver].ToString());
        }

        /// <summary>
        /// Conecta a la base de datos, usa la variable global ubicacion para saber donde está ubicado el archivo
        /// </summary>
        private void Conectarbasededatos()
        {
            Conexion = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + ubicacion + ";Persist Security Info=True");
            Conexion.Open();
        }

        /// <summary>
        /// Comprobar si existe un registro
        /// </summary>
        /// <param name="tabla">tabla</param>
        /// <param name="nombrecampocodigo">Nombre del campo clave</param>
        /// <param name="valorcampocodigo">Valor del campo clave</param>
        /// <returns>TRUE (EXISTE) / FALSE (NO EXISTE)</returns>
        private bool ExisteRegistro(string tabla, string nombrecampocodigo, string valorcampocodigo)
        {
            OleDbDataReader Lector;
            OleDbCommand Comando = new OleDbCommand();
            Comando.Connection = Conexion;
            Comando.CommandText = "SELECT " + nombrecampocodigo + " FROM " + tabla + " WHERE " + nombrecampocodigo + "='" + valorcampocodigo + "';";
            Lector = Comando.ExecuteReader();
            return (Lector.Read());
        }

        private void Código_Leave(object sender, EventArgs e)
        {
      //      codcurso.CambiarNombreTextBoxComoControl();

            if (controlclave.Text != "")
            {
               // controlclave.Text = controlclave.Text.PadLeft(numerocerosaizquierda, '0');
                if (ExisteRegistro(tabla, controlclave.Name, controlclave.Text))
                {
                    RellenarFicha(this);
                    CargarFoto();
                    estadoformulario = Estado.Modificando;
                }
                else
                {
                    estadoformulario = Estado.Nuevo;
                    LimpiezaFormulario(this, true);
                }
            }
            else
            {
                LimpiezaFormulario(this, false);
                estadoformulario = Estado.Codigo;
            }
            CambiarEstadoFormulario();

           // codcurso.CambiarNombreTextBoxOriginal();
            CargarFoto(((TextBox)controlclave).Text);
        }

        private void CambiarEstadoFormulario()
        {

            switch (estadoformulario)
            {
                case Estado.Nuevo:
                    TSBBorrar.Enabled = false;
                   // TSBGuardarAlMover.Enabled = true;
                    BT_Guardar.Enabled = true;
                    BT_Foto.Enabled = true;
                    BT_Cancelar.Enabled = true;
                    HabilitarTodosControles(this);
                    controlclave.Enabled = true;
                    CargarFoto();
                    

                    break;
                case Estado.Modificando:
                    TSBBorrar.Enabled = true;
                   // TSBGuardarAlMover.Enabled = true;
                    BT_Guardar.Enabled = true;
                    BT_Cancelar.Enabled = true;
                    controlclave.Enabled = false;
                    HabilitarTodosControles(this);
                    BT_Foto.Enabled = true;
                    CargarFoto(((TextBox)controlclave).Text);

                    break;
                case Estado.Codigo:
                    //TSBGuardarAlMover.Enabled = false;
                    BT_Guardar.Enabled = false;
                    BT_Cancelar.Enabled = true;
                    TSBBorrar.Enabled = false;
                    DeshabilitarTodosControles(this);
                    controlclave.Enabled = true;
                    BT_Foto.Enabled = false;
                    CargarFoto();
                    break;

            }
        }

        private void DeshabilitarTodosControles(Control contenedor)
        {
            foreach (Control ctrl in contenedor.Controls)
            {
                if (ctrl is TextBox)
                {
                    if (ctrl.Name != controlclave.Name)
                    {
                        ctrl.Enabled = false;
                    }
                }
                if (ctrl.HasChildren)
                {
                    DeshabilitarTodosControles(ctrl);
                }

            }


        }


        private void HabilitarTodosControles(Control contenedor)
        {
            foreach (Control ctrl in contenedor.Controls)
            {
                if (ctrl is TextBox)
                {
                    if (ctrl.Name != controlclave.Name)
                    {
                        ctrl.Enabled = true;
                    }
                }
                if (ctrl.HasChildren)
                {
                    HabilitarTodosControles(ctrl);
                }

            }


        }


        /// <summary>
        /// Devuelve el codigo anterior del codigo actual
        /// </summary>
        /// <param name="tabla">tabla</param>
        /// <param name="nombrecampocodigo">Nombre del campo clave</param>
        /// <param name="valorcampocodigo">valor actual del campo clave</param>
        /// <returns>Valor del codigo anterior del actual</returns>
        private string BuscarCodigoAnterior(string tabla, string nombrecampocodigo, string valorcampocodigo)
        {
            OleDbDataReader Lector;
            OleDbCommand Comando = new OleDbCommand();
            Comando.Connection = Conexion;
            Comando.CommandText = "SELECT " + nombrecampocodigo + " FROM " + tabla + " WHERE " + nombrecampocodigo + "<'" + valorcampocodigo + "' ORDER BY " + nombrecampocodigo + " DESC;";
            Lector = Comando.ExecuteReader();
            if (Lector.Read())
            {
                return (Lector[nombrecampocodigo].ToString());
            }
            else
            {
                return ("-1");
            }
        }

        /// <summary>
        /// Devuelve el primer codigo de la tabla
        /// </summary>
        /// <param name="tabla">tabla</param>
        /// <param name="nombrecampocodigo">Nombre del campo clave</param>
        /// <returns></returns>
        private string BuscarPrimerCodigo(string tabla, string nombrecampocodigo)
        {
            OleDbDataReader Lector;
            OleDbCommand Comando = new OleDbCommand();
            Comando.Connection = Conexion;
            Comando.CommandText = "SELECT " + nombrecampocodigo + " FROM " + tabla + " ORDER BY " + nombrecampocodigo + " ASC;";
            Lector = Comando.ExecuteReader();

            if (Lector.Read())
            {
                return (Lector[nombrecampocodigo].ToString());
            }
            else
            {
                return ("-1");

            }
        }
        private string BuscarCodigoSiguiente(string tabla, string nombrecampocodigo, string valorcampocodigo)
        {
            OleDbDataReader Lector;
            OleDbCommand Comando = new OleDbCommand();
            Comando.Connection = Conexion;
            Comando.CommandText = "SELECT " + nombrecampocodigo + " FROM " + tabla + " WHERE " + nombrecampocodigo + ">'" + valorcampocodigo + "' ORDER BY " + nombrecampocodigo + " ASC;";
            Lector = Comando.ExecuteReader();
            if (Lector.Read())
            {
                return (Lector[nombrecampocodigo].ToString());
            }
            else
            {
                return ("-1");
            }
        }

        private int BuscarUltimoCodigo(string tabla, string nombrecampocodigo)
        {

            OleDbDataReader Lector;
            OleDbCommand Comando = new OleDbCommand();
            Comando.Connection = Conexion;
            Comando.CommandText = "SELECT " + nombrecampocodigo + " FROM " + tabla + " ORDER BY " + nombrecampocodigo + " DESC;";
            Lector = Comando.ExecuteReader();
            if (Lector.Read())
            {
                return (int.Parse(Lector[nombrecampocodigo].ToString()));
            }
            else
            {
                //El numero en el que empieza el codigo 000001
                return (-1);
            }
        }
        private void TSBAnterior_Click(object sender, EventArgs e)
        {
            bool nohayregistros = false;
                estadoformulario = Estado.Codigo;
            CambiarEstadoFormulario();
            string auxstr = "-2";

            if (controlclave.Text != "")
            {
                if (TSBGuardarAlMover.Checked)
                {
                    estadoformulario = Estado.Modificando;
                    GuardarRegistro();
                }
                auxstr = BuscarCodigoAnterior(tabla, controlclave.Name, controlclave.Text);

                //No existe
                if (auxstr == "-1")
                {

                    nohayregistros = true;
                }
                else
                {
                    if (auxstr == "-2")
                    {
                        controlclave.Text = "";
                        nohayregistros = true;
                        MessageBox.Show("No hay más registros en la tabla");
                    }
                    else
                    {
                        controlclave.Text = auxstr;
                        controlclave.Focus();
                        SendKeys.Send("{TAB}");

                    }

                }


            }
            else
            {
                MessageBox.Show("Introduce un codigo para ir al anterior");
            }
            if (nohayregistros)
            {
                estadoformulario = Estado.Modificando;
                CambiarEstadoFormulario();
                controlclave.Focus();
                MessageBox.Show("No hay más registros en la tabla");
            }

        }

        private void TSBSiguiente_Click(object sender, EventArgs e)
        {
            bool nohayregistros = false;
            estadoformulario = Estado.Codigo;
            CambiarEstadoFormulario();
            string auxstr;

            if (controlclave.Text == "")
            {
                TSBPrimero_Click(null, null);
            }
            else
            {
              
                if (TSBGuardarAlMover.Checked)
                {
                    estadoformulario = Estado.Modificando;
                    GuardarRegistro();
                }
                auxstr = BuscarCodigoSiguiente(tabla, controlclave.Name, controlclave.Text);
                if (auxstr != "-1")
                {
                    controlclave.Text = auxstr.ToString();
                    controlclave.Focus();
                    SendKeys.Send("{TAB}");
                }
                else
                {
                    nohayregistros = true;

                }
            }
            if (nohayregistros)
            {

                estadoformulario = Estado.Modificando;
                CambiarEstadoFormulario();
                controlclave.Focus();
                MessageBox.Show("No hay más registros en la tabla");
            }
           
            

        }
        private void TSBPrimero_Click(object sender, EventArgs e)
        {
            bool nohayregistros = false;
            estadoformulario = Estado.Codigo;
            CambiarEstadoFormulario();
            string aux = BuscarPrimerCodigo(tabla, controlclave.Name);
            controlclave.Focus();
            if (aux == "-1")
            {
                LimpiezaFormulario(this, false);
                MessageBox.Show("No hay registros en la tabla");
                nohayregistros = true;
            }
            else
            {
                controlclave.Text = aux;
                controlclave.Focus();
                SendKeys.Send("{TAB}");
            }
            if (!nohayregistros)
            {
                estadoformulario = Estado.Modificando;
                CambiarEstadoFormulario();
                controlclave.Focus();
            }

        }

        private void TSBUltimo_Click(object sender, EventArgs e)
        {
            bool nohayregistros = false;
            estadoformulario = Estado.Codigo;
            CambiarEstadoFormulario();
            int aux = BuscarUltimoCodigo(tabla, controlclave.Name);
            if (aux == -1)
            {
                nohayregistros = true;
                LimpiezaFormulario(this, false);
                MessageBox.Show("No hay registros en la tabla");
            }
            else
            {
                controlclave.Text = aux.ToString();
                controlclave.Focus();
                SendKeys.Send("{TAB}");
            }
            if (!nohayregistros)
            {
                estadoformulario = Estado.Modificando;
                CambiarEstadoFormulario();
                controlclave.Focus();

            }
        }
        private void ControlesFormularioTeclado_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.PageDown:
                    TSBSiguiente.PerformClick();
                    break;
                case Keys.PageUp:
                    TSBAnterior.PerformClick();
                    break;
                case Keys.F3:
                    TSBBuscar.PerformClick();
                    break;
                case Keys.Escape:
                    BT_Cancelar.PerformClick();
                    break;
                case Keys.F1:
                    TSBCodigo.PerformClick();
                    break;
                case Keys.End:
                    TSBUltimo.PerformClick();
                    break;
                case Keys.Home:
                    TSBPrimero.PerformClick();
                    break;                
            }
            //e.Handled = true;
        }
        private void TSBCodigo_Click(object sender, EventArgs e)
        {

           
            int auxint;
            TSBGuardarAlMover.Checked = false;
            auxint = BuscarUltimoCodigo(tabla, controlclave.Name);
            //auxstr = auxstr.TrimStart('0');
            if (auxint == -1)
            {
                auxint = 1;
            }
            else
            {

                auxint++;
            }
            //auxstr = auxint.ToString().PadLeft(numerocerosaizquierda, '0');
            controlclave.Text = auxint.ToString();
            LimpiezaFormulario(this, true);
            estadoformulario = Estado.Nuevo;
            CambiarEstadoFormulario();
            controlclave.Focus();
            SendKeys.Send("{TAB}");
        }

        /// <summary>
        /// Limpiar los controles del formulario
        /// </summary>
        /// <param name="contenedor">This contenedor a limpiar</param>
        /// <param name="conservarcodigo">TRUE PARA CONSERVAR CODIGO, FALSE SI LO QUEREMOS BORRAR</param>
        private void LimpiezaFormulario(Control contenedor, bool conservarcodigo)
        {
            if (!conservarcodigo)
            {
                foreach (Control ctrl in contenedor.Controls)
                {
                    if (ctrl is TextBox)
                    {
                        ctrl.Text = "";
                    }
                    if (ctrl.HasChildren)
                    {
                        LimpiezaFormulario(ctrl, conservarcodigo);
                    }

                }
            }
            else
            {
                foreach (Control ctrl in contenedor.Controls)
                {
                    if (ctrl is TextBox)
                    {
                        if (ctrl.Name != controlclave.Name)
                        {
                            ctrl.Text = "";
                        }
                    }
                    if (ctrl.HasChildren)
                    {
                        LimpiezaFormulario(ctrl, conservarcodigo);
                    }

                }
            }


        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
                //LimpiezaFormulario(this, false);
                //estadoformulario = Estado.Codigo;
                //CambiarEstadoFormulario();
                //controlclave.Focus();
        }

        private void TSBBorrar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("¿Esta seguro de borrar la ficha?", "Borrar Ficha", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                if (ExisteRegistro(tabla, controlclave.Name, controlclave.Text))
                {
                    string direccionfoto = carpetafotos + @"\"+ ((TextBox)controlclave).Text + ".jpg";
                   if(File.Exists(direccionfoto))
                    {
                    File.Delete(direccionfoto);
                    
                    }
                   EliminarRegistro(tabla, controlclave.Name, controlclave.Text);
                    
                }
                BT_Cancelar_Click(null, null);
            }

        }
        private void EliminarRegistro(string tabla, string nombrecampocodigo, string valorcampocodigo)
        {

            OleDbCommand Comando = new OleDbCommand();
            Comando.Connection = Conexion;
            Comando.CommandText = "DELETE FROM " + tabla + " WHERE " + nombrecampocodigo + "='" + valorcampocodigo + "';";
            Comando.ExecuteNonQuery();

        }

        private void BT_Guardar_Click(object sender, EventArgs e)
        {
          //  codcurso.CambiarNombreTextBoxComoControl();
            GuardarRegistro();
            if (!ControlesVacios(this, false))
            BT_Cancelar.PerformClick();
           // codcurso.CambiarNombreTextBoxOriginal();
           
        }

        private void GuardarRegistro()
        {
            if (!ControlesVacios(this, false))
            {
                if (estadoformulario == Estado.Nuevo)
                {

                    Nombredecampos = new List<string>();
                    ValoresCampos = new List<string>();
                    CampoParaAgregar = "";
                    ConstruirSQLNuevo(this);
                    AñadirRegistroNuevo();
                    //LLAMAMOS A AÑADIR RGISTRO

                }
                else
                {
                    if (estadoformulario == Estado.Modificando)
                    {
                        Nombredecampos = new List<string>();
                        ValoresCampos = new List<string>();
                        CampoParaAgregar = "";
                        ConstruirSQLModificando(this);
                        AñadirRegistroModificado();
                    }

                }
            }
            else
            {
                MessageBox.Show("Debe rellenar todos los campos", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AñadirRegistroModificado()
        {
            OleDbCommand Comando = new OleDbCommand();
            Comando.Connection = Conexion;
            Comando.CommandText = "UPDATE " + tabla + CampoParaAgregar + " WHERE " + controlclave.Name + "='" + controlclave.Text + "';";
            Comando.ExecuteNonQuery();
        }

        private void ConstruirSQLModificando(Control contenedor)
        {

            foreach (Control ctrl in contenedor.Controls)
            {
                if (ctrl is TextBox)
                {
                    if ((string)ctrl.Tag == null && ctrl.Name.ToLower() != controlclave.Name.ToLower())
                    {
                        Nombredecampos.Add(ctrl.Name);

                        ValoresCampos.Add("'" + ctrl.Text + "'");
                    }
                    if ((string)ctrl.Tag == "D")
                    {
                        if (ctrl.Text != "")
                        {
                            Nombredecampos.Add(ctrl.Name);
                            ValoresCampos.Add("#" + Convert.ToDateTime(ctrl.Text).ToString("MM-dd-yy") + "#");
                        }
                        else
                        {
                            Nombredecampos.Add(ctrl.Name);
                            ValoresCampos.Add("null");
                        }
                    }
                    else
                    {
                        if ((string)ctrl.Tag == "N")
                        {
                            Nombredecampos.Add(ctrl.Name);

                            ValoresCampos.Add(ctrl.Text);
                        }

                    }
                }
                if (ctrl.HasChildren)
                {
                    ConstruirSQLModificando(ctrl);
                }
            }
            //YA TENEMOS LAS LISTAS CON LOS DATOS DE LOS TEXBOXES Y  LOS VALORES DE CAMPOS
            //GENERAR LA CADENA 
            CampoParaAgregar = " SET ";

            for (int i = 0; i < Nombredecampos.Count; i++)
            {
                CampoParaAgregar = CampoParaAgregar + Nombredecampos[i] + "=" + ValoresCampos[i] + ", ";
            }


            //para eliminar la coma final
            CampoParaAgregar = CampoParaAgregar.Remove(CampoParaAgregar.Length - 2);


        }
        private void AñadirRegistroNuevo()
        {
            OleDbCommand Comando = new OleDbCommand();
            Comando.Connection = Conexion;
            Comando.CommandText = "INSERT INTO " + tabla + CampoParaAgregar.Replace("''","null") + ";";
            Comando.ExecuteNonQuery();
        }
        private void ConstruirSQLNuevo(Control contenedor)
        {



            foreach (Control ctrl in contenedor.Controls)
            {
                if (ctrl is TextBox)
                {
                    if ((string)ctrl.Tag == null)
                    {
                        Nombredecampos.Add(ctrl.Name);

                        ValoresCampos.Add("'" + ctrl.Text + "'");
                    }
                    if ((string)ctrl.Tag == "D")
                    {
                        if (ctrl.Text != "")
                        {
                            Nombredecampos.Add(ctrl.Name);
                            ValoresCampos.Add("#" + Convert.ToDateTime(ctrl.Text).ToString("MM-dd-yy") + "#");
                        }
                        else
                        {
                            Nombredecampos.Add(ctrl.Name);
                            ValoresCampos.Add("null");
                        }
                    }
                    else
                    {
                        if ((string)ctrl.Tag == "N")
                        {
                            Nombredecampos.Add(ctrl.Name);

                            ValoresCampos.Add(ctrl.Text);
                        }

                    }

                }

                if (ctrl.HasChildren)
                {
                    ConstruirSQLNuevo(ctrl);
                }
            }
            //YA TENEMOS LAS LISTAS CON LOS DATOS DE LOS TEXBOXES Y  LOS VALORES DE CAMPOS
            //GENERAR LA CADENA 
            CampoParaAgregar = " (";


            foreach (string str in Nombredecampos)
            {
                CampoParaAgregar = CampoParaAgregar + str + ",";
            }
            //para eliminar la coma final
            CampoParaAgregar = CampoParaAgregar.Remove(CampoParaAgregar.Length - 1);
            CampoParaAgregar = CampoParaAgregar + ") VALUES (";
            foreach (string str in ValoresCampos)
            {
                CampoParaAgregar = CampoParaAgregar + str + ",";
            }

            CampoParaAgregar = CampoParaAgregar.Remove(CampoParaAgregar.Length - 1);
            CampoParaAgregar = CampoParaAgregar + ")";

        }
        private bool ControlesVacios(Control contenedor, bool vacio)
        {
            //PREGUNTAR A ANGEL

            foreach (Control ctlr in contenedor.Controls)
            {
                if (ctlr is TextBox)
                {
                    if (ctlr.Text == "")
                    {
                        if(ctlr.Name!=ubicacionfoto.Name)
                        vacio = true;
                    }
                }
                if (ctlr.HasChildren)
                {
                    vacio = ControlesVacios(ctlr, vacio);
                }

            }
            return (vacio);



        }

        private void TSBBuscar_Click(object sender, EventArgs e)
        {
            estadoformulario = Estado.Codigo;
            CambiarEstadoFormulario();

            Buscar formulariobuscar = new Buscar();
            formulariobuscar.tituloventana = TITULOBUSQUEDA;
            formulariobuscar.Conexion = Conexion;
            formulariobuscar.campoclave = controlclave;
            formulariobuscar.instrcSQL = "SELECT * FROM " + tabla + " ORDER BY " + controlclave.Name + " ASC;";
            formulariobuscar.campos = SQLBUSQUEDA;
            formulariobuscar.ShowDialog();
            if (controlclave.Text != "")
            {
                controlclave.Focus();
                SendKeys.Send("{TAB}");
                estadoformulario = Estado.Modificando;
                CambiarEstadoFormulario();
            }
            else
            {
                controlclave.Focus();
                estadoformulario = Estado.Codigo;
                CambiarEstadoFormulario();
            }

        }

        private void TSBCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT_Cancelar_Click(object sender, EventArgs e)
        {
            LimpiezaFormulario(this, false);
            estadoformulario = Estado.Codigo;
            CambiarEstadoFormulario();
            controlclave.Focus();
        }

        private void ComprobarFecha_Leave(object sender, EventArgs e)
        {
            DateTime aux = new DateTime();
            if (!DateTime.TryParse(((TextBox)sender).Text, out aux) && ((TextBox)sender).Text != "")
            {

                errorProvider1.SetError(((TextBox)sender), "Fecha incorrecta");
                //MessageBox.Show("Fecha incorrecta, revise la fecha", "Error fecha", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //((TextBox)sender).Text = "";
                ((TextBox)sender).Focus();
            }
            else
            {

                errorProvider1.SetError(((TextBox)sender), "");
            }

        }
        
        #endregion

        private void FechaInscripcion_Enter(object sender, EventArgs e)
        {
            if(((TextBox)sender).Text =="")
            ((TextBox)sender).Text = DateTime.Now.ToShortDateString();
        }

        private void button_foto_Click(object sender, EventArgs e)
        {
           
            Salva_Peluqueros.Recursos.Foto2 aux = new Recursos.Foto2();
            aux.ubicacionfoto = pictureBox_imagen.ImageLocation;
            aux.imageninicial = pictureBox_imagen.Image;
            aux.codigoproducto = Codigo.Text;
            aux.carpetafotos = carpetafotos;
            aux.ShowDialog();
            ubicacionfoto.Text = Codigo.Text+aux.ubicacionfoto.Substring(aux.ubicacionfoto.Length-4);
            pictureBox_imagen.ImageLocation = aux.ubicacionfoto;
            
            if (Directory.Exists(carpetafotos) == false)
            {
                Directory.CreateDirectory(carpetafotos);
            }
            Foto form = new Foto();
            //form.codigoalumno = ((TextBox)controlclave).Text;
            //form.codigo = ((TextBox)controlclave).Text;
            //form.CarpetaFotos = carpetafotos;
            //form.ShowDialog();
            //pictureBox_imagen.Image = form.ImagenFinal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

        }


        private void CargarFoto(string codigo)
        {
            pictureBox_imagen.Enabled = true;
            if (File.Exists(carpetafotos+@"\" + codigo + ".jpg"))
            {
                pictureBox_imagen.ImageLocation = carpetafotos+@"\" + codigo + ".jpg";
            }
            else
            {
                pictureBox_imagen.Image = global::Salva_Peluqueros.Properties.Resources.sinfoto;
            }
        }
        private void CargarFoto()
        {
            pictureBox_imagen.Enabled = true;

                pictureBox_imagen.Image = global::Salva_Peluqueros.Properties.Resources.sinfoto;
        }

        private void FORM_ProductosPeluqueria_FormClosing(object sender, FormClosingEventArgs e)
        {
            //BorrarFotosSobrantes();
        }
     /*   public void BorrarFotosSobrantes()
        {

            OleDbCommand Comando = new OleDbCommand();
            OleDbDataReader Lector;
            Comando.Connection = Conexion;
            string[] listafotos;
            string archivoactual;
            int i = 0;
            if(Directory.Exists(carpetafotos))
            {
            listafotos = Directory.GetFiles(carpetafotos);
            while (i < listafotos.Length)
            {
                archivoactual = listafotos[i].Substring(listafotos[i].IndexOf("\\")).Replace("\\","");
                Comando.CommandText = "SELECT Codigo FROM " + tabla + " WHERE Codigo='" + (i+1).ToString() + "';";
                Lector = Comando.ExecuteReader();
                if (Lector.Read()==false)
                {
                    File.Delete(carpetafotos + @"\" + archivoactual);
                }
                i++;
                Lector.Close();
            }
            }
        }*/


       

       
    }
}
