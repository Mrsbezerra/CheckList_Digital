using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckList_Digital.model
{
    internal class Inspecao_Setor
    {
        public int Id_Inspecao_Setor { get; set; }

        public DateTime Data_Inspecao_Setor { get; set; }

        public Usuario Usuario { get; set; }

        public Inspecao_Setor() { }

       
    }
}
