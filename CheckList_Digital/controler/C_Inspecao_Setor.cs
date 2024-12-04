using CheckList_Digital.conexao;
using CheckList_Digital.model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CheckList_Digital.controler
{
    internal class C_Inspecao_Setor : ICRUD
    {
        SqlConnection con;
        SqlCommand cmd;

        readonly string sqlInserir = "INSERT INTO Inspecao_Setor (Data_Inspecao_Setor, Id_Usuario_fk) " +
                                     "VALUES (@dataInspecaoSetor, @idUsuarioFk)";

        readonly string sqlApagar = "DELETE FROM Inspecao_Setor WHERE Id_Inspecao_Setor = @Id_Inspecao_Setor";

        readonly string sqlTodos = "SELECT * FROM Inspecao_Setor";

        readonly string sqlEditar = "UPDATE Inspecao_Setor SET Data_Inspecao_Setor = @dataInspecaoSetor, " +
                                    "Id_Usuario_fk = @idUsuarioFk WHERE Id_Inspecao_Setor = @Id_Inspecao_Setor";

        readonly string sqlBuscaData = "SELECT * FROM Inspecao_Setor WHERE Data_Inspecao_Setor = @dataInspecaoSetor";

        public void InsereDados(object obj)
        {
            Inspecao_Setor inspecaoSetor = obj as Inspecao_Setor;

            if (inspecaoSetor == null)
            {
                MessageBox.Show("Objeto Inspecao_Setor inválido.");
                return;
            }

            ConectaBanco cb = new ConectaBanco();
            con = cb.ConectaSqlServer();
            cmd = new SqlCommand(sqlInserir, con);

            cmd.Parameters.AddWithValue("@dataInspecaoSetor", inspecaoSetor.Data_Inspecao_Setor);
            cmd.Parameters.AddWithValue("@idUsuarioFk", inspecaoSetor.Usuario.Id_Usuario);

            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Inspeção do setor incluída com sucesso");
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
            Inspecao_Setor inspecaoSetor = obj as Inspecao_Setor;

            if (inspecaoSetor == null)
            {
                MessageBox.Show("Objeto Inspecao_Setor inválido.");
                return;
            }

            ConectaBanco cb = new ConectaBanco();
            con = cb.ConectaSqlServer();
            cmd = new SqlCommand(sqlEditar, con);

            cmd.Parameters.AddWithValue("@Id_Inspecao_Setor", inspecaoSetor.Id_Inspecao_Setor);
            cmd.Parameters.AddWithValue("@dataInspecaoSetor", inspecaoSetor.Data_Inspecao_Setor);
            cmd.Parameters.AddWithValue("@idUsuarioFk", inspecaoSetor.Usuario.Id_Usuario);

            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Inspeção do setor alterada com sucesso");
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

        public void ApagaDados(int id_Inspecao_Setor)
        {
            ConectaBanco cb = new ConectaBanco();
            con = cb.ConectaSqlServer();
            cmd = new SqlCommand(sqlApagar, con);

            cmd.Parameters.AddWithValue("@Id_Inspecao_Setor", id_Inspecao_Setor);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Inspeção do setor apagada com sucesso!\nCódigo da Inspeção: " + id_Inspecao_Setor);
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
            DataTable inspecaoSetores = new DataTable();

            con.Open();

            try
            {
                da.Fill(inspecaoSetores);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar inspeções do setor!\nErro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return inspecaoSetores;
        }

        public DataTable BuscarData(DateTime data)
        {
            ConectaBanco cb = new ConectaBanco();
            con = cb.ConectaSqlServer();
            cmd = new SqlCommand(sqlBuscaData, con);

            cmd.Parameters.AddWithValue("@dataInspecaoSetor", data);
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable inspecaoSetores = new DataTable();

            con.Open();

            try
            {
                da.Fill(inspecaoSetores);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar inspeções pela data!\nErro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return inspecaoSetores;
        }
    }
}
