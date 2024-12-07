using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CheckList_Digital.view
{
    public partial class Frm_SubMenu_Cadastros : Form
    {
        private string loginUsuario;

        public Frm_SubMenu_Cadastros(string login)
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            menuStrip1.BackColor = Color.FromArgb(51, 51, 76);
            loginUsuario = login;


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
            btnCadastros.BackColor = Color.FromArgb(0, 0, 0);
            btnCadastros.ForeColor = Color.White;

            Frm_Menu frmMenu = new Frm_Menu(loginUsuario);

            frmMenu.Show();

            this.Hide();
        }

        private void sexoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Frm_CSexo frmCsexo = new Frm_CSexo())
            {
                this.Hide();
                frmCsexo.ShowDialog();
            }
            this.Close();
        }

        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Frm_CCargo frmCcargo = new Frm_CCargo(loginUsuario))
            {
                this.Hide();
                frmCcargo.ShowDialog();
            }
            this.Close();
        }

        private void tipoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Frm_CTipoUsuario frmCtipousuario = new Frm_CTipoUsuario())
            {
                this.Hide();
                frmCtipousuario.ShowDialog();
            }
            this.Close();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Frm_CUsuario frmCusuario = new Frm_CUsuario())
            {
                this.Hide();
                frmCusuario.ShowDialog();
            }
            this.Close();
        }

        private void setorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Frm_CSetor frmCsetor = new Frm_CSetor())
            {
                this.Hide();
                frmCsetor.ShowDialog();
            }
            this.Close();
        }

        private void inspençãoSetorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Frm_CInspecaoSetor frmCinspecaosetor = new Frm_CInspecaoSetor())
            {
                this.Hide();
                frmCinspecaosetor.ShowDialog();
            }
            this.Close();
        }

        private void inspeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Frm_CInspecao frmCinspecao = new Frm_CInspecao())
            {
                this.Hide();
                frmCinspecao.ShowDialog();
            }
            this.Close();
        }

        private void btnReceitas_Click(object sender, EventArgs e)
        {
            // Cria e exibe a nova instância de Frm_SubMenu_Cadastros
            Frm_SubMenu_Consultas subMenuConsultas = new Frm_SubMenu_Consultas(loginUsuario);

            // Configura o evento FormClosed para liberar recursos ao fechar Frm_SubMenu_Cadastros
            subMenuConsultas.FormClosed += (s, args) =>
            {
                // Fecha Frm_Menu ao fechar o submenu
                this.Close();
            };

            // Exibe o sub-menu e fecha Frm_Menu
            subMenuConsultas.Show();
            this.Hide();
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            // Cria e exibe a nova instância de Frm_SubMenu_Cadastros
            Frm_SubMenu_Relatorios subMenuRelatorios = new Frm_SubMenu_Relatorios(loginUsuario);

            // Configura o evento FormClosed para liberar recursos ao fechar Frm_SubMenu_Cadastros
            subMenuRelatorios.FormClosed += (s, args) =>
            {
                // Fecha Frm_Menu ao fechar o submenu
                this.Close();
            };

            // Exibe o sub-menu e fecha Frm_Menu
            subMenuRelatorios.Show();
            this.Hide();
        }
    }
}
