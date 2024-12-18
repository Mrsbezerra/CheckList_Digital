﻿using CheckList_Digital.conexao;
using CheckList_Digital.model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CheckList_Digital.controler
{
    internal class C_Sexo : ICRUD
    {
        private readonly string sqlInserir = "INSERT INTO Sexo (Nome_Sexo) VALUES (@nome_sexo)";
        private readonly string sqlApagar = "DELETE FROM Sexo WHERE Id_Sexo = @Id_Sexo";
        private readonly string sqlTodos = "SELECT Id_Sexo as 'Código', Nome_Sexo as Sexo FROM Sexo";
        private readonly string sqlEditar = "UPDATE Sexo SET Nome_Sexo = @pnome WHERE Id_Sexo = @pId_Sexo";
        private readonly string sqlBuscaNome = "SELECT Id_Sexo as 'Código', Nome_Sexo as Sexo FROM Sexo WHERE Nome_Sexo LIKE @pNome";

        private SqlConnection GetConnection()
        {
            var cb = new ConectaBanco();
            return cb.ConectaSqlServer();
        }

        public void InsereDados(object obj)
        {
            Sexo sexo = obj as Sexo;

            if (sexo == null)
            {
                MessageBox.Show("Objeto Sexo inválido.");
                return;
            }

            using (var con = GetConnection())
            {
                using (var cmd = new SqlCommand(sqlInserir + "; SELECT SCOPE_IDENTITY();", con))
                {
                    cmd.Parameters.AddWithValue("@nome_sexo", sexo.Nome_Sexo);
                    cmd.CommandType = CommandType.Text;

                    try
                    {
                        con.Open();
                        object idSexoObj = cmd.ExecuteScalar();
                        if (idSexoObj != null)
                        {
                            int idSexo = Convert.ToInt32(idSexoObj);
                            MessageBox.Show($"Sexo ({idSexo} - {sexo.Nome_Sexo}) cadastrado com sucesso.");
                        }
                        else
                        {
                            MessageBox.Show("Falha ao incluir o sexo.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }
                }
            }
        }

        public void EditarDados(object obj)
        {
            Sexo sexo = obj as Sexo;

            if (sexo == null)
            {
                MessageBox.Show("Objeto Sexo inválido.");
                return;
            }

            using (var con = GetConnection())
            {
                using (var cmd = new SqlCommand(sqlEditar, con))
                {
                    cmd.Parameters.AddWithValue("@pNome", sexo.Nome_Sexo);
                    cmd.Parameters.AddWithValue("@pId_Sexo", sexo.Id_Sexo);
                    cmd.CommandType = CommandType.Text;

                    try
                    {
                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Sexo alterado com sucesso.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }
                }
            }
        }

        public void ApagaDados(int id_Sexo)
        {
            using (var con = GetConnection())
            {
                using (var cmd = new SqlCommand(sqlApagar, con))
                {
                    cmd.Parameters.AddWithValue("@Id_Sexo", id_Sexo);
                    cmd.CommandType = CommandType.Text;

                    try
                    {
                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Sexo apagado com sucesso! Código de Sexo: {id_Sexo}");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao apagar sexo! Erro: " + ex.Message);
                    }
                }
            }
        }

        public DataTable BuscarTodos()
        {
            using (var con = GetConnection())
            {
                using (var cmd = new SqlCommand(sqlTodos, con))
                {
                    cmd.CommandType = CommandType.Text;
                    var da = new SqlDataAdapter(cmd);
                    var sexos = new DataTable();

                    try
                    {
                        con.Open();
                        da.Fill(sexos);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao buscar sexos! Erro: " + ex.Message);
                    }

                    return sexos;
                }
            }
        }

        public DataTable BuscarNome(string valor)
        {
            using (var con = GetConnection())
            {
                using (var cmd = new SqlCommand(sqlBuscaNome, con))
                {
                    cmd.Parameters.AddWithValue("@pNome", valor + "%");
                    cmd.CommandType = CommandType.Text;

                    var da = new SqlDataAdapter(cmd);
                    var sexos = new DataTable();

                    try
                    {
                        con.Open();
                        da.Fill(sexos);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao buscar sexos! Erro: " + ex.Message);
                    }

                    return sexos;
                }
            }
        }

        public DataTable BuscarDados(string textoBusca)
        {
            using (var con = GetConnection())
            {
                using (var cmd = new SqlCommand("SELECT * FROM Sexo WHERE Nome_Sexo LIKE @TextoBusca", con))
                {
                    cmd.Parameters.AddWithValue("@TextoBusca", "%" + textoBusca + "%");

                    var da = new SqlDataAdapter(cmd);
                    var dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
