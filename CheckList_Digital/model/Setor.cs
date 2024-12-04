using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckList_Digital.model
{
    internal class Setor
    {
        public int Id_Setor { get; set; }

        public String Nome_Setor { get; set; }

        public String Descricao_Setor { get; set; }

        public Setor() { }

        public static implicit operator Setor(ComboBox v)
        {
            throw new NotImplementedException();
        }
    }
}
