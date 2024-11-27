namespace CheckList_Digital.view
{
    partial class Frm_Usuario
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
            System.Windows.Forms.Label id_UsuarioLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label senhaLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label id_Sexo_fkLabel;
            System.Windows.Forms.Label id_Cargo_fkLabel;
            System.Windows.Forms.Label id_Tipo_Usuario_fkLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Usuario));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TsbNovo = new System.Windows.Forms.ToolStripButton();
            this.TsbSalvar = new System.Windows.Forms.ToolStripButton();
            this.TsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.TsbEditar = new System.Windows.Forms.ToolStripButton();
            this.TsbExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblBuscaId = new System.Windows.Forms.ToolStripLabel();
            this.TxtBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.BtnBuscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnPrimeiro = new System.Windows.Forms.ToolStripButton();
            this.BtnAnterior = new System.Windows.Forms.ToolStripButton();
            this.BtnProximo = new System.Windows.Forms.ToolStripButton();
            this.BtnUltimo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnRelatorio = new System.Windows.Forms.ToolStripButton();
            this.DgvUsuario = new System.Windows.Forms.DataGridView();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkListDBDataSet = new CheckList_Digital.CheckListDBDataSet();
            this.LblTotal_Registros2 = new System.Windows.Forms.Label();
            this.lblTotal_Registros = new System.Windows.Forms.Label();
           // this.usuarioTableAdapter = new CheckList_Digital.CheckListDBDataSetTableAdapters.UsuarioTableAdapter();
            this.tableAdapterManager = new CheckList_Digital.CheckListDBDataSetTableAdapters.TableAdapterManager();
           // this.cargoTableAdapter = new CheckList_Digital.CheckListDBDataSetTableAdapters.CargoTableAdapter();
            this.sexoTableAdapter = new CheckList_Digital.CheckListDBDataSetTableAdapters.SexoTableAdapter();
           // this.tipo_UsuarioTableAdapter = new CheckList_Digital.CheckListDBDataSetTableAdapters.Tipo_UsuarioTableAdapter();
            this.TxtId_Usuario = new System.Windows.Forms.Label();
            this.TxtNome_Usuario = new System.Windows.Forms.TextBox();
            this.TxtLogin = new System.Windows.Forms.TextBox();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.CmbSexo = new System.Windows.Forms.ComboBox();
            this.sexoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CmbCargo = new System.Windows.Forms.ComboBox();
            this.cargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CmbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.tipo_UsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSexofkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCargofkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTipoUsuariofkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            id_UsuarioLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            loginLabel = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            id_Sexo_fkLabel = new System.Windows.Forms.Label();
            id_Cargo_fkLabel = new System.Windows.Forms.Label();
            id_Tipo_Usuario_fkLabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkListDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipo_UsuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_UsuarioLabel
            // 
            id_UsuarioLabel.AutoSize = true;
            id_UsuarioLabel.Location = new System.Drawing.Point(14, 45);
            id_UsuarioLabel.Name = "id_UsuarioLabel";
            id_UsuarioLabel.Size = new System.Drawing.Size(43, 13);
            id_UsuarioLabel.TabIndex = 69;
            id_UsuarioLabel.Text = "Código:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(14, 74);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 71;
            nomeLabel.Text = "Nome:";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new System.Drawing.Point(14, 100);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(36, 13);
            loginLabel.TabIndex = 73;
            loginLabel.Text = "Login:";
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Location = new System.Drawing.Point(14, 126);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(41, 13);
            senhaLabel.TabIndex = 75;
            senhaLabel.Text = "Senha:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(14, 152);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 77;
            emailLabel.Text = "Email:";
            // 
            // id_Sexo_fkLabel
            // 
            id_Sexo_fkLabel.AutoSize = true;
            id_Sexo_fkLabel.Location = new System.Drawing.Point(381, 68);
            id_Sexo_fkLabel.Name = "id_Sexo_fkLabel";
            id_Sexo_fkLabel.Size = new System.Drawing.Size(58, 13);
            id_Sexo_fkLabel.TabIndex = 79;
            id_Sexo_fkLabel.Text = "Id Sexo fk:";
            // 
            // id_Cargo_fkLabel
            // 
            id_Cargo_fkLabel.AutoSize = true;
            id_Cargo_fkLabel.Location = new System.Drawing.Point(381, 95);
            id_Cargo_fkLabel.Name = "id_Cargo_fkLabel";
            id_Cargo_fkLabel.Size = new System.Drawing.Size(62, 13);
            id_Cargo_fkLabel.TabIndex = 81;
            id_Cargo_fkLabel.Text = "Id Cargo fk:";
            // 
            // id_Tipo_Usuario_fkLabel
            // 
            id_Tipo_Usuario_fkLabel.AutoSize = true;
            id_Tipo_Usuario_fkLabel.Location = new System.Drawing.Point(381, 122);
            id_Tipo_Usuario_fkLabel.Name = "id_Tipo_Usuario_fkLabel";
            id_Tipo_Usuario_fkLabel.Size = new System.Drawing.Size(94, 13);
            id_Tipo_Usuario_fkLabel.TabIndex = 83;
            id_Tipo_Usuario_fkLabel.Text = "Id Tipo Usuario fk:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AllowMerge = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbNovo,
            this.TsbSalvar,
            this.TsbCancelar,
            this.TsbEditar,
            this.TsbExcluir,
            this.toolStripSeparator1,
            this.lblBuscaId,
            this.TxtBuscar,
            this.BtnBuscar,
            this.toolStripSeparator2,
            this.BtnPrimeiro,
            this.BtnAnterior,
            this.BtnProximo,
            this.BtnUltimo,
            this.toolStripSeparator3,
            this.BtnRelatorio});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(820, 25);
            this.toolStrip1.TabIndex = 65;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TsbNovo
            // 
            this.TsbNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbNovo.Image = ((System.Drawing.Image)(resources.GetObject("TsbNovo.Image")));
            this.TsbNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbNovo.Name = "TsbNovo";
            this.TsbNovo.Size = new System.Drawing.Size(23, 22);
            this.TsbNovo.Text = "toolStripButton1";
            this.TsbNovo.ToolTipText = "Adicionar Novo Usuario";
            this.TsbNovo.Click += new System.EventHandler(this.TsbNovo_Click);
            // 
            // TsbSalvar
            // 
            this.TsbSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbSalvar.Image = ((System.Drawing.Image)(resources.GetObject("TsbSalvar.Image")));
            this.TsbSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbSalvar.Name = "TsbSalvar";
            this.TsbSalvar.Size = new System.Drawing.Size(23, 22);
            this.TsbSalvar.Text = "toolStripButton1";
            this.TsbSalvar.ToolTipText = "Salvar Usuario";
            this.TsbSalvar.Click += new System.EventHandler(this.TsbSalvar_Click);
            // 
            // TsbCancelar
            // 
            this.TsbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("TsbCancelar.Image")));
            this.TsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbCancelar.Name = "TsbCancelar";
            this.TsbCancelar.Size = new System.Drawing.Size(23, 22);
            this.TsbCancelar.Text = "toolStripButton1";
            this.TsbCancelar.ToolTipText = "Cancelar";
            this.TsbCancelar.Click += new System.EventHandler(this.TsbCancelar_Click);
            // 
            // TsbEditar
            // 
            this.TsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbEditar.Image = ((System.Drawing.Image)(resources.GetObject("TsbEditar.Image")));
            this.TsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbEditar.Name = "TsbEditar";
            this.TsbEditar.Size = new System.Drawing.Size(23, 22);
            this.TsbEditar.Text = "toolStripButton2";
            this.TsbEditar.ToolTipText = "Alterar Registro";
            this.TsbEditar.Click += new System.EventHandler(this.TsbEditar_Click);
            // 
            // TsbExcluir
            // 
            this.TsbExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbExcluir.Image = ((System.Drawing.Image)(resources.GetObject("TsbExcluir.Image")));
            this.TsbExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbExcluir.Name = "TsbExcluir";
            this.TsbExcluir.Size = new System.Drawing.Size(23, 22);
            this.TsbExcluir.Text = "toolStripButton1";
            this.TsbExcluir.ToolTipText = "Excluir Registro";
            this.TsbExcluir.Click += new System.EventHandler(this.TsbExcluir_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // lblBuscaId
            // 
            this.lblBuscaId.Name = "lblBuscaId";
            this.lblBuscaId.Size = new System.Drawing.Size(88, 22);
            this.lblBuscaId.Text = "Buscar Usuario:";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(180, 25);
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(23, 22);
            this.BtnBuscar.Text = "toolStripButton1";
            this.BtnBuscar.ToolTipText = "Buscar Usuario";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // BtnPrimeiro
            // 
            this.BtnPrimeiro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnPrimeiro.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrimeiro.Image")));
            this.BtnPrimeiro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnPrimeiro.Name = "BtnPrimeiro";
            this.BtnPrimeiro.Size = new System.Drawing.Size(23, 22);
            this.BtnPrimeiro.Text = "toolStripButton1";
            this.BtnPrimeiro.ToolTipText = "Primeiro Registro";
            this.BtnPrimeiro.Click += new System.EventHandler(this.BtnPrimeiro_Click);
            // 
            // BtnAnterior
            // 
            this.BtnAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("BtnAnterior.Image")));
            this.BtnAnterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAnterior.Name = "BtnAnterior";
            this.BtnAnterior.Size = new System.Drawing.Size(23, 22);
            this.BtnAnterior.Text = "Registro Anterior";
            this.BtnAnterior.Click += new System.EventHandler(this.BtnAnterior_Click);
            // 
            // BtnProximo
            // 
            this.BtnProximo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnProximo.Image = ((System.Drawing.Image)(resources.GetObject("BtnProximo.Image")));
            this.BtnProximo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnProximo.Name = "BtnProximo";
            this.BtnProximo.Size = new System.Drawing.Size(23, 22);
            this.BtnProximo.Text = "toolStripButton1";
            this.BtnProximo.ToolTipText = "Próximo Registro";
            this.BtnProximo.Click += new System.EventHandler(this.BtnProximo_Click);
            // 
            // BtnUltimo
            // 
            this.BtnUltimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnUltimo.Image = ((System.Drawing.Image)(resources.GetObject("BtnUltimo.Image")));
            this.BtnUltimo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnUltimo.Name = "BtnUltimo";
            this.BtnUltimo.Size = new System.Drawing.Size(23, 22);
            this.BtnUltimo.Text = "toolStripButton1";
            this.BtnUltimo.ToolTipText = "Último Registro";
            this.BtnUltimo.Click += new System.EventHandler(this.BtnUltimo_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // BtnRelatorio
            // 
            this.BtnRelatorio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("BtnRelatorio.Image")));
            this.BtnRelatorio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnRelatorio.Name = "BtnRelatorio";
            this.BtnRelatorio.Size = new System.Drawing.Size(23, 22);
            this.BtnRelatorio.Text = "toolStripButton1";
            this.BtnRelatorio.ToolTipText = "Gerar Relatório";
            // 
            // DgvUsuario
            // 
            this.DgvUsuario.AllowUserToAddRows = false;
            this.DgvUsuario.AutoGenerateColumns = false;
            this.DgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsuarioDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.senhaDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.idSexofkDataGridViewTextBoxColumn,
            this.idCargofkDataGridViewTextBoxColumn,
            this.idTipoUsuariofkDataGridViewTextBoxColumn});
            this.DgvUsuario.DataSource = this.usuarioBindingSource;
            this.DgvUsuario.Location = new System.Drawing.Point(8, 199);
            this.DgvUsuario.MultiSelect = false;
            this.DgvUsuario.Name = "DgvUsuario";
            this.DgvUsuario.ReadOnly = true;
            this.DgvUsuario.Size = new System.Drawing.Size(800, 180);
            this.DgvUsuario.TabIndex = 66;
            this.DgvUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUsuario_CellClick);
            this.DgvUsuario.SelectionChanged += new System.EventHandler(this.DgvUsuario_SelectionChanged);
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
            // LblTotal_Registros2
            // 
            this.LblTotal_Registros2.AutoSize = true;
            this.LblTotal_Registros2.Location = new System.Drawing.Point(770, 45);
            this.LblTotal_Registros2.Name = "LblTotal_Registros2";
            this.LblTotal_Registros2.Size = new System.Drawing.Size(13, 13);
            this.LblTotal_Registros2.TabIndex = 68;
            this.LblTotal_Registros2.Text = "0";
            // 
            // lblTotal_Registros
            // 
            this.lblTotal_Registros.AutoSize = true;
            this.lblTotal_Registros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal_Registros.Location = new System.Drawing.Point(650, 45);
            this.lblTotal_Registros.Name = "lblTotal_Registros";
            this.lblTotal_Registros.Size = new System.Drawing.Size(97, 13);
            this.lblTotal_Registros.TabIndex = 67;
            this.lblTotal_Registros.Text = "Total Registros:";
            // 
            // usuarioTableAdapter
            // 
            //this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            //this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            //this.tableAdapterManager.CargoTableAdapter = this.cargoTableAdapter;
            //this.tableAdapterManager.ColaboradorTableAdapter = null;
            //this.tableAdapterManager.Entrega_EPITableAdapter = null;
            //this.tableAdapterManager.EPITableAdapter = null;
            //this.tableAdapterManager.Inspecao_ColaboradorTableAdapter = null;
            //this.tableAdapterManager.Inspecao_SetorTableAdapter = null;
            //this.tableAdapterManager.InspecaoTableAdapter = null;
            //this.tableAdapterManager.Item_ChecklistTableAdapter = null;
            //this.tableAdapterManager.Itens_Entrega_EPITableAdapter = null;
            //this.tableAdapterManager.Itens_Inspecao_ColaboradorTableAdapter = null;
            //this.tableAdapterManager.Itens_Inspecao_SetorTableAdapter = null;
            //this.tableAdapterManager.Relatorio_RiscoTableAdapter = null;
            //this.tableAdapterManager.Resultado_ChecklistTableAdapter = null;
            //this.tableAdapterManager.SetorTableAdapter = null;
            //this.tableAdapterManager.SexoTableAdapter = this.sexoTableAdapter;
            //this.tableAdapterManager.Tipo_UsuarioTableAdapter = this.tipo_UsuarioTableAdapter;
            //this.tableAdapterManager.UpdateOrder = CheckList_Digital.CheckListDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            //this.tableAdapterManager.UsuarioTableAdapter = this.usuarioTableAdapter;
            // 
            // cargoTableAdapter
            // 
            //this.cargoTableAdapter.ClearBeforeFill = true;
            // 
            // sexoTableAdapter
            // 
            this.sexoTableAdapter.ClearBeforeFill = true;
            // 
            // tipo_UsuarioTableAdapter
            // 
           // this.tipo_UsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // TxtId_Usuario
            // 
            this.TxtId_Usuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Id_Usuario", true));
            this.TxtId_Usuario.Location = new System.Drawing.Point(114, 45);
            this.TxtId_Usuario.Name = "TxtId_Usuario";
            this.TxtId_Usuario.Size = new System.Drawing.Size(121, 23);
            this.TxtId_Usuario.TabIndex = 70;
            // 
            // TxtNome_Usuario
            // 
            this.TxtNome_Usuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Nome", true));
            this.TxtNome_Usuario.Location = new System.Drawing.Point(114, 71);
            this.TxtNome_Usuario.Name = "TxtNome_Usuario";
            this.TxtNome_Usuario.Size = new System.Drawing.Size(261, 20);
            this.TxtNome_Usuario.TabIndex = 72;
            // 
            // TxtLogin
            // 
            this.TxtLogin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Login", true));
            this.TxtLogin.Location = new System.Drawing.Point(114, 97);
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.Size = new System.Drawing.Size(261, 20);
            this.TxtLogin.TabIndex = 74;
            // 
            // TxtSenha
            // 
            this.TxtSenha.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Senha", true));
            this.TxtSenha.Location = new System.Drawing.Point(114, 123);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(261, 20);
            this.TxtSenha.TabIndex = 76;
            // 
            // TxtEmail
            // 
            this.TxtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Email", true));
            this.TxtEmail.Location = new System.Drawing.Point(114, 149);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(261, 20);
            this.TxtEmail.TabIndex = 78;
            // 
            // CmbSexo
            // 
            this.CmbSexo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.usuarioBindingSource, "Id_Sexo_fk", true));
            this.CmbSexo.DataSource = this.sexoBindingSource;
            this.CmbSexo.DisplayMember = "Nome_Sexo";
            this.CmbSexo.FormattingEnabled = true;
            this.CmbSexo.Location = new System.Drawing.Point(481, 65);
            this.CmbSexo.Name = "CmbSexo";
            this.CmbSexo.Size = new System.Drawing.Size(121, 21);
            this.CmbSexo.TabIndex = 80;
            this.CmbSexo.ValueMember = "Id_Sexo";
            // 
            // sexoBindingSource
            // 
            this.sexoBindingSource.DataMember = "Sexo";
            this.sexoBindingSource.DataSource = this.checkListDBDataSet;
            // 
            // CmbCargo
            // 
            this.CmbCargo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.usuarioBindingSource, "Id_Cargo_fk", true));
            this.CmbCargo.DataSource = this.cargoBindingSource;
            this.CmbCargo.DisplayMember = "Nome_Cargo";
            this.CmbCargo.FormattingEnabled = true;
            this.CmbCargo.Location = new System.Drawing.Point(481, 92);
            this.CmbCargo.Name = "CmbCargo";
            this.CmbCargo.Size = new System.Drawing.Size(121, 21);
            this.CmbCargo.TabIndex = 82;
            this.CmbCargo.ValueMember = "Id_Cargo";
            // 
            // cargoBindingSource
            // 
            this.cargoBindingSource.DataMember = "Cargo";
            this.cargoBindingSource.DataSource = this.checkListDBDataSet;
            // 
            // CmbTipoUsuario
            // 
            this.CmbTipoUsuario.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.usuarioBindingSource, "Id_Tipo_Usuario_fk", true));
            this.CmbTipoUsuario.DataSource = this.tipo_UsuarioBindingSource;
            this.CmbTipoUsuario.DisplayMember = "Nome_Tipo";
            this.CmbTipoUsuario.FormattingEnabled = true;
            this.CmbTipoUsuario.Location = new System.Drawing.Point(481, 119);
            this.CmbTipoUsuario.Name = "CmbTipoUsuario";
            this.CmbTipoUsuario.Size = new System.Drawing.Size(121, 21);
            this.CmbTipoUsuario.TabIndex = 84;
            this.CmbTipoUsuario.ValueMember = "Id_Tipo_Usuario";
            // 
            // tipo_UsuarioBindingSource
            // 
            this.tipo_UsuarioBindingSource.DataMember = "Tipo_Usuario";
            this.tipo_UsuarioBindingSource.DataSource = this.checkListDBDataSet;
            // 
            // idUsuarioDataGridViewTextBoxColumn
            // 
            this.idUsuarioDataGridViewTextBoxColumn.DataPropertyName = "Id_Usuario";
            this.idUsuarioDataGridViewTextBoxColumn.HeaderText = "Código";
            this.idUsuarioDataGridViewTextBoxColumn.Name = "idUsuarioDataGridViewTextBoxColumn";
            this.idUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // senhaDataGridViewTextBoxColumn
            // 
            this.senhaDataGridViewTextBoxColumn.DataPropertyName = "Senha";
            this.senhaDataGridViewTextBoxColumn.HeaderText = "Senha";
            this.senhaDataGridViewTextBoxColumn.Name = "senhaDataGridViewTextBoxColumn";
            this.senhaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idSexofkDataGridViewTextBoxColumn
            // 
            this.idSexofkDataGridViewTextBoxColumn.DataPropertyName = "Id_Sexo_fk";
            this.idSexofkDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.idSexofkDataGridViewTextBoxColumn.Name = "idSexofkDataGridViewTextBoxColumn";
            this.idSexofkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idCargofkDataGridViewTextBoxColumn
            // 
            this.idCargofkDataGridViewTextBoxColumn.DataPropertyName = "Id_Cargo_fk";
            this.idCargofkDataGridViewTextBoxColumn.HeaderText = "Cargo";
            this.idCargofkDataGridViewTextBoxColumn.Name = "idCargofkDataGridViewTextBoxColumn";
            this.idCargofkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idTipoUsuariofkDataGridViewTextBoxColumn
            // 
            this.idTipoUsuariofkDataGridViewTextBoxColumn.DataPropertyName = "Id_Tipo_Usuario_fk";
            this.idTipoUsuariofkDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.idTipoUsuariofkDataGridViewTextBoxColumn.Name = "idTipoUsuariofkDataGridViewTextBoxColumn";
            this.idTipoUsuariofkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Frm_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 616);
            this.Controls.Add(id_UsuarioLabel);
            this.Controls.Add(this.TxtId_Usuario);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.TxtNome_Usuario);
            this.Controls.Add(loginLabel);
            this.Controls.Add(this.TxtLogin);
            this.Controls.Add(senhaLabel);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(id_Sexo_fkLabel);
            this.Controls.Add(this.CmbSexo);
            this.Controls.Add(id_Cargo_fkLabel);
            this.Controls.Add(this.CmbCargo);
            this.Controls.Add(id_Tipo_Usuario_fkLabel);
            this.Controls.Add(this.CmbTipoUsuario);
            this.Controls.Add(this.LblTotal_Registros2);
            this.Controls.Add(this.lblTotal_Registros);
            this.Controls.Add(this.DgvUsuario);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Frm_Usuario";
            this.ShowIcon = false;
            this.Text = "Cadastro Usuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Usuario_Load_1);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkListDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipo_UsuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TsbNovo;
        private System.Windows.Forms.ToolStripButton TsbSalvar;
        private System.Windows.Forms.ToolStripButton TsbCancelar;
        private System.Windows.Forms.ToolStripButton TsbEditar;
        private System.Windows.Forms.ToolStripButton TsbExcluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel lblBuscaId;
        private System.Windows.Forms.ToolStripTextBox TxtBuscar;
        private System.Windows.Forms.ToolStripButton BtnBuscar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton BtnPrimeiro;
        private System.Windows.Forms.ToolStripButton BtnAnterior;
        private System.Windows.Forms.ToolStripButton BtnProximo;
        private System.Windows.Forms.ToolStripButton BtnUltimo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton BtnRelatorio;
        private System.Windows.Forms.DataGridView DgvUsuario;
        private System.Windows.Forms.Label LblTotal_Registros2;
        private System.Windows.Forms.Label lblTotal_Registros;
        private CheckListDBDataSet checkListDBDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        
        private CheckListDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private CheckListDBDataSetTableAdapters.SexoTableAdapter sexoTableAdapter;
        private System.Windows.Forms.Label TxtId_Usuario;
        private System.Windows.Forms.TextBox TxtNome_Usuario;
        private System.Windows.Forms.TextBox TxtLogin;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.ComboBox CmbSexo;
        private System.Windows.Forms.ComboBox CmbCargo;
        private System.Windows.Forms.ComboBox CmbTipoUsuario;
        private System.Windows.Forms.BindingSource sexoBindingSource;
        
        private System.Windows.Forms.BindingSource cargoBindingSource;
       
        private System.Windows.Forms.BindingSource tipo_UsuarioBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senhaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSexofkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCargofkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipoUsuariofkDataGridViewTextBoxColumn;
    }
}