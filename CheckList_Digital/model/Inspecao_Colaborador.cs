using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckList_Digital.model
{
    /// <summary>
    /// Representa uma inspeção realizada por um colaborador.
    /// </summary>
    internal class Inspecao_Colaborador
    {
        /// <summary>
        /// Identificador único da inspeção do colaborador.
        /// </summary>
        public int Id_Inspecao_Colaborador { get; set; }

        /// <summary>
        /// Data da inspeção realizada pelo colaborador.
        /// </summary>
        public DateTime Data_Inspecao_Colaborador { get; set; }

        /// <summary>
        /// Usuário responsável pela inspeção.
        /// </summary>
        public Usuario Usuario { get; set; }

        /// <summary>
        /// Construtor padrão.
        /// </summary>
        public Inspecao_Colaborador() { }

        /// <summary>
        /// Construtor completo para inicializar todas as propriedades.
        /// </summary>
        /// <param name="dataInspecaoColaborador">Data da inspeção realizada pelo colaborador.</param>
        /// <param name="usuario">Usuário responsável pela inspeção.</param>
        public Inspecao_Colaborador(DateTime dataInspecaoColaborador, Usuario usuario)
        {
            Data_Inspecao_Colaborador = dataInspecaoColaborador;
            Usuario = usuario ?? throw new ArgumentNullException(nameof(usuario), "O usuário responsável pela inspeção é obrigatório.");
        }

        /// <summary>
        /// Representação em string do objeto.
        /// </summary>
        /// <returns>Data da inspeção e o nome do usuário responsável.</returns>
        public override string ToString()
        {
            return $"{Data_Inspecao_Colaborador:yyyy-MM-dd} - {Usuario?.Nome}";
        }
    }
}

