﻿using System.Data.SqlClient;

namespace CheckList_Digital.conexao
{
    internal class ConectaBanco
    {
        SqlConnection con;
        string ConnectionString = @"Server=DESKTOP-FIJQG9J\SQLEXPRESS03;
                                       Database=CheckListDB;
                                    Trusted_Connection=True;";

        public SqlConnection ConectaSqlServer()
        {
            //cria a conexão com o banco de dados
            con = new SqlConnection(ConnectionString);       

            return con;
        }
    }
}
