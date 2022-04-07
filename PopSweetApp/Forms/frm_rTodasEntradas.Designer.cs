
namespace PopSweetApp {
    partial class frm_rTodasEntradas {
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
            this.EntradasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EntradasTableAdapter = new PopSweetApp.PopSweetDataSetTableAdapters.EntradasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PopSweetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntradasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Entradas";
            reportDataSource1.Value = this.EntradasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PopSweetApp.Reports.TodasEntradas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 1;
            // 
            // PopSweetDataSet
            // 
            this.PopSweetDataSet.DataSetName = "PopSweetDataSet";
            this.PopSweetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EntradasBindingSource
            // 
            this.EntradasBindingSource.DataMember = "Entradas";
            this.EntradasBindingSource.DataSource = this.PopSweetDataSet;
            // 
            // EntradasTableAdapter
            // 
            this.EntradasTableAdapter.ClearBeforeFill = true;
            // 
            // frm_rTodasEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_rTodasEntradas";
            this.Text = "frm_rTodasEntradas";
            this.Load += new System.EventHandler(this.frm_rTodasEntradas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PopSweetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntradasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EntradasBindingSource;
        private PopSweetDataSet PopSweetDataSet;
        private PopSweetDataSetTableAdapters.EntradasTableAdapter EntradasTableAdapter;
    }
}