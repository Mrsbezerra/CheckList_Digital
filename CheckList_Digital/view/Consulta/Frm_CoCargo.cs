using CheckList_Digital.conexao;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CheckList_Digital.view.Consulta
{
    public partial class Frm_CoCargo : Form
    {
        public Frm_CoCargo()
        {
            InitializeComponent();
            TxtId_Cargo.Focus();
        }
        private void DgvCargo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                TxtId_Cargo.Text = DgvCargo.Rows[e.RowIndex].Cells["Id_Cargo"].Value.ToString();
                TxtNome_Cargo.Text = DgvCargo.Rows[e.RowIndex].Cells["Nome_Cargo"].Value.ToString();
                TxtDescCargo.Text = DgvCargo.Rows[e.RowIndex].Cells["Descricao_Cargo"].Value.ToString();
            }
        }
        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            string idCargo = TxtId_Cargo.Text.Trim();
            string nomeCargo = TxtNome_Cargo.Text.Trim();
            string descCargo = TxtDescCargo.Text.Trim();
            string query = "SELECT * FROM Cargo WHERE 1=1";

            // Verificação de ID_Cargo
            if (!string.IsNullOrEmpty(idCargo))
            {
                query += " AND Id_Cargo LIKE @Id_Cargo";
            }

            // Verificação de Nome_Cargo
            if (!string.IsNullOrEmpty(nomeCargo))
            {
                query += " AND Nome_Cargo LIKE @Nome_Cargo";
            }

            if (!string.IsNullOrEmpty(descCargo))
            {
                query += " AND Descricao_Cargo LIKE @Descricao_Cargo";
            }

            try
            {
                using (SqlConnection connection = new ConectaBanco().ConectaSqlServer())
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (!string.IsNullOrEmpty(idCargo))
                    {
                        command.Parameters.AddWithValue("@Id_Cargo", "%" + idCargo + "%");
                    }

                    if (!string.IsNullOrEmpty(nomeCargo))
                    {
                        command.Parameters.AddWithValue("@Nome_Cargo", "%" + nomeCargo + "%");
                    }

                    if (!string.IsNullOrEmpty(descCargo))
                    {
                        command.Parameters.AddWithValue("@Descricao_Cargo", "%" + descCargo + "%");
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    DgvCargo.DataSource = dataTable;

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

            DgvCargo.Columns["Id_Cargo"].HeaderText = "Cód. Cargo";
            DgvCargo.Columns["Nome_Cargo"].HeaderText = "Cargo";
            DgvCargo.Columns["Descricao_Cargo"].HeaderText = "Descrição Cargo";
            DgvCargo.Columns["Id_Cargo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DgvCargo.Columns["Nome_Cargo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            AtualizarTotalRegistrosVisiveis();

            TosCargo.Enabled = true;
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtNome_Cargo.Clear();
            TxtId_Cargo.Clear();
            TxtDescCargo.Clear();
        }
        private void BtnSair_Click(object sender, EventArgs e)
        {
            using (Frm_CCargo frmCsexo = new Frm_CCargo())
                {
                    this.Hide(); // Esconde o formulário atual temporariamente
                    frmCsexo.ShowDialog(); // Mostra o novo formulário
                }
                this.Close(); // Fecha o formulário atual após o fechamento de Frm_SubMenu_Cadastroo
        }
        private void AtualizarTotalRegistrosVisiveis()
        {
            int totalRegistros = DgvCargo.Rows.Count;
            LblTotalRegistro2.Text = totalRegistros.ToString();
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
                        TxtNome_Cargo.Text = nomeCargo;
                        TxtDescCargo.Text = descCargo;
                    }
                }
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
    }
}
