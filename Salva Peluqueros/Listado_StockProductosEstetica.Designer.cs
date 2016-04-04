namespace Salva_Peluqueros
{
    partial class Listado_StockProductosEstetica
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
            this.ListadoVentasEsteticaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PeluqueriaDataSet = new Salva_Peluqueros.PeluqueriaDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ListadoVentasEsteticaTableAdapter = new Salva_Peluqueros.PeluqueriaDataSetTableAdapters.ListadoVentasEsteticaTableAdapter();
            this.ProductosEsteticaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProductosEsteticaTableAdapter = new Salva_Peluqueros.PeluqueriaDataSetTableAdapters.ProductosEsteticaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoVentasEsteticaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeluqueriaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosEsteticaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ListadoVentasEsteticaBindingSource
            // 
            this.ListadoVentasEsteticaBindingSource.DataMember = "ListadoVentasEstetica";
            this.ListadoVentasEsteticaBindingSource.DataSource = this.PeluqueriaDataSet;
            // 
            // PeluqueriaDataSet
            // 
            this.PeluqueriaDataSet.DataSetName = "PeluqueriaDataSet";
            this.PeluqueriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ProductosEsteticaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Salva_Peluqueros.StockEstetica.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(741, 418);
            this.reportViewer1.TabIndex = 0;
            // 
            // ListadoVentasEsteticaTableAdapter
            // 
            this.ListadoVentasEsteticaTableAdapter.ClearBeforeFill = true;
            // 
            // ProductosEsteticaBindingSource
            // 
            this.ProductosEsteticaBindingSource.DataMember = "ProductosEstetica";
            this.ProductosEsteticaBindingSource.DataSource = this.PeluqueriaDataSet;
            // 
            // ProductosEsteticaTableAdapter
            // 
            this.ProductosEsteticaTableAdapter.ClearBeforeFill = true;
            // 
            // Listado_StockProductosEstetica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 418);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Listado_StockProductosEstetica";
            this.Text = "Listado_StockProductosEstetica";
            this.Load += new System.EventHandler(this.Listado_StockProductosEstetica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListadoVentasEsteticaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeluqueriaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosEsteticaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ListadoVentasEsteticaBindingSource;
        private PeluqueriaDataSet PeluqueriaDataSet;
        private PeluqueriaDataSetTableAdapters.ListadoVentasEsteticaTableAdapter ListadoVentasEsteticaTableAdapter;
        private System.Windows.Forms.BindingSource ProductosEsteticaBindingSource;
        private PeluqueriaDataSetTableAdapters.ProductosEsteticaTableAdapter ProductosEsteticaTableAdapter;
    }
}