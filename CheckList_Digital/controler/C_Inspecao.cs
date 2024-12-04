using CheckList_Digital.conexao;
using CheckList_Digital.model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CheckList_Digital.controler
{
    internal class C_Inspecao : ICRUD
    {
        SqlConnection con;
        SqlCommand cmd;

        readonly string sqlInserir = "INSERT INTO Inspecao (Data, Hora, Id_Setor_fk, Id_Inspecao_Setor_fk, Id_Usuario_fk) " +
                                     "VALUES (@data, @hora, @idSetorFk, @idInspecaoSetorFk, @idUsuarioFk)";

        readonly string sqlApagar = "DELETE FROM Inspecao WHERE Id_Inspecao = @Id_Inspecao";

        readonly string sqlTodos = "SELECT * FROM Inspecao";

        readonly string sqlEditar = "UPDATE Inspecao SET Data = @data, Hora = @hora, Id_Setor_fk = @idSetorFk, " +
                                    "Id_Inspecao_Setor_fk = @idInspecaoSetorFk, Id_Usuario_fk = @idUsuarioFk WHERE Id_Inspecao = @Id_Inspecao";

        readonly string sqlBuscaData = "SELECT * FROM Inspecao WHERE Data = @data";

        public void InsereDados(object obj)
        {
            Inspecao inspecao = obj as Inspecao;

            if (inspecao == null)
            {
                MessageBox.Show("Objeto Inspecao inválido.");
                return;
            }

            ConectaBanco cb = new ConectaBanco();
            con = cb.ConectaSqlServer();
            cmd = new SqlCommand(sqlInserir, con);

            cmd.Parameters.AddWithValue("@data", inspecao.Data);
            cmd.Parameters.AddWithValue("@hora", inspecao.Hora);
            cmd.Parameters.AddWithValue("@idSetorFk", inspecao.Setor.Id_Setor);
            cmd.Parameters.AddWithValue("@idInspecaoSetorFk", inspecao.Inspecao_Setor.Id_Inspecao_Setor);
            cmd.Parameters.AddWithValue("@idUsuarioFk", inspecao.Usuario.Id_Usuario);

            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Inspeção realizada com sucesso");
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
            Inspecao inspecao = obj as Inspecao;

            if (inspecao == null)
            {
                MessageBox.Show("Objeto Inspecao inválido.");
                return;
            }

            ConectaBanco cb = new ConectaBanco();
            con = cb.ConectaSqlServer();
            cmd = new SqlCommand(sqlEditar, con);

            cmd.Parameters.AddWithValue("@Id_Inspecao", inspecao.Id_Inspecao);
            cmd.Parameters.AddWithValue("@data", inspecao.Data);
            cmd.Parameters.AddWithValue("@hora", inspecao.Hora);
            cmd.Parameters.AddWithValue("@idSetorFk", inspecao.Setor.Id_Setor);
            cmd.Parameters.AddWithValue("@idInspecaoSetorFk", inspecao.Inspecao_Setor.Id_Inspecao_Setor);
            cmd.Parameters.AddWithValue("@idUsuarioFk", inspecao.Usuario.Id_Usuario);

            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Inspeção alterada com sucesso");
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

        public void ApagaDados(int id_Inspecao)
        {
            ConectaBanco cb = new ConectaBanco();
            con = cb.ConectaSqlServer();
            cmd = new SqlCommand(sqlApagar, con);

            cmd.Parameters.AddWithValue("@Id_Inspecao", id_Inspecao);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Inspeção apagada com sucesso!\nCódigo da Inspeção: " + id_Inspecao);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao apagar inspeção!\nErro: " + ex.ToString());
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
            DataTable inspecao = new DataTable();

            con.Open();

            try
            {
                da.Fill(inspecao);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar inspeções!\nErro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return inspecao;
        }

        public DataTable BuscarData(DateTime data)
        {
            ConectaBanco cb = new ConectaBanco();
            con = cb.ConectaSqlServer();
            cmd = new SqlCommand(sqlBuscaData, con);

            cmd.Parameters.AddWithValue("@data", data);
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable inspecao = new DataTable();

            con.Open();

            try
            {
                da.Fill(inspecao);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar inspeções pela data!\nErro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return inspecao;
        }
    }
}

