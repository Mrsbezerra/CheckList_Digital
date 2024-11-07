namespace CheckList_Digital.view
{
    partial class Frm_Tipo_Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Tipo_Usuario));
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
            this.LblTotal_Registros2 = new System.Windows.Forms.Label();
            this.lblTotal_Registros = new System.Windows.Forms.Label();
            this.DgvTipo_Usuario = new System.Windows.Forms.DataGridView();
            this.lblNome_Tipo_Usuario = new System.Windows.Forms.Label();
            this.lblId_Tipo_Usuario = new System.Windows.Forms.Label();
            this.txtNome_Tipo_Usuario = new System.Windows.Forms.TextBox();
            this.txtId_Tipo_Usuario = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTipo_Usuario)).BeginInit();
            this.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 32;
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
            this.TsbNovo.ToolTipText = "Adicionar Novo Tipo Usuario";
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
            this.TsbSalvar.ToolTipText = "Salvar Tipo Usuario";
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
            this.TsbExcluir.Click += new System.EventHandler(this.TsbExcluir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // lblBuscaId
            // 
            this.lblBuscaId.Name = "lblBuscaId";
            this.lblBuscaId.Size = new System.Drawing.Size(114, 22);
            this.lblBuscaId.Text = "Buscar Tipo Usuario:";
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
            this.BtnBuscar.ToolTipText = "Buscar Tipo Usuario";
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
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
            this.BtnRelatorio.Click += new System.EventHandler(this.BtnRelatorio_Click);
            // 
            // LblTotal_Registros2
            // 
            this.LblTotal_Registros2.AutoSize = true;
            this.LblTotal_Registros2.Location = new System.Drawing.Point(514, 140);
            this.LblTotal_Registros2.Name = "LblTotal_Registros2";
            this.LblTotal_Registros2.Size = new System.Drawing.Size(13, 13);
            this.LblTotal_Registros2.TabIndex = 53;
            this.LblTotal_Registros2.Text = "0";
            // 
            // lblTotal_Registros
            // 
            this.lblTotal_Registros.AutoSize = true;
            this.lblTotal_Registros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal_Registros.Location = new System.Drawing.Point(390, 141);
            this.lblTotal_Registros.Name = "lblTotal_Registros";
            this.lblTotal_Registros.Size = new System.Drawing.Size(97, 13);
            this.lblTotal_Registros.TabIndex = 52;
            this.lblTotal_Registros.Text = "Total Registros:";
            // 
            // DgvTipo_Usuario
            // 
            this.DgvTipo_Usuario.AllowUserToAddRows = false;
            this.DgvTipo_Usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTipo_Usuario.Location = new System.Drawing.Point(12, 162);
            this.DgvTipo_Usuario.MultiSelect = false;
            this.DgvTipo_Usuario.Name = "DgvTipo_Usuario";
            this.DgvTipo_Usuario.ReadOnly = true;
            this.DgvTipo_Usuario.Size = new System.Drawing.Size(542, 180);
            this.DgvTipo_Usuario.TabIndex = 51;
            this.DgvTipo_Usuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTipo_Usuario_CellClick);
            this.DgvTipo_Usuario.SelectionChanged += new System.EventHandler(this.DgvTipo_Usuario_SelectionChanged);
            // 
            // lblNome_Tipo_Usuario
            // 
            this.lblNome_Tipo_Usuario.AutoSize = true;
            this.lblNome_Tipo_Usuario.Location = new System.Drawing.Point(12, 88);
            this.lblNome_Tipo_Usuario.Name = "lblNome_Tipo_Usuario";
            this.lblNome_Tipo_Usuario.Size = new System.Drawing.Size(67, 13);
            this.lblNome_Tipo_Usuario.TabIndex = 50;
            this.lblNome_Tipo_Usuario.Text = "Tipo Usuario";
            // 
            // lblId_Tipo_Usuario
            // 
            this.lblId_Tipo_Usuario.AutoSize = true;
            this.lblId_Tipo_Usuario.Location = new System.Drawing.Point(12, 38);
            this.lblId_Tipo_Usuario.Name = "lblId_Tipo_Usuario";
            this.lblId_Tipo_Usuario.Size = new System.Drawing.Size(40, 13);
            this.lblId_Tipo_Usuario.TabIndex = 49;
            this.lblId_Tipo_Usuario.Text = "Código";
            // 
            // txtNome_Tipo_Usuario
            // 
            this.txtNome_Tipo_Usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome_Tipo_Usuario.Enabled = false;
            this.txtNome_Tipo_Usuario.Location = new System.Drawing.Point(12, 104);
            this.txtNome_Tipo_Usuario.MaxLength = 50;
            this.txtNome_Tipo_Usuario.Name = "txtNome_Tipo_Usuario";
            this.txtNome_Tipo_Usuario.Size = new System.Drawing.Size(100, 20);
            this.txtNome_Tipo_Usuario.TabIndex = 48;
            // 
            // txtId_Tipo_Usuario
            // 
            this.txtId_Tipo_Usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtId_Tipo_Usuario.Enabled = false;
            this.txtId_Tipo_Usuario.Location = new System.Drawing.Point(12, 54);
            this.txtId_Tipo_Usuario.Name = "txtId_Tipo_Usuario";
            this.txtId_Tipo_Usuario.Size = new System.Drawing.Size(100, 20);
            this.txtId_Tipo_Usuario.TabIndex = 47;
            // 
            // Frm_Tipo_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblTotal_Registros2);
            this.Controls.Add(this.lblTotal_Registros);
            this.Controls.Add(this.DgvTipo_Usuario);
            this.Controls.Add(this.lblNome_Tipo_Usuario);
            this.Controls.Add(this.lblId_Tipo_Usuario);
            this.Controls.Add(this.txtNome_Tipo_Usuario);
            this.Controls.Add(this.txtId_Tipo_Usuario);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Frm_Tipo_Usuario";
            this.ShowIcon = false;
            this.Text = "Cadastrar Tipo Usuario";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTipo_Usuario)).EndInit();
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
        private System.Windows.Forms.Label LblTotal_Registros2;
        private System.Windows.Forms.Label lblTotal_Registros;
        private System.Windows.Forms.DataGridView DgvTipo_Usuario;
        private System.Windows.Forms.Label lblNome_Tipo_Usuario;
        private System.Windows.Forms.Label lblId_Tipo_Usuario;
        private System.Windows.Forms.TextBox txtNome_Tipo_Usuario;
        private System.Windows.Forms.TextBox txtId_Tipo_Usuario;
    }
}