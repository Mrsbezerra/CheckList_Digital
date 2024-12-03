using CheckList_Digital.conexao;
using CheckList_Digital.controler;
using CheckList_Digital.model;
using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using CheckList_Digital.view.Consulta;
using CheckList_Digital.view.Frm_Relatorio;

namespace CheckList_Digital.view
{
    public partial class Frm_CTipoUsuario : Form
    {
        private bool novo = true;

        public Frm_CTipoUsuario()
        {
            InitializeComponent();
        }
        private void AtivarTexts()
        {
            TxtId_TipoUsuario.Enabled = false; 
            TxtNome_Tipo.Enabled = true;
        }
        private void DesabilitaTexts()
        {
            TxtId_TipoUsuario.Enabled = false;
            TxtNome_Tipo.Enabled = false;
        }
        private int ObterProximoIdTipoUsuario()
        {
            int proximoId = 1;

            using (SqlConnection con = new ConectaBanco().ConectaSqlServer())
            {
                string query = "SELECT IDENT_CURRENT('tipo_usuario') + 1";
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
            TxtId_TipoUsuario.Text = string.Empty;
            TxtNome_Tipo.Text = string.Empty;
        }
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            AtivarTexts();
            int proximoId = ObterProximoIdTipoUsuario();
            TxtId_TipoUsuario.Text = proximoId.ToString();
            TxtNome_Tipo.Focus();
            BtnNovo.Enabled = false;
            BtnSalvar.Enabled = true;
            BtnCancelar.Enabled = true;
            BtnEditar.Enabled = false;
            BtnExcluir.Enabled = false;
            BtnConsultar.Enabled = false;
            BtnRelatorio.Enabled = false;
            BtnAjuda.Enabled = true;
        }
        private void txtNome_TipoUsuario_TextChanged(object sender, EventArgs e)
        {
            TxtNome_Tipo.Text = TxtNome_Tipo.Text.ToUpper();
            TxtNome_Tipo.SelectionStart = TxtNome_Tipo.Text.Length;
        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtNome_Tipo.Text))
            {
                MessageBox.Show("O Nome do TipoUsuario não pode estar vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Tipo_Usuario tipo_usuario = new Tipo_Usuario
            {
                Nome_Tipo = TxtNome_Tipo.Text,
            };

            try
            {
                C_Tipo_Usuario ca = new C_Tipo_Usuario();

                if (novo)
                {
                    ca.InsereDados(tipo_usuario);
                }
                else
                {
                    tipo_usuario.Id_Tipo_Usuario = int.Parse(TxtId_TipoUsuario.Text);
                    ca.EditarDados(tipo_usuario);
                    novo = true;
                }

                MessageBox.Show("Dados salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    string query = "DELETE FROM TipoUsuario WHERE Nome_Tipo = ''";
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
            TxtId_TipoUsuario.Enabled = true;
            TxtId_TipoUsuario.Focus();
            BtnCancelar.Enabled = true;
            BtnNovo.Enabled=false;
            BtnConsultar.Enabled=false;
            BtnRelatorio.Enabled=false;
            novo = false;
        }
        private string BuscarNomeTipoUsuarioPorId(int idTipoUsuario)
        {
            string nomeTipoUsuario = null;
            ConectaBanco cb = new ConectaBanco();

            using (SqlConnection con = cb.ConectaSqlServer())
            {
                string query = "SELECT Nome_TipoUsuario FROM TipoUsuario WHERE Id_TipoUsuario = @Id_TipoUsuario";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id_Tipo_Usuario", idTipoUsuario);

                try
                {
                    con.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        nomeTipoUsuario = result.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar o nome do tipo_usuario: " + ex.Message);
                }
                TxtNome_Tipo.Enabled = true;
                BtnNovo.Enabled = false;
                BtnSalvar.Enabled = true;
            }
            return nomeTipoUsuario;
        }
        private void BuscarNomeTipoUsuario()
        {
            int idTipoUsuario;
            if (int.TryParse(TxtId_TipoUsuario.Text, out idTipoUsuario))
            {
                string nomeTipoUsuario = BuscarNomeTipoUsuarioPorId(idTipoUsuario);
                if (!string.IsNullOrEmpty(nomeTipoUsuario))
                {
                    TxtNome_Tipo.Text = nomeTipoUsuario;
                    TxtNome_Tipo.Enabled = true;
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
                    MessageBox.Show("Tipo Usuario não encontrado para o código informado.");
                    TxtNome_Tipo.Clear();
                    TxtId_TipoUsuario.Focus();
                    TxtNome_Tipo.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Por favor, digite um código válido.");
            }
        }
        private void TxtId_TipoUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int idTipoUsuario;

                if (int.TryParse(TxtId_TipoUsuario.Text, out idTipoUsuario))
                {
                    string nomeTipoUsuario = BuscarNomeTipoUsuarioPorId(idTipoUsuario);

                    if (!string.IsNullOrEmpty(nomeTipoUsuario))
                    {
                        TxtNome_Tipo.Text = nomeTipoUsuario;
                    }
                    else
                    {
                        MessageBox.Show("Tipo Usuario não encontrado para o código informado.");
                        TxtNome_Tipo.Clear();
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
        private void TxtId_TipoUsuario_Leave(object sender, EventArgs e)
        {
            BuscarNomeTipoUsuario();
        }
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtId_TipoUsuario.Text))
            {
                MessageBox.Show("Por favor, selecione um registro para excluir.");
                return;
            }

            DialogResult confirmacao = MessageBox.Show("Tem certeza de que deseja excluir este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmacao == DialogResult.Yes)
            {
                int idTipoUsuario;
                if (int.TryParse(TxtId_TipoUsuario.Text, out idTipoUsuario))
                {
                    try
                    {
                        C_Tipo_Usuario ca = new C_Tipo_Usuario();
                        ca.ApagaDados(idTipoUsuario);

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
            using (Frm_CoTipoUsuario frmCotipo_usuario = new Frm_CoTipoUsuario())
            {
                this.Hide();
                frmCotipo_usuario.ShowDialog();
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
            using (FrmRelTipoUsuario frmReltipo_usuario = new FrmRelTipoUsuario())
            {
                this.Hide();
                frmReltipo_usuario.ShowDialog();
                this.Show();
            }
        }
    }
}
