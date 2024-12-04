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
    public partial class Frm_CSetor : Form
    {
        private bool novo = true;

        public Frm_CSetor()
        {
            InitializeComponent();
        }
        private void AtivarTexts()
        {
            TxtId_Setor.Enabled = false; 
            TxtNome_Setor.Enabled = true;
            TxtDescSetor.Enabled = true;
        }
        private void DesabilitaTexts()
        {
            TxtId_Setor.Enabled = false;
            TxtNome_Setor.Enabled = false;
            TxtDescSetor.Enabled = false;
        }
        private int ObterProximoIdSetor()
        {
            int proximoId = 1;

            using (SqlConnection con = new ConectaBanco().ConectaSqlServer())
            {
                string query = "SELECT IDENT_CURRENT('setor') + 1";
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
            TxtId_Setor.Text = string.Empty;
            TxtNome_Setor.Text = string.Empty;
            TxtDescSetor.Text = string.Empty;
        }
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            AtivarTexts();
            int proximoId = ObterProximoIdSetor();
            TxtId_Setor.Text = proximoId.ToString();
            TxtNome_Setor.Focus();
            BtnNovo.Enabled = false;
            BtnSalvar.Enabled = true;
            BtnCancelar.Enabled = true;
            BtnEditar.Enabled = false;
            BtnExcluir.Enabled = false;
            BtnConsultar.Enabled = false;
            BtnRelatorio.Enabled = false;
            BtnAjuda.Enabled = true;
        }
        private void txtNome_Setor_TextChanged(object sender, EventArgs e)
        {
            TxtNome_Setor.Text = TxtNome_Setor.Text.ToUpper();
            TxtNome_Setor.SelectionStart = TxtNome_Setor.Text.Length;
        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtNome_Setor.Text))
            {
                MessageBox.Show("O Nome do Setor não pode estar vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(TxtDescSetor.Text))
            {
                MessageBox.Show("A Descrição do Setor não pode estar vazia.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Setor setor = new Setor
            {
                Nome_Setor = TxtNome_Setor.Text,
                Descricao_Setor = TxtDescSetor.Text
            };

            try
            {
                C_Setor ca = new C_Setor();

                if (novo)
                {
                    ca.InsereDados(setor);
                }
                else
                {
                    setor.Id_Setor = int.Parse(TxtId_Setor.Text);
                    ca.EditarDados(setor);
                    novo = true;
                }

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
                // Cria uma instância de ConectaBanco
                ConectaBanco conectaBanco = new ConectaBanco();

                // Usa a instância para obter a conexão
                using (SqlConnection conn = conectaBanco.ConectaSqlServer())
                {
                    string query = "DELETE FROM Setor WHERE Nome_Setor = '' OR Descricao_Setor = ''";
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
            TxtId_Setor.Enabled = true;
            TxtId_Setor.Focus();
            BtnCancelar.Enabled = true;
            BtnNovo.Enabled=false;
            BtnConsultar.Enabled=false;
            BtnRelatorio.Enabled=false;
            novo = false;
        }
        private string BuscarNomeSetorPorId(int idSetor)
        {
            string nomeSetor = null;
            ConectaBanco cb = new ConectaBanco();

            using (SqlConnection con = cb.ConectaSqlServer())
            {
                string query = "SELECT Nome_Setor FROM Setor WHERE Id_Setor = @Id_Setor";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id_Setor", idSetor);

                try
                {
                    con.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        nomeSetor = result.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar o nome do setor: " + ex.Message);
                }
                TxtNome_Setor.Enabled = true;
                BtnNovo.Enabled = false;
                BtnSalvar.Enabled = true;
            }
            return nomeSetor;
        }
        private void BuscarNomeSetor()
        {
            int idSetor;
            if (int.TryParse(TxtId_Setor.Text, out idSetor))
            {
                string nomeSetor = BuscarNomeSetorPorId(idSetor);
                if (!string.IsNullOrEmpty(nomeSetor))
                {
                    TxtNome_Setor.Text = nomeSetor;
                    TxtNome_Setor.Enabled = true;
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
                    MessageBox.Show("Setor não encontrado para o código informado.");
                    TxtNome_Setor.Clear();
                    TxtId_Setor.Focus();
                    TxtNome_Setor.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Por favor, digite um código válido.");
            }
        }
        private void txtId_Setor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int idSetor;

                if (int.TryParse(TxtId_Setor.Text, out idSetor))
                {
                    string nomeSetor = BuscarNomeSetorPorId(idSetor);

                    if (!string.IsNullOrEmpty(nomeSetor))
                    {
                        TxtNome_Setor.Text = nomeSetor;
                    }
                    else
                    {
                        MessageBox.Show("Setor não encontrado para o código informado.");
                        TxtNome_Setor.Clear();
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
        private void txtId_Setor_Leave(object sender, EventArgs e)
        {
            BuscarNomeSetor();
        }
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtId_Setor.Text))
            {
                MessageBox.Show("Por favor, selecione um registro para excluir.");
                return;
            }

            DialogResult confirmacao = MessageBox.Show("Tem certeza de que deseja excluir este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmacao == DialogResult.Yes)
            {
                int idSetor;
                if (int.TryParse(TxtId_Setor.Text, out idSetor))
                {
                    try
                    {
                        C_Setor ca = new C_Setor();
                        ca.ApagaDados(idSetor);

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
            using (Frm_CoSetor frmCosetor = new Frm_CoSetor())
            {
                this.Hide();
                frmCosetor.ShowDialog();
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
            using (FrmRelSetor frmRelsetor = new FrmRelSetor())
            {
                this.Hide();
                frmRelsetor.ShowDialog();
                this.Show();
            }
        }
    }
}
