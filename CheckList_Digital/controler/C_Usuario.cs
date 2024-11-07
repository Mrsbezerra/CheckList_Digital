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
    internal class C_Usuario : ICRUD
    {
        SqlConnection con;
        SqlCommand cmd;
        readonly string sqlInserir = "INSERT INTO Usuario (Nome, Login, Senha, Email, Id_Sexo_fk, Id_Cargo_fk, Id_Tipo_Usuario_fk) " +
                                        "VALUES (@nome, @login, @senha, @email, @idsexo, @idcargo, @idtipousuario)";

        readonly string sqlApagar = "DELETE " +
                                    "FROM Usuario " +
                                    "WHERE Id_Usuario = @Id_Usuario";

        readonly string sqlTodos = "SELECT * " +
                                   "FROM Usuario";

        readonly string sqlEditar = "UPDATE Usuario set Nome = @nome, " +
                                    "Login = @login, Senha = @senha, Email = @email, Id_Sexo_fk = @idsexo, Id_Cargo_fk = @idcargo, Id_Tipo_Usuario_fk = @idtipousuario  " +
                                    "WHERE Id_Usuario = @Id_Usuario";

        readonly string sqlBuscaNome = "SELECT * " +
                                       "FROM Usuario " +
                                       "WHERE Nome like @nome";

        public void InsereDados(object obj)
        {
            Usuario usuario = obj as Usuario;

            if (usuario == null)
            {
                MessageBox.Show("Objeto Usuario inválido.");
                return;
            }

            ConectaBanco cb = new ConectaBanco();
            con = cb.ConectaSqlServer();
            cmd = new SqlCommand(sqlInserir, con);

            cmd.Parameters.AddWithValue("@nome", usuario.Nome);
            cmd.Parameters.AddWithValue("@login", usuario.Login);
            cmd.Parameters.AddWithValue("@senha", usuario.Senha);
            cmd.Parameters.AddWithValue("@email", usuario.Email);
            cmd.Parameters.AddWithValue("@idsexo", usuario.Sexo.Id_Sexo);
            cmd.Parameters.AddWithValue("@idcargo", usuario.Cargo.Id_Cargo);
            cmd.Parameters.AddWithValue("@idtipousuario", usuario.Tipo_Usuario.Id_Tipo_Usuario);

            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Usuario incluído com sucesso");
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
            Usuario usuario = obj as Usuario;

            if (usuario == null)
            {
                MessageBox.Show("Objeto Usuario inválido.");
                return;
            }

            ConectaBanco cb = new ConectaBanco();
            con = cb.ConectaSqlServer();
            cmd = new SqlCommand(sqlEditar, con);

            cmd.Parameters.AddWithValue("@Id_Usuario", usuario.Id_Usuario);
            cmd.Parameters.AddWithValue("@nome", usuario.Nome);
            cmd.Parameters.AddWithValue("@login", usuario.Login);
            cmd.Parameters.AddWithValue("@senha", usuario.Senha);
            cmd.Parameters.AddWithValue("@email", usuario.Email);
            cmd.Parameters.AddWithValue("@idsexo", usuario.Sexo.Id_Sexo);
            cmd.Parameters.AddWithValue("@idcargo", usuario.Cargo.Id_Cargo);
            cmd.Parameters.AddWithValue("@idtipousuario", usuario.Tipo_Usuario.Id_Tipo_Usuario);

            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Usuario alterado com sucesso");
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

        public void ApagaDados(int id_Usuario)
        {
            ConectaBanco cb = new ConectaBanco();
            con = cb.ConectaSqlServer();
            cmd = new SqlCommand(sqlApagar, con);

            cmd.Parameters.AddWithValue("@Id_Usuario", id_Usuario);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Usuario apagado com sucesso!\nCódigo de Usuario: " + id_Usuario);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao apagar usuario!\nErro: " + ex.ToString());
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
            DataTable usuarios = new DataTable();

            con.Open();

            try
            {
                da.Fill(usuarios);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar usuarios!\nErro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return usuarios;
        }

        public DataTable BuscarNome(String valor)
        {
            ConectaBanco cb = new ConectaBanco();
            con = cb.ConectaSqlServer();
            cmd = new SqlCommand(sqlBuscaNome, con);

            cmd.Parameters.AddWithValue("@nome", valor + "%");
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable usuarios = new DataTable();

            con.Open();

            try
            {
                da.Fill(usuarios);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar usuarios!\nErro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return usuarios;
        }

        public DataTable BuscarDados(string textoBusca)
        {
            ConectaBanco conectaBanco = new ConectaBanco(); // Instancia a classe de conexão
            using (SqlConnection con = conectaBanco.ConectaSqlServer())
            {
                string query = "SELECT * FROM Usuario WHERE Nome LIKE @TextoBusca";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@TextoBusca", "%" + textoBusca + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public bool VerificaUsuarioExistente(string login)
        {
            using (SqlConnection con = new ConectaBanco().ConectaSqlServer()) // Abre a conexão
            {
                string query = "SELECT COUNT(*) FROM Usuario WHERE Login = @Login";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Login", login);

                    con.Open();
                    try
                    {
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao verificar usuário: " + ex.Message);
                        return false;
                    }
                    finally
                    {
                        con.Close(); // Fecha a conexão
                    }
                }
            }
        }

        public bool VerificaSenhaCorreta(string login, string senha)
        {
            ConectaBanco cb = new ConectaBanco();
            using (SqlConnection con = cb.ConectaSqlServer())
            {
                string query = "SELECT Senha FROM Usuario WHERE Login = @login";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@login", login);

                con.Open();
                string senhaBanco = cmd.ExecuteScalar()?.ToString();

                if (senhaBanco != null && senhaBanco == senha)
                {
                    return true; // Senha está correta
                }
                return false; // Senha incorreta
            }
        }

        public bool VerificaEmailCadastrado(string email)
        {
            bool emailExiste = false;

            ConectaBanco cb = new ConectaBanco();
            using (SqlConnection con = cb.ConectaSqlServer())
            {
                string query = "SELECT COUNT(*) FROM Usuario WHERE Email = @Email";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Email", email);

                con.Open();
                int count = (int)cmd.ExecuteScalar();
                emailExiste = count > 0;
                con.Close();
            }

            return emailExiste;
        }

    }
}
