using CheckList_Digital.conexao;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CheckList_Digital.view.Consulta
{
    public partial class Frm_CoUsuario : Form
    {
        public Frm_CoUsuario()
        {
            InitializeComponent();
            TxtId_Usuario.Focus();
        }
        private void DgvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                TxtId_Usuario.Text = DgvUsuario.Rows[e.RowIndex].Cells["Id_Usuario"].Value.ToString();
                TxtNome_Usuario.Text = DgvUsuario.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
                TxtLogin.Text = DgvUsuario.Rows[e.RowIndex].Cells["Login"].Value.ToString();
                TxtEmail.Text = DgvUsuario.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                TxtSexo.Text = DgvUsuario.Rows[e.RowIndex].Cells["Sexo"].Value.ToString();
                TxtCargo.Text = DgvUsuario.Rows[e.RowIndex].Cells["Cargo"].Value.ToString();
                TxtTipo.Text = DgvUsuario.Rows[e.RowIndex].Cells["Tipo_Usuario"].Value.ToString();
            }
        }
        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            string idUsuario = TxtId_Usuario.Text.Trim();
            string nomeUsuario = TxtNome_Usuario.Text.Trim();
            string login = TxtLogin.Text.Trim();
            string emailUsuario = TxtEmail.Text.Trim();
            string nomeSexo = TxtSexo.Text.Trim();
            string cargoUsuario = TxtCargo.Text.Trim();
            string tipoUsuario = TxtTipo.Text.Trim();

            // Query SQL com JOIN para buscar pelo Nome do Sexo (usando o ID do Sexo)
            string query = "SELECT u.*, s.Nome_Sexo, c.Nome_Cargo, t.Nome_Tipo_Usuario FROM Usuario u " +
                           "LEFT JOIN Sexo s ON u.Id_Sexo_fk = s.Id_Sexo " + // JOIN entre as tabelas Usuario e Sexo
                           "LEFT JOIN Cargo c ON u.Id_Cargo_fk = c.Id_Cargo " + // JOIN entre as tabelas Usuario e Cargo
                           "LEFT JOIN Tipo_Usuario t ON u.Id_Tipo_Usuario_fk = t.Id_Tipo_Usuario " + // JOIN entre as tabelas Usuario e Tipo_Usuario
                           "WHERE 1=1";

            // Condições de filtro para cada campo
            if (!string.IsNullOrEmpty(idUsuario))
            {
                query += " AND u.Id_Usuario LIKE @Id_Usuario";
            }
            if (!string.IsNullOrEmpty(nomeUsuario))
            {
                query += " AND u.Nome_Usuario LIKE @Nome_Usuario";
            }
            if (!string.IsNullOrEmpty(login))
            {
                query += " AND u.Login LIKE @Login";
            }
            if (!string.IsNullOrEmpty(emailUsuario))
            {
                query += " AND u.Email LIKE @Email";
            }
            if (!string.IsNullOrEmpty(nomeSexo))
            {
                query += " AND s.Nome_Sexo LIKE @NomeSexo";
            }
            if (!string.IsNullOrEmpty(cargoUsuario))
            {
                query += " AND c.Nome_Cargo LIKE @Cargo";
            }
            if (!string.IsNullOrEmpty(tipoUsuario))
            {
                query += " AND t.Nome_Tipo LIKE @Tipo";
            }

            try
            {
                using (SqlConnection connection = new ConectaBanco().ConectaSqlServer())
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Adicionando parâmetros para cada campo
                    if (!string.IsNullOrEmpty(idUsuario))
                    {
                        command.Parameters.AddWithValue("@Id_Usuario", "%" + idUsuario + "%");
                    }
                    if (!string.IsNullOrEmpty(nomeUsuario))
                    {
                        command.Parameters.AddWithValue("@Nome_Usuario", "%" + nomeUsuario + "%");
                    }
                    if (!string.IsNullOrEmpty(nomeUsuario))
                    {
                        command.Parameters.AddWithValue("@Login", "%" + login + "%");
                    }
                    if (!string.IsNullOrEmpty(emailUsuario))
                    {
                        command.Parameters.AddWithValue("@Email", "%" + emailUsuario + "%");
                    }
                    if (!string.IsNullOrEmpty(nomeSexo))
                    {
                        command.Parameters.AddWithValue("@NomeSexo", "%" + nomeSexo + "%");
                    }
                    if (!string.IsNullOrEmpty(cargoUsuario))
                    {
                        command.Parameters.AddWithValue("@Cargo", "%" + cargoUsuario + "%");
                    }
                    if (!string.IsNullOrEmpty(tipoUsuario))
                    {
                        command.Parameters.AddWithValue("@Tipo", "%" + tipoUsuario + "%");
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    DgvUsuario.DataSource = dataTable;

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

            // Configurar os cabeçalhos das colunas
            DgvUsuario.Columns["Id_Usuario"].HeaderText = "Cód. Usuario";
            DgvUsuario.Columns["Nome"].HeaderText = "Usuario";
            DgvUsuario.Columns["Login"].HeaderText = "Login";
            DgvUsuario.Columns["Email"].HeaderText = "Email";
            DgvUsuario.Columns["Id_Sexo_fk"].HeaderText = "Sexo"; // Usando o Nome do Sexo
            DgvUsuario.Columns["Id_Cargo_fk"].HeaderText = "Cargo";
            DgvUsuario.Columns["Id_Tipo_Usuario_fk"].HeaderText = "Tipo de Usuário";

            // Alinhar as colunas
            DgvUsuario.Columns["Id_Usuario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DgvUsuario.Columns["Nome"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Esconder as colunas que não queremos exibir
            DgvUsuario.Columns["Id_Sexo_fk"].Visible = false;
            DgvUsuario.Columns["Id_Cargo_fk"].Visible = false;
            DgvUsuario.Columns["Id_Tipo_Usuario_fk"].Visible = false;

            AtualizarTotalRegistrosVisiveis();

            // Ativa o ToolStrip
            TosUsuario.Enabled = true; // Torna o ToolStrip ativo (visível e funcional)
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtNome_Usuario.Clear();
            TxtId_Usuario.Clear();
            TxtLogin.Clear();
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
            int totalRegistros = DgvUsuario.Rows.Count;
            LblTotalRegistro2.Text = totalRegistros.ToString();
        }
        private void AtualizarTextBoxComLinhaSelecionada()
        {
            if (DgvUsuario.Rows.Count > 0)
            {
                if (DgvUsuario.CurrentRow != null)
                {
                    int selectedIndex = DgvUsuario.CurrentRow.Index;
                    if (selectedIndex >= 0)
                    {
                        DataGridViewRow selectedRow = DgvUsuario.Rows[selectedIndex];
                        int idCargo = Convert.ToInt32(selectedRow.Cells["Id_Cargo"].Value);
                        string nomeCargo = Convert.ToString(selectedRow.Cells["Nome_Cargo"].Value);
                        string descCargo = Convert.ToString(selectedRow.Cells["Descricao_Cargo"].Value);
                        TxtId_Usuario.Text = idCargo.ToString();
                        TxtNome_Usuario.Text = nomeCargo;
                        TxtLogin.Text = descCargo;
                    }
                }
            }
        }
        private void BtnPrimeiro_Click(object sender, EventArgs e)
        {
            if (DgvUsuario.Rows.Count > 0)
            {
                DgvUsuario.ClearSelection();
                DgvUsuario.CurrentCell = DgvUsuario.Rows[0].Cells[0];
                DgvUsuario.FirstDisplayedScrollingRowIndex = 0;
                DgvUsuario.Focus();
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
            if (DgvUsuario.Rows.Count > 0)
            {
                int lastIndex = DgvUsuario.Rows.Count - 1;
                DgvUsuario.ClearSelection();
                DgvUsuario.CurrentCell = DgvUsuario.Rows[lastIndex].Cells[0];
                DgvUsuario.FirstDisplayedScrollingRowIndex = lastIndex;
                DgvUsuario.Focus();
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
            if (DgvUsuario.Rows.Count > 0)
            {
                if (DgvUsuario.CurrentRow != null)
                {
                    int currentIndex = DgvUsuario.CurrentRow.Index;
                    if (currentIndex > 0)
                    {
                        DgvUsuario.CurrentCell = DgvUsuario.Rows[currentIndex - 1].Cells[0];
                        DgvUsuario.FirstDisplayedScrollingRowIndex = currentIndex - 1;
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
            if (DgvUsuario.Rows.Count > 0)
            {
                if (DgvUsuario.CurrentRow != null)
                {
                    int currentIndex = DgvUsuario.CurrentRow.Index;
                    if (currentIndex < DgvUsuario.Rows.Count - 1)
                    {
                        DgvUsuario.CurrentCell = DgvUsuario.Rows[currentIndex + 1].Cells[0];
                        DgvUsuario.FirstDisplayedScrollingRowIndex = currentIndex + 1;
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
