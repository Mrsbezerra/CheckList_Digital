using CheckList_Digital.conexao;
using CheckList_Digital.model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CheckList_Digital.controler
{
    internal class C_Entrega_EPI : ICRUD
    {
        private readonly string sqlInserir = "INSERT INTO Entrega_EPI (Data_Entrega_EPI, Id_Colaborador_fk) VALUES (@data_entrega, @id_colaborador)";
        private readonly string sqlApagar = "DELETE FROM Entrega_EPI WHERE Id_Entrega_EPI = @Id_Entrega_EPI";
        private readonly string sqlTodos = "SELECT Id_Entrega_EPI as 'Código', Data_Entrega_EPI as 'Data de Entrega', Colaborador.Nome_Colaborador as 'Colaborador' FROM Entrega_EPI INNER JOIN Colaborador ON Entrega_EPI.Id_Colaborador_fk = Colaborador.Id_Colaborador";
        private readonly string sqlEditar = "UPDATE Entrega_EPI SET Data_Entrega_EPI = @data_entrega, Id_Colaborador_fk = @id_colaborador WHERE Id_Entrega_EPI = @id_entrega";
        private readonly string sqlBuscaNome = "SELECT Id_Entrega_EPI as 'Código', Data_Entrega_EPI as 'Data de Entrega', Colaborador.Nome_Colaborador as 'Colaborador' FROM Entrega_EPI INNER JOIN Colaborador ON Entrega_EPI.Id_Colaborador_fk = Colaborador.Id_Colaborador WHERE Colaborador.Nome_Colaborador LIKE @pNome";

        private SqlConnection GetConnection()
        {
            var cb = new ConectaBanco();
            return cb.ConectaSqlServer();
        }

        public void InsereDados(object obj)
        {
            Entrega_EPI entrega = obj as Entrega_EPI;

            if (entrega == null)
            {
                MessageBox.Show("Objeto Entrega_EPI inválido.");
                return;
            }

            using (var con = GetConnection())
            {
                using (var cmd = new SqlCommand(sqlInserir + "; SELECT SCOPE_IDENTITY();", con))
                {
                    cmd.Parameters.AddWithValue("@data_entrega", entrega.Data_Entrega_EPI);
                    cmd.Parameters.AddWithValue("@id_colaborador", entrega.Colaborador.Id_Colaborador);
                    cmd.CommandType = CommandType.Text;

                    try
                    {
                        con.Open();
                        object idEntregaObj = cmd.ExecuteScalar();
                        if (idEntregaObj != null)
                        {
                            int idEntrega = Convert.ToInt32(idEntregaObj);
                            MessageBox.Show($"Entrega de EPI ({idEntrega} - {entrega.Data_Entrega_EPI.ToShortDateString()}) cadastrada com sucesso.");
                        }
                        else
                        {
                            MessageBox.Show("Falha ao incluir a entrega de EPI.");
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
            Entrega_EPI entrega = obj as Entrega_EPI;

            if (entrega == null)
            {
                MessageBox.Show("Objeto Entrega_EPI inválido.");
                return;
            }

            using (var con = GetConnection())
            {
                using (var cmd = new SqlCommand(sqlEditar, con))
                {
                    cmd.Parameters.AddWithValue("@data_entrega", entrega.Data_Entrega_EPI);
                    cmd.Parameters.AddWithValue("@id_colaborador", entrega.Colaborador.Id_Colaborador);
                    cmd.Parameters.AddWithValue("@id_entrega", entrega.Id_Entrega_EPI);
                    cmd.CommandType = CommandType.Text;

                    try
                    {
                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Entrega de EPI alterada com sucesso.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }
                }
            }
        }

        public void ApagaDados(int id_Entrega_EPI)
        {
            using (var con = GetConnection())
            {
                using (var cmd = new SqlCommand(sqlApagar, con))
                {
                    cmd.Parameters.AddWithValue("@Id_Entrega_EPI", id_Entrega_EPI);
                    cmd.CommandType = CommandType.Text;

                    try
                    {
                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Entrega de EPI apagada com sucesso! Código de Entrega: {id_Entrega_EPI}");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao apagar entrega de EPI! Erro: " + ex.Message);
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
                    var entregas = new DataTable();

                    try
                    {
                        con.Open();
                        da.Fill(entregas);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao buscar entregas de EPI! Erro: " + ex.Message);
                    }

                    return entregas;
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
                    var entregas = new DataTable();

                    try
                    {
                        con.Open();
                        da.Fill(entregas);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao buscar entregas de EPI! Erro: " + ex.Message);
                    }

                    return entregas;
                }
            }
        }

        public DataTable BuscarDados(string textoBusca)
        {
            using (var con = GetConnection())
            {
                using (var cmd = new SqlCommand("SELECT * FROM Entrega_EPI WHERE Data_Entrega_EPI LIKE @TextoBusca", con))
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

