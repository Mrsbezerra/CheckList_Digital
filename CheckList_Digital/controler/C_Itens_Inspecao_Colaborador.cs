using CheckList_Digital.conexao;
using CheckList_Digital.model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CheckList_Digital.controler
{
    internal class C_Itens_Inspecao_Colaborador : ICRUD2
    {
        SqlConnection con;
        SqlCommand cmd;

        readonly string sqlInserir = "INSERT INTO Itens_Inspecao_Colaborador (Id_Inspecao_Colaborador_fk, Id_Colaborador_fk) " +
                                     "VALUES (@idinspecao, @idcolaborador)";

        readonly string sqlApagar = "DELETE FROM Itens_Inspecao_Colaborador WHERE Id_Inspecao_Colaborador_fk = @idinspecao " +
                                    "AND Id_Colaborador_fk = @idcolaborador";

        readonly string sqlTodos = "SELECT * FROM Itens_Inspecao_Colaborador";

        readonly string sqlEditar = "UPDATE Itens_Inspecao_Colaborador SET Id_Inspecao_Colaborador_fk = @idinspecao, " +
                                    "Id_Colaborador_fk = @idcolaborador WHERE Id_Inspecao_Colaborador_fk = @idinspecao " +
                                    "AND Id_Colaborador_fk = @idcolaborador";

        readonly string sqlBuscaInspecaoColaborador = "SELECT * FROM Itens_Inspecao_Colaborador WHERE Id_Inspecao_Colaborador_fk = @idinspecao";

        public void InsereDados(object obj)
        {
            Itens_Inspecao_Colaborador item = obj as Itens_Inspecao_Colaborador;

            if (item == null)
            {
                MessageBox.Show("Objeto Itens_Inspecao_Colaborador inválido.");
                return;
            }

            ConectaBanco cb = new ConectaBanco();
            con = cb.ConectaSqlServer();
            cmd = new SqlCommand(sqlInserir, con);

            cmd.Parameters.AddWithValue("@idinspecao", item.Inspecao_Colaborador.Id_Inspecao_Colaborador);
            cmd.Parameters.AddWithValue("@idcolaborador", item.Colaborador.Id_Colaborador);

            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Item de inspeção adicionado com sucesso.");
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
            Itens_Inspecao_Colaborador item = obj as Itens_Inspecao_Colaborador;

            if (item == null)
            {
                MessageBox.Show("Objeto Itens_Inspecao_Colaborador inválido.");
                return;
            }

            ConectaBanco cb = new ConectaBanco();
            con = cb.ConectaSqlServer();
            cmd = new SqlCommand(sqlEditar, con);

            cmd.Parameters.AddWithValue("@idinspecao", item.Inspecao_Colaborador.Id_Inspecao_Colaborador);
            cmd.Parameters.AddWithValue("@idcolaborador", item.Colaborador.Id_Colaborador);

            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Item de inspeção atualizado com sucesso.");
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

        public void ApagaDados(int idInspecao, int idColaborador)
        {
            ConectaBanco cb = new ConectaBanco();
            con = cb.ConectaSqlServer();
            cmd = new SqlCommand(sqlApagar, con);

            cmd.Parameters.AddWithValue("@idinspecao", idInspecao);
            cmd.Parameters.AddWithValue("@idcolaborador", idColaborador);

            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Item de inspeção apagado com sucesso.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao apagar item de inspeção!\nErro: " + ex.ToString());
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
            DataTable itensInspecaoColaborador = new DataTable();

            con.Open();

            try
            {
                da.Fill(itensInspecaoColaborador);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar itens de inspeção de colaborador!\nErro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return itensInspecaoColaborador;
        }

        public DataTable BuscarPorInspecao(int idInspecao)
        {
            ConectaBanco cb = new ConectaBanco();
            con = cb.ConectaSqlServer();
            cmd = new SqlCommand(sqlBuscaInspecaoColaborador, con);

            cmd.Parameters.AddWithValue("@idinspecao", idInspecao);
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable itensInspecaoColaborador = new DataTable();

            con.Open();

            try
            {
                da.Fill(itensInspecaoColaborador);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar itens de inspeção de colaborador!\nErro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return itensInspecaoColaborador;
        }
    }
}
