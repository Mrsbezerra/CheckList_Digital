using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CheckList_Digital.view
{
    public partial class Frm_Menu : Form
    {
        private string loginUsuario;

        public Frm_Menu(/*string login*/)
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            /*loginUsuario = login;*/
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

        private void Frm_Menu_Load(object sender, EventArgs e)
        {
            LblUsuario.Text = $"{loginUsuario}";
        }

        private void btnCadastros_Click(object sender, EventArgs e)
        {
            // Cria e exibe a nova instância de Frm_SubMenu_Cadastros
            Frm_SubMenu_Cadastros subMenuCadastros = new Frm_SubMenu_Cadastros();

            // Configura o evento FormClosed para liberar recursos ao fechar Frm_SubMenu_Cadastros
            subMenuCadastros.FormClosed += (s, args) =>
            {
                // Fecha Frm_Menu ao fechar o submenu
                this.Close();
            };

            // Exibe o sub-menu e fecha Frm_Menu
            subMenuCadastros.Show();
            this.Hide();
        }
    }
}
