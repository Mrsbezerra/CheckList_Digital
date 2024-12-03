using CheckList_Digital.conexao;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CheckList_Digital.view.Consulta
{
    public partial class Frm_CoTipoUsuario : Form
    {
        public Frm_CoTipoUsuario()
        {
            InitializeComponent();
            TxtId_TipoUsuario.Focus();
        }
        private void DgvTipoUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                TxtId_TipoUsuario.Text = DgvTipoUsuario.Rows[e.RowIndex].Cells["Id_Tipo_Usuario"].Value.ToString();
                TxtNome_TipoUsuario.Text = DgvTipoUsuario.Rows[e.RowIndex].Cells["Nome_Tipo"].Value.ToString();
            }
        }
        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            string idTipoUsuario = TxtId_TipoUsuario.Text.Trim();
            string nomeTipoUsuario = TxtNome_TipoUsuario.Text.Trim();
            string query = "SELECT * FROM Tipo_Usuario WHERE 1=1";

            if (!string.IsNullOrEmpty(idTipoUsuario))
            {
                query += " AND Id_Tipo_Usuario LIKE @Id_Tipo_Usuario";
            }

            if (!string.IsNullOrEmpty(nomeTipoUsuario))
            {
                query += " AND Nome_Tipo LIKE @Nome_Tipo";
            }

            try
            {
                using (SqlConnection connection = new ConectaBanco().ConectaSqlServer())
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (!string.IsNullOrEmpty(idTipoUsuario))
                    {
                        command.Parameters.AddWithValue("@Id_Tipo_Usuario", "%" + idTipoUsuario + "%");
                    }

                    if (!string.IsNullOrEmpty(nomeTipoUsuario))
                    {
                        command.Parameters.AddWithValue("@Nome_Tipo", "%" + nomeTipoUsuario + "%");
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    DgvTipoUsuario.DataSource = dataTable;

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

            DgvTipoUsuario.Columns["Id_Tipo_Usuario"].HeaderText = "Cód. Tipo Usuario";
            DgvTipoUsuario.Columns["Nome_Tipo"].HeaderText = "Tipo Usuario";
            DgvTipoUsuario.Columns["Id_Tipo_Usuario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DgvTipoUsuario.Columns["Nome_Tipo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            AtualizarTotalRegistrosVisiveis();

            TosTipoUsuario.Enabled = true;
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtNome_TipoUsuario.Clear();
            TxtId_TipoUsuario.Clear();
        }
        private void BtnSair_Click(object sender, EventArgs e)
        {
            using (Frm_CTipoUsuario frmCtipousuario = new Frm_CTipoUsuario())
                {
                    this.Hide();
                    frmCtipousuario.ShowDialog(); 
                }
                this.Close();
        }
        private void AtualizarTotalRegistrosVisiveis()
        {
            int totalRegistros = DgvTipoUsuario.Rows.Count;
            LblTotalRegistro2.Text = totalRegistros.ToString();
        }
        private void AtualizarTextBoxComLinhaSelecionada()
        {
            if (DgvTipoUsuario.Rows.Count > 0)
            {
                if (DgvTipoUsuario.CurrentRow != null)
                {
                    int selectedIndex = DgvTipoUsuario.CurrentRow.Index;
                    if (selectedIndex >= 0)
                    {
                        DataGridViewRow selectedRow = DgvTipoUsuario.Rows[selectedIndex];
                        int idTipoUsuario = Convert.ToInt32(selectedRow.Cells["Id_Tipo_Usuario"].Value);
                        string nomeTipoUsuario = Convert.ToString(selectedRow.Cells["Nome_Tipo"].Value);
                        TxtId_TipoUsuario.Text = idTipoUsuario.ToString();
                        TxtNome_TipoUsuario.Text = nomeTipoUsuario;
                    }
                }
            }
        }
        private void BtnPrimeiro_Click(object sender, EventArgs e)
        {
            if (DgvTipoUsuario.Rows.Count > 0)
            {
                DgvTipoUsuario.ClearSelection();
                DgvTipoUsuario.CurrentCell = DgvTipoUsuario.Rows[0].Cells[0];
                DgvTipoUsuario.FirstDisplayedScrollingRowIndex = 0;
                DgvTipoUsuario.Focus();
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
            if (DgvTipoUsuario.Rows.Count > 0)
            {
                int lastIndex = DgvTipoUsuario.Rows.Count - 1;
                DgvTipoUsuario.ClearSelection();
                DgvTipoUsuario.CurrentCell = DgvTipoUsuario.Rows[lastIndex].Cells[0];
                DgvTipoUsuario.FirstDisplayedScrollingRowIndex = lastIndex;
                DgvTipoUsuario.Focus();
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
            if (DgvTipoUsuario.Rows.Count > 0)
            {
                if (DgvTipoUsuario.CurrentRow != null)
                {
                    int currentIndex = DgvTipoUsuario.CurrentRow.Index;
                    if (currentIndex > 0)
                    {
                        DgvTipoUsuario.CurrentCell = DgvTipoUsuario.Rows[currentIndex - 1].Cells[0];
                        DgvTipoUsuario.FirstDisplayedScrollingRowIndex = currentIndex - 1;
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
            if (DgvTipoUsuario.Rows.Count > 0)
            {
                if (DgvTipoUsuario.CurrentRow != null)
                {
                    int currentIndex = DgvTipoUsuario.CurrentRow.Index;
                    if (currentIndex < DgvTipoUsuario.Rows.Count - 1)
                    {
                        DgvTipoUsuario.CurrentCell = DgvTipoUsuario.Rows[currentIndex + 1].Cells[0];
                        DgvTipoUsuario.FirstDisplayedScrollingRowIndex = currentIndex + 1;
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
