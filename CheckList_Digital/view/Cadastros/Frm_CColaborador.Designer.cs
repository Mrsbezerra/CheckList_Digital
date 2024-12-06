namespace CheckList_Digital.view
{
    partial class Frm_CUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CUsuario));
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.BtnRelatorio = new System.Windows.Forms.Button();
            this.LblNome_Usuario = new System.Windows.Forms.Label();
            this.LblId_Usuário = new System.Windows.Forms.Label();
            this.TxtNome_Usuario = new System.Windows.Forms.TextBox();
            this.TxtId_Usuario = new System.Windows.Forms.TextBox();
            this.BtnAjuda = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.TxtLogin = new System.Windows.Forms.TextBox();
            this.LblLogin = new System.Windows.Forms.Label();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.LblSenha = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.CmbSexo = new System.Windows.Forms.ComboBox();
            this.LblSexo = new System.Windows.Forms.Label();
            this.checkListDBDataSet = new CheckList_Digital.CheckListDBDataSet();
            this.sexoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sexoTableAdapter = new CheckList_Digital.CheckListDBDataSetTableAdapters.SexoTableAdapter();
            this.CmbCargo = new System.Windows.Forms.ComboBox();
            this.LblCargo = new System.Windows.Forms.Label();
            this.cargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cargoTableAdapter = new CheckList_Digital.CheckListDBDataSetTableAdapters.CargoTableAdapter();
            this.CmbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.LblTipoUsuario = new System.Windows.Forms.Label();
            this.tipoUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipo_UsuarioTableAdapter = new CheckList_Digital.CheckListDBDataSetTableAdapters.Tipo_UsuarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.checkListDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoUsuarioBindingSource)).BeginInit();
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
            // LblNome_Usuario
            // 
            this.LblNome_Usuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblNome_Usuario.AutoSize = true;
            this.LblNome_Usuario.Location = new System.Drawing.Point(275, 69);
            this.LblNome_Usuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNome_Usuario.Name = "LblNome_Usuario";
            this.LblNome_Usuario.Size = new System.Drawing.Size(68, 20);
            this.LblNome_Usuario.TabIndex = 46;
            this.LblNome_Usuario.Text = "Usuário:";
            // 
            // LblId_Usuário
            // 
            this.LblId_Usuário.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblId_Usuário.AutoSize = true;
            this.LblId_Usuário.Location = new System.Drawing.Point(238, 22);
            this.LblId_Usuário.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblId_Usuário.Name = "LblId_Usuário";
            this.LblId_Usuário.Size = new System.Drawing.Size(105, 20);
            this.LblId_Usuário.TabIndex = 45;
            this.LblId_Usuário.Text = "Cód. Usuário:";
            // 
            // TxtNome_Usuario
            // 
            this.TxtNome_Usuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtNome_Usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNome_Usuario.Enabled = false;
            this.TxtNome_Usuario.Location = new System.Drawing.Point(351, 66);
            this.TxtNome_Usuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNome_Usuario.MaxLength = 50;
            this.TxtNome_Usuario.Name = "TxtNome_Usuario";
            this.TxtNome_Usuario.Size = new System.Drawing.Size(556, 26);
            this.TxtNome_Usuario.TabIndex = 44;
            this.TxtNome_Usuario.TextChanged += new System.EventHandler(this.TxtNome_Usuario_TextChanged);
            // 
            // TxtId_Usuario
            // 
            this.TxtId_Usuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtId_Usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtId_Usuario.Enabled = false;
            this.TxtId_Usuario.Location = new System.Drawing.Point(351, 19);
            this.TxtId_Usuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtId_Usuario.Name = "TxtId_Usuario";
            this.TxtId_Usuario.Size = new System.Drawing.Size(41, 26);
            this.TxtId_Usuario.TabIndex = 43;
            this.TxtId_Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtId_Usuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtId_Usuario_KeyDown);
            this.TxtId_Usuario.Leave += new System.EventHandler(this.txtId_Cargo_Leave);
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
            // TxtLogin
            // 
            this.TxtLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtLogin.Enabled = false;
            this.TxtLogin.Location = new System.Drawing.Point(351, 111);
            this.TxtLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtLogin.MaxLength = 50;
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.Size = new System.Drawing.Size(556, 26);
            this.TxtLogin.TabIndex = 56;
            // 
            // LblLogin
            // 
            this.LblLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblLogin.AutoSize = true;
            this.LblLogin.Location = new System.Drawing.Point(291, 114);
            this.LblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(52, 20);
            this.LblLogin.TabIndex = 57;
            this.LblLogin.Text = "Login:";
            // 
            // TxtSenha
            // 
            this.TxtSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtSenha.Enabled = false;
            this.TxtSenha.Location = new System.Drawing.Point(351, 155);
            this.TxtSenha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSenha.MaxLength = 50;
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(556, 26);
            this.TxtSenha.TabIndex = 58;
            // 
            // LblSenha
            // 
            this.LblSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblSenha.AutoSize = true;
            this.LblSenha.Location = new System.Drawing.Point(283, 158);
            this.LblSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSenha.Name = "LblSenha";
            this.LblSenha.Size = new System.Drawing.Size(60, 20);
            this.LblSenha.TabIndex = 59;
            this.LblSenha.Text = "Senha:";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtEmail.Enabled = false;
            this.TxtEmail.Location = new System.Drawing.Point(351, 200);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtEmail.MaxLength = 50;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(556, 26);
            this.TxtEmail.TabIndex = 60;
            // 
            // LblEmail
            // 
            this.LblEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(286, 203);
            this.LblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(57, 20);
            this.LblEmail.TabIndex = 61;
            this.LblEmail.Text = "E-Mail:";
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
            // checkListDBDataSet
            // 
            this.checkListDBDataSet.DataSetName = "CheckListDBDataSet";
            this.checkListDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sexoBindingSource
            // 
            this.sexoBindingSource.DataMember = "Sexo";
            this.sexoBindingSource.DataSource = this.checkListDBDataSet;
            // 
            // sexoTableAdapter
            // 
            this.sexoTableAdapter.ClearBeforeFill = true;
            // 
            // CmbCargo
            // 
            this.CmbCargo.DataSource = this.cargoBindingSource;
            this.CmbCargo.DisplayMember = "Nome_Cargo";
            this.CmbCargo.Enabled = false;
            this.CmbCargo.FormattingEnabled = true;
            this.CmbCargo.Location = new System.Drawing.Point(351, 289);
            this.CmbCargo.Name = "CmbCargo";
            this.CmbCargo.Size = new System.Drawing.Size(266, 28);
            this.CmbCargo.TabIndex = 64;
            this.CmbCargo.ValueMember = "Id_Cargo";
            // 
            // LblCargo
            // 
            this.LblCargo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblCargo.AutoSize = true;
            this.LblCargo.Location = new System.Drawing.Point(287, 292);
            this.LblCargo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCargo.Name = "LblCargo";
            this.LblCargo.Size = new System.Drawing.Size(56, 20);
            this.LblCargo.TabIndex = 65;
            this.LblCargo.Text = "Cargo:";
            // 
            // cargoBindingSource
            // 
            this.cargoBindingSource.DataMember = "Cargo";
            this.cargoBindingSource.DataSource = this.checkListDBDataSet;
            // 
            // cargoTableAdapter
            // 
            this.cargoTableAdapter.ClearBeforeFill = true;
            // 
            // CmbTipoUsuario
            // 
            this.CmbTipoUsuario.DataSource = this.tipoUsuarioBindingSource;
            this.CmbTipoUsuario.DisplayMember = "Nome_Tipo";
            this.CmbTipoUsuario.Enabled = false;
            this.CmbTipoUsuario.FormattingEnabled = true;
            this.CmbTipoUsuario.Location = new System.Drawing.Point(351, 336);
            this.CmbTipoUsuario.Name = "CmbTipoUsuario";
            this.CmbTipoUsuario.Size = new System.Drawing.Size(266, 28);
            this.CmbTipoUsuario.TabIndex = 66;
            this.CmbTipoUsuario.ValueMember = "Id_Tipo_Usuario";
            // 
            // LblTipoUsuario
            // 
            this.LblTipoUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblTipoUsuario.AutoSize = true;
            this.LblTipoUsuario.Location = new System.Drawing.Point(242, 339);
            this.LblTipoUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTipoUsuario.Name = "LblTipoUsuario";
            this.LblTipoUsuario.Size = new System.Drawing.Size(102, 20);
            this.LblTipoUsuario.TabIndex = 67;
            this.LblTipoUsuario.Text = "Tipo Usuário:";
            // 
            // tipoUsuarioBindingSource
            // 
            this.tipoUsuarioBindingSource.DataMember = "Tipo_Usuario";
            this.tipoUsuarioBindingSource.DataSource = this.checkListDBDataSet;
            // 
            // tipo_UsuarioTableAdapter
            // 
            this.tipo_UsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_CUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.ControlBox = false;
            this.Controls.Add(this.LblTipoUsuario);
            this.Controls.Add(this.CmbTipoUsuario);
            this.Controls.Add(this.LblCargo);
            this.Controls.Add(this.CmbCargo);
            this.Controls.Add(this.LblSexo);
            this.Controls.Add(this.CmbSexo);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.LblSenha);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.LblLogin);
            this.Controls.Add(this.TxtLogin);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnAjuda);
            this.Controls.Add(this.LblNome_Usuario);
            this.Controls.Add(this.LblId_Usuário);
            this.Controls.Add(this.TxtNome_Usuario);
            this.Controls.Add(this.TxtId_Usuario);
            this.Controls.Add(this.BtnRelatorio);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.BtnNovo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_CUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Usuário";
            this.Load += new System.EventHandler(this.Frm_CUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.checkListDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoUsuarioBindingSource)).EndInit();
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
        private System.Windows.Forms.Label LblNome_Usuario;
        private System.Windows.Forms.Label LblId_Usuário;
        private System.Windows.Forms.TextBox TxtNome_Usuario;
        private System.Windows.Forms.TextBox TxtId_Usuario;
        private System.Windows.Forms.Button BtnAjuda;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.TextBox TxtLogin;
        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.Label LblSenha;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.ComboBox CmbSexo;
        private System.Windows.Forms.Label LblSexo;
        private CheckListDBDataSet checkListDBDataSet;
        private System.Windows.Forms.BindingSource sexoBindingSource;
        private CheckListDBDataSetTableAdapters.SexoTableAdapter sexoTableAdapter;
        private System.Windows.Forms.ComboBox CmbCargo;
        private System.Windows.Forms.Label LblCargo;
        private System.Windows.Forms.BindingSource cargoBindingSource;
        private CheckListDBDataSetTableAdapters.CargoTableAdapter cargoTableAdapter;
        private System.Windows.Forms.ComboBox CmbTipoUsuario;
        private System.Windows.Forms.Label LblTipoUsuario;
        private System.Windows.Forms.BindingSource tipoUsuarioBindingSource;
        private CheckListDBDataSetTableAdapters.Tipo_UsuarioTableAdapter tipo_UsuarioTableAdapter;
    }
}