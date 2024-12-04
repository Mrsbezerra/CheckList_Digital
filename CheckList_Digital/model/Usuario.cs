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

        public Usuario(int idUsuario, string nome, string login, string senha, string email, Sexo sexo, Cargo cargo, Tipo_Usuario tipoUsuario)
        {
            Id_Usuario = idUsuario;
            Nome = nome ?? throw new ArgumentNullException(nameof(nome), "O nome não pode ser nulo.");
            Login = login ?? throw new ArgumentNullException(nameof(login), "O login não pode ser nulo.");
            Senha = senha ?? throw new ArgumentNullException(nameof(senha), "A senha não pode ser nula.");
            Email = email ?? throw new ArgumentNullException(nameof(email), "O e-mail não pode ser nulo.");
            Sexo = sexo ?? throw new ArgumentNullException(nameof(sexo), "O sexo não pode ser nulo.");
            Cargo = cargo ?? throw new ArgumentNullException(nameof(cargo), "O cargo não pode ser nulo.");
            Tipo_Usuario = tipoUsuario ?? throw new ArgumentNullException(nameof(tipoUsuario), "O tipo de usuário não pode ser nulo.");
        }
        public override string ToString() => $"{Nome} ({Login})";
    }
}
