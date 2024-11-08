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
    public partial class Frm_Sexo : Form
    {
        DataTable tabelaSexo;

        private Boolean novo = true;
        private SqlConnection con;
        private SqlCommand cmd;
        private string ConnectionString;
        private int posicao;
        DataRow[] linhaAtual;

        public Frm_Sexo()
        {
            InitializeComponent();
            CarregarTabela();
            AtualizarTotalRegistrosVisiveis(); // Atualizar no carregamento inicial
        }

        public void CarregarTabela()
        {
            C_Sexo ca = new C_Sexo();
            tabelaSexo = ca.BuscarNome(TxtBuscar.Text);
            DataTable dataTable = tabelaSexo.Copy();
            dataTable.DefaultView.Sort = "Código ASC";
            DgvSexo.DataSource = dataTable;

            if (DgvSexo.Rows.Count > 0)
            {
                DgvSexo.ClearSelection();
                DgvSexo.Rows[0].Selected = true;
                DgvSexo.FirstDisplayedScrollingRowIndex = 0;
                AtualizarTextBoxComLinhaSelecionada();
            }

            AtualizarTotalRegistrosVisiveis(); // Atualizar após carregar a tabela
        }

        private void AtivarTexts()
        {
            txtId_Sexo.Enabled = false;
            txtNome_Sexo.Enabled = true;
        }

        private void DesabilitaTexts()
        {
            txtId_Sexo.Enabled = false;
            txtNome_Sexo.Enabled = false;
        }

        private void LimparCampos()
        {
            txtId_Sexo.Text = string.Empty;
            txtNome_Sexo.Text = string.Empty;
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
                Sexo sexo = new Sexo
                {
                    Nome_Sexo = txtNome_Sexo.Text
                };
                C_Sexo ca = new C_Sexo();
                ca.InsereDados(sexo);
                CarregarTabela();
                DesabilitaTexts();
            }
            else
            {
                Sexo sexo = new Sexo
                {
                    Nome_Sexo = txtNome_Sexo.Text,
                    Id_Sexo = Int32.Parse(txtId_Sexo.Text)
                };
                C_Sexo ca = new C_Sexo();
                ca.EditarDados(sexo);
                CarregarTabela();
                novo = true;
                DesabilitaTexts();
            }
        }

        private void TsbCancelar_Click(object sender, EventArgs e)
        {
            txtNome_Sexo.Text = string.Empty;
            txtNome_Sexo.Enabled = true;
            novo = true;
            DesabilitaTexts();
        }

        private void TsbExcluir_Click(object sender, EventArgs e)
        {
            if (DgvSexo.CurrentRow != null && DgvSexo.CurrentRow.Index != -1)
            {
                int idSexo = Convert.ToInt32(DgvSexo.CurrentRow.Cells["Id_Sexo"].Value);
                var result = MessageBox.Show("Tem certeza que deseja excluir este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    C_Sexo ca = new C_Sexo();
                    ca.ApagaDados(idSexo);
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
            C_Sexo ca = new C_Sexo();

            tabelaSexo = ca.BuscarNome(TxtBuscar.Text);
            CarregarTabela();
            novo = false;
        }

        private void DgvSexo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _ = e.RowIndex;

            txtId_Sexo.Text = DgvSexo.CurrentRow.Cells[0].Value.ToString();
            txtNome_Sexo.Text = DgvSexo.CurrentRow.Cells[1].Value.ToString();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            string textoBusca = TxtBuscar.Text.Trim();

            if (!string.IsNullOrEmpty(textoBusca))
            {
                C_Sexo ca = new C_Sexo();
                DataTable resultado = ca.BuscarDados(textoBusca);
                DgvSexo.DataSource = resultado;

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
            if (DgvSexo.CurrentRow != null && DgvSexo.CurrentRow.Index != -1)
            {
                txtId_Sexo.Text = DgvSexo.CurrentRow.Cells["Id_Sexo"].Value.ToString();
                txtNome_Sexo.Text = DgvSexo.CurrentRow.Cells["Nome_Sexo"].Value.ToString();
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
            if (DgvSexo.Rows.Count > 0)
            {
                DgvSexo.ClearSelection();
                DgvSexo.CurrentCell = DgvSexo.Rows[0].Cells[0];
                DgvSexo.FirstDisplayedScrollingRowIndex = 0;
                DgvSexo.Focus();
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
            if (DgvSexo.Rows.Count > 0)
            {
                if (DgvSexo.CurrentRow != null)
                {
                    int currentIndex = DgvSexo.CurrentRow.Index;
                    if (currentIndex > 0)
                    {
                        DgvSexo.CurrentCell = DgvSexo.Rows[currentIndex - 1].Cells[0];
                        DgvSexo.FirstDisplayedScrollingRowIndex = currentIndex - 1;
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
            if (DgvSexo.Rows.Count > 0)
            {
                if (DgvSexo.CurrentRow != null)
                {
                    int selectedIndex = DgvSexo.CurrentRow.Index;
                    if (selectedIndex >= 0)
                    {
                        DataGridViewRow selectedRow = DgvSexo.Rows[selectedIndex];
                        int idSexo = Convert.ToInt32(selectedRow.Cells["Código"].Value);
                        string nomeSexo = Convert.ToString(selectedRow.Cells["Sexo"].Value);
                        txtId_Sexo.Text = idSexo.ToString();
                        txtNome_Sexo.Text = nomeSexo;
                    }
                }
            }
        }

        private void DgvSexo_SelectionChanged(object sender, EventArgs e)
        {
            AtualizarTextBoxComLinhaSelecionada();
            AtualizarTotalRegistrosVisiveis();
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            if (DgvSexo.Rows.Count > 0)
            {
                if (DgvSexo.CurrentRow != null)
                {
                    int currentIndex = DgvSexo.CurrentRow.Index;
                    if (currentIndex < DgvSexo.Rows.Count - 1)
                    {
                        DgvSexo.CurrentCell = DgvSexo.Rows[currentIndex + 1].Cells[0];
                        DgvSexo.FirstDisplayedScrollingRowIndex = currentIndex + 1;
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
            if (DgvSexo.Rows.Count > 0)
            {
                int lastIndex = DgvSexo.Rows.Count - 1;
                DgvSexo.ClearSelection();
                DgvSexo.CurrentCell = DgvSexo.Rows[lastIndex].Cells[0];
                DgvSexo.FirstDisplayedScrollingRowIndex = lastIndex;
                DgvSexo.Focus();
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
            int totalRegistros = DgvSexo.Rows.Count;
            LblTotal_Registros2.Text = totalRegistros.ToString();
        }

        private void BtnRelatorio_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmRelSexo()) 
                frm.ShowDialog();
        }

        private void LblTotal_Registros2_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Registros_Click(object sender, EventArgs e)
        {

        }
    }
}

