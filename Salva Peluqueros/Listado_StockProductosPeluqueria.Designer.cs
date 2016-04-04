namespace Salva_Peluqueros
{
    partial class Listado_StockProductosPeluqueria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PeluqueriaDataSet = new Salva_Peluqueros.PeluqueriaDataSet();
            this.ProductosPeluqueriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProductosPeluqueriaTableAdapter = new Salva_Peluqueros.PeluqueriaDataSetTableAdapters.ProductosPeluqueriaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PeluqueriaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosPeluqueriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ProductosPeluqueriaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Salva_Peluqueros.StockPeluqueria.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(741, 418);
            this.reportViewer1.TabIndex = 0;
            // 
            // PeluqueriaDataSet
            // 
            this.PeluqueriaDataSet.DataSetName = "PeluqueriaDataSet";
            this.PeluqueriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ProductosPeluqueriaBindingSource
            // 
            this.ProductosPeluqueriaBindingSource.DataMember = "ProductosPeluqueria";
            this.ProductosPeluqueriaBindingSource.DataSource = this.PeluqueriaDataSet;
            // 
            // ProductosPeluqueriaTableAdapter
            // 
            this.ProductosPeluqueriaTableAdapter.ClearBeforeFill = true;
            // 
            // Listado_StockProductosPeluqueria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 418);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Listado_StockProductosPeluqueria";
            this.Text = "Listado de stock de productos peluqueria";
            this.Load += new System.EventHandler(this.Listado_StockProductosPeluqueria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PeluqueriaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosPeluqueriaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProductosPeluqueriaBindingSource;
        private PeluqueriaDataSet PeluqueriaDataSet;
        private PeluqueriaDataSetTableAdapters.ProductosPeluqueriaTableAdapter ProductosPeluqueriaTableAdapter;


    }
}