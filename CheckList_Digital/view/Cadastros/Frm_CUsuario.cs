using CheckList_Digital.conexao;
using CheckList_Digital.controler;
using CheckList_Digital.model;
using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using CheckList_Digital.view.Consulta;
using CheckList_Digital.view.Frm_Relatorio;
using System.Data;

namespace CheckList_Digital.view
{
    public partial class Frm_CUsuario : Form
    {
        private bool novo = true;

        public Frm_CUsuario()
        {
            InitializeComponent();
        }
       
        private void AtivarTexts()
        {
            TxtId_Usuario.Enabled = false; 
            TxtNome_Usuario.Enabled = true;
            TxtLogin.Enabled = true;
            TxtSenha.Enabled = true;
            TxtEmail.Enabled = true;
            CmbSexo.Enabled = true;
            CmbCargo.Enabled = true;
            CmbTipoUsuario.Enabled = true;

        }
        private void DesabilitaTexts()
        {
            TxtId_Usuario.Enabled = false;
            TxtNome_Usuario.Enabled = false;
            TxtLogin.Enabled = false;
            TxtSenha.Enabled = false;
            TxtEmail.Enabled = false;
            CmbSexo.Enabled = false;
            CmbCargo.Enabled = false;
            CmbTipoUsuario.Enabled = false;
        }
        private int ObterProximoIdUsuario()
        {
            int proximoId = 1;

            using (SqlConnection con = new ConectaBanco().ConectaSqlServer())
            {
                string query = "SELECT IDENT_CURRENT('usuario') + 1";
                SqlCommand cmd = new SqlCommand(query, con);

                try
                {
                    con.Open();
                    object resultado = cmd.ExecuteScalar();

                    if (resultado != DBNull.Value)
                    {
                        proximoId = Convert.ToInt32(resultado);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao obter próximo ID: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return proximoId;
        }
        private void LimparCampos()
        {
            TxtId_Usuario.Text = string.Empty;
            TxtNome_Usuario.Text = string.Empty;
            TxtLogin.Text = string.Empty;
            TxtSenha.Text = string.Empty;
            TxtEmail.Text = string.Empty;
            CmbSexo.Text = string.Empty;
            CmbCargo.Text = string.Empty;
            CmbTipoUsuario.Text = string.Empty;

        }
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            AtivarTexts();
            int proximoId = ObterProximoIdUsuario();
            TxtId_Usuario.Text = proximoId.ToString();
            TxtNome_Usuario.Focus();
            BtnNovo.Enabled = false;
            BtnSalvar.Enabled = true;
            BtnCancelar.Enabled = true;
            BtnEditar.Enabled = false;
            BtnExcluir.Enabled = false;
            BtnConsultar.Enabled = false;
            BtnRelatorio.Enabled = false;
            BtnAjuda.Enabled = true;
        }
        private void TxtNome_Usuario_TextChanged(object sender, EventArgs e)
        {
            TxtNome_Usuario.Text = TxtNome_Usuario.Text.ToUpper();
            TxtNome_Usuario.SelectionStart = TxtNome_Usuario.Text.Length;
        }
        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(TxtNome_Usuario.Text) ||
                string.IsNullOrEmpty(TxtLogin.Text) ||
                string.IsNullOrEmpty(TxtSenha.Text) ||
                string.IsNullOrEmpty(TxtEmail.Text) ||
                CmbSexo.SelectedIndex == -1 ||
                CmbCargo.SelectedIndex == -1 ||
                CmbTipoUsuario.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.");
                return false;
            }
            return true;
        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtNome_Usuario.Text))
            {
                MessageBox.Show("O Nome do Usuário não pode estar vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(TxtLogin.Text))
            {
                MessageBox.Show("O Login do Usuário não pode estar vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(TxtSenha.Text))
            {
                MessageBox.Show("A Senha do Usuário não pode estar vazia.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CmbSexo.SelectedValue == null || CmbCargo.SelectedValue == null || CmbTipoUsuario.SelectedValue == null)
            {
                MessageBox.Show("Todos os campos de seleção devem ser preenchidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Usuario usuario = new Usuario
            {
                Nome = TxtNome_Usuario.Text,
                Login = TxtLogin.Text,
                Senha = TxtSenha.Text,
                Email = TxtEmail.Text,

                Sexo = new Sexo
                {
                    Id_Sexo = Convert.ToInt32(CmbSexo.SelectedValue),
                    Nome_Sexo = CmbSexo.Text                         
                },
                Cargo = new Cargo
                {
                    Id_Cargo = Convert.ToInt32(CmbCargo.SelectedValue),
                    Nome_Cargo = CmbCargo.Text
                },
                Tipo_Usuario = new Tipo_Usuario
                {
                    Id_Tipo_Usuario = Convert.ToInt32(CmbTipoUsuario.SelectedValue),
                    Nome_Tipo = CmbTipoUsuario.Text
                }
            };

            try
            {
                C_Usuario cUsuario = new C_Usuario();

                if (novo) // Cadastro de um novo usuário
                {
                    cUsuario.InsereDados(usuario);
                }
                else // Atualização de um usuário existente
                {
                    usuario.Id_Usuario = int.Parse(TxtId_Usuario.Text);
                    cUsuario.EditarDados(usuario);
                    novo = true; // Reseta a variável para o próximo uso
                }

                MessageBox.Show("Dados salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Atualiza o estado do formulário
                DesabilitaTexts();
                LimparCampos();
                BtnNovo.Enabled = true;
                BtnSalvar.Enabled = false;
                BtnCancelar.Enabled = false;
                BtnEditar.Enabled = true;
                BtnExcluir.Enabled = true;
                BtnConsultar.Enabled = true;
                BtnRelatorio.Enabled = true;
                BtnAjuda.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar os dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ExcluirRegistrosEmBranco()
        {
            try
            {
                ConectaBanco conectaBanco = new ConectaBanco();

                using (SqlConnection conn = conectaBanco.ConectaSqlServer())
                {
                    string query = "DELETE FROM Usuario WHERE Nome_Usuario = ''";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir registros em branco: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            DesabilitaTexts();
            BtnNovo.Enabled = true;
            BtnSalvar.Enabled = false;
            BtnCancelar.Enabled = false;
            BtnEditar.Enabled = true;
            BtnExcluir.Enabled = true;
            BtnConsultar.Enabled = true;
            BtnRelatorio.Enabled = true;
            BtnAjuda.Enabled = true;
        }
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            TxtId_Usuario.Enabled = true;
            TxtId_Usuario.Focus();
            BtnCancelar.Enabled = true;
            BtnNovo.Enabled=false;
            BtnConsultar.Enabled=false;
            BtnRelatorio.Enabled=false;
            novo = false;
        }
        private string BuscarNomeUsuarioPorId(int idUsuario)
        {
            string nomeUsuario = null;
            ConectaBanco cb = new ConectaBanco();

            using (SqlConnection con = cb.ConectaSqlServer())
            {
                string query = "SELECT Nome_Usuario FROM Usuario WHERE Id_Usuario = @Id_Usuario";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id_Usuario", idUsuario);

                try
                {
                    con.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        nomeUsuario = result.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar o nome do Usuário: " + ex.Message);
                }
                TxtNome_Usuario.Enabled = true;
                BtnNovo.Enabled = false;
                BtnSalvar.Enabled = true;
            }
            return nomeUsuario;
        }
        private void BuscarNomeUsuario()
        {
            int idUsuario;
            if (int.TryParse(TxtId_Usuario.Text, out idUsuario))
            {
                string nomeUsuario = BuscarNomeUsuarioPorId(idUsuario);
                if (!string.IsNullOrEmpty(nomeUsuario))
                {
                    TxtNome_Usuario.Text = nomeUsuario;
                    TxtNome_Usuario.Enabled = true;
                    BtnNovo.Enabled = false;
                    BtnSalvar.Enabled = true;
                    BtnEditar.Enabled = false;
                    BtnExcluir.Enabled = true;
                    BtnConsultar.Enabled = false;
                    BtnRelatorio.Enabled = false;
                    BtnAjuda.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Usuário não encontrado para o código informado.");
                    TxtNome_Usuario.Clear();
                    TxtId_Usuario.Focus();
                    TxtNome_Usuario.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Por favor, digite um código válido.");
            }
        }
        private void txtId_Usuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int idUsuario;

                if (int.TryParse(TxtId_Usuario.Text, out idUsuario))
                {
                    string nomeUsuario = BuscarNomeUsuarioPorId(idUsuario);

                    if (!string.IsNullOrEmpty(nomeUsuario))
                    {
                        TxtNome_Usuario.Text = nomeUsuario;
                    }
                    else
                    {
                        MessageBox.Show("Usuário não encontrado para o código informado.");
                        TxtNome_Usuario.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, digite um código válido.");
                }

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void txtId_Cargo_Leave(object sender, EventArgs e)
        {
            BuscarNomeUsuario();
        }
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtId_Usuario.Text))
            {
                MessageBox.Show("Por favor, selecione um registro para excluir.");
                return;
            }

            DialogResult confirmacao = MessageBox.Show("Tem certeza de que deseja excluir este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmacao == DialogResult.Yes)
            {
                int idUsuario;
                if (int.TryParse(TxtId_Usuario.Text, out idUsuario))
                {
                    try
                    {
                        C_Usuario ca = new C_Usuario();
                        ca.ApagaDados(idUsuario);

                        MessageBox.Show("Registro excluído com sucesso.");

                        LimparCampos();
                        DesabilitaTexts();
                        BtnNovo.Enabled = true;
                        BtnSalvar.Enabled = false;
                        BtnCancelar.Enabled = false;
                        BtnEditar.Enabled = true;
                        BtnExcluir.Enabled = false;
                        BtnConsultar.Enabled = true;
                        BtnRelatorio.Enabled = true;
                        BtnAjuda.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao excluir o registro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Código inválido.");
                }
            }
        }
        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            using (Frm_CoUsuario frmCousuario = new Frm_CoUsuario())
            {
                this.Hide();
                frmCousuario.ShowDialog();
            }
            this.Close();
        }
        private void BtnSair_Click(object sender, EventArgs e)
        {
            using (Frm_SubMenu_Cadastros frmSubc = new Frm_SubMenu_Cadastros())
            {
                this.Hide();
                frmSubc.ShowDialog();
            }
            this.Close();
        }
        private void BtnRelatorio_Click(object sender, EventArgs e)
        {
            using (FrmRelCargo frmRelcargo = new FrmRelCargo())
            {
                this.Hide();
                frmRelcargo.ShowDialog();
                this.Show();
            }
        }

        private void Frm_CUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'checkListDBDataSet.Tipo_Usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tipo_UsuarioTableAdapter.Fill(this.checkListDBDataSet.Tipo_Usuario);
            CmbTipoUsuario.SelectedIndex = -1;
            // TODO: esta linha de código carrega dados na tabela 'checkListDBDataSet.Cargo'. Você pode movê-la ou removê-la conforme necessário.
            this.cargoTableAdapter.Fill(this.checkListDBDataSet.Cargo);
            CmbCargo.SelectedIndex = -1;
            // TODO: esta linha de código carrega dados na tabela 'checkListDBDataSet.Sexo'. Você pode movê-la ou removê-la conforme necessário.
            this.sexoTableAdapter.Fill(this.checkListDBDataSet.Sexo);
            CmbSexo.SelectedIndex = -1;

        }
    }
}
