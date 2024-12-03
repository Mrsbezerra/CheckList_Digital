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
    public partial class Frm_CCargo : Form
    {
        private bool novo = true;

        public Frm_CCargo()
        {
            InitializeComponent();
        }
        private void AtivarTexts()
        {
            TxtId_Cargo.Enabled = false; 
            TxtNome_Cargo.Enabled = true;
            TxtDescCargo.Enabled = true;
        }
        private void DesabilitaTexts()
        {
            TxtId_Cargo.Enabled = false;
            TxtNome_Cargo.Enabled = false;
            TxtDescCargo.Enabled = false;
        }
        private int ObterProximoIdCargo()
        {
            int proximoId = 1;

            using (SqlConnection con = new ConectaBanco().ConectaSqlServer())
            {
                string query = "SELECT IDENT_CURRENT('cargo') + 1";
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
            TxtId_Cargo.Text = string.Empty;
            TxtNome_Cargo.Text = string.Empty;
            TxtDescCargo.Text = string.Empty;
        }
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            AtivarTexts();
            int proximoId = ObterProximoIdCargo();
            TxtId_Cargo.Text = proximoId.ToString();
            TxtNome_Cargo.Focus();
            BtnNovo.Enabled = false;
            BtnSalvar.Enabled = true;
            BtnCancelar.Enabled = true;
            BtnEditar.Enabled = false;
            BtnExcluir.Enabled = false;
            BtnConsultar.Enabled = false;
            BtnRelatorio.Enabled = false;
            BtnAjuda.Enabled = true;
        }
        private void txtNome_Cargo_TextChanged(object sender, EventArgs e)
        {
            TxtNome_Cargo.Text = TxtNome_Cargo.Text.ToUpper();
            TxtNome_Cargo.SelectionStart = TxtNome_Cargo.Text.Length;
        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            // Valida os campos antes de tentar salvar
            if (string.IsNullOrEmpty(TxtNome_Cargo.Text))
            {
                MessageBox.Show("O Nome do Cargo não pode estar vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(TxtDescCargo.Text))
            {
                MessageBox.Show("A Descrição do Cargo não pode estar vazia.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Cria o objeto Cargo
            Cargo cargo = new Cargo
            {
                Nome_Cargo = TxtNome_Cargo.Text,
                Descricao_Cargo = TxtDescCargo.Text
            };

            try
            {
                C_Cargo ca = new C_Cargo();

                if (novo) // Cadastro de um novo cargo
                {
                    ca.InsereDados(cargo);
                }
                else // Atualização de um cargo existente
                {
                    cargo.Id_Cargo = int.Parse(TxtId_Cargo.Text);
                    ca.EditarDados(cargo);
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
                // Cria uma instância de ConectaBanco
                ConectaBanco conectaBanco = new ConectaBanco();

                // Usa a instância para obter a conexão
                using (SqlConnection conn = conectaBanco.ConectaSqlServer())
                {
                    string query = "DELETE FROM Cargo WHERE Nome_Cargo = '' OR Descricao_Cargo = ''";
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
            TxtId_Cargo.Enabled = true;
            TxtId_Cargo.Focus();
            BtnCancelar.Enabled = true;
            BtnNovo.Enabled=false;
            BtnConsultar.Enabled=false;
            BtnRelatorio.Enabled=false;
            novo = false;
        }
        private string BuscarNomeCargoPorId(int idCargo)
        {
            string nomeCargo = null;
            ConectaBanco cb = new ConectaBanco();

            using (SqlConnection con = cb.ConectaSqlServer())
            {
                string query = "SELECT Nome_Cargo FROM Cargo WHERE Id_Cargo = @Id_Cargo";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id_Cargo", idCargo);

                try
                {
                    con.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        nomeCargo = result.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar o nome do cargo: " + ex.Message);
                }
                TxtNome_Cargo.Enabled = true;
                BtnNovo.Enabled = false;
                BtnSalvar.Enabled = true;
            }
            return nomeCargo;
        }
        private void BuscarNomeCargo()
        {
            int idCargo;
            if (int.TryParse(TxtId_Cargo.Text, out idCargo))
            {
                string nomeCargo = BuscarNomeCargoPorId(idCargo);
                if (!string.IsNullOrEmpty(nomeCargo))
                {
                    TxtNome_Cargo.Text = nomeCargo;
                    TxtNome_Cargo.Enabled = true;
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
                    MessageBox.Show("Cargo não encontrado para o código informado.");
                    TxtNome_Cargo.Clear();
                    TxtId_Cargo.Focus();
                    TxtNome_Cargo.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Por favor, digite um código válido.");
            }
        }
        private void txtId_Cargo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int idCargo;

                if (int.TryParse(TxtId_Cargo.Text, out idCargo))
                {
                    string nomeCargo = BuscarNomeCargoPorId(idCargo);

                    if (!string.IsNullOrEmpty(nomeCargo))
                    {
                        TxtNome_Cargo.Text = nomeCargo;
                    }
                    else
                    {
                        MessageBox.Show("Cargo não encontrado para o código informado.");
                        TxtNome_Cargo.Clear();
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
            BuscarNomeCargo();
        }
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtId_Cargo.Text))
            {
                MessageBox.Show("Por favor, selecione um registro para excluir.");
                return;
            }

            DialogResult confirmacao = MessageBox.Show("Tem certeza de que deseja excluir este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmacao == DialogResult.Yes)
            {
                int idCargo;
                if (int.TryParse(TxtId_Cargo.Text, out idCargo))
                {
                    try
                    {
                        C_Cargo ca = new C_Cargo();
                        ca.ApagaDados(idCargo);

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
            using (Frm_CoCargo frmCocargo = new Frm_CoCargo())
            {
                this.Hide();
                frmCocargo.ShowDialog();
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
    }
}
