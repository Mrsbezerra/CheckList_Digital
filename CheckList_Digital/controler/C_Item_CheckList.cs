using CheckList_Digital.conexao;
using CheckList_Digital.model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CheckList_Digital.controler
{
    internal class C_Item_Checklist : ICRUD
    {
        SqlConnection con;
        SqlCommand cmd;

        readonly string sqlInserir = "INSERT INTO Item_Checklist (Descricao) VALUES (@descricao)";

        readonly string sqlApagar = "DELETE FROM Item_Checklist WHERE Id_Item_Checklist = @iditem";

        readonly string sqlTodos = "SELECT * FROM Item_Checklist";

        readonly string sqlEditar = "UPDATE Item_Checklist SET Descricao = @descricao WHERE Id_Item_Checklist = @iditem";

        public void InsereDados(object obj)
        {
            Item_Checklist item = obj as Item_Checklist;

            if (item == null)
            {
                MessageBox.Show("Objeto Item_Checklist inválido.");
                return;
            }

            ConectaBanco cb = new ConectaBanco();
            con = cb.ConectaSqlServer();
            cmd = new SqlCommand(sqlInserir, con);

            cmd.Parameters.AddWithValue("@descricao", item.Descricao);

            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Item de checklist adicionado com sucesso.");
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
            Item_Checklist item = obj as Item_Checklist;

            if (item == null)
            {
                MessageBox.Show("Objeto Item_Checklist inválido.");
                return;
            }

            ConectaBanco cb = new ConectaBanco();
            con = cb.ConectaSqlServer();
            cmd = new SqlCommand(sqlEditar, con);

            cmd.Parameters.AddWithValue("@descricao", item.Descricao);
            cmd.Parameters.AddWithValue("@iditem", item.Id_Item_Checklist);

            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Item de checklist atualizado com sucesso.");
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

        public void ApagaDados(int idItem)
        {
            ConectaBanco cb = new ConectaBanco();
            con = cb.ConectaSqlServer();
            cmd = new SqlCommand(sqlApagar, con);

            cmd.Parameters.AddWithValue("@iditem", idItem);

            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Item de checklist apagado com sucesso.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao apagar item de checklist!\nErro: " + ex.ToString());
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
            DataTable itensChecklist = new DataTable();

            con.Open();

            try
            {
                da.Fill(itensChecklist);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar itens de checklist!\nErro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return itensChecklist;
        }
    }
}

