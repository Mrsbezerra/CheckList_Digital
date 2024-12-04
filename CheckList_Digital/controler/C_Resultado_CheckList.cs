using CheckList_Digital.conexao;
using CheckList_Digital.model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CheckList_Digital.controler
{
    internal class C_Resultado_Checklist : ICRUD
    {
        SqlConnection con;
        SqlCommand cmd;

        readonly string sqlInserir = @"
            INSERT INTO Resultado_Checklist (Condicao_Encontrada, Acao_Corretiva, Id_Inspecao_fk, Id_Item_Checklist_fk) 
            VALUES (@condicaoEncontrada, @acaoCorretiva, @idInspecao, @idItemChecklist)";

        readonly string sqlApagar = "DELETE FROM Resultado_Checklist WHERE Id_Resultado_Checklist = @idResultado";

        readonly string sqlTodos = "SELECT * FROM Resultado_Checklist";

        readonly string sqlEditar = @"
            UPDATE Resultado_Checklist 
            SET Condicao_Encontrada = @condicaoEncontrada, Acao_Corretiva = @acaoCorretiva, 
                Id_Inspecao_fk = @idInspecao, Id_Item_Checklist_fk = @idItemChecklist 
            WHERE Id_Resultado_Checklist = @idResultado";

        public void InsereDados(object obj)
        {
            Resultado_Checklist resultado = obj as Resultado_Checklist;

            if (resultado == null)
            {
                MessageBox.Show("Objeto Resultado_Checklist inválido.");
                return;
            }

            ConectaBanco cb = new ConectaBanco();
            con = cb.ConectaSqlServer();
            cmd = new SqlCommand(sqlInserir, con);

            cmd.Parameters.AddWithValue("@condicaoEncontrada", resultado.Condicao_Encontrada);
            cmd.Parameters.AddWithValue("@acaoCorretiva", resultado.Acao_Corretiva);
            cmd.Parameters.AddWithValue("@idInspecao", resultado.Inspecao.Id_Inspecao);
            cmd.Parameters.AddWithValue("@idItemChecklist", resultado.Item_Checklist.Id_Item_Checklist);

            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Resultado de checklist inserido com sucesso.");
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
            Resultado_Checklist resultado = obj as Resultado_Checklist;

            if (resultado == null)
            {
                MessageBox.Show("Objeto Resultado_Checklist inválido.");
                return;
            }

            ConectaBanco cb = new ConectaBanco();
            con = cb.ConectaSqlServer();
            cmd = new SqlCommand(sqlEditar, con);

            cmd.Parameters.AddWithValue("@condicaoEncontrada", resultado.Condicao_Encontrada);
            cmd.Parameters.AddWithValue("@acaoCorretiva", resultado.Acao_Corretiva);
            cmd.Parameters.AddWithValue("@idInspecao", resultado.Inspecao.Id_Inspecao);
            cmd.Parameters.AddWithValue("@idItemChecklist", resultado.Item_Checklist.Id_Item_Checklist);
            cmd.Parameters.AddWithValue("@idResultado", resultado.Id_Resultado_Checklist);

            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Resultado de checklist atualizado com sucesso.");
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

        public void ApagaDados(int idResultado)
        {
            ConectaBanco cb = new ConectaBanco();
            con = cb.ConectaSqlServer();
            cmd = new SqlCommand(sqlApagar, con);

            cmd.Parameters.AddWithValue("@idResultado", idResultado);

            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Resultado de checklist apagado com sucesso.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao apagar resultado de checklist!\nErro: " + ex.ToString());
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
            DataTable resultadosChecklist = new DataTable();

            con.Open();

            try
            {
                da.Fill(resultadosChecklist);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar resultados de checklist!\nErro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return resultadosChecklist;
        }
    }
}
