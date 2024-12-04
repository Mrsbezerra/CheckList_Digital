using CheckList_Digital.conexao;
using CheckList_Digital.model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CheckList_Digital.controler
{
    internal class C_Inspecao_Colaborador : ICRUD
    {
        SqlConnection con;
        SqlCommand cmd;

        readonly string sqlInserir = "INSERT INTO Inspecao_Colaborador (Data_Inspecao_Colaborador, Id_Usuario_fk) " +
                                     "VALUES (@data, @idusuario)";

        readonly string sqlApagar = "DELETE FROM Inspecao_Colaborador WHERE Id_Inspecao_Colaborador = @Id_Inspecao_Colaborador";

        readonly string sqlTodos = "SELECT * FROM Inspecao_Colaborador";

        readonly string sqlEditar = "UPDATE Inspecao_Colaborador SET Data_Inspecao_Colaborador = @data, " +
                                     "Id_Usuario_fk = @idusuario WHERE Id_Inspecao_Colaborador = @Id_Inspecao_Colaborador";

        readonly string sqlBuscaNome = "SELECT * FROM Inspecao_Colaborador WHERE Id_Usuario_fk IN (SELECT Id_Usuario FROM Usuario WHERE Nome LIKE @nome)";

        public void InsereDados(object obj)
        {
            Inspecao_Colaborador inspecao = obj as Inspecao_Colaborador;

            if (inspecao == null)
            {
                MessageBox.Show("Objeto Inspecao_Colaborador inválido.");
                return;
            }

            ConectaBanco cb = new ConectaBanco();
            con = cb.ConectaSqlServer();
            cmd = new SqlCommand(sqlInserir, con);

            cmd.Parameters.AddWithValue("@data", inspecao.Data_Inspecao_Colaborador);
            cmd.Parameters.AddWithValue("@idusuario", inspecao.Usuario.Id_Usuario);

            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Inspeção realizada com sucesso.");
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
            Inspecao_Colaborador inspecao = obj as Inspecao_Colaborador;

            if (inspecao == null)
            {
                MessageBox.Show("Objeto Inspecao_Colaborador inválido.");
                return;
            }

            ConectaBanco cb = new ConectaBanco();
            con = cb.ConectaSqlServer();
            cmd = new SqlCommand(sqlEditar, con);

            cmd.Parameters.AddWithValue("@Id_Inspecao_Colaborador", inspecao.Id_Inspecao_Colaborador);
            cmd.Parameters.AddWithValue("@data", inspecao.Data_Inspecao_Colaborador);
            cmd.Parameters.AddWithValue("@idusuario", inspecao.Usuario.Id_Usuario);

            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Inspeção alterada com sucesso.");
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

        public void ApagaDados(int id_Inspecao_Colaborador)
        {
            ConectaBanco cb = new ConectaBanco();
            con = cb.ConectaSqlServer();
            cmd = new SqlCommand(sqlApagar, con);

            cmd.Parameters.AddWithValue("@Id_Inspecao_Colaborador", id_Inspecao_Colaborador);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Inspeção apagada com sucesso!\nCódigo de Inspeção: " + id_Inspecao_Colaborador);
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
            DataTable inspecaoColaboradores = new DataTable();

            con.Open();

            try
            {
                da.Fill(inspecaoColaboradores);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar inspeções de colaboradores!\nErro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return inspecaoColaboradores;
        }

        public DataTable BuscarNome(string valor)
        {
            ConectaBanco cb = new ConectaBanco();
            con = cb.ConectaSqlServer();
            cmd = new SqlCommand(sqlBuscaNome, con);

            cmd.Parameters.AddWithValue("@nome", valor + "%");
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable inspecaoColaboradores = new DataTable();

            con.Open();

            try
            {
                da.Fill(inspecaoColaboradores);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar inspeções de colaboradores!\nErro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return inspecaoColaboradores;
        }
    }
}

