﻿/*namespace CheckList_Digital.view
{
    partial class Frm_CItensInspecaoSetor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CItensInspecaoSetor));
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.BtnRelatorio = new System.Windows.Forms.Button();
            this.LblSetor = new System.Windows.Forms.Label();
            this.LblId_InspecaoSetor = new System.Windows.Forms.Label();
            this.BtnAjuda = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.CmbUsuInspecaoSetor = new System.Windows.Forms.ComboBox();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkListDBDataSet = new CheckList_Digital.CheckListDBDataSet();
            this.usuarioTableAdapter = new CheckList_Digital.CheckListDBDataSetTableAdapters.UsuarioTableAdapter();
            this.inspecaoSetorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inspecao_SetorTableAdapter = new CheckList_Digital.CheckListDBDataSetTableAdapters.Inspecao_SetorTableAdapter();
            this.CmbSetor = new System.Windows.Forms.ComboBox();
            this.setorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.setorTableAdapter = new CheckList_Digital.CheckListDBDataSetTableAdapters.SetorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkListDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspecaoSetorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNovo
            // 
            this.BtnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNovo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnNovo.Location = new System.Drawing.Point(1058, 19);
            this.BtnNovo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(125, 39);
            this.BtnNovo.TabIndex = 0;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalvar.Enabled = false;
            this.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnSalvar.Location = new System.Drawing.Point(1058, 66);
            this.BtnSalvar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(125, 39);
            this.BtnSalvar.TabIndex = 1;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.Enabled = false;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnCancelar.Location = new System.Drawing.Point(1058, 114);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(125, 39);
            this.BtnCancelar.TabIndex = 2;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnEditar.Location = new System.Drawing.Point(1058, 161);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(125, 39);
            this.BtnEditar.TabIndex = 3;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExcluir.Enabled = false;
            this.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnExcluir.Location = new System.Drawing.Point(1058, 209);
            this.BtnExcluir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(125, 39);
            this.BtnExcluir.TabIndex = 4;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnConsultar.Location = new System.Drawing.Point(1058, 258);
            this.BtnConsultar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(125, 39);
            this.BtnConsultar.TabIndex = 5;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // BtnRelatorio
            // 
            this.BtnRelatorio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnRelatorio.Location = new System.Drawing.Point(1058, 305);
            this.BtnRelatorio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnRelatorio.Name = "BtnRelatorio";
            this.BtnRelatorio.Size = new System.Drawing.Size(125, 39);
            this.BtnRelatorio.TabIndex = 6;
            this.BtnRelatorio.Text = "Relatório";
            this.BtnRelatorio.UseVisualStyleBackColor = true;
            this.BtnRelatorio.Click += new System.EventHandler(this.BtnRelatorio_Click);
            // 
            // LblSetor
            // 
            this.LblSetor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblSetor.AutoSize = true;
            this.LblSetor.Location = new System.Drawing.Point(291, 69);
            this.LblSetor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSetor.Name = "LblSetor";
            this.LblSetor.Size = new System.Drawing.Size(52, 20);
            this.LblSetor.TabIndex = 46;
            this.LblSetor.Text = "Setor:";
            // 
            // LblId_InspecaoSetor
            // 
            this.LblId_InspecaoSetor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblId_InspecaoSetor.AutoSize = true;
            this.LblId_InspecaoSetor.Location = new System.Drawing.Point(184, 22);
            this.LblId_InspecaoSetor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblId_InspecaoSetor.Name = "LblId_InspecaoSetor";
            this.LblId_InspecaoSetor.Size = new System.Drawing.Size(159, 20);
            this.LblId_InspecaoSetor.TabIndex = 45;
            this.LblId_InspecaoSetor.Text = "Cód. Inspeção Setor:";
            // 
            // BtnAjuda
            // 
            this.BtnAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAjuda.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnAjuda.Location = new System.Drawing.Point(1058, 352);
            this.BtnAjuda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAjuda.Name = "BtnAjuda";
            this.BtnAjuda.Size = new System.Drawing.Size(125, 39);
            this.BtnAjuda.TabIndex = 47;
            this.BtnAjuda.Text = "Ajuda";
            this.BtnAjuda.UseVisualStyleBackColor = true;
            // 
            // BtnSair
            // 
            this.BtnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnSair.Location = new System.Drawing.Point(1058, 400);
            this.BtnSair.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(125, 39);
            this.BtnSair.TabIndex = 55;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // CmbUsuInspecaoSetor
            // 
            this.CmbUsuInspecaoSetor.DataSource = this.inspecaoSetorBindingSource;
            this.CmbUsuInspecaoSetor.DisplayMember = "Id_Inspecao_Setor";
            this.CmbUsuInspecaoSetor.Enabled = false;
            this.CmbUsuInspecaoSetor.FormattingEnabled = true;
            this.CmbUsuInspecaoSetor.Location = new System.Drawing.Point(350, 19);
            this.CmbUsuInspecaoSetor.Name = "CmbUsuInspecaoSetor";
            this.CmbUsuInspecaoSetor.Size = new System.Drawing.Size(100, 28);
            this.CmbUsuInspecaoSetor.TabIndex = 60;
            this.CmbUsuInspecaoSetor.ValueMember = "Id_Inspecao_Setor";
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.checkListDBDataSet;
            // 
            // checkListDBDataSet
            // 
            this.checkListDBDataSet.DataSetName = "CheckListDBDataSet";
            this.checkListDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // inspecaoSetorBindingSource
            // 
            this.inspecaoSetorBindingSource.DataMember = "Inspecao_Setor";
            this.inspecaoSetorBindingSource.DataSource = this.checkListDBDataSet;
            // 
            // inspecao_SetorTableAdapter
            // 
            this.inspecao_SetorTableAdapter.ClearBeforeFill = true;
            // 
            // CmbSetor
            // 
            this.CmbSetor.DataSource = this.setorBindingSource;
            this.CmbSetor.DisplayMember = "Id_Setor";
            this.CmbSetor.Enabled = false;
            this.CmbSetor.FormattingEnabled = true;
            this.CmbSetor.Location = new System.Drawing.Point(350, 66);
            this.CmbSetor.Name = "CmbSetor";
            this.CmbSetor.Size = new System.Drawing.Size(547, 28);
            this.CmbSetor.TabIndex = 61;
            this.CmbSetor.ValueMember = "Nome_Setor";
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
            // Frm_CItensInspecaoSetor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.ControlBox = false;
            this.Controls.Add(this.CmbSetor);
            this.Controls.Add(this.CmbUsuInspecaoSetor);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnAjuda);
            this.Controls.Add(this.LblSetor);
            this.Controls.Add(this.LblId_InspecaoSetor);
            this.Controls.Add(this.BtnRelatorio);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.BtnNovo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_CItensInspecaoSetor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Itens Inspecao Setor";
            this.Load += new System.EventHandler(this.Frm_CItensInspecaoSetor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkListDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspecaoSetorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Button BtnRelatorio;
        private System.Windows.Forms.Label LblSetor;
        private System.Windows.Forms.Label LblId_InspecaoSetor;
        private System.Windows.Forms.Button BtnAjuda;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.ComboBox CmbUsuInspecaoSetor;
        private CheckListDBDataSet checkListDBDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private CheckListDBDataSetTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.BindingSource inspecaoSetorBindingSource;
        private CheckListDBDataSetTableAdapters.Inspecao_SetorTableAdapter inspecao_SetorTableAdapter;
        private System.Windows.Forms.ComboBox CmbSetor;
        private System.Windows.Forms.BindingSource setorBindingSource;
        private CheckListDBDataSetTableAdapters.SetorTableAdapter setorTableAdapter;
    }
}*/