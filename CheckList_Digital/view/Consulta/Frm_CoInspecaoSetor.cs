using CheckList_Digital.conexao;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CheckList_Digital.view.Consulta
{
    public partial class Frm_CoInspecaoSetor : Form
    {
        public Frm_CoInspecaoSetor()
        {
            InitializeComponent();
            TxtId_InspecaoSetor.Focus();
        }
        private void DgvInspecaoSetor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                TxtId_InspecaoSetor.Text = DgvInspecaoSetor.Rows[e.RowIndex].Cells["Id_Inspecao_Setor"].Value?.ToString();
                MtbDataInicial.Text = DgvInspecaoSetor.Rows[e.RowIndex].Cells["Data_Inspecao_Setor"].Value?.ToString();
                TxtUsuInspecaoSetor.Text = DgvInspecaoSetor.Rows[e.RowIndex].Cells["Usuario"].Value?.ToString();
            }
        }
        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            string idInspecaoSetor = TxtId_InspecaoSetor.Text.Trim();
            string usuarioInspecaoSetor = TxtUsuInspecaoSetor.Text.Trim();
            string dataInicial = MtbDataInicial.Text.Trim();
            string dataFinal = MtbDataFinal.Text.Trim();

            // Definir data atual se os campos de data estiverem vazios ou no formato "/  /"
            if (string.IsNullOrWhiteSpace(dataInicial) || dataInicial == "/  /")
            {
                dataInicial = ("01/01/1990");
            }
            if (string.IsNullOrWhiteSpace(dataFinal) || dataFinal == "/  /")
            {
                dataFinal = DateTime.Now.ToString("dd/MM/yyyy");
            }

            string query = @"
        SELECT i.*, u.Nome 
        FROM Inspecao_Setor i
        LEFT JOIN Usuario u ON i.Id_Usuario_fk = u.Id_Usuario 
        WHERE 1=1";

            if (!string.IsNullOrEmpty(idInspecaoSetor))
            {
                query += " AND i.Id_Inspecao_Setor LIKE @Id_InspecaoSetor";
            }

            // Adicionar filtro para nome do usuário
            if (!string.IsNullOrWhiteSpace(usuarioInspecaoSetor))
            {
                query += " AND u.Nome LIKE @Nome";
            }

            // Adicionar filtro para datas se válidas
            bool filtroData = false;
            if (DateTime.TryParseExact(dataInicial, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dataInicialParsed) &&
                DateTime.TryParseExact(dataFinal, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dataFinalParsed))
            {
                filtroData = true;
                query += " AND i.Data_Inspecao_Setor BETWEEN @DataInicial AND @DataFinal";
            }

            try
            {
                using (SqlConnection connection = new ConectaBanco().ConectaSqlServer())
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Adicionar parâmetros de busca
                    if (!string.IsNullOrEmpty(idInspecaoSetor))
                    {
                        command.Parameters.AddWithValue("@Id_InspecaoSetor", $"%{idInspecaoSetor}%");
                    }

                    if (!string.IsNullOrWhiteSpace(usuarioInspecaoSetor))
                    {
                        command.Parameters.AddWithValue("@Nome", $"%{usuarioInspecaoSetor}%");
                    }

                    if (filtroData)
                    {
                        command.Parameters.AddWithValue("@DataInicial", dataInicial);
                        command.Parameters.AddWithValue("@DataFinal", dataFinal);
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    DgvInspecaoSetor.DataSource = dataTable;

                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Nenhum registro encontrado com os critérios informados.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        AtualizarTotalRegistrosVisiveis();
                        TosInspecaoSetor.Enabled = true;

                        DgvInspecaoSetor.Columns["Id_Inspecao_Setor"].HeaderText = "Cód. Inspeção";
                        DgvInspecaoSetor.Columns["Data_Inspecao_Setor"].HeaderText = "Data de Inspeção";

                        DgvInspecaoSetor.Columns["Id_Usuario_fk"].Visible = false;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Erro ao buscar registros no banco de dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtId_InspecaoSetor.Clear();
            MtbDataInicial.Clear();
            MtbDataFinal.Clear();
            TxtUsuInspecaoSetor.Clear();
        }
        private void BtnSair_Click(object sender, EventArgs e)
        {
            using (Frm_CInspecaoSetor frmCsexo = new Frm_CInspecaoSetor())
                {
                    this.Hide();
                    frmCsexo.ShowDialog();
                }
                this.Close();
        }
        private void AtualizarTotalRegistrosVisiveis()
        {
            int totalRegistros = DgvInspecaoSetor.Rows.Count;
            LblTotalRegistro2.Text = totalRegistros.ToString();
        }
        private void AtualizarTextBoxComLinhaSelecionada()
        {
            if (DgvInspecaoSetor.Rows.Count > 0)
            {
                if (DgvInspecaoSetor.CurrentRow != null)
                {
                    int selectedIndex = DgvInspecaoSetor.CurrentRow.Index;
                    if (selectedIndex >= 0)
                    {
                        DataGridViewRow selectedRow = DgvInspecaoSetor.Rows[selectedIndex];
                        int idInspecaoSetor = Convert.ToInt32(selectedRow.Cells["Id_Inspecao_Setor"].Value);
                        string dataInspecaoSetor = Convert.ToString(selectedRow.Cells["Data_Inspecao_Setor"].Value);
                        string usuarioInspecaoSetor = Convert.ToString(selectedRow.Cells["Nome"].Value);
                        TxtId_InspecaoSetor.Text = idInspecaoSetor.ToString();
                        TxtUsuInspecaoSetor.Text = usuarioInspecaoSetor;
                    }
                }
            }
        }
        private void BtnPrimeiro_Click(object sender, EventArgs e)
        {
            if (DgvInspecaoSetor.Rows.Count > 0)
            {
                DgvInspecaoSetor.ClearSelection();
                DgvInspecaoSetor.CurrentCell = DgvInspecaoSetor.Rows[0].Cells[0];
                DgvInspecaoSetor.FirstDisplayedScrollingRowIndex = 0;
                DgvInspecaoSetor.Focus();
                AtualizarTextBoxComLinhaSelecionada();
                AtualizarTotalRegistrosVisiveis();
            }
            else
            {
                MessageBox.Show("Não há registros disponíveis.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void BtnUltimo_Click(object sender, EventArgs e)
        {
            if (DgvInspecaoSetor.Rows.Count > 0)
            {
                int lastIndex = DgvInspecaoSetor.Rows.Count - 1;
                DgvInspecaoSetor.ClearSelection();
                DgvInspecaoSetor.CurrentCell = DgvInspecaoSetor.Rows[lastIndex].Cells[0];
                DgvInspecaoSetor.FirstDisplayedScrollingRowIndex = lastIndex;
                DgvInspecaoSetor.Focus();
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
            if (DgvInspecaoSetor.Rows.Count > 0)
            {
                if (DgvInspecaoSetor.CurrentRow != null)
                {
                    int currentIndex = DgvInspecaoSetor.CurrentRow.Index;
                    if (currentIndex > 0)
                    {
                        DgvInspecaoSetor.CurrentCell = DgvInspecaoSetor.Rows[currentIndex - 1].Cells[0];
                        DgvInspecaoSetor.FirstDisplayedScrollingRowIndex = currentIndex - 1;
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
        private void BtnProximo_Click(object sender, EventArgs e)
        {
            if (DgvInspecaoSetor.Rows.Count > 0)
            {
                if (DgvInspecaoSetor.CurrentRow != null)
                {
                    int currentIndex = DgvInspecaoSetor.CurrentRow.Index;
                    if (currentIndex < DgvInspecaoSetor.Rows.Count - 1)
                    {
                        DgvInspecaoSetor.CurrentCell = DgvInspecaoSetor.Rows[currentIndex + 1].Cells[0];
                        DgvInspecaoSetor.FirstDisplayedScrollingRowIndex = currentIndex + 1;
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
    }
}
