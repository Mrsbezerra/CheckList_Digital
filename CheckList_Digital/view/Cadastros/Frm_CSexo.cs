using CheckList_Digital.conexao;
using CheckList_Digital.controler;
using CheckList_Digital.model;
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;
using CheckList_Digital.view.Consulta;

namespace CheckList_Digital.view
{
    public partial class Frm_CSexo : Form
    {
        DataTable tabelaSexo;
        private bool novo = true;
        private int posicao;
        DataRow[] linhaAtual;

        public Frm_CSexo()
        {
            InitializeComponent();
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

        private int ObterProximoIdSexo()
        {
            int proximoId = 1;

            using (SqlConnection con = new ConectaBanco().ConectaSqlServer())
            {
                // Query para obter o próximo ID do sexo com base no IDENT_CURRENT
                string query = "SELECT IDENT_CURRENT('sexo') + 1";
                SqlCommand cmd = new SqlCommand(query, con);

                try
                {
                    con.Open();
                    // Executa a consulta e armazena o valor retornado
                    object resultado = cmd.ExecuteScalar();

                    if (resultado != DBNull.Value)
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
            txtId_Sexo.Text = string.Empty;
            txtNome_Sexo.Text = string.Empty;
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            AtivarTexts();

            // Obtemos o próximo ID disponível
            int proximoId = ObterProximoIdSexo();

            // Atribuímos o ID ao txtId_Sexo
            txtId_Sexo.Text = proximoId.ToString();

            txtNome_Sexo.Focus();
            BtnNovo.Enabled = false;
            BtnSalvar.Enabled = true;
            BtnCancelar.Enabled = true;
            BtnEditar.Enabled = false;
            BtnExcluir.Enabled = false;
            BtnConsultar.Enabled = false;
            BtnRelatorio.Enabled = false;
            BtnAjuda.Enabled = true;
        }

        private void txtNome_Sexo_TextChanged(object sender, EventArgs e)
        {
            txtNome_Sexo.Text = txtNome_Sexo.Text.ToUpper();
            txtNome_Sexo.SelectionStart = txtNome_Sexo.Text.Length;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNome_Sexo.Text))
            {
                MessageBox.Show("O nome do sexo não pode estar vazio.");
                return;
            }

            Sexo sexo = new Sexo
            {
                Nome_Sexo = txtNome_Sexo.Text
            };

            C_Sexo ca = new C_Sexo();

            if (novo) // Cadastro de um novo sexo
            {
                ca.InsereDados(sexo);
            }
            else // Atualização de um sexo existente
            {
                sexo.Id_Sexo = int.Parse(txtId_Sexo.Text);
                ca.EditarDados(sexo);
                novo = true; // Reseta a variável para o próximo uso
            }

            DesabilitaTexts();
            LimparCampos();
            BtnNovo.Enabled = true;
            BtnSalvar.Enabled = false;
            BtnCancelar.Enabled = false;
            BtnEditar.Enabled = true;
            BtnExcluir.Enabled = true;
            BtnConsultar.Enabled = true;
            BtnRelatorio.Enabled = true;
            BtnAjuda.Enabled = true;
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
            txtId_Sexo.Enabled = true;
            txtId_Sexo.Focus();
            BtnCancelar.Enabled = true;
            BtnNovo.Enabled=false;
            BtnConsultar.Enabled=false;
            BtnRelatorio.Enabled=false;


            novo = false;
        }

        private string BuscarNomeSexoPorId(int idSexo)
        {
            string nomeSexo = null;

            // Configurações da conexão e comando para buscar o nome do sexo
            ConectaBanco cb = new ConectaBanco();
            using (SqlConnection con = cb.ConectaSqlServer())
            {
                string query = "SELECT Nome_Sexo FROM Sexo WHERE Id_Sexo = @Id_Sexo";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id_Sexo", idSexo);

                try
                {
                    con.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        nomeSexo = result.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar o nome do sexo: " + ex.Message);
                }
                txtNome_Sexo.Enabled = true;
                BtnNovo.Enabled = false;
                BtnSalvar.Enabled = true;
            }

            return nomeSexo;
        }

        private void BuscarNomeSexo()
        {
            int idSexo;
            if (int.TryParse(txtId_Sexo.Text, out idSexo))
            {
                string nomeSexo = BuscarNomeSexoPorId(idSexo);
                if (!string.IsNullOrEmpty(nomeSexo))
                {
                    txtNome_Sexo.Text = nomeSexo;
                    txtNome_Sexo.Enabled = true;
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
                    MessageBox.Show("Sexo não encontrado para o código informado.");
                    txtNome_Sexo.Clear();
                    txtId_Sexo.Focus();
                    txtNome_Sexo.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Por favor, digite um código válido.");
            }
        }

        private void txtId_Sexo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int idSexo;

                // Verifica se o valor digitado é um número válido
                if (int.TryParse(txtId_Sexo.Text, out idSexo))
                {
                    // Chama o método para buscar o nome do sexo pelo Id_Sexo
                    string nomeSexo = BuscarNomeSexoPorId(idSexo);

                    if (!string.IsNullOrEmpty(nomeSexo))
                    {
                        txtNome_Sexo.Text = nomeSexo;
                    }
                    else
                    {
                        MessageBox.Show("Sexo não encontrado para o código informado.");
                        txtNome_Sexo.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, digite um código válido.");
                }

                e.Handled = true; // Evita qualquer processamento adicional da tecla
                e.SuppressKeyPress = true; // Suprime o som do "Enter"
            }
        }

        private void txtId_Sexo_Leave(object sender, EventArgs e)
        {
            BuscarNomeSexo();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            // Verifica se o campo txtId_Sexo contém um valor válido
            if (string.IsNullOrEmpty(txtId_Sexo.Text))
            {
                MessageBox.Show("Por favor, selecione um registro para excluir.");
                return;
            }

            // Confirmação de exclusão
            DialogResult confirmacao = MessageBox.Show("Tem certeza de que deseja excluir este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmacao == DialogResult.Yes)
            {
                int idSexo;
                if (int.TryParse(txtId_Sexo.Text, out idSexo))
                {
                    try
                    {
                        C_Sexo ca = new C_Sexo();
                        ca.ApagaDados(idSexo);

                        MessageBox.Show("Registro excluído com sucesso.");

                        // Limpa os campos e desativa os controles
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
            Frm_CoSexo frmCoSexo = new Frm_CoSexo(); 
            frmCoSexo.Show();
        }
    }
}
