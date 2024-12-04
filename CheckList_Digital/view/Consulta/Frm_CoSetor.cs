using CheckList_Digital.conexao;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CheckList_Digital.view.Consulta
{
    public partial class Frm_CoSetor : Form
    {
        public Frm_CoSetor()
        {
            InitializeComponent();
            TxtId_Setor.Focus();
        }
        private void DgvSetor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                TxtId_Setor.Text = DgvSetor.Rows[e.RowIndex].Cells["Id_Setor"].Value.ToString();
                TxtNome_Setor.Text = DgvSetor.Rows[e.RowIndex].Cells["Nome_Setor"].Value.ToString();
                TxtDescSetor.Text = DgvSetor.Rows[e.RowIndex].Cells["Descricao_Setor"].Value.ToString();
            }
        }
        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            string idSetor = TxtId_Setor.Text.Trim();
            string nomeSetor = TxtNome_Setor.Text.Trim();
            string descSetor = TxtDescSetor.Text.Trim();
            string query = "SELECT * FROM Setor WHERE 1=1";

            // Verificação de ID_Setor
            if (!string.IsNullOrEmpty(idSetor))
            {
                query += " AND Id_Setor LIKE @Id_Setor";
            }

            // Verificação de Nome_Setor
            if (!string.IsNullOrEmpty(nomeSetor))
            {
                query += " AND Nome_Setor LIKE @Nome_Setor";
            }

            if (!string.IsNullOrEmpty(descSetor))
            {
                query += " AND Descricao_Setor LIKE @Descricao_Setor";
            }

            try
            {
                using (SqlConnection connection = new ConectaBanco().ConectaSqlServer())
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (!string.IsNullOrEmpty(idSetor))
                    {
                        command.Parameters.AddWithValue("@Id_Setor", "%" + idSetor + "%");
                    }

                    if (!string.IsNullOrEmpty(nomeSetor))
                    {
                        command.Parameters.AddWithValue("@Nome_Setor", "%" + nomeSetor + "%");
                    }

                    if (!string.IsNullOrEmpty(descSetor))
                    {
                        command.Parameters.AddWithValue("@Descricao_Setor", "%" + descSetor + "%");
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    DgvSetor.DataSource = dataTable;

                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Nenhum registro encontrado com os critérios informados.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar os registros: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DgvSetor.Columns["Id_Setor"].HeaderText = "Cód. Setor";
            DgvSetor.Columns["Nome_Setor"].HeaderText = "Setor";
            DgvSetor.Columns["Descricao_Setor"].HeaderText = "Descrição Setor";
            DgvSetor.Columns["Id_Setor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DgvSetor.Columns["Nome_Setor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            AtualizarTotalRegistrosVisiveis();

            TosSetor.Enabled = true;
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtNome_Setor.Clear();
            TxtId_Setor.Clear();
            TxtDescSetor.Clear();
        }
        private void BtnSair_Click(object sender, EventArgs e)
        {
            using (Frm_CSetor frmCsexo = new Frm_CSetor())
                {
                    this.Hide(); // Esconde o formulário atual temporariamente
                    frmCsexo.ShowDialog(); // Mostra o novo formulário
                }
                this.Close(); // Fecha o formulário atual após o fechamento de Frm_SubMenu_Cadastroo
        }
        private void AtualizarTotalRegistrosVisiveis()
        {
            int totalRegistros = DgvSetor.Rows.Count;
            LblTotalRegistro2.Text = totalRegistros.ToString();
        }
        private void AtualizarTextBoxComLinhaSelecionada()
        {
            if (DgvSetor.Rows.Count > 0)
            {
                if (DgvSetor.CurrentRow != null)
                {
                    int selectedIndex = DgvSetor.CurrentRow.Index;
                    if (selectedIndex >= 0)
                    {
                        DataGridViewRow selectedRow = DgvSetor.Rows[selectedIndex];
                        int idSetor = Convert.ToInt32(selectedRow.Cells["Id_Setor"].Value);
                        string nomeSetor = Convert.ToString(selectedRow.Cells["Nome_Setor"].Value);
                        string descSetor = Convert.ToString(selectedRow.Cells["Descricao_Setor"].Value);
                        TxtId_Setor.Text = idSetor.ToString();
                        TxtNome_Setor.Text = nomeSetor;
                        TxtDescSetor.Text = descSetor;
                    }
                }
            }
        }
        private void BtnPrimeiro_Click(object sender, EventArgs e)
        {
            if (DgvSetor.Rows.Count > 0)
            {
                DgvSetor.ClearSelection();
                DgvSetor.CurrentCell = DgvSetor.Rows[0].Cells[0];
                DgvSetor.FirstDisplayedScrollingRowIndex = 0;
                DgvSetor.Focus();
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
            if (DgvSetor.Rows.Count > 0)
            {
                int lastIndex = DgvSetor.Rows.Count - 1;
                DgvSetor.ClearSelection();
                DgvSetor.CurrentCell = DgvSetor.Rows[lastIndex].Cells[0];
                DgvSetor.FirstDisplayedScrollingRowIndex = lastIndex;
                DgvSetor.Focus();
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
            if (DgvSetor.Rows.Count > 0)
            {
                if (DgvSetor.CurrentRow != null)
                {
                    int currentIndex = DgvSetor.CurrentRow.Index;
                    if (currentIndex > 0)
                    {
                        DgvSetor.CurrentCell = DgvSetor.Rows[currentIndex - 1].Cells[0];
                        DgvSetor.FirstDisplayedScrollingRowIndex = currentIndex - 1;
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
            if (DgvSetor.Rows.Count > 0)
            {
                if (DgvSetor.CurrentRow != null)
                {
                    int currentIndex = DgvSetor.CurrentRow.Index;
                    if (currentIndex < DgvSetor.Rows.Count - 1)
                    {
                        DgvSetor.CurrentCell = DgvSetor.Rows[currentIndex + 1].Cells[0];
                        DgvSetor.FirstDisplayedScrollingRowIndex = currentIndex + 1;
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
