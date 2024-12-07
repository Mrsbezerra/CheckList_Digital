namespace CheckList_Digital.view
{
    partial class Frm_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Menu));
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.PanelTitulo = new System.Windows.Forms.Panel();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.BtnMinimizar = new System.Windows.Forms.Button();
            this.BtnMaximizar = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnLogoff = new System.Windows.Forms.Button();
            this.BtnRelatorios = new System.Windows.Forms.Button();
            this.BtnConsultas = new System.Windows.Forms.Button();
            this.btnCadastros = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLogo.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.PanelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(264, 123);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(40, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "CheckList Digital";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.BtnLogoff);
            this.panelMenu.Controls.Add(this.BtnRelatorios);
            this.panelMenu.Controls.Add(this.BtnConsultas);
            this.panelMenu.Controls.Add(this.btnCadastros);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(264, 1050);
            this.panelMenu.TabIndex = 2;
            // 
            // PanelTitulo
            // 
            this.PanelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(130)))));
            this.PanelTitulo.Controls.Add(this.LblUsuario);
            this.PanelTitulo.Controls.Add(this.pictureBox2);
            this.PanelTitulo.Controls.Add(this.BtnMinimizar);
            this.PanelTitulo.Controls.Add(this.BtnMaximizar);
            this.PanelTitulo.Controls.Add(this.BtnFechar);
            this.PanelTitulo.Controls.Add(this.LblTitulo);
            this.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitulo.Location = new System.Drawing.Point(264, 0);
            this.PanelTitulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelTitulo.Name = "PanelTitulo";
            this.PanelTitulo.Size = new System.Drawing.Size(1660, 123);
            this.PanelTitulo.TabIndex = 5;
            this.PanelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitulo_MouseDown);
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.ForeColor = System.Drawing.Color.White;
            this.LblUsuario.Location = new System.Drawing.Point(58, 85);
            this.LblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(19, 20);
            this.LblUsuario.TabIndex = 8;
            this.LblUsuario.Text = "0";
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimizar.FlatAppearance.BorderSize = 0;
            this.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMinimizar.ForeColor = System.Drawing.Color.White;
            this.BtnMinimizar.Location = new System.Drawing.Point(1527, 5);
            this.BtnMinimizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(45, 46);
            this.BtnMinimizar.TabIndex = 7;
            this.BtnMinimizar.Text = "O";
            this.BtnMinimizar.UseVisualStyleBackColor = true;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // BtnMaximizar
            // 
            this.BtnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMaximizar.FlatAppearance.BorderSize = 0;
            this.BtnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMaximizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMaximizar.ForeColor = System.Drawing.Color.White;
            this.BtnMaximizar.Location = new System.Drawing.Point(1570, 5);
            this.BtnMaximizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnMaximizar.Name = "BtnMaximizar";
            this.BtnMaximizar.Size = new System.Drawing.Size(45, 46);
            this.BtnMaximizar.TabIndex = 7;
            this.BtnMaximizar.Text = "O";
            this.BtnMaximizar.UseVisualStyleBackColor = true;
            this.BtnMaximizar.Click += new System.EventHandler(this.BtnMaximizar_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFechar.FlatAppearance.BorderSize = 0;
            this.BtnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFechar.ForeColor = System.Drawing.Color.White;
            this.BtnFechar.Location = new System.Drawing.Point(1611, 5);
            this.BtnFechar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(45, 46);
            this.BtnFechar.TabIndex = 6;
            this.BtnFechar.Text = "O";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.White;
            this.LblTitulo.Location = new System.Drawing.Point(862, 40);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(112, 37);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "HOME";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(106, 23);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 57);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // BtnLogoff
            // 
            this.BtnLogoff.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnLogoff.FlatAppearance.BorderSize = 0;
            this.BtnLogoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogoff.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnLogoff.Image = global::CheckList_Digital.Properties.Resources.Logoff;
            this.BtnLogoff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogoff.Location = new System.Drawing.Point(0, 958);
            this.BtnLogoff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnLogoff.Name = "BtnLogoff";
            this.BtnLogoff.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.BtnLogoff.Size = new System.Drawing.Size(264, 92);
            this.BtnLogoff.TabIndex = 8;
            this.BtnLogoff.Text = "   Logoff";
            this.BtnLogoff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogoff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLogoff.UseVisualStyleBackColor = true;
            this.BtnLogoff.Click += new System.EventHandler(this.BtnLogoff_Click_1);
            // 
            // BtnRelatorios
            // 
            this.BtnRelatorios.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRelatorios.FlatAppearance.BorderSize = 0;
            this.BtnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRelatorios.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnRelatorios.Image = ((System.Drawing.Image)(resources.GetObject("BtnRelatorios.Image")));
            this.BtnRelatorios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRelatorios.Location = new System.Drawing.Point(0, 307);
            this.BtnRelatorios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnRelatorios.Name = "BtnRelatorios";
            this.BtnRelatorios.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.BtnRelatorios.Size = new System.Drawing.Size(264, 92);
            this.BtnRelatorios.TabIndex = 5;
            this.BtnRelatorios.Text = "   Relatorios";
            this.BtnRelatorios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRelatorios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRelatorios.UseVisualStyleBackColor = true;
            this.BtnRelatorios.Click += new System.EventHandler(this.BtnRelatorios_Click);
            // 
            // BtnConsultas
            // 
            this.BtnConsultas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnConsultas.FlatAppearance.BorderSize = 0;
            this.BtnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultas.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnConsultas.Image = global::CheckList_Digital.Properties.Resources.Consulta;
            this.BtnConsultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultas.Location = new System.Drawing.Point(0, 215);
            this.BtnConsultas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnConsultas.Name = "BtnConsultas";
            this.BtnConsultas.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.BtnConsultas.Size = new System.Drawing.Size(264, 92);
            this.BtnConsultas.TabIndex = 2;
            this.BtnConsultas.Text = "   Consultas";
            this.BtnConsultas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConsultas.UseVisualStyleBackColor = true;
            this.BtnConsultas.Click += new System.EventHandler(this.BtnConsultas_Click);
            // 
            // btnCadastros
            // 
            this.btnCadastros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastros.FlatAppearance.BorderSize = 0;
            this.btnCadastros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastros.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCadastros.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastros.Image")));
            this.btnCadastros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastros.Location = new System.Drawing.Point(0, 123);
            this.btnCadastros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCadastros.Name = "btnCadastros";
            this.btnCadastros.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnCadastros.Size = new System.Drawing.Size(264, 92);
            this.btnCadastros.TabIndex = 1;
            this.btnCadastros.Text = "   Cadastros";
            this.btnCadastros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastros.UseVisualStyleBackColor = true;
            this.btnCadastros.Click += new System.EventHandler(this.btnCadastros_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::CheckList_Digital.Properties.Resources.Menu_1_Segurança_do_Trabalho_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(603, 366);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(571, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.PanelTitulo);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1339, 662);
            this.Name = "Frm_Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Menu_Load);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.PanelTitulo.ResumeLayout(false);
            this.PanelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button BtnLogoff;
        private System.Windows.Forms.Button BtnRelatorios;
        private System.Windows.Forms.Button BtnConsultas;
        private System.Windows.Forms.Button btnCadastros;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PanelTitulo;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Button BtnMaximizar;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnMinimizar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LblUsuario;
    }
}