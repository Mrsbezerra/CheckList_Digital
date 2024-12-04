using CheckList_Digital.conexao;
using CheckList_Digital.model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CheckList_Digital.controler
{
    internal class C_Itens_Inspecao_Setor : ICRUD2
    {
        SqlConnection con;
        SqlCommand cmd;

        readonly string sqlInserir = "INSERT INTO Itens_Inspecao_Setor (Id_Inspecao_Setor_fk, Id_Setor_fk) " +
                                     "VALUES (@idInspecaoSetorFk, @idSetorFk)";

        readonly string sqlApagar = "DELETE FROM Itens_Inspecao_Setor WHERE Id_Inspecao_Setor_fk = @Id_Inspecao_Setor_fk AND Id_Setor_fk = @Id_Setor_fk";

        readonly string sqlTodos = "SELECT * FROM Itens_Inspecao_Setor";

        readonly string sqlEditar = "UPDATE Itens_Inspecao_Setor SET Id_Inspecao_Setor_fk = @idInspecaoSetorFk, " +
                                    "Id_Setor_fk = @idSetorFk WHERE Id_Inspecao_Setor_fk = @Id_Inspecao_Setor_fk AND Id_Setor_fk = @Id_Setor_fk";

        public void InsereDados(object obj)
        {
            Itens_Inspecao_Setor itensInspecaoSetor = obj as Itens_Inspecao_Setor;

            if (itensInspecaoSetor == null)
            {
                MessageBox.Show("Objeto Itens_Inspecao_Setor inválido.");
                return;
            }

            ConectaBanco cb = new ConectaBanco();
            con = cb.ConectaSqlServer();
            cmd = new SqlCommand(sqlInserir, con);

            cmd.Parameters.AddWithValue("@idInspecaoSetorFk", itensInspecaoSetor.Inspecao_Setor.Id_Inspecao_Setor);
            cmd.Parameters.AddWithValue("@idSetorFk", itensInspecaoSetor.Setor.Id_Setor);

            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Item de inspeção do setor inserido com sucesso");
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
            Itens_Inspecao_Setor itensInspecaoSetor = obj as Itens_Inspecao_Setor;

            if (itensInspecaoSetor == null)
            {
                MessageBox.Show("Objeto Itens_Inspecao_Setor inválido.");
                return;
            }

            ConectaBanco cb = new ConectaBanco();
            con = cb.ConectaSqlServer();
            cmd = new SqlCommand(sqlEditar, con);

            cmd.Parameters.AddWithValue("@Id_Inspecao_Setor_fk", itensInspecaoSetor.Inspecao_Setor.Id_Inspecao_Setor);
            cmd.Parameters.AddWithValue("@Id_Setor_fk", itensInspecaoSetor.Setor.Id_Setor);

            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Item de inspeção do setor atualizado com sucesso");
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

        public void ApagaDados(int id_Inspecao_Setor, int id_Setor)
        {
            ConectaBanco cb = new ConectaBanco();
            con = cb.ConectaSqlServer();
            cmd = new SqlCommand(sqlApagar, con);

            cmd.Parameters.AddWithValue("@Id_Inspecao_Setor_fk", id_Inspecao_Setor);
            cmd.Parameters.AddWithValue("@Id_Setor_fk", id_Setor);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Item de inspeção do setor apagado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao apagar item de inspeção do setor!\nErro: " + ex.ToString());
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
            DataTable itensInspecaoSetor = new DataTable();

            con.Open();

            try
            {
                da.Fill(itensInspecaoSetor);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar itens de inspeção do setor!\nErro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return itensInspecaoSetor;
        }
    }
}
