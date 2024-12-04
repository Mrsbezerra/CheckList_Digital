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
    internal class C_Colaborador : ICRUD
    {
        SqlConnection con;
        SqlCommand cmd;

        readonly string sqlInserir = "INSERT INTO Colaborador (Nome_Colaborador, Email, RG, CPF, Id_Sexo_fk, Id_Setor_fk, Id_Cargo_fk) " +
                                     "VALUES (@nome, @email, @rg, @cpf, @idsexo, @idsetor, @idcargo)";

        readonly string sqlApagar = "DELETE FROM Colaborador WHERE Id_Colaborador = @Id_Colaborador";

        readonly string sqlTodos = "SELECT * FROM Colaborador";

        readonly string sqlEditar = "UPDATE Colaborador SET Nome_Colaborador = @nome, " +
                                     "Email = @email, RG = @rg, CPF = @cpf, Id_Sexo_fk = @idsexo, " +
                                     "Id_Setor_fk = @idsetor, Id_Cargo_fk = @idcargo WHERE Id_Colaborador = @Id_Colaborador";

        readonly string sqlBuscaNome = "SELECT * FROM Colaborador WHERE Nome_Colaborador LIKE @nome";

        public void InsereDados(object obj)
        {
            Colaborador colaborador = obj as Colaborador;

            if (colaborador == null)
            {
                MessageBox.Show("Objeto Colaborador inválido.");
                return;
            }

            ConectaBanco cb = new ConectaBanco();
            con = cb.ConectaSqlServer();
            cmd = new SqlCommand(sqlInserir, con);

            cmd.Parameters.AddWithValue("@nome", colaborador.Nome_Colaborador);
            cmd.Parameters.AddWithValue("@email", colaborador.Email);
            cmd.Parameters.AddWithValue("@rg", colaborador.RG);
            cmd.Parameters.AddWithValue("@cpf", colaborador.CPF);
            cmd.Parameters.AddWithValue("@idsexo", colaborador.Sexo.Id_Sexo);
            cmd.Parameters.AddWithValue("@idsetor", colaborador.Setor.Id_Setor);
            cmd.Parameters.AddWithValue("@idcargo", colaborador.Cargo.Id_Cargo);

            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Colaborador incluído com sucesso");
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
            Colaborador colaborador = obj as Colaborador;

            if (colaborador == null)
            {
                MessageBox.Show("Objeto Colaborador inválido.");
                return;
            }

            ConectaBanco cb = new ConectaBanco();
            con = cb.ConectaSqlServer();
            cmd = new SqlCommand(sqlEditar, con);

            cmd.Parameters.AddWithValue("@Id_Colaborador", colaborador.Id_Colaborador);
            cmd.Parameters.AddWithValue("@nome", colaborador.Nome_Colaborador);
            cmd.Parameters.AddWithValue("@email", colaborador.Email);
            cmd.Parameters.AddWithValue("@rg", colaborador.RG);
            cmd.Parameters.AddWithValue("@cpf", colaborador.CPF);
            cmd.Parameters.AddWithValue("@idsexo", colaborador.Sexo.Id_Sexo);
            cmd.Parameters.AddWithValue("@idsetor", colaborador.Setor.Id_Setor);
            cmd.Parameters.AddWithValue("@idcargo", colaborador.Cargo.Id_Cargo);

            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Colaborador alterado com sucesso");
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

        public void ApagaDados(int id_Colaborador)
        {
            ConectaBanco cb = new ConectaBanco();
            con = cb.ConectaSqlServer();
            cmd = new SqlCommand(sqlApagar, con);

            cmd.Parameters.AddWithValue("@Id_Colaborador", id_Colaborador);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Colaborador apagado com sucesso!\nCódigo de Colaborador: " + id_Colaborador);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao apagar colaborador!\nErro: " + ex.ToString());
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
            DataTable colaboradores = new DataTable();

            con.Open();

            try
            {
                da.Fill(colaboradores);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar colaboradores!\nErro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return colaboradores;
        }

        public DataTable BuscarNome(string valor)
        {
            ConectaBanco cb = new ConectaBanco();
            con = cb.ConectaSqlServer();
            cmd = new SqlCommand(sqlBuscaNome, con);

            cmd.Parameters.AddWithValue("@nome", valor + "%");
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable colaboradores = new DataTable();

            con.Open();

            try
            {
                da.Fill(colaboradores);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar colaboradores!\nErro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return colaboradores;
        }

        public DataTable BuscarDados(string textoBusca)
        {
            ConectaBanco conectaBanco = new ConectaBanco(); // Instancia a classe de conexão
            using (SqlConnection con = conectaBanco.ConectaSqlServer())
            {
                string query = "SELECT * FROM Colaborador WHERE Nome_Colaborador LIKE @TextoBusca";
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