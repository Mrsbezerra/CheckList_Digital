﻿namespace CheckList_Digital.view.frm_relatorio
{
    partial class FrmRelCargo
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
           // this.checkListDBDataSet1 = new CheckList_Digital.CheckListDBDataSet1();
            this.cargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
           // this.cargoTableAdapter = new CheckList_Digital.CheckListDBDataSet1TableAdapters.CargoTableAdapter();
            //((System.ComponentModel.ISupportInitialize)(this.checkListDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.cargoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CheckList_Digital.relatorio.RelatorioCargo .rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // checkListDBDataSet1
            // 
            //this.checkListDBDataSet1.DataSetName = "CheckListDBDataSet1";
            //this.checkListDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cargoBindingSource
            // 
            this.cargoBindingSource.DataMember = "Cargo";
            //this.cargoBindingSource.DataSource = this.checkListDBDataSet1;
            // 
            // cargoTableAdapter
            // 
            //this.cargoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRelCargo";
            this.ShowIcon = false;
            this.Text = "Relatório de Cargo";
            this.Load += new System.EventHandler(this.FrmRelCargo_Load);
           // ((System.ComponentModel.ISupportInitialize)(this.checkListDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
       // private CheckListDBDataSet1 checkListDBDataSet1;
        private System.Windows.Forms.BindingSource cargoBindingSource;
       //private CheckListDBDataSet1TableAdapters.CargoTableAdapter cargoTableAdapter;
    }
}