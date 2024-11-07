using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckList_Digital.conexao
{
    internal class ConectaBanco
    {
        SqlConnection con;
        string ConnectionString = @"Server=localhost\SQLEXPRESS01;
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
