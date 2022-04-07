
namespace PopSweetApp {
    partial class frm_rHistoricoCliente {
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PopSweetDataSet = new PopSweetApp.PopSweetDataSet();
            this.VendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VendasTableAdapter = new PopSweetApp.PopSweetDataSetTableAdapters.VendasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PopSweetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VendasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Vendas";
            reportDataSource1.Value = this.VendasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PopSweetApp.Reports.HistoricoCliente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // PopSweetDataSet
            // 
            this.PopSweetDataSet.DataSetName = "PopSweetDataSet";
            this.PopSweetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VendasBindingSource
            // 
            this.VendasBindingSource.DataMember = "Vendas";
            this.VendasBindingSource.DataSource = this.PopSweetDataSet;
            // 
            // VendasTableAdapter
            // 
            this.VendasTableAdapter.ClearBeforeFill = true;
            // 
            // frm_rHistoricoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_rHistoricoCliente";
            this.Text = "frm_rHistoricoCliente";
            this.Load += new System.EventHandler(this.frm_rHistoricoCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PopSweetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VendasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VendasBindingSource;
        private PopSweetDataSet PopSweetDataSet;
        private PopSweetDataSetTableAdapters.VendasTableAdapter VendasTableAdapter;
    }
}