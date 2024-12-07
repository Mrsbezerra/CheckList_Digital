using System.Windows.Forms;

namespace CheckList_Digital.view
{
    partial class Frm_Acesso : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Acesso));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtLogin = new System.Windows.Forms.TextBox();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.BtnEntrar = new System.Windows.Forms.Button();
            this.LblEsqueceuSenha = new System.Windows.Forms.Label();
            this.BtnOlho = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(1202, 320);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(709, 98);
            this.label2.TabIndex = 3;
            this.label2.Text = "CheckList Digital";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(1443, 455);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 49);
            this.label3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(1451, 455);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "| Segurança no Trabalho";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(1327, 537);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(472, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "--------------- Acesse sua Conta ---------------";
            // 
            // TxtLogin
            // 
            this.TxtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLogin.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.TxtLogin.Location = new System.Drawing.Point(1307, 645);
            this.TxtLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtLogin.MaxLength = 80;
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.Size = new System.Drawing.Size(524, 30);
            this.TxtLogin.TabIndex = 8;
            this.TxtLogin.Text = "Usuário";
            this.TxtLogin.Enter += new System.EventHandler(this.TxtUsuario_Enter);
            this.TxtLogin.Leave += new System.EventHandler(this.TxtUsuario_Leave);
            // 
            // TxtSenha
            // 
            this.TxtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSenha.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.TxtSenha.Location = new System.Drawing.Point(1307, 711);
            this.TxtSenha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSenha.MaxLength = 80;
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(524, 30);
            this.TxtSenha.TabIndex = 9;
            this.TxtSenha.Text = "Senha";
            this.TxtSenha.Enter += new System.EventHandler(this.TxtSenha_Enter);
            this.TxtSenha.Leave += new System.EventHandler(this.TxtSenha_Leave);
            // 
            // BtnEntrar
            // 
            this.BtnEntrar.BackColor = System.Drawing.Color.DarkGray;
            this.BtnEntrar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.BtnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEntrar.Location = new System.Drawing.Point(1307, 775);
            this.BtnEntrar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnEntrar.Name = "BtnEntrar";
            this.BtnEntrar.Size = new System.Drawing.Size(526, 68);
            this.BtnEntrar.TabIndex = 10;
            this.BtnEntrar.Text = "Entrar";
            this.BtnEntrar.UseVisualStyleBackColor = false;
            this.BtnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
            // 
            // LblEsqueceuSenha
            // 
            this.LblEsqueceuSenha.AutoSize = true;
            this.LblEsqueceuSenha.BackColor = System.Drawing.Color.White;
            this.LblEsqueceuSenha.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEsqueceuSenha.ForeColor = System.Drawing.Color.Black;
            this.LblEsqueceuSenha.Location = new System.Drawing.Point(1451, 872);
            this.LblEsqueceuSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblEsqueceuSenha.Name = "LblEsqueceuSenha";
            this.LblEsqueceuSenha.Size = new System.Drawing.Size(215, 26);
            this.LblEsqueceuSenha.TabIndex = 11;
            this.LblEsqueceuSenha.Text = " Esqueceu a Senha?";
            this.LblEsqueceuSenha.Click += new System.EventHandler(this.LblEsqueceuSenha_Click);
            this.LblEsqueceuSenha.MouseEnter += new System.EventHandler(this.LblEsqueceuSenha_MouseEnter);
            this.LblEsqueceuSenha.MouseLeave += new System.EventHandler(this.LblEsqueceuSenha_MouseLeave);
            // 
            // BtnOlho
            // 
            this.BtnOlho.Image = global::CheckList_Digital.Properties.Resources.olho_fechado;
            this.BtnOlho.Location = new System.Drawing.Point(1782, 711);
            this.BtnOlho.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnOlho.Name = "BtnOlho";
            this.BtnOlho.Size = new System.Drawing.Size(51, 35);
            this.BtnOlho.TabIndex = 12;
            this.BtnOlho.UseVisualStyleBackColor = true;
            this.BtnOlho.Click += new System.EventHandler(this.BtnOlho_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1392, 431);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 52);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBox1.Image = global::CheckList_Digital.Properties.Resources.Menu_1_Segurança_do_Trabalho_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(75, 305);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1047, 420);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Acesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.BtnOlho);
            this.Controls.Add(this.LblEsqueceuSenha);
            this.Controls.Add(this.BtnEntrar);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.TxtLogin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1339, 662);
            this.Name = "Frm_Acesso";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtLogin;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.Button BtnEntrar;
        private System.Windows.Forms.Label LblEsqueceuSenha;
        private Button BtnOlho;
    }
}