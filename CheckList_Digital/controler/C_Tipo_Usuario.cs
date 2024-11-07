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
    internal class C_Tipo_Usuario : ICRUD
    {
        SqlConnection con;
        SqlCommand cmd;
        readonly string sqlInserir = "INSERT INTO Tipo_Usuario (Nome_Tipo) " +
                                        "VALUES (@nome_tipo)";

        readonly string sqlApagar = "DELETE " +
                                    "FROM Tipo_Usuario " +
                                    "WHERE Id_Tipo_Usuario = @Id_Tipo_Usuario";

        readonly string sqlTodos = "SELECT * " +
                                   "FROM Tipo_Usuario";

        readonly string sqlEditar = "UPDATE Tipo_Usuario set Nome_Tipo = @pnome " +
                                    "WHERE Id_Tipo_Usuario = @pId_Tipo_Usuario";

        readonly string sqlBuscaNome = "SELECT * " +
                                       "FROM Tipo_Usuario " +
                                       "WHERE Nome_Tipo like @pNome";

        public void InsereDados(object obj)
        {
            Tipo_Usuario tipo_usuario = obj as Tipo_Usuario;

            if (tipo_usuario == null)
            {
                MessageBox.Show("Objeto Tipo_Usuario inválido.");
                return;
            }

            ConectaBanco cb = new ConectaBanco();
            con = cb.ConectaSqlServer();
            cmd = new SqlCommand(sqlInserir, con);

            cmd.Parameters.AddWithValue("@Nome_Tipo", tipo_usuario.Nome_Tipo);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Tipo_Usuario incluído com sucesso");
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
            Tipo_Usuario tipo_usuario = obj as Tipo_Usuario;

            if (tipo_usuario == null)
            {
                MessageBox.Show("Objeto Tipo_Usuario inválido.");
                return;
            }

            ConectaBanco cb = new ConectaBanco();
            con = cb.ConectaSqlServer();
            cmd = new SqlCommand(sqlEditar, con);

            cmd.Parameters.AddWithValue("@pNome", tipo_usuario.Nome_Tipo);
            cmd.Parameters.AddWithValue("@pId_tipo_usuario", tipo_usuario.Id_Tipo_Usuario);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Tipo_Usuario alterado com sucesso");
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

        public void ApagaDados(int id_Tipo_Usuario)
        {
            ConectaBanco cb = new ConectaBanco();
            con = cb.ConectaSqlServer();
            cmd = new SqlCommand(sqlApagar, con);

            cmd.Parameters.AddWithValue("@Id_Tipo_Usuario", id_Tipo_Usuario);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Tipo_Usuario apagado com sucesso!\nCódigo de Tipo_Usuario: " + id_Tipo_Usuario);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao apagar tipo_usuario!\nErro: " + ex.ToString());
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
            DataTable tipo_usuarios = new DataTable();

            con.Open();

            try
            {
                da.Fill(tipo_usuarios);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar tipo_usuarios!\nErro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return tipo_usuarios;
        }

        public DataTable BuscarNome(String valor)
        {
            ConectaBanco cb = new ConectaBanco();
            con = cb.ConectaSqlServer();
            cmd = new SqlCommand(sqlBuscaNome, con);

            cmd.Parameters.AddWithValue("@pNome", valor + "%");
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tipo_usuarios = new DataTable();

            con.Open();

            try
            {
                da.Fill(tipo_usuarios);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar tipo_usuarios!\nErro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return tipo_usuarios;
        }

        public DataTable BuscarDados(string textoBusca)
        {
            ConectaBanco conectaBanco = new ConectaBanco(); // Instancia a classe de conexão
            using (SqlConnection con = conectaBanco.ConectaSqlServer())
            {
                string query = "SELECT * FROM Tipo_Usuario WHERE Nome_Tipo LIKE @TextoBusca";
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
