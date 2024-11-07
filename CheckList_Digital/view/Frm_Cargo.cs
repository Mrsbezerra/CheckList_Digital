using CheckList_Digital.conexao;
using CheckList_Digital.controler;
using CheckList_Digital.model;
using CheckList_Digital.view.frm_relatorio;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CheckList_Digital.view
{
    public partial class Frm_Cargo : Form
    {
        DataTable tabelaCargo;

        private Boolean novo = true;
        private SqlConnection con;
        private SqlCommand cmd;
        private string ConnectionString;
        private int posicao;
        DataRow[] linhaAtual;

        public Frm_Cargo()
        {
            InitializeComponent();
            CarregarTabela();
            AtualizarTotalRegistrosVisiveis(); // Atualizar no carregamento inicial
        }

        public void CarregarTabela()
        {
            C_Cargo ca = new C_Cargo();
            tabelaCargo = ca.BuscarNome(TxtBuscar.Text);
            DataTable dataTable = tabelaCargo.Copy();
            dataTable.DefaultView.Sort = "Id_Cargo ASC";
            DgvCargo.DataSource = dataTable;

            if (DgvCargo.Rows.Count > 0)
            {
                DgvCargo.ClearSelection();
                DgvCargo.Rows[0].Selected = true;
                DgvCargo.FirstDisplayedScrollingRowIndex = 0;
                AtualizarTextBoxComLinhaSelecionada();
            }

            AtualizarTotalRegistrosVisiveis(); // Atualizar após carregar a tabela
        }

        private void AtivarTexts()
        {
            TxtId_Cargo.Enabled = false;
            TxtCargo.Enabled = true;
            TxtDescCargo.Enabled = true;
        }

        private void DesabilitaTexts()
        {
            TxtId_Cargo.Enabled = false;
            TxtCargo.Enabled = false;
            TxtDescCargo.Enabled = false;
        }

        private void LimparCampos()
        {
            TxtId_Cargo.Text = string.Empty;
            TxtCargo.Text = string.Empty;
            TxtDescCargo.Text = string.Empty;
        }

        private void TsbNovo_Click(object sender, EventArgs e)
        {
            AtivarTexts();
            LimparCampos();
        }

        private void TsbSalvar_Click(object sender, EventArgs e)
        {
            if (novo)
            {
                AtivarTexts();
                Cargo cargo = new Cargo
                {
                    Nome_Cargo = TxtCargo.Text,
                    Descricao_Cargo = TxtDescCargo.Text
                };
                C_Cargo ca = new C_Cargo();
                ca.InsereDados(cargo);
                CarregarTabela();
                DesabilitaTexts();
            }
            else
            {
                Cargo cargo = new Cargo
                {
                    Id_Cargo = Int32.Parse(TxtId_Cargo.Text),
                    Nome_Cargo = TxtCargo.Text,
                    Descricao_Cargo = TxtDescCargo.Text
                };
                C_Cargo ca = new C_Cargo();
                ca.EditarDados(cargo);
                CarregarTabela();
                novo = true;
                DesabilitaTexts();
            }
        }

        private void TsbCancelar_Click(object sender, EventArgs e)
        {
            TxtCargo.Text = string.Empty;
            TxtCargo.Enabled = true;
            TxtDescCargo.Text = string.Empty;
            TxtDescCargo.Enabled = true;
            novo = true;
            DesabilitaTexts();
        }

        private void TsbExcluir_Click(object sender, EventArgs e)
        {
            if (DgvCargo.CurrentRow != null && DgvCargo.CurrentRow.Index != -1)
            {
                int idCargo = Convert.ToInt32(DgvCargo.CurrentRow.Cells["Id_Cargo"].Value);
                var result = MessageBox.Show("Tem certeza que deseja excluir este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    C_Cargo ca = new C_Cargo();
                    ca.ApagaDados(idCargo);
                    CarregarTabela();
                    LimparCampos();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um registro para excluir.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            C_Cargo ca = new C_Cargo();

            tabelaCargo = ca.BuscarNome(TxtBuscar.Text);
            CarregarTabela();
            novo = false;
        }

        private void DgvCargo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _ = e.RowIndex;

            TxtId_Cargo.Text = DgvCargo.CurrentRow.Cells[0].Value.ToString();
            TxtCargo.Text = DgvCargo.CurrentRow.Cells[1].Value.ToString();
            TxtDescCargo.Text = DgvCargo.CurrentRow.Cells[2].Value.ToString();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            string textoBusca = TxtBuscar.Text.Trim();

            if (!string.IsNullOrEmpty(textoBusca))
            {
                C_Cargo ca = new C_Cargo();
                DataTable resultado = ca.BuscarDados(textoBusca);
                DgvCargo.DataSource = resultado;

                AtualizarTotalRegistrosVisiveis();
                AtualizarTextBoxComLinhaSelecionada(); // Atualizar os TextBox com o primeiro resultado da busca
            }
            else
            {
                CarregarTabela();
            }
        }

        private void TsbEditar_Click(object sender, EventArgs e)
        {
            if (DgvCargo.CurrentRow != null && DgvCargo.CurrentRow.Index != -1)
            {
                TxtId_Cargo.Text = DgvCargo.CurrentRow.Cells["Id_Cargo"].Value.ToString();
                TxtCargo.Text = DgvCargo.CurrentRow.Cells["Nome_Cargo"].Value.ToString();
                TxtDescCargo.Text = DgvCargo.CurrentRow.Cells["Descricao_Cargo"].Value.ToString();
                AtivarTexts();
                novo = false;
            }
            else
            {
                MessageBox.Show("Por favor, selecione um registro para editar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private ConectaBanco conectaBanco = new ConectaBanco();

        public int TotalRegistros(string tabela, string condicao = "")
        {
            string sqlBuscarId = $"SELECT COUNT(*) AS total FROM {tabela}";

            if (!string.IsNullOrEmpty(condicao))
            {
                sqlBuscarId += " WHERE " + condicao;
            }

            // Usa a classe ConectaBanco para obter a conexão
            using (SqlConnection con = conectaBanco.ConectaSqlServer())
            using (SqlCommand cmd = new SqlCommand(sqlBuscarId, con))
            {
                con.Open();
                int total = 0;
                try
                {
                    total = (int)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar total de registros!\nErro: " + ex.Message);
                }

                return total;
            }
        }

        private void BtnPrimeiro_Click(object sender, EventArgs e)
        {
            if (DgvCargo.Rows.Count > 0)
            {
                DgvCargo.ClearSelection();
                DgvCargo.CurrentCell = DgvCargo.Rows[0].Cells[0];
                DgvCargo.FirstDisplayedScrollingRowIndex = 0;
                DgvCargo.Focus();
                AtualizarTextBoxComLinhaSelecionada();
                AtualizarTotalRegistrosVisiveis();
            }
            else
            {
                MessageBox.Show("Não há registros disponíveis.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            if (DgvCargo.Rows.Count > 0)
            {
                if (DgvCargo.CurrentRow != null)
                {
                    int currentIndex = DgvCargo.CurrentRow.Index;
                    if (currentIndex > 0)
                    {
                        DgvCargo.CurrentCell = DgvCargo.Rows[currentIndex - 1].Cells[0];
                        DgvCargo.FirstDisplayedScrollingRowIndex = currentIndex - 1;
                        AtualizarTextBoxComLinhaSelecionada();
                        AtualizarTotalRegistrosVisiveis();
                    }
                    else
                    {
                        MessageBox.Show("Não há registros anteriores.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Nenhuma linha está selecionada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AtualizarTextBoxComLinhaSelecionada()
        {
            if (DgvCargo.Rows.Count > 0)
            {
                if (DgvCargo.CurrentRow != null)
                {
                    int selectedIndex = DgvCargo.CurrentRow.Index;
                    if (selectedIndex >= 0)
                    {
                        DataGridViewRow selectedRow = DgvCargo.Rows[selectedIndex];
                        int idCargo = Convert.ToInt32(selectedRow.Cells["Id_Cargo"].Value);
                        string nomeCargo = Convert.ToString(selectedRow.Cells["Nome_Cargo"].Value);
                        string descCargo = Convert.ToString(selectedRow.Cells["Descricao_Cargo"].Value);
                        TxtId_Cargo.Text = idCargo.ToString();
                        TxtCargo.Text = nomeCargo;
                        TxtDescCargo.Text = descCargo;
                    }
                }
            }
        }

        private void DgvCargo_SelectionChanged(object sender, EventArgs e)
        {
            AtualizarTextBoxComLinhaSelecionada();
            AtualizarTotalRegistrosVisiveis();
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            if (DgvCargo.Rows.Count > 0)
            {
                if (DgvCargo.CurrentRow != null)
                {
                    int currentIndex = DgvCargo.CurrentRow.Index;
                    if (currentIndex < DgvCargo.Rows.Count - 1)
                    {
                        DgvCargo.CurrentCell = DgvCargo.Rows[currentIndex + 1].Cells[0];
                        DgvCargo.FirstDisplayedScrollingRowIndex = currentIndex + 1;
                        AtualizarTextBoxComLinhaSelecionada();
                        AtualizarTotalRegistrosVisiveis();
                    }
                    else
                    {
                        MessageBox.Show("Não há registros posteriores.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Nenhuma linha está selecionada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnUltimo_Click(object sender, EventArgs e)
        {
            if (DgvCargo.Rows.Count > 0)
            {
                int lastIndex = DgvCargo.Rows.Count - 1;
                DgvCargo.ClearSelection();
                DgvCargo.CurrentCell = DgvCargo.Rows[lastIndex].Cells[0];
                DgvCargo.FirstDisplayedScrollingRowIndex = lastIndex;
                DgvCargo.Focus();
                AtualizarTextBoxComLinhaSelecionada();
                AtualizarTotalRegistrosVisiveis();
            }
            else
            {
                MessageBox.Show("Não há registros disponíveis.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AtualizarTotalRegistrosVisiveis()
        {
            int totalRegistros = DgvCargo.Rows.Count;
            LblTotal_Registros2.Text = totalRegistros.ToString();
        }

        private void BtnRelatorio_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmRelCargo())
                frm.ShowDialog();
        }
    }
}

