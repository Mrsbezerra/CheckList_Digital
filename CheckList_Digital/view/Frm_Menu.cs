using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CheckList_Digital.view
{
    public partial class Frm_Menu : Form
    {
        private string loginUsuario;

        public Frm_Menu(string login)
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            loginUsuario = login;
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
            LblUsuario.Text = $"{loginUsuario.ToUpper()}";
        }

        private void btnCadastros_Click(object sender, EventArgs e)
        {
            Frm_SubMenu_Cadastros subMenuCadastros = new Frm_SubMenu_Cadastros(loginUsuario); // Passa o login
            subMenuCadastros.FormClosed += (s, args) =>
            {
                this.Show();
            };
            subMenuCadastros.Show();
            this.Hide();
        }

        private void BtnConsultas_Click(object sender, EventArgs e)
        {
            Frm_SubMenu_Consultas subMenuConsultas = new Frm_SubMenu_Consultas(loginUsuario);

            subMenuConsultas.FormClosed += (s, args) =>
            {
                this.Close();
            };
            subMenuConsultas.Show();
            this.Hide();
        }

        private void BtnRelatorios_Click(object sender, EventArgs e)
        {
            Frm_SubMenu_Relatorios subMenuRelatorios = new Frm_SubMenu_Relatorios(loginUsuario);

            subMenuRelatorios.FormClosed += (s, args) =>
            {
                this.Close();
            };
            subMenuRelatorios.Show();
            this.Hide();
        }
    }
}
