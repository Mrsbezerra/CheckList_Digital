using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckList_Digital.model
{
    internal class Tipo_Usuario
    {
        public int Id_Tipo_Usuario { get; set; }

        public String Nome_Tipo { get; set; }
        public Tipo_Usuario() { }

        public static implicit operator Tipo_Usuario(ComboBox v)
        {
            throw new NotImplementedException();
        }
    }
}
