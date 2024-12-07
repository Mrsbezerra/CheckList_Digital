using System;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using System.Drawing;
using CheckList_Digital.controler;
using CheckList_Digital.conexao;
using System.Data.SqlClient;
using System.Text;
using System.Runtime.InteropServices;


namespace CheckList_Digital.view
{
    public partial class Frm_Acesso : Form
    {
        public Frm_Acesso()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.AcceptButton = BtnEntrar;
        }
        /*[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);*/

        public void EnviaEmail(string emailDestinatario)
        {
            string titulo = "Recuperação de Senha";
            string mensagem;
            string senha = "lyR4^5D=tmc^"; // Senha do e-mail de envio

            // Objeto de conexão
            ConectaBanco conectaBanco = new ConectaBanco();

            // Variáveis para armazenar login e senha do banco de dados
            string loginUsuario = "";
            string senhaUsuario = "";

            try
            {
                using (SqlConnection conexao = conectaBanco.ConectaSqlServer()) // Conecta ao banco usando a classe ConectaBanco
                {
                    string query = "SELECT Login, Senha FROM Usuario WHERE Email = @Email";
                    SqlCommand comando = new SqlCommand(query, conexao);
                    comando.Parameters.AddWithValue("@Email", emailDestinatario);

                    conexao.Open();
                    SqlDataReader reader = comando.ExecuteReader();

                    if (reader.Read())
                    {
                        loginUsuario = reader["Login"].ToString();
                        senhaUsuario = reader["Senha"].ToString();
                        mensagem = $"Olá! Seu login é <b>{loginUsuario}</b> e sua senha é <b>{senhaUsuario}</b>.";
                    }
                    else
                    {
                        mensagem = "O e-mail fornecido não está cadastrado no sistema.";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar os dados do usuário: {ex.Message}");
                return;
            }

            // Código para enviar o e-mail
            try
            {
                using (MailMessage mailMessage = new MailMessage("sistema_checkList@outlook.com", emailDestinatario))
                {
                    mailMessage.Subject = titulo;
                    mailMessage.IsBodyHtml = true;
                    mailMessage.Body = $"<p>{mensagem}</p>";
                    mailMessage.SubjectEncoding = Encoding.UTF8;
                    mailMessage.BodyEncoding = Encoding.UTF8;

                    using (SmtpClient smtpClient = new SmtpClient("smtp-mail.outlook.com", 587))
                    {
                        smtpClient.UseDefaultCredentials = false;
                        smtpClient.Credentials = new NetworkCredential("sistema_checkList@outlook.com", senha);
                        smtpClient.EnableSsl = true;

                        smtpClient.Send(mailMessage);
                        MessageBox.Show("E-mail enviado com sucesso!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao enviar o e-mail: {ex.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*string titulo = "Recuperação de Senha";
            string mensagem = "Sua solicitação de recuperação de senha foi recebida. Se o e-mail estiver cadastrado, você receberá instruções para redefinir sua senha.";
            string senha = "lyR4^5D=tmc^"; // Considere usar um método seguro para armazenar a senha

            try
            {
                // Cria o objeto MailMessage
                using (MailMessage mailMessage = new MailMessage("sistema_checkList@outlook.com", emailDestinatario))
                {
                    mailMessage.Subject = titulo;
                    mailMessage.IsBodyHtml = true;
                    mailMessage.Body = $"<p>{mensagem}</p>";
                    mailMessage.SubjectEncoding = Encoding.UTF8;
                    mailMessage.BodyEncoding = Encoding.UTF8;

                    // Cria o objeto SmtpClient
                    using (SmtpClient smtpClient = new SmtpClient("smtp-mail.outlook.com", 587))
                    {
                        smtpClient.UseDefaultCredentials = false;
                        smtpClient.Credentials = new NetworkCredential("sistema_checkList@outlook.com", senha);
                        smtpClient.EnableSsl = true;

                        // Envia o e-mail
                        smtpClient.Send(mailMessage);
                        MessageBox.Show("E-mail enviado com sucesso!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Digite um e-mail válido.","ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void TxtUsuario_Enter(object sender, EventArgs e)
        {
            if (TxtLogin.Text.Equals("Usuário"))
            {
                TxtLogin.Text = string.Empty;
                TxtLogin.ForeColor = Color.Black;
            }
        }

        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            if (TxtLogin.Text.Equals(""))
            {
                TxtLogin.Text = "Usuário";
                TxtLogin.ForeColor = Color.FromKnownColor(KnownColor.ControlDark);
            }
        }

        private void TxtSenha_Enter(object sender, EventArgs e)
        {
            if (TxtSenha.Text.Equals("Senha"))
            {
                TxtSenha.Text = string.Empty;
                TxtSenha.ForeColor = Color.Black;
                TxtSenha.PasswordChar = '*'; // Ativa o modo de senha
            }
        }

        private void TxtSenha_Leave(object sender, EventArgs e)
        {
            if (TxtSenha.Text.Equals(""))
            {
                TxtSenha.PasswordChar = '\0'; // Desativa o modo de senha
                TxtSenha.Text = "Senha";
                TxtSenha.ForeColor = Color.FromKnownColor(KnownColor.ControlDark);
            }
        }

        private bool senhaVisivel = false;

        private void BtnOlho_Click(object sender, EventArgs e)
        {
            if (senhaVisivel)
            {
                TxtSenha.PasswordChar = '*'; // Oculta a senha com asteriscos
                BtnOlho.Image = Properties.Resources.olho_fechado; // Altere para o ícone de olho fechado
            }
            else
            {
                TxtSenha.PasswordChar = '\0'; // Mostra a senha (sem caractere de máscara)
                BtnOlho.Image = Properties.Resources.olho; // Altere para o ícone de olho aberto
            }

            senhaVisivel = !senhaVisivel; // Alterna entre mostrar/ocultar
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            string login = TxtLogin.Text;
            // Verifica se o campo de login está preenchido
            if (TxtLogin.Text == "Usuário" || TxtLogin.Text == "")
            {
                MessageBox.Show("Por favor, informe o usuário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verifica se o campo de senha está preenchido
            if (TxtSenha.Text == "Senha" || TxtSenha.Text == "")
            {
                MessageBox.Show("Por favor, informe a senha.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            C_Usuario controlUsuario = new C_Usuario();
            if (controlUsuario.VerificaUsuarioExistente(TxtLogin.Text))
            {
                // Verifica se a senha está correta
                if (controlUsuario.VerificaSenhaCorreta(TxtLogin.Text, TxtSenha.Text))
                {
                    // Usuário e senha corretos, abre o formulário Frm_Usuario
                    Frm_Menu frmMenu = new Frm_Menu(login); 
                    frmMenu.Show();
                    this.Hide(); // Esconde o formulário atual
                }
                else
                {
                    // Usuário correto, mas senha errada
                    MessageBox.Show("Usuário está correto, mas a senha não.", "Erro de autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Usuário não existe
                MessageBox.Show("Usuário não cadastrado, procure o setor de TI.", "Erro de autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static string Prompt(string texto, string titulo)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 200,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = titulo,
                StartPosition = FormStartPosition.CenterScreen,
                BackColor = Color.WhiteSmoke // Fundo suave
            };

            Label textoLabel = new Label()
            {
                Left = 40,
                Top = 20,
                Text = texto,
                Width = 420,
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.DarkSlateGray
            };

            TextBox textoBox = new TextBox()
            {
                Left = 40,
                Top = 60,
                Width = 400,
                Font = new Font("Arial", 10),
                Text = "Email",
                ForeColor = Color.FromKnownColor(KnownColor.ControlDark)
            };

            // Evento Enter: Remove o placeholder "Email" quando o usuário clica na caixa de texto
            textoBox.Enter += (sender, e) =>
            {
                if (textoBox.Text == "Email")
                {
                    textoBox.Text = string.Empty;
                    textoBox.ForeColor = Color.Black;
                }
            };

            // Evento Leave: Retorna o placeholder "Email" quando a caixa de texto está vazia ao perder o foco
            textoBox.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textoBox.Text))
                {
                    textoBox.Text = "Email";
                    textoBox.ForeColor = Color.FromKnownColor(KnownColor.ControlDark);
                }
            };

            Button confirmation = new Button()
            {
                Text = "OK",
                Left = 230,
                Width = 100,
                Top = 120,
                DialogResult = DialogResult.OK
            };
            confirmation.FlatAppearance.BorderSize = 1;
            confirmation.FlatAppearance.BorderColor = Color.DarkSlateGray;

            Button cancel = new Button()
            {
                Text = "Cancelar",
                Left = 340,
                Width = 100,
                Top = 120,
                DialogResult = DialogResult.Cancel
            };
            cancel.FlatAppearance.BorderSize = 1;
            cancel.FlatAppearance.BorderColor = Color.DarkSlateGray;

            prompt.Controls.Add(textoLabel);
            prompt.Controls.Add(textoBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(cancel);

            prompt.Shown += (sender, e) => textoBox.Focus();

            prompt.AcceptButton = confirmation;
            prompt.CancelButton = cancel;

            return prompt.ShowDialog() == DialogResult.OK ? textoBox.Text : null;
        }


        private void LblEsqueceuSenha_Click(object sender, EventArgs e)
        {

            // Solicita que o usuário informe o e-mail
            string email = Prompt("Informe o seu e-mail:", "Recuperar Senha");

            // Se o usuário cancelou a operação, interrompe o processo
            if (email == null)
            {
                MessageBox.Show("Operação cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Verifica se o e-mail está vazio
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Você precisa informar um e-mail para recuperar a senha.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verifica se o e-mail está cadastrado na tabela Usuario
            C_Usuario cUsuario = new C_Usuario();
            if (cUsuario.VerificaEmailCadastrado(email))
            {
                EnviaEmail(email);
            }
            else
            {
                MessageBox.Show("O e-mail " + email + " não está cadastrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LblEsqueceuSenha_MouseEnter(object sender, EventArgs e)
        {
            // Muda o cursor para "mão" e o texto para azul, simulando um link
            LblEsqueceuSenha.ForeColor = Color.Black;
            LblEsqueceuSenha.Font = new Font(LblEsqueceuSenha.Font, FontStyle.Underline);
            LblEsqueceuSenha.Cursor = Cursors.Hand;
        }

        private void LblEsqueceuSenha_MouseLeave(object sender, EventArgs e)
        {
            // Restaura o estilo padrão
            LblEsqueceuSenha.ForeColor = Color.Black; // Cor original
            LblEsqueceuSenha.Font = new Font(LblEsqueceuSenha.Font, FontStyle.Regular);
            LblEsqueceuSenha.Cursor = Cursors.Default;
        }
    }
}
