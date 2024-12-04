using CheckList_Digital.conexao;
using CheckList_Digital.model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CheckList_Digital.controler
{
    internal class C_EPI : ICRUD
    {
        private readonly string sqlInserir = "INSERT INTO EPI (Nome_EPI, Data_Inspecao, Substituicao, Descricao, Validade) VALUES (@nome_epi, @data_inspecao, @substituicao, @descricao, @validade)";
        private readonly string sqlApagar = "DELETE FROM EPI WHERE Id_EPI = @Id_EPI";
        private readonly string sqlTodos = "SELECT Id_EPI as 'Código', Nome_EPI as EPI, Data_Inspecao as 'Data Inspecao', Substituicao, Descricao, Validade FROM EPI";
        private readonly string sqlEditar = "UPDATE EPI SET Nome_EPI = @pnome, Data_Inspecao = @pdata_inspecao, Substituicao = @psubstituicao, Descricao = @pdescricao, Validade = @pvalidade WHERE Id_EPI = @pId_EPI";
        private readonly string sqlBuscaNome = "SELECT Id_EPI as 'Código', Nome_EPI as EPI, Data_Inspecao as 'Data Inspecao', Substituicao, Descricao, Validade FROM EPI WHERE Nome_EPI LIKE @pNome";

        private SqlConnection GetConnection()
        {
            var cb = new ConectaBanco();
            return cb.ConectaSqlServer();
        }

        public void InsereDados(object obj)
        {
            EPI epi = obj as EPI;

            if (epi == null)
            {
                MessageBox.Show("Objeto EPI inválido.");
                return;
            }

            using (var con = GetConnection())
            {
                using (var cmd = new SqlCommand(sqlInserir + "; SELECT SCOPE_IDENTITY();", con))
                {
                    cmd.Parameters.AddWithValue("@nome_epi", epi.Nome_EPI);
                    cmd.Parameters.AddWithValue("@data_inspecao", epi.Data_Inspecao);
                    cmd.Parameters.AddWithValue("@substituicao", epi.Substituicao);
                    cmd.Parameters.AddWithValue("@descricao", epi.Descricao);
                    cmd.Parameters.AddWithValue("@validade", epi.Validade.HasValue ? (object)epi.Validade.Value : DBNull.Value);
                    cmd.CommandType = CommandType.Text;

                    try
                    {
                        con.Open();
                        object idEPIObj = cmd.ExecuteScalar();
                        if (idEPIObj != null)
                        {
                            int idEPI = Convert.ToInt32(idEPIObj);
                            MessageBox.Show($"EPI ({idEPI} - {epi.Nome_EPI}) cadastrado com sucesso.");
                        }
                        else
                        {
                            MessageBox.Show("Falha ao incluir o EPI.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }
                }
            }
        }

        public void EditarDados(object obj)
        {
            EPI epi = obj as EPI;

            if (epi == null)
            {
                MessageBox.Show("Objeto EPI inválido.");
                return;
            }

            using (var con = GetConnection())
            {
                using (var cmd = new SqlCommand(sqlEditar, con))
                {
                    cmd.Parameters.AddWithValue("@pnome", epi.Nome_EPI);
                    cmd.Parameters.AddWithValue("@pdata_inspecao", epi.Data_Inspecao);
                    cmd.Parameters.AddWithValue("@psubstituicao", epi.Substituicao);
                    cmd.Parameters.AddWithValue("@pdescricao", epi.Descricao);
                    cmd.Parameters.AddWithValue("@pvalidade", epi.Validade.HasValue ? (object)epi.Validade.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@pId_EPI", epi.Id_EPI);
                    cmd.CommandType = CommandType.Text;

                    try
                    {
                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("EPI alterado com sucesso.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }
                }
            }
        }

        public void ApagaDados(int id_EPI)
        {
            using (var con = GetConnection())
            {
                using (var cmd = new SqlCommand(sqlApagar, con))
                {
                    cmd.Parameters.AddWithValue("@Id_EPI", id_EPI);
                    cmd.CommandType = CommandType.Text;

                    try
                    {
                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"EPI apagado com sucesso! Código de EPI: {id_EPI}");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao apagar EPI! Erro: " + ex.Message);
                    }
                }
            }
        }

        public DataTable BuscarTodos()
        {
            using (var con = GetConnection())
            {
                using (var cmd = new SqlCommand(sqlTodos, con))
                {
                    cmd.CommandType = CommandType.Text;
                    var da = new SqlDataAdapter(cmd);
                    var epis = new DataTable();

                    try
                    {
                        con.Open();
                        da.Fill(epis);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao buscar EPIs! Erro: " + ex.Message);
                    }

                    return epis;
                }
            }
        }

        public DataTable BuscarNome(string valor)
        {
            using (var con = GetConnection())
            {
                using (var cmd = new SqlCommand(sqlBuscaNome, con))
                {
                    cmd.Parameters.AddWithValue("@pNome", valor + "%");
                    cmd.CommandType = CommandType.Text;

                    var da = new SqlDataAdapter(cmd);
                    var epis = new DataTable();

                    try
                    {
                        con.Open();
                        da.Fill(epis);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao buscar EPIs! Erro: " + ex.Message);
                    }

                    return epis;
                }
            }
        }

        public DataTable BuscarDados(string textoBusca)
        {
            using (var con = GetConnection())
            {
                using (var cmd = new SqlCommand("SELECT * FROM EPI WHERE Nome_EPI LIKE @TextoBusca", con))
                {
                    cmd.Parameters.AddWithValue("@TextoBusca", "%" + textoBusca + "%");

                    var da = new SqlDataAdapter(cmd);
                    var dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
