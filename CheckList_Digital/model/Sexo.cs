using System;
using System.Windows.Forms;

namespace CheckList_Digital.model
{
    internal class Sexo
    {
        public int Id_Sexo { get; set; }

        public String Nome_Sexo { get; set; }
        public Sexo() { }

        public static implicit operator Sexo(ComboBox v)
        {
            throw new NotImplementedException();
        }
    }
}
