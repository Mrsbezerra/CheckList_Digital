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
    public partial class Frm_Tipo_Usuario : Form
    {
        DataTable tabelaTipo_Usuario;

        private Boolean novo = true;
        private SqlConnection con;
        private SqlCommand cmd;
        private string ConnectionString;
        private int posicao;
        DataRow[] linhaAtual;

        public Frm_Tipo_Usuario()
        {
            InitializeComponent();
            CarregarTabela();
            AtualizarTotalRegistrosVisiveis(); // Atualizar no carregamento inicial
        }

        public void CarregarTabela()
        {
            C_Tipo_Usuario ca = new C_Tipo_Usuario();
            tabelaTipo_Usuario = ca.BuscarNome(TxtBuscar.Text);
            DataTable dataTable = tabelaTipo_Usuario.Copy();
            dataTable.DefaultView.Sort = "Id_Tipo_Usuario ASC";
            DgvTipo_Usuario.DataSource = dataTable;

            if (DgvTipo_Usuario.Rows.Count > 0)
            {
                DgvTipo_Usuario.ClearSelection();
                DgvTipo_Usuario.Rows[0].Selected = true;
                DgvTipo_Usuario.FirstDisplayedScrollingRowIndex = 0;
                AtualizarTextBoxComLinhaSelecionada();
            }

            AtualizarTotalRegistrosVisiveis(); // Atualizar após carregar a tabela
        }

        private void AtivarTexts()
        {
            txtId_Tipo_Usuario.Enabled = false;
            txtNome_Tipo_Usuario.Enabled = true;
        }

        private void DesabilitaTexts()
        {
            txtId_Tipo_Usuario.Enabled = false;
            txtNome_Tipo_Usuario.Enabled = false;
        }

        private void LimparCampos()
        {
            txtId_Tipo_Usuario.Text = string.Empty;
            txtNome_Tipo_Usuario.Text = string.Empty;
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
                Tipo_Usuario tipo_usuario = new Tipo_Usuario
                {
                    Nome_Tipo = txtNome_Tipo_Usuario.Text
                };
                C_Tipo_Usuario ca = new C_Tipo_Usuario();
                ca.InsereDados(tipo_usuario);
                CarregarTabela();
                DesabilitaTexts();
            }
            else
            {
                Tipo_Usuario tipo_usuario = new Tipo_Usuario
                {
                    Nome_Tipo = txtNome_Tipo_Usuario.Text,
                    Id_Tipo_Usuario = Int32.Parse(txtId_Tipo_Usuario.Text)
                };
                C_Tipo_Usuario ca = new C_Tipo_Usuario();
                ca.EditarDados(tipo_usuario);
                CarregarTabela();
                novo = true;
                DesabilitaTexts();
            }
        }

        private void TsbCancelar_Click(object sender, EventArgs e)
        {
            txtNome_Tipo_Usuario.Text = string.Empty;
            txtNome_Tipo_Usuario.Enabled = true;
            novo = true;
            DesabilitaTexts();
        }

        private void TsbExcluir_Click(object sender, EventArgs e)
        {
            if (DgvTipo_Usuario.CurrentRow != null && DgvTipo_Usuario.CurrentRow.Index != -1)
            {
                int idTipo_Usuario = Convert.ToInt32(DgvTipo_Usuario.CurrentRow.Cells["Id_Tipo_Usuario"].Value);
                var result = MessageBox.Show("Tem certeza que deseja excluir este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    C_Tipo_Usuario ca = new C_Tipo_Usuario();
                    ca.ApagaDados(idTipo_Usuario);
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
            C_Tipo_Usuario ca = new C_Tipo_Usuario();

            tabelaTipo_Usuario = ca.BuscarNome(TxtBuscar.Text);
            CarregarTabela();
            novo = false;
        }

        private void DgvTipo_Usuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _ = e.RowIndex;

            txtId_Tipo_Usuario.Text = DgvTipo_Usuario.CurrentRow.Cells[0].Value.ToString();
            txtNome_Tipo_Usuario.Text = DgvTipo_Usuario.CurrentRow.Cells[1].Value.ToString();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            string textoBusca = TxtBuscar.Text.Trim();

            if (!string.IsNullOrEmpty(textoBusca))
            {
                C_Tipo_Usuario ca = new C_Tipo_Usuario();
                DataTable resultado = ca.BuscarDados(textoBusca);
                DgvTipo_Usuario.DataSource = resultado;

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
            if (DgvTipo_Usuario.CurrentRow != null && DgvTipo_Usuario.CurrentRow.Index != -1)
            {
                txtId_Tipo_Usuario.Text = DgvTipo_Usuario.CurrentRow.Cells["Id_Tipo_Usuario"].Value.ToString();
                txtNome_Tipo_Usuario.Text = DgvTipo_Usuario.CurrentRow.Cells["Nome_Tipo"].Value.ToString();
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
            if (DgvTipo_Usuario.Rows.Count > 0)
            {
                DgvTipo_Usuario.ClearSelection();
                DgvTipo_Usuario.CurrentCell = DgvTipo_Usuario.Rows[0].Cells[0];
                DgvTipo_Usuario.FirstDisplayedScrollingRowIndex = 0;
                DgvTipo_Usuario.Focus();
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
            if (DgvTipo_Usuario.Rows.Count > 0)
            {
                if (DgvTipo_Usuario.CurrentRow != null)
                {
                    int currentIndex = DgvTipo_Usuario.CurrentRow.Index;
                    if (currentIndex > 0)
                    {
                        DgvTipo_Usuario.CurrentCell = DgvTipo_Usuario.Rows[currentIndex - 1].Cells[0];
                        DgvTipo_Usuario.FirstDisplayedScrollingRowIndex = currentIndex - 1;
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
            if (DgvTipo_Usuario.Rows.Count > 0)
            {
                if (DgvTipo_Usuario.CurrentRow != null)
                {
                    int selectedIndex = DgvTipo_Usuario.CurrentRow.Index;
                    if (selectedIndex >= 0)
                    {
                        DataGridViewRow selectedRow = DgvTipo_Usuario.Rows[selectedIndex];
                        int idTipo_Usuario = Convert.ToInt32(selectedRow.Cells["Id_Tipo_Usuario"].Value);
                        string nomeTipo = Convert.ToString(selectedRow.Cells["Nome_Tipo"].Value);
                        txtId_Tipo_Usuario.Text = idTipo_Usuario.ToString();
                        txtNome_Tipo_Usuario.Text = nomeTipo;
                    }
                }
            }
        }

        private void DgvTipo_Usuario_SelectionChanged(object sender, EventArgs e)
        {
            AtualizarTextBoxComLinhaSelecionada();
            AtualizarTotalRegistrosVisiveis();
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            if (DgvTipo_Usuario.Rows.Count > 0)
            {
                if (DgvTipo_Usuario.CurrentRow != null)
                {
                    int currentIndex = DgvTipo_Usuario.CurrentRow.Index;
                    if (currentIndex < DgvTipo_Usuario.Rows.Count - 1)
                    {
                        DgvTipo_Usuario.CurrentCell = DgvTipo_Usuario.Rows[currentIndex + 1].Cells[0];
                        DgvTipo_Usuario.FirstDisplayedScrollingRowIndex = currentIndex + 1;
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
            if (DgvTipo_Usuario.Rows.Count > 0)
            {
                int lastIndex = DgvTipo_Usuario.Rows.Count - 1;
                DgvTipo_Usuario.ClearSelection();
                DgvTipo_Usuario.CurrentCell = DgvTipo_Usuario.Rows[lastIndex].Cells[0];
                DgvTipo_Usuario.FirstDisplayedScrollingRowIndex = lastIndex;
                DgvTipo_Usuario.Focus();
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
            int totalRegistros = DgvTipo_Usuario.Rows.Count;
            LblTotal_Registros2.Text = totalRegistros.ToString();
        }

        private void BtnRelatorio_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmRelTipoUsuario())
                frm.ShowDialog();
        }
    }
}
