namespace CheckList_Digital.view.Frm_Relatorio
{
    partial class FrmRelSetor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRelSetor));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.checkListDBDataSet = new CheckList_Digital.CheckListDBDataSet();
            this.setorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.setorTableAdapter = new CheckList_Digital.CheckListDBDataSetTableAdapters.SetorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.checkListDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.setorBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CheckList_Digital.view.Relatorio_RDLC.RelSetor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // checkListDBDataSet
            // 
            this.checkListDBDataSet.DataSetName = "CheckListDBDataSet";
            this.checkListDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // setorBindingSource
            // 
            this.setorBindingSource.DataMember = "Setor";
            this.setorBindingSource.DataSource = this.checkListDBDataSet;
            // 
            // setorTableAdapter
            // 
            this.setorTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelSetor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRelSetor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRelSetor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRelSetor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.checkListDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private CheckListDBDataSet checkListDBDataSet;
        private System.Windows.Forms.BindingSource setorBindingSource;
        private CheckListDBDataSetTableAdapters.SetorTableAdapter setorTableAdapter;
    }
}