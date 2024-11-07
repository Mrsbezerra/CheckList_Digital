using CheckList_Digital.conexao;
using CheckList_Digital.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckList_Digital.controler
{
    internal class C_Cargo : ICRUD
    {
        SqlConnection con;
        SqlCommand cmd;
        readonly string sqlInserir = "INSERT INTO Cargo (Nome_Cargo, Descricao_Cargo) " +
                                        "VALUES (@nome_cargo, @descricao_cargo)";

        readonly string sqlApagar = "DELETE " +
                                    "FROM Cargo " +
                                    "WHERE Id_Cargo = @Id_Cargo";

        readonly string sqlTodos = "SELECT * " +
                                   "FROM Cargo";

        readonly string sqlEditar = "UPDATE Cargo set Nome_Cargo = @pnome, " +
                                    "Descricao_Cargo = @pdescricao " +
                                    "WHERE Id_Cargo = @pId_Cargo";

        readonly string sqlBuscaNome = "SELECT * " +
                                       "FROM Cargo " +
                                       "WHERE Nome_Cargo like @pnome";

        public void InsereDados(object obj)
        {
            Cargo cargo = obj as Cargo;

            if (cargo == null)
            {
                MessageBox.Show("Objeto Cargo inválido.");
                return;
            }

            ConectaBanco cb = new ConectaBanco();
            con = cb.ConectaSqlServer();
            cmd = new SqlCommand(sqlInserir, con);

            cmd.Parameters.AddWithValue("@nome_cargo", cargo.Nome_Cargo);
            cmd.Parameters.AddWithValue("@descricao_cargo", cargo.Descricao_Cargo);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Cargo incluído com sucesso");
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

        public void EditarDados(object obj)
        {
            Cargo cargo = obj as Cargo;

            if (cargo == null)
            {
                MessageBox.Show("Objeto Cargo inválido.");
                return;
            }

            ConectaBanco cb = new ConectaBanco();
            con = cb.ConectaSqlServer();
            cmd = new SqlCommand(sqlEditar, con);

            cmd.Parameters.AddWithValue("@pId_cargo", cargo.Id_Cargo);
            cmd.Parameters.AddWithValue("@pnome", cargo.Nome_Cargo);
            cmd.Parameters.AddWithValue("@pdescricao", cargo.Descricao_Cargo);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Cargo alterado com sucesso");
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

        public void ApagaDados(int id_Cargo)
        {
            ConectaBanco cb = new ConectaBanco();
            con = cb.ConectaSqlServer();
            cmd = new SqlCommand(sqlApagar, con);

            cmd.Parameters.AddWithValue("@Id_Cargo", id_Cargo);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Cargo apagado com sucesso!\nCódigo de Cargo: " + id_Cargo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao apagar cargo!\nErro: " + ex.ToString());
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
            DataTable cargos = new DataTable();

            con.Open();

            try
            {
                da.Fill(cargos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar cargos!\nErro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return cargos;
        }

        public DataTable BuscarNome(String valor)
        {
            ConectaBanco cb = new ConectaBanco();
            con = cb.ConectaSqlServer();
            cmd = new SqlCommand(sqlBuscaNome, con);

            cmd.Parameters.AddWithValue("@pNome", valor + "%");
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable cargos = new DataTable();

            con.Open();

            try
            {
                da.Fill(cargos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar cargos!\nErro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return cargos;
        }

        public DataTable BuscarDados(string textoBusca)
        {
            ConectaBanco conectaBanco = new ConectaBanco(); // Instancia a classe de conexão
            using (SqlConnection con = conectaBanco.ConectaSqlServer())
            {
                string query = "SELECT * FROM Cargo WHERE Nome_Cargo LIKE @TextoBusca";
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
