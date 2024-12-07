/*using CheckList_Digital.conexao;
using CheckList_Digital.controler;
using CheckList_Digital.model;
using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using CheckList_Digital.view.Consulta;
using CheckList_Digital.view.Frm_Relatorio;

namespace CheckList_Digital.view
{
    public partial class Frm_CItensInspecaoSetor : Form
    {
        private bool novo = true;

        public Frm_CItensInspecaoSetor()
        {
            InitializeComponent();
        }
        private void AtivarTexts()
        {
            CmbUsuInspecaoSetor.Enabled = true;
            CmbSetor.Enabled = true;
        }
        private void DesabilitaTexts()
        {
            CmbUsuInspecaoSetor.Enabled = false;
            CmbSetor.Enabled = false;
        }
        private int ObterProximoIdInspecaoSetor()
        {
            int proximoId = 1;

            using (SqlConnection con = new ConectaBanco().ConectaSqlServer())
            {
                string query = string query = "SELECT ISNULL(MAX(Id_Inspecao_Setor), 0) + 1 FROM Inspecao_Setor";
                // Corrigido
                SqlCommand cmd = new SqlCommand(query, con);

                try
                {
                    con.Open();
                    object resultado = cmd.ExecuteScalar();

                    if (resultado != DBNull.Value && resultado != null) // Verifica resultado
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
            CmbUsuInspecaoSetor.Text = string.Empty;
            CmbSetor.Text = string.Empty;
        }
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            AtivarTexts();
            int proximoId = ObterProximoIdInspecaoSetor();
            TxtId_InspecaoSetor.Text = proximoId.ToString();
            CmbUsuInspecaoSetor.Focus();
            BtnNovo.Enabled = false;
            BtnSalvar.Enabled = true;
            BtnCancelar.Enabled = true;
            BtnEditar.Enabled = false;
            BtnExcluir.Enabled = false;
            BtnConsultar.Enabled = false;
            BtnRelatorio.Enabled = false;
            BtnAjuda.Enabled = true;
        }
        private void txtNome_InspecaoSetor_TextChanged(object sender, EventArgs e)
        {
            MtbDataInspecao.Text = MtbDataInspecao.Text.ToUpper();
            MtbDataInspecao.SelectionStart = MtbDataInspecao.Text.Length;
        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            // Validação do ComboBox de usuário (CmbUsuInspecaoSetor)
            if (CmbUsuInspecaoSetor.SelectedValue == null)
            {
                MessageBox.Show("Por favor, selecione um usuário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validação do ComboBox de setor (CmbSetor)
            if (CmbSetor.SelectedValue == null)
            {
                MessageBox.Show("Por favor, selecione um setor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Criando o objeto de Inspeção de Itens com os valores selecionados
            InspecaoSetor itemInspecao = new InspecaoSetor
            {
                Usuario = new Usuario
                {
                    Id_Usuario = Convert.ToInt32(CmbUsuInspecaoSetor.SelectedValue) // Valor selecionado no ComboBox de usuário
                },
                Setor = new Setor
                {
                    Id_Setor = Convert.ToInt32(CmbSetor.SelectedValue) // Valor selecionado no ComboBox de setor
                }
            };

            try
            {
                // Controlador para inserir ou editar os dados
                C_Itens_Inspecao_Setor controller = new C_Itens_Inspecao_Setor();

                // Se for um novo registro (verificado pela variável 'novo')
                if (novo)
                {
                    controller.InsereDados(itemInspecao); // Inserir dados
                }
                else
                {
                    itemInspecao.Id_InspecaoSetor = int.Parse(TxtId_InspecaoSetor.Text); // Para edição
                    controller.EditarDados(itemInspecao); // Editar dados
                }

                // Desabilitar campos e limpar após salvar
                DesabilitaCampos();
                LimparCampos();

                // Habilitar/Desabilitar botões conforme o fluxo
                BtnNovo.Enabled = true;
                BtnSalvar.Enabled = false;
                BtnCancelar.Enabled = false;
                BtnEditar.Enabled = true;
                BtnExcluir.Enabled = true;
            }
            catch (Exception ex)
            {
                // Exibir erro em caso de falha
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
                    string query = "DELETE FROM InspecaoSetor WHERE Nome_InspecaoSetor = '' OR Descricao_InspecaoSetor = ''";
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
            TxtId_InspecaoSetor.Enabled = true;
            TxtId_InspecaoSetor.Focus();
            BtnCancelar.Enabled = true;
            BtnNovo.Enabled=false;
            BtnConsultar.Enabled=false;
            BtnRelatorio.Enabled=false;
            novo = false;
        }
        private string BuscarNomeInspecaoSetorPorId(int idInspecaoSetor)
        {
            string nomeInspecaoSetor = null;
            ConectaBanco cb = new ConectaBanco();

            using (SqlConnection con = cb.ConectaSqlServer())
            {
                string query = "SELECT Nome_InspecaoSetor FROM InspecaoSetor WHERE Id_InspecaoSetor = @Id_InspecaoSetor";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id_InspecaoSetor", idInspecaoSetor);

                try
                {
                    con.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        nomeInspecaoSetor = result.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar o nome do setor: " + ex.Message);
                }
                MtbDataInspecao.Enabled = true;
                BtnNovo.Enabled = false;
                BtnSalvar.Enabled = true;
            }
            return nomeInspecaoSetor;
        }
        private void BuscarNomeInspecaoSetor()
        {
            int idInspecaoSetor;
            if (int.TryParse(TxtId_InspecaoSetor.Text, out idInspecaoSetor))
            {
                string nomeInspecaoSetor = BuscarNomeInspecaoSetorPorId(idInspecaoSetor);
                if (!string.IsNullOrEmpty(nomeInspecaoSetor))
                {
                    MtbDataInspecao.Text = nomeInspecaoSetor;
                    MtbDataInspecao.Enabled = true;
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
                    MessageBox.Show("InspecaoSetor não encontrado para o código informado.");
                    MtbDataInspecao.Clear();
                    TxtId_InspecaoSetor.Focus();
                    MtbDataInspecao.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Por favor, digite um código válido.");
            }
        }
        private void txtId_InspecaoSetor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int idInspecaoSetor;

                if (int.TryParse(TxtId_InspecaoSetor.Text, out idInspecaoSetor))
                {
                    string nomeInspecaoSetor = BuscarNomeInspecaoSetorPorId(idInspecaoSetor);

                    if (!string.IsNullOrEmpty(nomeInspecaoSetor))
                    {
                        MtbDataInspecao.Text = nomeInspecaoSetor;
                    }
                    else
                    {
                        MessageBox.Show("InspecaoSetor não encontrado para o código informado.");
                        MtbDataInspecao.Clear();
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
        private void txtId_InspecaoSetor_Leave(object sender, EventArgs e)
        {
            BuscarNomeInspecaoSetor();
        }
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtId_InspecaoSetor.Text))
            {
                MessageBox.Show("Por favor, selecione um registro para excluir.");
                return;
            }

            DialogResult confirmacao = MessageBox.Show("Tem certeza de que deseja excluir este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmacao == DialogResult.Yes)
            {
                int idInspecaoSetor;
                if (int.TryParse(TxtId_InspecaoSetor.Text, out idInspecaoSetor))
                {
                    try
                    {
                        C_Inspecao_Setor ca = new C_Inspecao_Setor();
                        ca.ApagaDados(idInspecaoSetor);

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
            using (Frm_CoInspecaoSetor frmCosetor = new Frm_CoInspecaoSetor())
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
            using (FrmRelInspecaoSetor frmRelsetor = new FrmRelInspecaoSetor())
            {
                this.Hide();
                frmRelsetor.ShowDialog();
                this.Show();
            }
        }

        private void Frm_CItensInspecaoSetor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'checkListDBDataSet.Setor'. Você pode movê-la ou removê-la conforme necessário.
            this.setorTableAdapter.Fill(this.checkListDBDataSet.Setor);
            // TODO: esta linha de código carrega dados na tabela 'checkListDBDataSet.Inspecao_Setor'. Você pode movê-la ou removê-la conforme necessário.
            this.inspecao_SetorTableAdapter.Fill(this.checkListDBDataSet.Inspecao_Setor);
            // TODO: esta linha de código carrega dados na tabela 'checkListDBDataSet.Usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.usuarioTableAdapter.Fill(this.checkListDBDataSet.Usuario);
            CmbUsuInspecaoSetor.SelectedIndex = -1;

        }
    }
}*/
