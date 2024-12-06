namespace CheckList_Digital.view
{
    partial class Frm_CInspecao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CInspecao));
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.BtnRelatorio = new System.Windows.Forms.Button();
            this.LblData_Inspecao = new System.Windows.Forms.Label();
            this.LblId_Inspecao = new System.Windows.Forms.Label();
            this.TxtId_Inspecao = new System.Windows.Forms.TextBox();
            this.BtnAjuda = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.MtbDataInspecao = new System.Windows.Forms.MaskedTextBox();
            this.CmbUsuario = new System.Windows.Forms.ComboBox();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkListDBDataSet = new CheckList_Digital.CheckListDBDataSet();
            this.usuarioTableAdapter = new CheckList_Digital.CheckListDBDataSetTableAdapters.UsuarioTableAdapter();
            this.LblHora = new System.Windows.Forms.Label();
            this.MtbHora = new System.Windows.Forms.MaskedTextBox();
            this.CmbSetor = new System.Windows.Forms.ComboBox();
            this.setorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.setorTableAdapter = new CheckList_Digital.CheckListDBDataSetTableAdapters.SetorTableAdapter();
            this.LblSetor = new System.Windows.Forms.Label();
            this.CmbInspecaoSetor = new System.Windows.Forms.ComboBox();
            this.inspecaoSetorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LblInspecaoSetor = new System.Windows.Forms.Label();
            this.inspecao_SetorTableAdapter = new CheckList_Digital.CheckListDBDataSetTableAdapters.Inspecao_SetorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkListDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspecaoSetorBindingSource)).BeginInit();
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
            // LblData_Inspecao
            // 
            this.LblData_Inspecao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblData_Inspecao.AutoSize = true;
            this.LblData_Inspecao.Location = new System.Drawing.Point(203, 69);
            this.LblData_Inspecao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblData_Inspecao.Name = "LblData_Inspecao";
            this.LblData_Inspecao.Size = new System.Drawing.Size(140, 20);
            this.LblData_Inspecao.TabIndex = 46;
            this.LblData_Inspecao.Text = "Data de Inspeção:";
            // 
            // LblId_Inspecao
            // 
            this.LblId_Inspecao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblId_Inspecao.AutoSize = true;
            this.LblId_Inspecao.Location = new System.Drawing.Point(227, 22);
            this.LblId_Inspecao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblId_Inspecao.Name = "LblId_Inspecao";
            this.LblId_Inspecao.Size = new System.Drawing.Size(116, 20);
            this.LblId_Inspecao.TabIndex = 45;
            this.LblId_Inspecao.Text = "Cód. Inspeção:";
            // 
            // TxtId_Inspecao
            // 
            this.TxtId_Inspecao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtId_Inspecao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtId_Inspecao.Enabled = false;
            this.TxtId_Inspecao.Location = new System.Drawing.Point(351, 19);
            this.TxtId_Inspecao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtId_Inspecao.Name = "TxtId_Inspecao";
            this.TxtId_Inspecao.Size = new System.Drawing.Size(41, 26);
            this.TxtId_Inspecao.TabIndex = 43;
            this.TxtId_Inspecao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtId_Inspecao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtId_Inspecao_KeyDown);
            this.TxtId_Inspecao.Leave += new System.EventHandler(this.txtId_Inspecao_Leave);
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
            // LblUsuario
            // 
            this.LblUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(275, 212);
            this.LblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(68, 20);
            this.LblUsuario.TabIndex = 57;
            this.LblUsuario.Text = "Usuário:";
            // 
            // MtbDataInspecao
            // 
            this.MtbDataInspecao.Enabled = false;
            this.MtbDataInspecao.Location = new System.Drawing.Point(350, 66);
            this.MtbDataInspecao.Mask = "00/00/0000";
            this.MtbDataInspecao.Name = "MtbDataInspecao";
            this.MtbDataInspecao.Size = new System.Drawing.Size(100, 26);
            this.MtbDataInspecao.TabIndex = 59;
            this.MtbDataInspecao.ValidatingType = typeof(System.DateTime);
            // 
            // CmbUsuario
            // 
            this.CmbUsuario.DataSource = this.usuarioBindingSource;
            this.CmbUsuario.DisplayMember = "Nome";
            this.CmbUsuario.Enabled = false;
            this.CmbUsuario.FormattingEnabled = true;
            this.CmbUsuario.Location = new System.Drawing.Point(350, 209);
            this.CmbUsuario.Name = "CmbUsuario";
            this.CmbUsuario.Size = new System.Drawing.Size(475, 28);
            this.CmbUsuario.TabIndex = 60;
            this.CmbUsuario.ValueMember = "Id_Usuario";
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
            // LblHora
            // 
            this.LblHora.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblHora.AutoSize = true;
            this.LblHora.Location = new System.Drawing.Point(470, 69);
            this.LblHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(140, 20);
            this.LblHora.TabIndex = 61;
            this.LblHora.Text = "Hora da Inspeção:";
            // 
            // MtbHora
            // 
            this.MtbHora.Enabled = false;
            this.MtbHora.Location = new System.Drawing.Point(617, 66);
            this.MtbHora.Mask = "00:00";
            this.MtbHora.Name = "MtbHora";
            this.MtbHora.Size = new System.Drawing.Size(57, 26);
            this.MtbHora.TabIndex = 62;
            this.MtbHora.ValidatingType = typeof(System.DateTime);
            // 
            // CmbSetor
            // 
            this.CmbSetor.DataSource = this.setorBindingSource;
            this.CmbSetor.DisplayMember = "Nome_Setor";
            this.CmbSetor.Enabled = false;
            this.CmbSetor.FormattingEnabled = true;
            this.CmbSetor.Location = new System.Drawing.Point(350, 161);
            this.CmbSetor.Name = "CmbSetor";
            this.CmbSetor.Size = new System.Drawing.Size(475, 28);
            this.CmbSetor.TabIndex = 63;
            this.CmbSetor.ValueMember = "Id_Setor";
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
            // LblSetor
            // 
            this.LblSetor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblSetor.AutoSize = true;
            this.LblSetor.Location = new System.Drawing.Point(291, 164);
            this.LblSetor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSetor.Name = "LblSetor";
            this.LblSetor.Size = new System.Drawing.Size(52, 20);
            this.LblSetor.TabIndex = 64;
            this.LblSetor.Text = "Setor:";
            // 
            // CmbInspecaoSetor
            // 
            this.CmbInspecaoSetor.DataSource = this.inspecaoSetorBindingSource;
            this.CmbInspecaoSetor.DisplayMember = "Id_Inspecao_Setor";
            this.CmbInspecaoSetor.Enabled = false;
            this.CmbInspecaoSetor.FormattingEnabled = true;
            this.CmbInspecaoSetor.Location = new System.Drawing.Point(350, 114);
            this.CmbInspecaoSetor.Name = "CmbInspecaoSetor";
            this.CmbInspecaoSetor.Size = new System.Drawing.Size(71, 28);
            this.CmbInspecaoSetor.TabIndex = 65;
            this.CmbInspecaoSetor.ValueMember = "Id_Inspecao_Setor";
            // 
            // inspecaoSetorBindingSource
            // 
            this.inspecaoSetorBindingSource.DataMember = "Inspecao_Setor";
            this.inspecaoSetorBindingSource.DataSource = this.checkListDBDataSet;
            // 
            // LblInspecaoSetor
            // 
            this.LblInspecaoSetor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblInspecaoSetor.AutoSize = true;
            this.LblInspecaoSetor.Location = new System.Drawing.Point(221, 117);
            this.LblInspecaoSetor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblInspecaoSetor.Name = "LblInspecaoSetor";
            this.LblInspecaoSetor.Size = new System.Drawing.Size(122, 20);
            this.LblInspecaoSetor.TabIndex = 66;
            this.LblInspecaoSetor.Text = "Inspeção Setor:";
            // 
            // inspecao_SetorTableAdapter
            // 
            this.inspecao_SetorTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_CInspecao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.ControlBox = false;
            this.Controls.Add(this.LblInspecaoSetor);
            this.Controls.Add(this.CmbInspecaoSetor);
            this.Controls.Add(this.LblSetor);
            this.Controls.Add(this.CmbSetor);
            this.Controls.Add(this.MtbHora);
            this.Controls.Add(this.LblHora);
            this.Controls.Add(this.CmbUsuario);
            this.Controls.Add(this.MtbDataInspecao);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnAjuda);
            this.Controls.Add(this.LblData_Inspecao);
            this.Controls.Add(this.LblId_Inspecao);
            this.Controls.Add(this.TxtId_Inspecao);
            this.Controls.Add(this.BtnRelatorio);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.BtnNovo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_CInspecao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Inspecao";
            this.Load += new System.EventHandler(this.Frm_CInspecao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkListDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspecaoSetorBindingSource)).EndInit();
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
        private System.Windows.Forms.Label LblData_Inspecao;
        private System.Windows.Forms.Label LblId_Inspecao;
        private System.Windows.Forms.TextBox TxtId_Inspecao;
        private System.Windows.Forms.Button BtnAjuda;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.MaskedTextBox MtbDataInspecao;
        private System.Windows.Forms.ComboBox CmbUsuario;
        private CheckListDBDataSet checkListDBDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private CheckListDBDataSetTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.MaskedTextBox MtbHora;
        private System.Windows.Forms.ComboBox CmbSetor;
        private System.Windows.Forms.BindingSource setorBindingSource;
        private CheckListDBDataSetTableAdapters.SetorTableAdapter setorTableAdapter;
        private System.Windows.Forms.Label LblSetor;
        private System.Windows.Forms.ComboBox CmbInspecaoSetor;
        private System.Windows.Forms.Label LblInspecaoSetor;
        private System.Windows.Forms.BindingSource inspecaoSetorBindingSource;
        private CheckListDBDataSetTableAdapters.Inspecao_SetorTableAdapter inspecao_SetorTableAdapter;
    }
}