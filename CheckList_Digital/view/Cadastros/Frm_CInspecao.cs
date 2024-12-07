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
    public partial class Frm_CInspecao : Form
    {
        private bool novo = true;
        private string loginUsuario;

        public Frm_CInspecao()
        {
            InitializeComponent();
        }
        private void AtivarTexts()
        {
            TxtId_Inspecao.Enabled = false; 
            MtbDataInspecao.Enabled = true;
            MtbHora.Enabled = true;
            CmbSetor.Enabled = true;
            CmbInspecaoSetor.Enabled = true;
            CmbUsuario.Enabled = true;
        }
        private void DesabilitaTexts()
        {
            TxtId_Inspecao.Enabled = false;
            MtbDataInspecao.Enabled = false;
            CmbUsuario.Enabled = false;
        }
        private int ObterProximoIdInspecao()
        {
            int proximoId = 1;

            using (SqlConnection con = new ConectaBanco().ConectaSqlServer())
            {
                string query = "SELECT MAX(Id_Inspecao) + 1 FROM Inspecao"; // Corrigido
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
            TxtId_Inspecao.Text = string.Empty;
            MtbDataInspecao.Text = string.Empty;
            MtbHora.Text = string.Empty;
            CmbInspecaoSetor.Text = string.Empty;
            CmbSetor.Text = string.Empty;
            CmbUsuario.Text = string.Empty;
        }
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            AtivarTexts();
            int proximoId = ObterProximoIdInspecao();
            TxtId_Inspecao.Text = proximoId.ToString();
            MtbDataInspecao.Focus();
            BtnNovo.Enabled = false;
            BtnSalvar.Enabled = true;
            BtnCancelar.Enabled = true;
            BtnEditar.Enabled = false;
            BtnExcluir.Enabled = false;
            BtnConsultar.Enabled = false;
            BtnRelatorio.Enabled = false;
            BtnAjuda.Enabled = true;
        }
        private void txtNome_Inspecao_TextChanged(object sender, EventArgs e)
        {
            MtbDataInspecao.Text = MtbDataInspecao.Text.ToUpper();
            MtbDataInspecao.SelectionStart = MtbDataInspecao.Text.Length;
        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            // Validação da data
            if (string.IsNullOrEmpty(MtbDataInspecao.Text))
            {
                MessageBox.Show("A data da inspeção não pode estar vazia.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!DateTime.TryParse(MtbDataInspecao.Text, out DateTime data))
            {
                MessageBox.Show("Por favor, insira uma data válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validação do usuário
            if (CmbUsuario.SelectedValue == null)
            {
                MessageBox.Show("Por favor, selecione um usuário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Criação do objeto Inspecao
            Inspecao inspecao = new Inspecao
            {
                Data = DateTime.Parse(MtbDataInspecao.Text),
                Hora = TimeSpan.Parse(MtbHora.Text), // Considerando que você tenha um campo para a hora
                Setor = new Setor { Id_Setor = Convert.ToInt32(CmbSetor.SelectedValue) }, // Assuming Setor is a combo box
                Inspecao_Setor = new Inspecao_Setor { Id_Inspecao_Setor = Convert.ToInt32(CmbInspecaoSetor.SelectedValue) }, // Assuming Inspecao_Setor is a combo box
                Usuario = new Usuario { Id_Usuario = Convert.ToInt32(CmbUsuario.SelectedValue) }
            };

            try
            {
                // Controlador de Inspecao
                C_Inspecao controller = new C_Inspecao();

                // Salvar ou editar dependendo do estado
                if (novo)
                {
                    controller.InsereDados(inspecao);
                }
                else
                {
                    inspecao.Id_Inspecao = int.Parse(TxtId_Inspecao.Text);
                    controller.EditarDados(inspecao);
                }

                // Limpeza e desabilitação dos campos
                DesabilitaTexts();
                LimparCampos();

                // Atualização dos botões
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
                    string query = "DELETE FROM Inspecao WHERE Nome_Inspecao = '' OR Descricao_Inspecao = ''";
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
            TxtId_Inspecao.Enabled = true;
            TxtId_Inspecao.Focus();
            BtnCancelar.Enabled = true;
            BtnNovo.Enabled=false;
            BtnConsultar.Enabled=false;
            BtnRelatorio.Enabled=false;
            novo = false;
        }
        private string BuscarNomeInspecaoPorId(int idInspecao)
        {
            string nomeInspecao = null;
            ConectaBanco cb = new ConectaBanco();

            using (SqlConnection con = cb.ConectaSqlServer())
            {
                string query = "SELECT Nome_Inspecao FROM Inspecao WHERE Id_Inspecao = @Id_Inspecao";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id_Inspecao", idInspecao);

                try
                {
                    con.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        nomeInspecao = result.ToString();
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
            return nomeInspecao;
        }
        private void BuscarNomeInspecao()
        {
            int idInspecao;
            if (int.TryParse(TxtId_Inspecao.Text, out idInspecao))
            {
                string nomeInspecao = BuscarNomeInspecaoPorId(idInspecao);
                if (!string.IsNullOrEmpty(nomeInspecao))
                {
                    MtbDataInspecao.Text = nomeInspecao;
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
                    MessageBox.Show("Inspecao não encontrado para o código informado.");
                    MtbDataInspecao.Clear();
                    TxtId_Inspecao.Focus();
                    MtbDataInspecao.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Por favor, digite um código válido.");
            }
        }
        private void txtId_Inspecao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int idInspecao;

                if (int.TryParse(TxtId_Inspecao.Text, out idInspecao))
                {
                    string nomeInspecao = BuscarNomeInspecaoPorId(idInspecao);

                    if (!string.IsNullOrEmpty(nomeInspecao))
                    {
                        MtbDataInspecao.Text = nomeInspecao;
                    }
                    else
                    {
                        MessageBox.Show("Inspecao não encontrado para o código informado.");
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
        private void txtId_Inspecao_Leave(object sender, EventArgs e)
        {
            BuscarNomeInspecao();
        }
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtId_Inspecao.Text))
            {
                MessageBox.Show("Por favor, selecione um registro para excluir.");
                return;
            }

            DialogResult confirmacao = MessageBox.Show("Tem certeza de que deseja excluir este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmacao == DialogResult.Yes)
            {
                int idInspecao;
                if (int.TryParse(TxtId_Inspecao.Text, out idInspecao))
                {
                    try
                    {
                        C_Inspecao_Setor ca = new C_Inspecao_Setor();
                        ca.ApagaDados(idInspecao);

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
            /*using (Frm_CoInspecao frmCosetor = new Frm_CoInspecao())
            {
                this.Hide();
                frmCosetor.ShowDialog();
            }
            this.Close();*/
        }
        private void BtnSair_Click(object sender, EventArgs e)
        {
            using (Frm_SubMenu_Cadastros frmSubc = new Frm_SubMenu_Cadastros(loginUsuario))
            {
                this.Hide();
                frmSubc.ShowDialog();
            }
            this.Close();
        }
        private void BtnRelatorio_Click(object sender, EventArgs e)
        {
            /*using (FrmRelInspecao frmRelsetor = new FrmRelInspecao())
            {
                this.Hide();
                frmRelsetor.ShowDialog();
                this.Show();
            }*/
        }

        private void Frm_CInspecao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'checkListDBDataSet.Inspecao_Setor'. Você pode movê-la ou removê-la conforme necessário.
            this.inspecao_SetorTableAdapter.Fill(this.checkListDBDataSet.Inspecao_Setor);
            CmbInspecaoSetor.SelectedIndex = -1;
            // TODO: esta linha de código carrega dados na tabela 'checkListDBDataSet.Setor'. Você pode movê-la ou removê-la conforme necessário.
            this.setorTableAdapter.Fill(this.checkListDBDataSet.Setor);
            CmbSetor.SelectedIndex = -1;
            // TODO: esta linha de código carrega dados na tabela 'checkListDBDataSet.Inspecao'. Você pode movê-la ou removê-la conforme necessário.
            //this.inspecaoTableAdapter.Fill(this.checkListDBDataSet.Inspecao);
            // TODO: esta linha de código carrega dados na tabela 'checkListDBDataSet.Usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.usuarioTableAdapter.Fill(this.checkListDBDataSet.Usuario);
            CmbUsuario.SelectedIndex = -1;

        }
    }
}
