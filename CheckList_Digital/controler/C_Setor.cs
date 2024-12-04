using CheckList_Digital.conexao;
using CheckList_Digital.model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CheckList_Digital.controler
{
    internal class C_Setor : ICRUD
    {
        SqlConnection con;
        SqlCommand cmd;

        readonly string sqlInserir = "INSERT INTO Setor (Nome_Setor, Descricao_Setor) " +
                                     "VALUES (@nomeSetor, @descricaoSetor)";

        readonly string sqlApagar = "DELETE FROM Setor WHERE Id_Setor = @Id_Setor";

        readonly string sqlTodos = "SELECT * FROM Setor";

        readonly string sqlEditar = "UPDATE Setor SET Nome_Setor = @nomeSetor, Descricao_Setor = @descricaoSetor " +
                                    "WHERE Id_Setor = @Id_Setor";

        readonly string sqlBuscaNome = "SELECT * FROM Setor WHERE Nome_Setor LIKE @nomeSetor";

        public void InsereDados(object obj)
        {
            Setor setor = obj as Setor;

            if (setor == null)
            {
                MessageBox.Show("Objeto Setor inválido.");
                return;
            }

            ConectaBanco cb = new ConectaBanco();
            con = cb.ConectaSqlServer();
            cmd = new SqlCommand(sqlInserir, con);

            cmd.Parameters.AddWithValue("@nomeSetor", setor.Nome_Setor);
            cmd.Parameters.AddWithValue("@descricaoSetor", setor.Descricao_Setor);

            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Setor incluído com sucesso");
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
            Setor setor = obj as Setor;

            if (setor == null)
            {
                MessageBox.Show("Objeto Setor inválido.");
                return;
            }

            ConectaBanco cb = new ConectaBanco();
            con = cb.ConectaSqlServer();
            cmd = new SqlCommand(sqlEditar, con);

            cmd.Parameters.AddWithValue("@Id_Setor", setor.Id_Setor);
            cmd.Parameters.AddWithValue("@nomeSetor", setor.Nome_Setor);
            cmd.Parameters.AddWithValue("@descricaoSetor", setor.Descricao_Setor);

            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Setor alterado com sucesso");
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

        public void ApagaDados(int id_Setor)
        {
            ConectaBanco cb = new ConectaBanco();
            con = cb.ConectaSqlServer();
            cmd = new SqlCommand(sqlApagar, con);

            cmd.Parameters.AddWithValue("@Id_Setor", id_Setor);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Setor apagado com sucesso!\nCódigo de Setor: " + id_Setor);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao apagar setor!\nErro: " + ex.ToString());
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
            DataTable setores = new DataTable();

            con.Open();

            try
            {
                da.Fill(setores);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar setores!\nErro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return setores;
        }

        public DataTable BuscarNome(string valor)
        {
            ConectaBanco cb = new ConectaBanco();
            con = cb.ConectaSqlServer();
            cmd = new SqlCommand(sqlBuscaNome, con);

            cmd.Parameters.AddWithValue("@nomeSetor", valor + "%");
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable setores = new DataTable();

            con.Open();

            try
            {
                da.Fill(setores);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar setores!\nErro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return setores;
        }
    }
}
