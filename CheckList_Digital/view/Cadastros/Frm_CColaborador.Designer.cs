namespace CheckList_Digital.view
{
    partial class Frm_CColaborador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CColaborador));
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.BtnRelatorio = new System.Windows.Forms.Button();
            this.LblNome_Colaborador = new System.Windows.Forms.Label();
            this.LblId_Colaborador = new System.Windows.Forms.Label();
            this.TxtNome_Colaborador = new System.Windows.Forms.TextBox();
            this.TxtId_Colaborador = new System.Windows.Forms.TextBox();
            this.BtnAjuda = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblRG = new System.Windows.Forms.Label();
            this.LblCPF = new System.Windows.Forms.Label();
            this.CmbSexo = new System.Windows.Forms.ComboBox();
            this.sexoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkListDBDataSet = new CheckList_Digital.CheckListDBDataSet();
            this.LblSexo = new System.Windows.Forms.Label();
            this.sexoTableAdapter = new CheckList_Digital.CheckListDBDataSetTableAdapters.SexoTableAdapter();
            this.CmbSetor = new System.Windows.Forms.ComboBox();
            this.cargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LblSetor = new System.Windows.Forms.Label();
            this.cargoTableAdapter = new CheckList_Digital.CheckListDBDataSetTableAdapters.CargoTableAdapter();
            this.CmbCargo = new System.Windows.Forms.ComboBox();
            this.tipoUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LblCargo = new System.Windows.Forms.Label();
            this.tipo_UsuarioTableAdapter = new CheckList_Digital.CheckListDBDataSetTableAdapters.Tipo_UsuarioTableAdapter();
            this.setorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.setorTableAdapter = new CheckList_Digital.CheckListDBDataSetTableAdapters.SetorTableAdapter();
            this.cargoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.MtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.MtbRg = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sexoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkListDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource1)).BeginInit();
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
            // LblNome_Colaborador
            // 
            this.LblNome_Colaborador.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblNome_Colaborador.AutoSize = true;
            this.LblNome_Colaborador.Location = new System.Drawing.Point(244, 69);
            this.LblNome_Colaborador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNome_Colaborador.Name = "LblNome_Colaborador";
            this.LblNome_Colaborador.Size = new System.Drawing.Size(100, 20);
            this.LblNome_Colaborador.TabIndex = 46;
            this.LblNome_Colaborador.Text = "Colaborador:";
            // 
            // LblId_Colaborador
            // 
            this.LblId_Colaborador.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblId_Colaborador.AutoSize = true;
            this.LblId_Colaborador.Location = new System.Drawing.Point(206, 22);
            this.LblId_Colaborador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblId_Colaborador.Name = "LblId_Colaborador";
            this.LblId_Colaborador.Size = new System.Drawing.Size(137, 20);
            this.LblId_Colaborador.TabIndex = 45;
            this.LblId_Colaborador.Text = "Cód. Colaborador:";
            // 
            // TxtNome_Colaborador
            // 
            this.TxtNome_Colaborador.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtNome_Colaborador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNome_Colaborador.Enabled = false;
            this.TxtNome_Colaborador.Location = new System.Drawing.Point(351, 66);
            this.TxtNome_Colaborador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNome_Colaborador.MaxLength = 50;
            this.TxtNome_Colaborador.Name = "TxtNome_Colaborador";
            this.TxtNome_Colaborador.Size = new System.Drawing.Size(556, 26);
            this.TxtNome_Colaborador.TabIndex = 44;
            this.TxtNome_Colaborador.TextChanged += new System.EventHandler(this.TxtNome_Colaborador_TextChanged);
            // 
            // TxtId_Colaborador
            // 
            this.TxtId_Colaborador.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtId_Colaborador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtId_Colaborador.Enabled = false;
            this.TxtId_Colaborador.Location = new System.Drawing.Point(351, 19);
            this.TxtId_Colaborador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtId_Colaborador.Name = "TxtId_Colaborador";
            this.TxtId_Colaborador.Size = new System.Drawing.Size(41, 26);
            this.TxtId_Colaborador.TabIndex = 43;
            this.TxtId_Colaborador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtId_Colaborador.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtId_Colaborador_KeyDown);
            this.TxtId_Colaborador.Leave += new System.EventHandler(this.txtId_Cargo_Leave);
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
            // TxtEmail
            // 
            this.TxtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtEmail.Enabled = false;
            this.TxtEmail.Location = new System.Drawing.Point(351, 111);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtEmail.MaxLength = 50;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(556, 26);
            this.TxtEmail.TabIndex = 56;
            // 
            // LblEmail
            // 
            this.LblEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(287, 114);
            this.LblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(57, 20);
            this.LblEmail.TabIndex = 57;
            this.LblEmail.Text = "E-mail:";
            // 
            // LblRG
            // 
            this.LblRG.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblRG.AutoSize = true;
            this.LblRG.Location = new System.Drawing.Point(305, 158);
            this.LblRG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblRG.Name = "LblRG";
            this.LblRG.Size = new System.Drawing.Size(38, 20);
            this.LblRG.TabIndex = 59;
            this.LblRG.Text = "RG:";
            // 
            // LblCPF
            // 
            this.LblCPF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblCPF.AutoSize = true;
            this.LblCPF.Location = new System.Drawing.Point(299, 203);
            this.LblCPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCPF.Name = "LblCPF";
            this.LblCPF.Size = new System.Drawing.Size(44, 20);
            this.LblCPF.TabIndex = 61;
            this.LblCPF.Text = "CPF:";
            // 
            // CmbSexo
            // 
            this.CmbSexo.DataSource = this.sexoBindingSource;
            this.CmbSexo.DisplayMember = "Nome_Sexo";
            this.CmbSexo.Enabled = false;
            this.CmbSexo.FormattingEnabled = true;
            this.CmbSexo.Location = new System.Drawing.Point(351, 244);
            this.CmbSexo.Name = "CmbSexo";
            this.CmbSexo.Size = new System.Drawing.Size(266, 28);
            this.CmbSexo.TabIndex = 62;
            this.CmbSexo.ValueMember = "Id_Sexo";
            // 
            // sexoBindingSource
            // 
            this.sexoBindingSource.DataMember = "Sexo";
            this.sexoBindingSource.DataSource = this.checkListDBDataSet;
            // 
            // checkListDBDataSet
            // 
            this.checkListDBDataSet.DataSetName = "CheckListDBDataSet";
            this.checkListDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LblSexo
            // 
            this.LblSexo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblSexo.AutoSize = true;
            this.LblSexo.Location = new System.Drawing.Point(294, 247);
            this.LblSexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSexo.Name = "LblSexo";
            this.LblSexo.Size = new System.Drawing.Size(49, 20);
            this.LblSexo.TabIndex = 63;
            this.LblSexo.Text = "Sexo:";
            // 
            // sexoTableAdapter
            // 
            this.sexoTableAdapter.ClearBeforeFill = true;
            // 
            // CmbSetor
            // 
            this.CmbSetor.DataSource = this.setorBindingSource;
            this.CmbSetor.DisplayMember = "Nome_Setor";
            this.CmbSetor.Enabled = false;
            this.CmbSetor.FormattingEnabled = true;
            this.CmbSetor.Location = new System.Drawing.Point(351, 289);
            this.CmbSetor.Name = "CmbSetor";
            this.CmbSetor.Size = new System.Drawing.Size(266, 28);
            this.CmbSetor.TabIndex = 64;
            this.CmbSetor.ValueMember = "Id_Setor";
            // 
            // cargoBindingSource
            // 
            this.cargoBindingSource.DataMember = "Cargo";
            this.cargoBindingSource.DataSource = this.checkListDBDataSet;
            // 
            // LblSetor
            // 
            this.LblSetor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblSetor.AutoSize = true;
            this.LblSetor.Location = new System.Drawing.Point(291, 292);
            this.LblSetor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSetor.Name = "LblSetor";
            this.LblSetor.Size = new System.Drawing.Size(52, 20);
            this.LblSetor.TabIndex = 65;
            this.LblSetor.Text = "Setor:";
            // 
            // cargoTableAdapter
            // 
            this.cargoTableAdapter.ClearBeforeFill = true;
            // 
            // CmbCargo
            // 
            this.CmbCargo.DataSource = this.cargoBindingSource1;
            this.CmbCargo.DisplayMember = "Nome_Cargo";
            this.CmbCargo.Enabled = false;
            this.CmbCargo.FormattingEnabled = true;
            this.CmbCargo.Location = new System.Drawing.Point(351, 336);
            this.CmbCargo.Name = "CmbCargo";
            this.CmbCargo.Size = new System.Drawing.Size(266, 28);
            this.CmbCargo.TabIndex = 66;
            this.CmbCargo.ValueMember = "Id_Cargo";
            // 
            // tipoUsuarioBindingSource
            // 
            this.tipoUsuarioBindingSource.DataMember = "Tipo_Usuario";
            this.tipoUsuarioBindingSource.DataSource = this.checkListDBDataSet;
            // 
            // LblCargo
            // 
            this.LblCargo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblCargo.AutoSize = true;
            this.LblCargo.Location = new System.Drawing.Point(287, 339);
            this.LblCargo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCargo.Name = "LblCargo";
            this.LblCargo.Size = new System.Drawing.Size(56, 20);
            this.LblCargo.TabIndex = 67;
            this.LblCargo.Text = "Cargo:";
            // 
            // tipo_UsuarioTableAdapter
            // 
            this.tipo_UsuarioTableAdapter.ClearBeforeFill = true;
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
            // cargoBindingSource1
            // 
            this.cargoBindingSource1.DataMember = "Cargo";
            this.cargoBindingSource1.DataSource = this.checkListDBDataSet;
            // 
            // MtbCpf
            // 
            this.MtbCpf.Enabled = false;
            this.MtbCpf.Location = new System.Drawing.Point(350, 200);
            this.MtbCpf.Mask = "000.000.000-00";
            this.MtbCpf.Name = "MtbCpf";
            this.MtbCpf.Size = new System.Drawing.Size(124, 26);
            this.MtbCpf.TabIndex = 68;
            // 
            // MtbRg
            // 
            this.MtbRg.Enabled = false;
            this.MtbRg.Location = new System.Drawing.Point(350, 155);
            this.MtbRg.Mask = "0000000-0";
            this.MtbRg.Name = "MtbRg";
            this.MtbRg.Size = new System.Drawing.Size(87, 26);
            this.MtbRg.TabIndex = 69;
            // 
            // Frm_CColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.ControlBox = false;
            this.Controls.Add(this.MtbRg);
            this.Controls.Add(this.MtbCpf);
            this.Controls.Add(this.LblCargo);
            this.Controls.Add(this.CmbCargo);
            this.Controls.Add(this.LblSetor);
            this.Controls.Add(this.CmbSetor);
            this.Controls.Add(this.LblSexo);
            this.Controls.Add(this.CmbSexo);
            this.Controls.Add(this.LblCPF);
            this.Controls.Add(this.LblRG);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnAjuda);
            this.Controls.Add(this.LblNome_Colaborador);
            this.Controls.Add(this.LblId_Colaborador);
            this.Controls.Add(this.TxtNome_Colaborador);
            this.Controls.Add(this.TxtId_Colaborador);
            this.Controls.Add(this.BtnRelatorio);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.BtnNovo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_CColaborador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Colaborador";
            this.Load += new System.EventHandler(this.Frm_CColaborador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sexoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkListDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource1)).EndInit();
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
        private System.Windows.Forms.Label LblNome_Colaborador;
        private System.Windows.Forms.Label LblId_Colaborador;
        private System.Windows.Forms.TextBox TxtNome_Colaborador;
        private System.Windows.Forms.TextBox TxtId_Colaborador;
        private System.Windows.Forms.Button BtnAjuda;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblRG;
        private System.Windows.Forms.Label LblCPF;
        private System.Windows.Forms.ComboBox CmbSexo;
        private System.Windows.Forms.Label LblSexo;
        private CheckListDBDataSet checkListDBDataSet;
        private System.Windows.Forms.BindingSource sexoBindingSource;
        private CheckListDBDataSetTableAdapters.SexoTableAdapter sexoTableAdapter;
        private System.Windows.Forms.ComboBox CmbSetor;
        private System.Windows.Forms.Label LblSetor;
        private System.Windows.Forms.BindingSource cargoBindingSource;
        private CheckListDBDataSetTableAdapters.CargoTableAdapter cargoTableAdapter;
        private System.Windows.Forms.ComboBox CmbCargo;
        private System.Windows.Forms.Label LblCargo;
        private System.Windows.Forms.BindingSource tipoUsuarioBindingSource;
        private CheckListDBDataSetTableAdapters.Tipo_UsuarioTableAdapter tipo_UsuarioTableAdapter;
        private System.Windows.Forms.BindingSource setorBindingSource;
        private CheckListDBDataSetTableAdapters.SetorTableAdapter setorTableAdapter;
        private System.Windows.Forms.BindingSource cargoBindingSource1;
        private System.Windows.Forms.MaskedTextBox MtbCpf;
        private System.Windows.Forms.MaskedTextBox MtbRg;
    }
}