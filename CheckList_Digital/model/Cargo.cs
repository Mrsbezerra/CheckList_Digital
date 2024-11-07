using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckList_Digital.model
{
    internal class Cargo
    {
        public int Id_Cargo { get; set; }

        public String Nome_Cargo { get; set; }

        public String Descricao_Cargo { get; set; }

        public Cargo() { }

        public static implicit operator Cargo(ComboBox v)
        {
            throw new NotImplementedException();
        }
    }
}
