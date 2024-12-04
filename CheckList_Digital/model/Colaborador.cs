using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckList_Digital.model
{
    /// <summary>
    /// Representa um colaborador no sistema.
    /// </summary>
    internal class Colaborador
    {
        /// <summary>
        /// Identificador único do colaborador.
        /// </summary>
        public int Id_Colaborador { get; set; }

        /// <summary>
        /// Nome do colaborador.
        /// </summary>
        public string Nome_Colaborador { get; set; }

        /// <summary>
        /// Email do colaborador. Deve ser único.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// RG do colaborador. Deve ser único.
        /// </summary>
        public string RG { get; set; }

        /// <summary>
        /// CPF do colaborador. Deve ser único.
        /// </summary>
        public string CPF { get; set; }

        /// <summary>
        /// Sexo do colaborador.
        /// </summary>
        public Sexo Sexo { get; set; }

        /// <summary>
        /// Setor onde o colaborador está alocado.
        /// </summary>
        public Setor Setor { get; set; }

        /// <summary>
        /// Cargo do colaborador.
        /// </summary>
        public Cargo Cargo { get; set; }

        /// <summary>
        /// Construtor padrão.
        /// </summary>
        public Colaborador() { }

        /// <summary>
        /// Construtor completo para inicializar todas as propriedades.
        /// </summary>
        /// <param name="nomeColaborador">Nome do colaborador.</param>
        /// <param name="email">Email do colaborador.</param>
        /// <param name="rg">RG do colaborador.</param>
        /// <param name="cpf">CPF do colaborador.</param>
        /// <param name="sexo">Sexo do colaborador.</param>
        /// <param name="setor">Setor do colaborador.</param>
        /// <param name="cargo">Cargo do colaborador.</param>
        public Colaborador(string nomeColaborador, string email, string rg, string cpf, Sexo sexo, Setor setor, Cargo cargo)
        {
            Nome_Colaborador = !string.IsNullOrWhiteSpace(nomeColaborador)
                ? nomeColaborador
                : throw new ArgumentException("O nome do colaborador é obrigatório.", nameof(nomeColaborador));
            Email = !string.IsNullOrWhiteSpace(email)
                ? email
                : throw new ArgumentException("O email do colaborador é obrigatório.", nameof(email));
            RG = !string.IsNullOrWhiteSpace(rg)
                ? rg
                : throw new ArgumentException("O RG do colaborador é obrigatório.", nameof(rg));
            CPF = !string.IsNullOrWhiteSpace(cpf)
                ? cpf
                : throw new ArgumentException("O CPF do colaborador é obrigatório.", nameof(cpf));
            Sexo = sexo ?? throw new ArgumentNullException(nameof(sexo), "O sexo do colaborador é obrigatório.");
            Setor = setor ?? throw new ArgumentNullException(nameof(setor), "O setor do colaborador é obrigatório.");
            Cargo = cargo ?? throw new ArgumentNullException(nameof(cargo), "O cargo do colaborador é obrigatório.");
        }

        /// <summary>
        /// Representação em string do objeto.
        /// </summary>
        /// <returns>Nome e email do colaborador.</returns>
        public override string ToString()
        {
            return $"{Nome_Colaborador} ({Email})";
        }
    }
}

