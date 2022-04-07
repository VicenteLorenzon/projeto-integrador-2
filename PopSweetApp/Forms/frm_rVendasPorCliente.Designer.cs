
namespace PopSweetApp {
    partial class frm_rVendasPorCliente {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.VendasPorClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PopSweetDataSet = new PopSweetApp.PopSweetDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VendasPorClienteTableAdapter = new PopSweetApp.PopSweetDataSetTableAdapters.VendasPorClienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.VendasPorClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopSweetDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // VendasPorClienteBindingSource
            // 
            this.VendasPorClienteBindingSource.DataMember = "VendasPorCliente";
            this.VendasPorClienteBindingSource.DataSource = this.PopSweetDataSet;
            // 
            // PopSweetDataSet
            // 
            this.PopSweetDataSet.DataSetName = "PopSweetDataSet";
            this.PopSweetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "VendasPorCliente";
            reportDataSource1.Value = this.VendasPorClienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PopSweetApp.Reports.VendasPorCliente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // VendasPorClienteTableAdapter
            // 
            this.VendasPorClienteTableAdapter.ClearBeforeFill = true;
            // 
            // frm_rVendasPorCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_rVendasPorCliente";
            this.Text = "Vendas por cliente";
            this.Load += new System.EventHandler(this.frm_verRelatorios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VendasPorClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopSweetDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VendasPorClienteBindingSource;
        private PopSweetDataSet PopSweetDataSet;
        private PopSweetDataSetTableAdapters.VendasPorClienteTableAdapter VendasPorClienteTableAdapter;
    }
}