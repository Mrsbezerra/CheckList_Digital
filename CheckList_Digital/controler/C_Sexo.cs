using CheckList_Digital.conexao;
using CheckList_Digital.model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CheckList_Digital.controler
{
    internal class C_Sexo : ICRUD
    {
        SqlConnection con;
        SqlCommand cmd;
        readonly string sqlInserir = "INSERT INTO Sexo (Nome_Sexo) " +
                                        "VALUES (@nome_sexo)";

        readonly string sqlApagar = "DELETE " +
                                    "FROM Sexo " +
                                    "WHERE Id_Sexo = @Id_Sexo";

        readonly string sqlTodos = "SELECT Id_Sexo as 'Código', Nome_Sexo as Sexo " +
                                   "FROM Sexo";

        readonly string sqlEditar = "UPDATE Sexo set Nome_Sexo = @pnome " +
                                    "WHERE Id_Sexo = @pId_Sexo";

        readonly string sqlBuscaNome = "SELECT Id_Sexo as 'Código', Nome_Sexo as Sexo " +
                                       "FROM Sexo " +
                                       "WHERE Nome_Sexo like @pNome";


        public void InsereDados(object obj)
        {
            Sexo sexo = obj as Sexo;

            if (sexo == null)
            {
                MessageBox.Show("Objeto Sexo inválido.");
                return;
            }

            ConectaBanco cb = new ConectaBanco();
            con = cb.ConectaSqlServer();

            cmd = new SqlCommand(sqlInserir + "; SELECT SCOPE_IDENTITY();", con);
            cmd.Parameters.AddWithValue("@nome_sexo", sexo.Nome_Sexo);
            cmd.CommandType = CommandType.Text;

            try
            {
                con.Open();

                object idSexoObj = cmd.ExecuteScalar();
                if (idSexoObj != null)
                {
                    int idSexo = Convert.ToInt32(idSexoObj);
                    MessageBox.Show($"Sexo ({idSexo} - {sexo.Nome_Sexo}) cadastrado com sucesso.");
                }
                else
                {
                    MessageBox.Show("Falha ao incluir o sexo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


        public void EditarDados(object obj)
        {
            Sexo sexo = obj as Sexo;

            if (sexo == null)
            {
                MessageBox.Show("Objeto Sexo inválido.");
                return;
            }

            ConectaBanco cb = new ConectaBanco();
            con = cb.ConectaSqlServer();
            cmd = new SqlCommand(sqlEditar, con);

            cmd.Parameters.AddWithValue("@pNome", sexo.Nome_Sexo);
            cmd.Parameters.AddWithValue("@pId_sexo", sexo.Id_Sexo);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Sexo alterado com sucesso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        public void ApagaDados(int id_Sexo)
        {
            ConectaBanco cb = new ConectaBanco();
            con = cb.ConectaSqlServer();
            cmd = new SqlCommand(sqlApagar, con);

            cmd.Parameters.AddWithValue("@Id_Sexo", id_Sexo);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Sexo apagado com sucesso!\nCódigo de Sexo: " + id_Sexo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao apagar sexo!\nErro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable BuscarTodos()
        {
            ConectaBanco cb = new ConectaBanco();
            con = cb.ConectaSqlServer();
            cmd = new SqlCommand(sqlTodos, con);
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable sexos = new DataTable();

            con.Open();

            try
            {
                da.Fill(sexos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar sexos!\nErro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return sexos;
        }

        public DataTable BuscarNome(String valor)
        {
            ConectaBanco cb = new ConectaBanco();
            con = cb.ConectaSqlServer();
            cmd = new SqlCommand(sqlBuscaNome, con);

            cmd.Parameters.AddWithValue("@pNome", valor + "%");
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable sexos = new DataTable();

            con.Open();

            try
            {
                da.Fill(sexos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar sexos!\nErro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return sexos;
        }

        public DataTable BuscarDados(string textoBusca)
        {
            ConectaBanco conectaBanco = new ConectaBanco(); // Instancia a classe de conexão
            using (SqlConnection con = conectaBanco.ConectaSqlServer())
            {
                string query = "SELECT * FROM Sexo WHERE Nome_Sexo LIKE @TextoBusca";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@TextoBusca", "%" + textoBusca + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

    }
}
