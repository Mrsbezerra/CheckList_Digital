using CheckList_Digital.conexao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckList_Digital.view.Consulta
{
    public partial class Frm_CoSexo : Form
    {
        public Frm_CoSexo()
        {
            InitializeComponent();
            txtId_Sexo.Focus();
        }

        private void DgvSexo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtId_Sexo.Text = DgvSexo.Rows[e.RowIndex].Cells["Id_Sexo"].Value.ToString();
                txtNome_Sexo.Text = DgvSexo.Rows[e.RowIndex].Cells["Nome_Sexo"].Value.ToString();
            }
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            string idSexo = txtId_Sexo.Text.Trim();
            string nomeSexo = txtNome_Sexo.Text.Trim();
            string query = "SELECT * FROM Sexo WHERE 1=1";

            // Verificação de ID_Sexo
            if (!string.IsNullOrEmpty(idSexo))
            {
                query += " AND Id_Sexo LIKE @Id_Sexo";
            }

            // Verificação de Nome_Sexo
            if (!string.IsNullOrEmpty(nomeSexo))
            {
                query += " AND Nome_Sexo LIKE @Nome_Sexo";
            }

            try
            {
                using (SqlConnection connection = new ConectaBanco().ConectaSqlServer())
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (!string.IsNullOrEmpty(idSexo))
                    {
                        command.Parameters.AddWithValue("@Id_Sexo", "%" + idSexo + "%");
                    }

                    if (!string.IsNullOrEmpty(nomeSexo))
                    {
                        command.Parameters.AddWithValue("@Nome_Sexo", "%" + nomeSexo + "%");
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    DgvSexo.DataSource = dataTable;

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

            DgvSexo.Columns["Id_Sexo"].HeaderText = "Cód. Sexo";
            DgvSexo.Columns["Nome_Sexo"].HeaderText = "Sexo";
            DgvSexo.Columns["Id_Sexo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; // Alinhamento à direita
            DgvSexo.Columns["Nome_Sexo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft; // Alinhamento à esquerda
            AtualizarTotalRegistrosVisiveis();

            // Ativa o ToolStrip
            TosSexo.Enabled = true; // Torna o ToolStrip ativo (visível e funcional)
        }


        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            txtNome_Sexo.Clear();
            txtId_Sexo.Clear();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            using (Frm_CSexo frmCsexo = new Frm_CSexo())
                {
                    this.Hide(); // Esconde o formulário atual temporariamente
                    frmCsexo.ShowDialog(); // Mostra o novo formulário
                }
                this.Close(); // Fecha o formulário atual após o fechamento de Frm_SubMenu_Cadastroo
        }

        private void AtualizarTotalRegistrosVisiveis()
        {
            int totalRegistros = DgvSexo.Rows.Count;
            LblTotalRegistro2.Text = totalRegistros.ToString();
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
                        int idSexo = Convert.ToInt32(selectedRow.Cells["Id_Sexo"].Value);
                        string nomeSexo = Convert.ToString(selectedRow.Cells["Nome_Sexo"].Value);
                        txtId_Sexo.Text = idSexo.ToString();
                        txtNome_Sexo.Text = nomeSexo;
                    }
                }
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
    }
}
