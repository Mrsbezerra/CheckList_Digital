using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckList_Digital.model
{
    internal class Usuario
    {
        public int Id_Usuario { get; set; }

        public String Nome { get; set; }

        public String Login { get; set; }

        public String Senha { get; set; }

        public String Email { get; set; }

        public Sexo Sexo { get; set; }

        public Cargo Cargo { get; set; }

        public Tipo_Usuario Tipo_Usuario { get; set; }

        public Usuario() { }

       
    }
}
