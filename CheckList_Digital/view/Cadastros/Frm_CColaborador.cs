using CheckList_Digital.conexao;
using CheckList_Digital.controler;
using CheckList_Digital.model;
using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using CheckList_Digital.view.Consulta;
using CheckList_Digital.view.Frm_Relatorio;
using System.Data;

namespace CheckList_Digital.view
{
    public partial class Frm_CColaborador : Form
    {
        private bool novo = true;

        public Frm_CColaborador()
        {
            InitializeComponent();
        }
       
        private void AtivarTexts()
        {
            TxtId_Colaborador.Enabled = false; 
            TxtNome_Colaborador.Enabled = true;
            TxtEmail.Enabled = true;
            MtbRg.Enabled = true;
            MtbCpf.Enabled = true;
            CmbSexo.Enabled = true;
            CmbSetor.Enabled = true;
            CmbCargo.Enabled = true;

        }
        private void DesabilitaTexts()
        {
            TxtId_Colaborador.Enabled = false;
            TxtNome_Colaborador.Enabled = false;
            TxtEmail.Enabled = false;
           MtbRg.Enabled = false;
            MtbCpf.Enabled = false;
            CmbSexo.Enabled = false;
            CmbSetor.Enabled = false;
            CmbCargo.Enabled = false;
        }
        private int ObterProximoIdColaborador()
        {
            int proximoId = 1;

            using (SqlConnection con = new ConectaBanco().ConectaSqlServer())
            {
                string query = "SELECT IDENT_CURRENT('Colaborador') + 1";
                SqlCommand cmd = new SqlCommand(query, con);

                try
                {
                    con.Open();
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
            TxtId_Colaborador.Text = string.Empty;
            TxtNome_Colaborador.Text = string.Empty;
            TxtEmail.Text = string.Empty;
            MtbRg.Text = string.Empty;
            MtbCpf.Text = string.Empty;
            CmbSexo.Text = string.Empty;
            CmbSetor.Text = string.Empty;
            CmbCargo.Text = string.Empty;

        }
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            AtivarTexts();
            int proximoId = ObterProximoIdColaborador();
            TxtId_Colaborador.Text = proximoId.ToString();
            TxtNome_Colaborador.Focus();
            BtnNovo.Enabled = false;
            BtnSalvar.Enabled = true;
            BtnCancelar.Enabled = true;
            BtnEditar.Enabled = false;
            BtnExcluir.Enabled = false;
            BtnConsultar.Enabled = false;
            BtnRelatorio.Enabled = false;
            BtnAjuda.Enabled = true;
        }
        private void TxtNome_Colaborador_TextChanged(object sender, EventArgs e)
        {
            TxtNome_Colaborador.Text = TxtNome_Colaborador.Text.ToUpper();
            TxtNome_Colaborador.SelectionStart = TxtNome_Colaborador.Text.Length;
        }
        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(TxtNome_Colaborador.Text) ||
                string.IsNullOrEmpty(TxtEmail.Text) ||
                string.IsNullOrEmpty(MtbRg.Text) ||
                string.IsNullOrEmpty(MtbCpf.Text) ||
                CmbSexo.SelectedIndex == -1 ||
                CmbSetor.SelectedIndex == -1 ||
                CmbCargo.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.");
                return false;
            }
            return true;
        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtNome_Colaborador.Text))
            {
                MessageBox.Show("O Nome do Colaborador não pode estar vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(TxtEmail.Text))
            {
                MessageBox.Show("O E-mail do Colaborador não pode estar vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(MtbRg.Text))
            {
                MessageBox.Show("O RG do Colaborador não pode estar vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(MtbCpf.Text))
            {
                MessageBox.Show("O CPF do Colaborador não pode estar vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CmbSexo.SelectedValue == null || CmbSetor.SelectedValue == null || CmbCargo.SelectedValue == null)
            {
                MessageBox.Show("Todos os campos de seleção devem ser preenchidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Colaborador colaborador = new Colaborador
            {
                Nome_Colaborador = TxtNome_Colaborador.Text,
                Email = TxtEmail.Text,
                RG =MtbRg.Text,
                CPF = MtbCpf.Text,

                Sexo = new Sexo
                {
                    Id_Sexo = Convert.ToInt32(CmbSexo.SelectedValue),
                    Nome_Sexo = CmbSexo.Text                         
                },
                Setor = new Setor
                {
                    Id_Setor = Convert.ToInt32(CmbSetor.SelectedValue),
                    Nome_Setor = CmbSetor.Text
                },
                Cargo = new Cargo
                {
                    Id_Cargo = Convert.ToInt32(CmbCargo.SelectedValue),
                    Nome_Cargo = CmbCargo.Text
                }
            };

            try
            {
                C_Colaborador cColaborador = new C_Colaborador();

                if (novo) // Cadastro de um novo colaborador
                {
                    cColaborador.InsereDados(colaborador);
                }
                else // Atualização de um colaborador existente
                {
                    colaborador.Id_Colaborador = int.Parse(TxtId_Colaborador.Text);
                    cColaborador.EditarDados(colaborador);
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
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar os dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ExcluirRegistrosEmBranco()
        {
            try
            {
                ConectaBanco conectaBanco = new ConectaBanco();

                using (SqlConnection conn = conectaBanco.ConectaSqlServer())
                {
                    string query = "DELETE FROM Colaborador WHERE Nome_Colaborador = ''";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir registros em branco: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            TxtId_Colaborador.Enabled = true;
            TxtId_Colaborador.Focus();
            BtnCancelar.Enabled = true;
            BtnNovo.Enabled=false;
            BtnConsultar.Enabled=false;
            BtnRelatorio.Enabled=false;
            novo = false;
        }
        private string BuscarNomeColaboradorPorId(int idColaborador)
        {
            string nomeColaborador = null;
            ConectaBanco cb = new ConectaBanco();

            using (SqlConnection con = cb.ConectaSqlServer())
            {
                string query = "SELECT Nome_Colaborador FROM Colaborador WHERE Id_Colaborador = @Id_Colaborador";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id_Colaborador", idColaborador);

                try
                {
                    con.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        nomeColaborador = result.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar o nome do Colaborador: " + ex.Message);
                }
                TxtNome_Colaborador.Enabled = true;
                BtnNovo.Enabled = false;
                BtnSalvar.Enabled = true;
            }
            return nomeColaborador;
        }
        private void BuscarNomeColaborador()
        {
            int idColaborador;
            if (int.TryParse(TxtId_Colaborador.Text, out idColaborador))
            {
                string nomeColaborador = BuscarNomeColaboradorPorId(idColaborador);
                if (!string.IsNullOrEmpty(nomeColaborador))
                {
                    TxtNome_Colaborador.Text = nomeColaborador;
                    TxtNome_Colaborador.Enabled = true;
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
                    MessageBox.Show("Colaborador não encontrado para o código informado.");
                    TxtNome_Colaborador.Clear();
                    TxtId_Colaborador.Focus();
                    TxtNome_Colaborador.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Por favor, digite um código válido.");
            }
        }
        private void txtId_Colaborador_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int idColaborador;

                if (int.TryParse(TxtId_Colaborador.Text, out idColaborador))
                {
                    string nomeColaborador = BuscarNomeColaboradorPorId(idColaborador);

                    if (!string.IsNullOrEmpty(nomeColaborador))
                    {
                        TxtNome_Colaborador.Text = nomeColaborador;
                    }
                    else
                    {
                        MessageBox.Show("Colaborador não encontrado para o código informado.");
                        TxtNome_Colaborador.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, digite um código válido.");
                }

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void txtId_Cargo_Leave(object sender, EventArgs e)
        {
            BuscarNomeColaborador();
        }
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtId_Colaborador.Text))
            {
                MessageBox.Show("Por favor, selecione um registro para excluir.");
                return;
            }

            DialogResult confirmacao = MessageBox.Show("Tem certeza de que deseja excluir este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmacao == DialogResult.Yes)
            {
                int idColaborador;
                if (int.TryParse(TxtId_Colaborador.Text, out idColaborador))
                {
                    try
                    {
                        C_Colaborador ca = new C_Colaborador();
                        ca.ApagaDados(idColaborador);

                        MessageBox.Show("Registro excluído com sucesso.");

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
            /*using (Frm_CoColaborador frmCocolaborador = new Frm_CoColaborador())
            {
                this.Hide();
                frmCocolaborador.ShowDialog();
            }
            this.Close();*/
        }
        private void BtnSair_Click(object sender, EventArgs e)
        {
            using (Frm_SubMenu_Cadastros frmSubc = new Frm_SubMenu_Cadastros())
            {
                this.Hide();
                frmSubc.ShowDialog();
            }
            this.Close();
        }
        private void BtnRelatorio_Click(object sender, EventArgs e)
        {
            /*using (FrmRelColaborador frmRelcolaborador = new FrmRelColaborador())
            {
                this.Hide();
                frmRelcolaborador.ShowDialog();
                this.Show();
            }*/
        }

        private void Frm_CColaborador_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'checkListDBDataSet.Setor'. Você pode movê-la ou removê-la conforme necessário.
            this.setorTableAdapter.Fill(this.checkListDBDataSet.Setor);
            CmbSetor.SelectedIndex = -1;
            // TODO: esta linha de código carrega dados na tabela 'checkListDBDataSet.Tipo_Colaborador'. Você pode movê-la ou removê-la conforme necessário.
            // this.tipo_ColaboradorTableAdapter.Fill(this.checkListDBDataSet.Tipo_Colaborador);
            
            // TODO: esta linha de código carrega dados na tabela 'checkListDBDataSet.Cargo'. Você pode movê-la ou removê-la conforme necessário.
            this.cargoTableAdapter.Fill(this.checkListDBDataSet.Cargo);
            CmbCargo.SelectedIndex = -1;

            // TODO: esta linha de código carrega dados na tabela 'checkListDBDataSet.Sexo'. Você pode movê-la ou removê-la conforme necessário.
            this.sexoTableAdapter.Fill(this.checkListDBDataSet.Sexo);
            CmbSexo.SelectedIndex = -1;

        }
    }
}
