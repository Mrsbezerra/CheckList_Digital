namespace CheckList_Digital.view.frm_relatorio
{
    partial class FrmRelTipoUsuario
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
            this.checkListDBDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.checkListDBDataSet2 = new CheckList_Digital.CheckListDBDataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tipoUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.tipo_UsuarioTableAdapter = new CheckList_Digital.CheckListDBDataSet2TableAdapters.Tipo_UsuarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.checkListDBDataSet2BindingSource)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.checkListDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoUsuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // checkListDBDataSet2BindingSource
            // 
            //this.checkListDBDataSet2BindingSource.DataSource =
                //this.checkListDBDataSet2;
            this.checkListDBDataSet2BindingSource.Position = 0;
            // 
            // checkListDBDataSet2
            // 
            //this.checkListDBDataSet2.DataSetName = "CheckListDBDataSet2";
            //this.checkListDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tipoUsuarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CheckList_Digital.relatorio.RelatorioTipoUsuario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // tipoUsuarioBindingSource
            // 
            this.tipoUsuarioBindingSource.DataMember = "Tipo_Usuario";
            this.tipoUsuarioBindingSource.DataSource = this.checkListDBDataSet2BindingSource;
            // 
            // tipo_UsuarioTableAdapter
            // 
           // this.tipo_UsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelTipoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRelTipoUsuario";
            this.ShowIcon = false;
            this.Text = "Relátorio Tipo do Usuario";
            this.Load += new System.EventHandler(this.FrmRelTipoUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.checkListDBDataSet2BindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.checkListDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoUsuarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource checkListDBDataSet2BindingSource;
        //private CheckListDBDataSet2 checkListDBDataSet2;
        private System.Windows.Forms.BindingSource tipoUsuarioBindingSource;
        //private CheckListDBDataSet2TableAdapters.Tipo_UsuarioTableAdapter tipo_UsuarioTableAdapter;
    }
}