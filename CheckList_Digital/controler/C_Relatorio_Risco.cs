using CheckList_Digital.conexao;
using CheckList_Digital.model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CheckList_Digital.controler
{
    internal class C_Relatorio_Risco : ICRUD
    {
        SqlConnection con;
        SqlCommand cmd;

        readonly string sqlInserir = "INSERT INTO Relatorio_Risco (Descricao, Areas_Alto_Risco, Id_Inspecao_fk) " +
                                     "VALUES (@descricao, @areasAltoRisco, @idInspecaoFk)";

        readonly string sqlApagar = "DELETE FROM Relatorio_Risco WHERE Id_Relatorio_Risco = @Id_Relatorio_Risco";

        readonly string sqlTodos = "SELECT * FROM Relatorio_Risco";

        readonly string sqlEditar = "UPDATE Relatorio_Risco SET Descricao = @descricao, Areas_Alto_Risco = @areasAltoRisco, " +
                                    "Id_Inspecao_fk = @idInspecaoFk WHERE Id_Relatorio_Risco = @Id_Relatorio_Risco";

        readonly string sqlBuscarPorId = "SELECT * FROM Relatorio_Risco WHERE Id_Relatorio_Risco = @Id_Relatorio_Risco";

        public void InsereDados(object obj)
        {
            Relatorio_Risco relatorioRisco = obj as Relatorio_Risco;

            if (relatorioRisco == null)
            {
                MessageBox.Show("Objeto Relatorio_Risco inválido.");
                return;
            }

            ConectaBanco cb = new ConectaBanco();
            con = cb.ConectaSqlServer();
            cmd = new SqlCommand(sqlInserir, con);

            cmd.Parameters.AddWithValue("@descricao", relatorioRisco.Descricao);
            cmd.Parameters.AddWithValue("@areasAltoRisco", relatorioRisco.Areas_Alto_Risco);
            cmd.Parameters.AddWithValue("@idInspecaoFk", relatorioRisco.Inspecao.Id_Inspecao);

            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Relatório de risco inserido com sucesso.");
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
            Relatorio_Risco relatorioRisco = obj as Relatorio_Risco;

            if (relatorioRisco == null)
            {
                MessageBox.Show("Objeto Relatorio_Risco inválido.");
                return;
            }

            ConectaBanco cb = new ConectaBanco();
            con = cb.ConectaSqlServer();
            cmd = new SqlCommand(sqlEditar, con);

            cmd.Parameters.AddWithValue("@Id_Relatorio_Risco", relatorioRisco.Id_Relatorio_Risco);
            cmd.Parameters.AddWithValue("@descricao", relatorioRisco.Descricao);
            cmd.Parameters.AddWithValue("@areasAltoRisco", relatorioRisco.Areas_Alto_Risco);
            cmd.Parameters.AddWithValue("@idInspecaoFk", relatorioRisco.Inspecao.Id_Inspecao);

            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Relatório de risco alterado com sucesso.");
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

        public void ApagaDados(int id_Relatorio_Risco)
        {
            ConectaBanco cb = new ConectaBanco();
            con = cb.ConectaSqlServer();
            cmd = new SqlCommand(sqlApagar, con);

            cmd.Parameters.AddWithValue("@Id_Relatorio_Risco", id_Relatorio_Risco);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Relatório de risco apagado com sucesso!\nCódigo do Relatório: " + id_Relatorio_Risco);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao apagar relatório!\nErro: " + ex.ToString());
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
            DataTable relatoriosRisco = new DataTable();

            con.Open();

            try
            {
                da.Fill(relatoriosRisco);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar relatórios de risco!\nErro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return relatoriosRisco;
        }

        public DataTable BuscarPorId(int id_Relatorio_Risco)
        {
            ConectaBanco cb = new ConectaBanco();
            con = cb.ConectaSqlServer();
            cmd = new SqlCommand(sqlBuscarPorId, con);

            cmd.Parameters.AddWithValue("@Id_Relatorio_Risco", id_Relatorio_Risco);
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable relatoriosRisco = new DataTable();

            con.Open();

            try
            {
                da.Fill(relatoriosRisco);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar relatório de risco!\nErro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return relatoriosRisco;
        }
    }
}
