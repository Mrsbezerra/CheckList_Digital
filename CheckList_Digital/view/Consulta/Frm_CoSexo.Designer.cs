namespace CheckList_Digital.view.Consulta
{
    partial class Frm_CoSexo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CoSexo));
            this.lblNome_Sexo = new System.Windows.Forms.Label();
            this.lblId_Sexo = new System.Windows.Forms.Label();
            this.txtNome_Sexo = new System.Windows.Forms.TextBox();
            this.txtId_Sexo = new System.Windows.Forms.TextBox();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.BtnAjuda = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.DgvSexo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.LblTotalRegistro2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSexo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome_Sexo
            // 
            this.lblNome_Sexo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNome_Sexo.AutoSize = true;
            this.lblNome_Sexo.Location = new System.Drawing.Point(12, 51);
            this.lblNome_Sexo.Name = "lblNome_Sexo";
            this.lblNome_Sexo.Size = new System.Drawing.Size(85, 13);
            this.lblNome_Sexo.TabIndex = 50;
            this.lblNome_Sexo.Text = "Descrição Sexo:";
            // 
            // lblId_Sexo
            // 
            this.lblId_Sexo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblId_Sexo.AutoSize = true;
            this.lblId_Sexo.Location = new System.Drawing.Point(38, 15);
            this.lblId_Sexo.Name = "lblId_Sexo";
            this.lblId_Sexo.Size = new System.Drawing.Size(59, 13);
            this.lblId_Sexo.TabIndex = 49;
            this.lblId_Sexo.Text = "Cód. Sexo:";
            // 
            // txtNome_Sexo
            // 
            this.txtNome_Sexo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNome_Sexo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome_Sexo.Location = new System.Drawing.Point(103, 48);
            this.txtNome_Sexo.MaxLength = 50;
            this.txtNome_Sexo.Name = "txtNome_Sexo";
            this.txtNome_Sexo.Size = new System.Drawing.Size(372, 20);
            this.txtNome_Sexo.TabIndex = 48;
            // 
            // txtId_Sexo
            // 
            this.txtId_Sexo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtId_Sexo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtId_Sexo.Location = new System.Drawing.Point(103, 12);
            this.txtId_Sexo.Name = "txtId_Sexo";
            this.txtId_Sexo.Size = new System.Drawing.Size(29, 20);
            this.txtId_Sexo.TabIndex = 47;
            this.txtId_Sexo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnMostrar.Location = new System.Drawing.Point(604, 15);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(83, 25);
            this.BtnMostrar.TabIndex = 51;
            this.BtnMostrar.Text = "Mostrar";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // BtnAjuda
            // 
            this.BtnAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAjuda.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnAjuda.Location = new System.Drawing.Point(693, 15);
            this.BtnAjuda.Name = "BtnAjuda";
            this.BtnAjuda.Size = new System.Drawing.Size(83, 25);
            this.BtnAjuda.TabIndex = 52;
            this.BtnAjuda.Text = "Ajuda";
            this.BtnAjuda.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnCancelar.Location = new System.Drawing.Point(604, 45);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(83, 25);
            this.BtnCancelar.TabIndex = 53;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnSair.Location = new System.Drawing.Point(693, 45);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(83, 25);
            this.BtnSair.TabIndex = 54;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // DgvSexo
            // 
            this.DgvSexo.AllowUserToAddRows = false;
            this.DgvSexo.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.DgvSexo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSexo.Location = new System.Drawing.Point(15, 128);
            this.DgvSexo.MultiSelect = false;
            this.DgvSexo.Name = "DgvSexo";
            this.DgvSexo.ReadOnly = true;
            this.DgvSexo.Size = new System.Drawing.Size(761, 238);
            this.DgvSexo.TabIndex = 55;
            this.DgvSexo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSexo_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(590, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Total Registros:";
            // 
            // LblTotalRegistro2
            // 
            this.LblTotalRegistro2.AutoSize = true;
            this.LblTotalRegistro2.Location = new System.Drawing.Point(729, 102);
            this.LblTotalRegistro2.Name = "LblTotalRegistro2";
            this.LblTotalRegistro2.Size = new System.Drawing.Size(13, 13);
            this.LblTotalRegistro2.TabIndex = 57;
            this.LblTotalRegistro2.Text = "0";
            // 
            // Frm_CoSexo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblTotalRegistro2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvSexo);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAjuda);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.lblNome_Sexo);
            this.Controls.Add(this.lblId_Sexo);
            this.Controls.Add(this.txtNome_Sexo);
            this.Controls.Add(this.txtId_Sexo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_CoSexo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Sexo";
            ((System.ComponentModel.ISupportInitialize)(this.DgvSexo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome_Sexo;
        private System.Windows.Forms.Label lblId_Sexo;
        private System.Windows.Forms.TextBox txtNome_Sexo;
        private System.Windows.Forms.TextBox txtId_Sexo;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.Button BtnAjuda;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.DataGridView DgvSexo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblTotalRegistro2;
    }
}