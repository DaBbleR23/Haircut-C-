using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Salva_Peluqueros
{
    public enum LimpiarTextBox
    {
        Nada = 0,
        AlEntrar = 1,
        AlPulsar = 2
    }

    public enum FiltroCaracteres
    {
        Todo = 0,
        Alfanumerico = 1,
        AlfanumericoSignos = 2,
        Numerico = 3,
        NumericoSignos = 4
        
    }         

    public partial class MiTextBox : TextBox
    {
        #region Campos
        
        private Color _colorBasico;             
        private Color _colorActivo;
        private LimpiarTextBox _limpiar;
        private bool _limpio;
        private FiltroCaracteres _filtroCaracteres;
        private bool _mayusculas;

        #endregion

        #region Propiedades

        [System.ComponentModel.Category("_Mis Controles")]
        [System.ComponentModel.Description("Color del control cuando no tiene el foco.")]
        [System.ComponentModel.ReadOnly(true)]        
        public Color ColorBasico
        {
            get { return _colorBasico; }
        }       

        [System.ComponentModel.Category("_Mis Controles")]
        [System.ComponentModel.Description("Color del control cuando se entra en él.")]
        public Color ColorActivo
        {
            get { return _colorActivo; }
            set { _colorActivo = value; }
        }

        [System.ComponentModel.Category("_Mis Controles")]
        [System.ComponentModel.Description("Indica la circunstancia en la que se limpiará el contenido del TextBox.")]
        [System.ComponentModel.DefaultValue(LimpiarTextBox.Nada)]
        public LimpiarTextBox Limpiar
        {
            get { return _limpiar; }
            set { _limpiar = value; }
        }

        [System.ComponentModel.Category("_Mis Controles")]
        [System.ComponentModel.Description("Número máximo de caracteres que el TextBox acepta.")]
        [System.ComponentModel.DefaultValue(10)]
        public int CaracteresMaximos
        {
            get { return this.MaxLength; }
            set
            {
                this.MaxLength = value;
                CalcularTamaño();
            }
        }

        [System.ComponentModel.Category("_Mis Controles")]
        [System.ComponentModel.Description("Filtra el tipo de caracteres que acepta el TextBox.")]
        [System.ComponentModel.DefaultValue(FiltroCaracteres.Todo)]
        public FiltroCaracteres CaracteresValidos
        {
            get { return _filtroCaracteres; }
            set { _filtroCaracteres = value; }
        }

        [System.ComponentModel.Category("_Mis Controles")]
        [System.ComponentModel.Description("Activa o desactiva la conversión automática del texto a mayúsculas.")]
        [System.ComponentModel.DefaultValue(false)]
        public bool Mayusculas
        {
            get { return _mayusculas; }
            set { _mayusculas = value; }
        }        

        #endregion

        #region Funciones

        public MiTextBox()
        {
            InitializeComponent();
            this.MaxLength = 10;
            CalcularTamaño();
        }

        /// <summary>
        /// Método que calcula el tamaño adecuado para el textbox según el número máximo de caracteres del mismo.
        /// </summary>
        private void CalcularTamaño()
        {
            Size tamaño = new Size();
            string cadena = new string('0', MaxLength);
            tamaño = TextRenderer.MeasureText(cadena, this.Font);
            this.Width = tamaño.Width;
        }

        #endregion 

        #region Eventos

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            switch (_filtroCaracteres)
            {
                case FiltroCaracteres.Alfanumerico:
                {
                    if (char.IsLetterOrDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) && e.KeyChar == 75)
                    {
                        if (_mayusculas)
                        {
                            e.KeyChar = char.ToUpper(e.KeyChar);
                        }                        
                    }
                    else
                    {
                        e.Handled = true;
                    }
                    break;
                }
                
                case FiltroCaracteres.AlfanumericoSignos:
                {
                    if (char.IsLetterOrDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || e.KeyChar == '+' || e.KeyChar == '-' || e.KeyChar == ',')
                    {
                        if (_mayusculas)
                        {
                            e.KeyChar = char.ToUpper(e.KeyChar);
                        }
                    }
                    else
                    {
                        e.Handled = true;
                    }
                    break;
                }

                case FiltroCaracteres.Numerico:
                {
                    if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                    break;                    
                }

                case FiltroCaracteres.NumericoSignos:
                {
                    if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '+' && e.KeyChar != '-' && e.KeyChar != ',')
                    {
                        e.Handled = true;
                    }
                    break;                    
                }

                case FiltroCaracteres.Todo:
                {
                    if (_mayusculas)
                    {
                        e.KeyChar = char.ToUpper(e.KeyChar);
                    }
                    break;
                }                 
            }          

            if (e.KeyChar == 13)
            {
                SendKeys.Send("{TAB}");
            }            
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

                 

            if (_limpiar == LimpiarTextBox.AlPulsar && _limpio == false && e.KeyData != Keys.Enter)
            {
                this.ResetText();
                _limpio = true;
            }
           
        }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            
            _colorBasico = this.BackColor;            
            this.BackColor = _colorActivo;

            if (this.Text != "")
            {
                _limpio = false;
            }
            else
            {
                _limpio = true;
            }

                if (_limpiar == LimpiarTextBox.AlEntrar)
            {
                this.ResetText();
            }
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            
            this.BackColor = _colorBasico;
        }

        #endregion
    }
}
