namespace CheckList_Digital.view
{
    partial class Frm_Sexo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Sexo));
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
            this.lblTotal_Registros = new System.Windows.Forms.Label();
            this.DgvSexo = new System.Windows.Forms.DataGridView();
            this.lblNome_Sexo = new System.Windows.Forms.Label();
            this.lblId_Sexo = new System.Windows.Forms.Label();
            this.txtNome_Sexo = new System.Windows.Forms.TextBox();
            this.txtId_Sexo = new System.Windows.Forms.TextBox();
            this.sexobindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LblTotal_Registros2 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSexo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexobindingSource)).BeginInit();
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
            this.toolStrip1.TabIndex = 31;
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
            this.TsbNovo.ToolTipText = "Adicionar Novo Sexo";
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
            this.TsbSalvar.ToolTipText = "Salvar Sexo";
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
            this.lblBuscaId.Size = new System.Drawing.Size(73, 22);
            this.lblBuscaId.Text = "Buscar Sexo:";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(180, 25);
            this.TxtBuscar.Click += new System.EventHandler(this.TxtBuscar_TextChanged);
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
            this.BtnBuscar.ToolTipText = "Buscar Sexo";
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
            // lblTotal_Registros
            // 
            this.lblTotal_Registros.AutoSize = true;
            this.lblTotal_Registros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal_Registros.Location = new System.Drawing.Point(390, 140);
            this.lblTotal_Registros.Name = "lblTotal_Registros";
            this.lblTotal_Registros.Size = new System.Drawing.Size(97, 13);
            this.lblTotal_Registros.TabIndex = 45;
            this.lblTotal_Registros.Text = "Total Registros:";
            this.lblTotal_Registros.Click += new System.EventHandler(this.lblTotal_Registros_Click);
            // 
            // DgvSexo
            // 
            this.DgvSexo.AllowUserToAddRows = false;
            this.DgvSexo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSexo.Location = new System.Drawing.Point(12, 161);
            this.DgvSexo.MultiSelect = false;
            this.DgvSexo.Name = "DgvSexo";
            this.DgvSexo.ReadOnly = true;
            this.DgvSexo.Size = new System.Drawing.Size(542, 180);
            this.DgvSexo.TabIndex = 43;
            this.DgvSexo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSexo_CellClick);
            this.DgvSexo.SelectionChanged += new System.EventHandler(this.DgvSexo_SelectionChanged);
            // 
            // lblNome_Sexo
            // 
            this.lblNome_Sexo.AutoSize = true;
            this.lblNome_Sexo.Location = new System.Drawing.Point(12, 87);
            this.lblNome_Sexo.Name = "lblNome_Sexo";
            this.lblNome_Sexo.Size = new System.Drawing.Size(34, 13);
            this.lblNome_Sexo.TabIndex = 42;
            this.lblNome_Sexo.Text = "Sexo:";
            // 
            // lblId_Sexo
            // 
            this.lblId_Sexo.AutoSize = true;
            this.lblId_Sexo.Location = new System.Drawing.Point(12, 37);
            this.lblId_Sexo.Name = "lblId_Sexo";
            this.lblId_Sexo.Size = new System.Drawing.Size(43, 13);
            this.lblId_Sexo.TabIndex = 41;
            this.lblId_Sexo.Text = "Código:";
            // 
            // txtNome_Sexo
            // 
            this.txtNome_Sexo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome_Sexo.Enabled = false;
            this.txtNome_Sexo.Location = new System.Drawing.Point(12, 103);
            this.txtNome_Sexo.MaxLength = 50;
            this.txtNome_Sexo.Name = "txtNome_Sexo";
            this.txtNome_Sexo.Size = new System.Drawing.Size(100, 20);
            this.txtNome_Sexo.TabIndex = 40;
            // 
            // txtId_Sexo
            // 
            this.txtId_Sexo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtId_Sexo.Enabled = false;
            this.txtId_Sexo.Location = new System.Drawing.Point(12, 53);
            this.txtId_Sexo.Name = "txtId_Sexo";
            this.txtId_Sexo.Size = new System.Drawing.Size(100, 20);
            this.txtId_Sexo.TabIndex = 31;
            // 
            // LblTotal_Registros2
            // 
            this.LblTotal_Registros2.AutoSize = true;
            this.LblTotal_Registros2.Location = new System.Drawing.Point(514, 139);
            this.LblTotal_Registros2.Name = "LblTotal_Registros2";
            this.LblTotal_Registros2.Size = new System.Drawing.Size(13, 13);
            this.LblTotal_Registros2.TabIndex = 46;
            this.LblTotal_Registros2.Text = "0";
            this.LblTotal_Registros2.Click += new System.EventHandler(this.LblTotal_Registros2_Click);
            // 
            // Frm_Sexo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblTotal_Registros2);
            this.Controls.Add(this.lblTotal_Registros);
            this.Controls.Add(this.DgvSexo);
            this.Controls.Add(this.lblNome_Sexo);
            this.Controls.Add(this.lblId_Sexo);
            this.Controls.Add(this.txtNome_Sexo);
            this.Controls.Add(this.txtId_Sexo);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Frm_Sexo";
            this.ShowIcon = false;
            this.Text = "Cadastro de Sexo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSexo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexobindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TsbNovo;
        private System.Windows.Forms.ToolStripButton TsbSalvar;
        private System.Windows.Forms.ToolStripButton TsbCancelar;
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
        private System.Windows.Forms.Label lblTotal_Registros;
        private System.Windows.Forms.DataGridView DgvSexo;
        private System.Windows.Forms.Label lblNome_Sexo;
        private System.Windows.Forms.Label lblId_Sexo;
        private System.Windows.Forms.TextBox txtNome_Sexo;
        private System.Windows.Forms.TextBox txtId_Sexo;
        private System.Windows.Forms.BindingSource sexobindingSource;
        private System.Windows.Forms.ToolStripButton TsbEditar;
        private System.Windows.Forms.Label LblTotal_Registros2;
    }
}