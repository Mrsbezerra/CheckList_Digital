using CheckList_Digital.conexao;
using CheckList_Digital.model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CheckList_Digital.controler
{
    internal class C_Itens_Entrega_EPI : ICRUD2
    {
        private readonly string sqlInserir = "INSERT INTO Itens_Entrega_EPI (Id_Entrega_EPI_fk, Id_EPI_fk) VALUES (@id_entrega, @id_epi)";
        private readonly string sqlApagar = "DELETE FROM Itens_Entrega_EPI WHERE Id_Entrega_EPI_fk = @id_entrega AND Id_EPI_fk = @id_epi";
        private readonly string sqlTodos = "SELECT Itens_Entrega_EPI.Id_Entrega_EPI_fk as 'Código Entrega', EPI.Nome_EPI as 'EPI', Entrega_EPI.Data_Entrega_EPI as 'Data de Entrega' FROM Itens_Entrega_EPI INNER JOIN EPI ON Itens_Entrega_EPI.Id_EPI_fk = EPI.Id_EPI INNER JOIN Entrega_EPI ON Itens_Entrega_EPI.Id_Entrega_EPI_fk = Entrega_EPI.Id_Entrega_EPI";
        private readonly string sqlEditar = "UPDATE Itens_Entrega_EPI SET Id_Entrega_EPI_fk = @id_entrega, Id_EPI_fk = @id_epi WHERE Id_Entrega_EPI_fk = @id_entrega AND Id_EPI_fk = @id_epi";
        private readonly string sqlBuscaEntrega = "SELECT Itens_Entrega_EPI.Id_Entrega_EPI_fk as 'Código Entrega', EPI.Nome_EPI as 'EPI', Entrega_EPI.Data_Entrega_EPI as 'Data de Entrega' FROM Itens_Entrega_EPI INNER JOIN EPI ON Itens_Entrega_EPI.Id_EPI_fk = EPI.Id_EPI INNER JOIN Entrega_EPI ON Itens_Entrega_EPI.Id_Entrega_EPI_fk = Entrega_EPI.Id_Entrega_EPI WHERE Entrega_EPI.Id_Entrega_EPI = @id_entrega";

        private SqlConnection GetConnection()
        {
            var cb = new ConectaBanco();
            return cb.ConectaSqlServer();
        }

        public void InsereDados(object obj)
        {
            Itens_Entrega_EPI item = obj as Itens_Entrega_EPI;

            if (item == null)
            {
                MessageBox.Show("Objeto Itens_Entrega_EPI inválido.");
                return;
            }

            using (var con = GetConnection())
            {
                using (var cmd = new SqlCommand(sqlInserir, con))
                {
                    cmd.Parameters.AddWithValue("@id_entrega", item.Entrega_EPI.Id_Entrega_EPI);
                    cmd.Parameters.AddWithValue("@id_epi", item.EPI.Id_EPI);
                    cmd.CommandType = CommandType.Text;

                    try
                    {
                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Item de entrega de EPI inserido com sucesso.");
                        }
                        else
                        {
                            MessageBox.Show("Falha ao inserir item de entrega de EPI.");
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
            Itens_Entrega_EPI item = obj as Itens_Entrega_EPI;

            if (item == null)
            {
                MessageBox.Show("Objeto Itens_Entrega_EPI inválido.");
                return;
            }

            using (var con = GetConnection())
            {
                using (var cmd = new SqlCommand(sqlEditar, con))
                {
                    cmd.Parameters.AddWithValue("@id_entrega", item.Entrega_EPI.Id_Entrega_EPI);
                    cmd.Parameters.AddWithValue("@id_epi", item.EPI.Id_EPI);
                    cmd.CommandType = CommandType.Text;

                    try
                    {
                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Item de entrega de EPI alterado com sucesso.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }
                }
            }
        }

        public void ApagaDados(int id_Entrega_EPI, int id_EPI)
        {
            using (var con = GetConnection())
            {
                using (var cmd = new SqlCommand(sqlApagar, con))
                {
                    cmd.Parameters.AddWithValue("@id_entrega", id_Entrega_EPI);
                    cmd.Parameters.AddWithValue("@id_epi", id_EPI);
                    cmd.CommandType = CommandType.Text;

                    try
                    {
                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Item de entrega de EPI apagado com sucesso! Entrega ID: {id_Entrega_EPI}, EPI ID: {id_EPI}");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao apagar item de entrega de EPI! Erro: " + ex.Message);
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
                    var itens = new DataTable();

                    try
                    {
                        con.Open();
                        da.Fill(itens);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao buscar itens de entrega de EPI! Erro: " + ex.Message);
                    }

                    return itens;
                }
            }
        }

        public DataTable BuscarPorEntrega(int id_Entrega_EPI)
        {
            using (var con = GetConnection())
            {
                using (var cmd = new SqlCommand(sqlBuscaEntrega, con))
                {
                    cmd.Parameters.AddWithValue("@id_entrega", id_Entrega_EPI);
                    cmd.CommandType = CommandType.Text;

                    var da = new SqlDataAdapter(cmd);
                    var itens = new DataTable();

                    try
                    {
                        con.Open();
                        da.Fill(itens);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao buscar itens de entrega de EPI! Erro: " + ex.Message);
                    }

                    return itens;
                }
            }
        }
    }
}
