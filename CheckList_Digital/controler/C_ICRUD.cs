using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckList_Digital.controler
{
    internal interface ICRUD
    {
        void InsereDados(Object obj);

        void EditarDados(Object obj);

        void ApagaDados(int cod);

        DataTable BuscarTodos();
    }
}
