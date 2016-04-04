namespace Salva_Peluqueros
{
    partial class MiControlCruzado
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_titulo = new System.Windows.Forms.Label();
            this.button_buscar = new System.Windows.Forms.Button();
            this.label_valordevuelto = new System.Windows.Forms.Label();
            this.textBox_codigo = new Salva_Peluqueros.MiTextBox();
            this.SuspendLayout();
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(81, 6);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(41, 13);
            this.label_titulo.TabIndex = 2;
            this.label_titulo.Text = "label1";
            // 
            // button_buscar
            // 
            this.button_buscar.Image = global::Salva_Peluqueros.Properties.Resources.view;
            this.button_buscar.Location = new System.Drawing.Point(46, 1);
            this.button_buscar.Name = "button_buscar";
            this.button_buscar.Size = new System.Drawing.Size(23, 23);
            this.button_buscar.TabIndex = 1;
            this.button_buscar.UseVisualStyleBackColor = true;
            this.button_buscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_valordevuelto
            // 
            this.label_valordevuelto.AutoSize = true;
            this.label_valordevuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_valordevuelto.Location = new System.Drawing.Point(75, 6);
            this.label_valordevuelto.Name = "label_valordevuelto";
            this.label_valordevuelto.Size = new System.Drawing.Size(0, 13);
            this.label_valordevuelto.TabIndex = 3;
            // 
            // textBox_codigo
            // 
            this.textBox_codigo.CaracteresMaximos = 5;
            this.textBox_codigo.CaracteresValidos = Salva_Peluqueros.FiltroCaracteres.Numerico;
            this.textBox_codigo.ColorActivo = System.Drawing.Color.Empty;
            this.textBox_codigo.Location = new System.Drawing.Point(3, 3);
            this.textBox_codigo.MaxLength = 5;
            this.textBox_codigo.Name = "textBox_codigo";
            this.textBox_codigo.Size = new System.Drawing.Size(37, 20);
            this.textBox_codigo.TabIndex = 0;
            this.textBox_codigo.TextChanged += new System.EventHandler(this.textBox_codigo_Leave);
            this.textBox_codigo.Leave += new System.EventHandler(this.textBox_codigo_Leave);
            this.textBox_codigo.Enter += new System.EventHandler(this.textBox_codigo_Enter);
            this.textBox_codigo.EnabledChanged += new System.EventHandler(this.textBox_codigo_EnabledChanged);
            // 
            // MiControlCruzado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.textBox_codigo);
            this.Controls.Add(this.label_valordevuelto);
            this.Controls.Add(this.button_buscar);
            this.Controls.Add(this.label_titulo);
            this.Name = "MiControlCruzado";
            this.Size = new System.Drawing.Size(187, 27);
            this.Load += new System.EventHandler(this.MiControlCruzado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.Button button_buscar;
        private System.Windows.Forms.Label label_valordevuelto;
        private MiTextBox textBox_codigo;
    }
}
