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
    public partial class MiControlCruzado : UserControl
    {
        public string TextoDevuelto
        {
            get
            {
                return label_valordevuelto.Text;
            }
        }
        public override string Text
        {
            get
            {
                return textBox_codigo.Text;
            }
            set
            {
                textBox_codigo.Text = value;
            }
        }

        public bool Errorlectura
        {
            get { return _errorlectura; }
            set { _errorlectura = value; }
        }

        public bool TextBoxVacio
        {

            get {


                if (textBox_codigo.Text == "")
                {
                    return (true);
                }
                else
                {
                    return (false);
                }
            
            }
        }
        public string valordevuelto
        {
            get { return label_valordevuelto.Text; }
          
        }
        public Color Coloractivo
        {
            get { return textBox_codigo.ColorActivo; }
            set { textBox_codigo.ColorActivo = value; }
        }
        public int CaracteresMaximos
        {
            get { return textBox_codigo.CaracteresMaximos; }
            set { textBox_codigo.CaracteresMaximos = value; }
        }
        public FiltroCaracteres CaracteresValidos
        {
            get { return textBox_codigo.CaracteresValidos; }
            set { textBox_codigo.CaracteresValidos = value; }
        }
        public bool Mayusculas
        {
            get { return textBox_codigo.Mayusculas; }
            set { textBox_codigo.Mayusculas = value; }
        }
        public LimpiarTextBox Limpiar
        {
            get { return textBox_codigo.Limpiar; }
            set { textBox_codigo.Limpiar = value; }
        }

        public string NombreTextbox
        {
            get { return textBox_codigo.Name; }
            set { textBox_codigo.Name = value; }
        }

        public MiControlCruzado()
        {
            InitializeComponent();
         

        }

        #region CamposPrivados
        private string _tabla;
        private OleDbConnection _conexion;
        private string _tituloventanabuscar;
        //Separados por /, el campo con * es el clave,{Entre llaves el titulo}
        private string _campos;
        private string _campoclave;
        private bool _errorlectura;

      
        private string _campolabel;
        private string _textoerror;
       
      
        #endregion

        #region PropiedadesPublicas
        public Color Color_label_titulo
        {
            get { return label_titulo.ForeColor; }
            set { label_titulo.ForeColor = value; }
        }

        public Color Color_label_campo
        {
            get { return label_valordevuelto.ForeColor; }
            set { label_valordevuelto.ForeColor = value; }
        }

        public Font Opciones_label_titulo
        {
            get { return label_titulo.Font; }
            set { label_titulo.Font = value; }
        }

        public Font Opciones_label_campo
        {
            get { return label_valordevuelto.Font; }
            set { label_valordevuelto.Font = value; }
        }

        public string Tabla
        {
            get { return _tabla; }
            set { _tabla = value; }
        }
        public OleDbConnection Conexion
        {
            get { return _conexion; }
            set { _conexion = value; }
        }
        public string Campos
        {
            get { return _campos; }
            set { _campos = value; }
        }
        public string Campoclave
        {
            get { return _campoclave; }
            set { _campoclave = value; }
        }
        public string Tituloventanabuscar
        {
            get { return _tituloventanabuscar; }
            set { _tituloventanabuscar = value; }
        }
        public string Campolabel
        {
            get { return _campolabel; }
            set { _campolabel = value; }
        }

        public string Textotitulo
        {
            get { return label_titulo.Text; }
            set { label_titulo.Text = value; }
        }

        public string Textoerror
        {
            get { return _textoerror; }
            set { _textoerror = value; }
        }
        #endregion

        
        #region Metodos

        public void CambiarNombreTextBoxOriginal()
        {

                textBox_codigo.Name = "textBox_codigo";
        }

        public void CambiarNombreTextBoxComoControl()
        {

                textBox_codigo.Name = this.Name;

        }
        private void AbrirConexion()
        {
            _conexion.Open();
        }
        private void CerrarConexion()
        {
            _conexion.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Conexion.State == ConnectionState.Closed)
                AbrirConexion();

            textBox_codigo.Name = _campoclave;
            Buscar formulariobuscar = new Buscar();
            formulariobuscar.tituloventana = _tituloventanabuscar;
            formulariobuscar.Conexion = _conexion;
            formulariobuscar.campoclave = this.textBox_codigo;
            //formulariobuscar.instrcSQL = "SELECT * FROM " + _tabla + " ORDER BY " + _campoclave.Name + " ASC;";
            formulariobuscar.campos = _campos;
            formulariobuscar.instrcSQL = "SELECT * FROM " + _tabla + " ORDER BY " + _campoclave + " ASC;";
            formulariobuscar.ShowDialog();
            textBox_codigo.Focus();
            SendKeys.Send("{TAB}");
            CerrarConexion();

        }

        private void textBox_codigo_Leave(object sender, EventArgs e)
        {
            if (textBox_codigo.Text != "")
            {
                OleDbCommand comando = new OleDbCommand();
                if (Conexion.State == ConnectionState.Closed)
                    AbrirConexion();

                comando.Connection = _conexion;
                comando.CommandText = "SELECT " + _campolabel + " FROM " + _tabla + " WHERE " + _campoclave + "=" + textBox_codigo.Text + ";";
                OleDbDataReader Lector;
                Lector = comando.ExecuteReader();
                if (Lector.Read())
                {
                    label_valordevuelto.Text = Lector[_campolabel].ToString();
                    _errorlectura = false;
                }
                else
                {
                    label_valordevuelto.Text = _textoerror;
                    _errorlectura = true;
                }


                ((TextBox)sender).Name = this.Name;
            }
            else
            {
                label_valordevuelto.ResetText();
            }
        }


         
        #endregion

        private void textBox_codigo_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).Name = "textBox_codigo";
        }

        private void textBox_codigo_EnabledChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Enabled)
            {
                button_buscar.Enabled = true;
                
            }
            else
            {
                button_buscar.Enabled = false;
              
            }
        }

        private void MiControlCruzado_Load(object sender, EventArgs e)
        {
            textBox_codigo.Text = "";
        }







    }
}
