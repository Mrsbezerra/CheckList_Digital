using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CheckList_Digital.view
{
    public partial class Frm_SubMenu_Cadastros : Form
    {
        private string loginUsuario;

        public Frm_SubMenu_Cadastros()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            // Define a cor de fundo do MenuStrip para azul marinho
            menuStrip1.BackColor = Color.FromArgb(51, 51, 76);

            // Define a cor do texto do MenuStrip
            menuStrip1.ForeColor = Color.Gainsboro;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BtnLogoff_Click_1(object sender, EventArgs e)
        {
            Frm_Acesso frmAcesso = new Frm_Acesso();
            frmAcesso.Show();
            this.Hide();
        }

        private void PanelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCadastros_Click(object sender, EventArgs e)
        {
            // Muda a cor do botão para indicar que ele foi selecionado
            btnCadastros.BackColor = Color.FromArgb(0, 0, 0); // Cor desejada (pode ser qualquer outra cor)
            btnCadastros.ForeColor = Color.White; // Cor do texto para contraste

            // Cria uma nova instância de Frm_Menu
            Frm_Menu frmMenu = new Frm_Menu();

            // Exibe Frm_Menu
            frmMenu.Show();

            // Fecha Frm_SubMenu_Cadastros (somente ele será fechado, não a aplicação)
            this.Hide();  // Usando Hide() em vez de Close() para garantir que o Frm_SubMenu_Cadastros não finalize a aplicação
        }

        private void sexoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Frm_CSexo frmCsexo = new Frm_CSexo())
            {
                this.Hide(); // Esconde o formulário atual temporariamente
                frmCsexo.ShowDialog(); // Mostra o novo formulário
            }
            this.Close(); // Fecha o formulário atual após o fechamento de Frm_SubMenu_Cadastro
        }
    }
}
