using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckList_Digital.model
{
    /// <summary>
    /// Representa os itens de uma inspeção realizada por colaboradores.
    /// </summary>
    internal class Itens_Inspecao_Colaborador
    {
        /// <summary>
        /// Inspeção do colaborador associada.
        /// </summary>
        public Inspecao_Colaborador Inspecao_Colaborador { get; set; }

        /// <summary>
        /// Colaborador envolvido na inspeção.
        /// </summary>
        public Colaborador Colaborador { get; set; }

        /// <summary>
        /// Construtor padrão.
        /// </summary>
        public Itens_Inspecao_Colaborador() { }

        /// <summary>
        /// Construtor completo para inicializar todas as propriedades.
        /// </summary>
        /// <param name="inspecaoColaborador">Inspeção do colaborador associada.</param>
        /// <param name="colaborador">Colaborador envolvido na inspeção.</param>
        public Itens_Inspecao_Colaborador(Inspecao_Colaborador inspecaoColaborador, Colaborador colaborador)
        {
            Inspecao_Colaborador = inspecaoColaborador ?? throw new ArgumentNullException(nameof(inspecaoColaborador), "A inspeção do colaborador é obrigatória.");
            Colaborador = colaborador ?? throw new ArgumentNullException(nameof(colaborador), "O colaborador associado é obrigatório.");
        }

        /// <summary>
        /// Representação em string do objeto.
        /// </summary>
        /// <returns>Informações da inspeção e do colaborador.</returns>
        public override string ToString()
        {
            return $"Inspeção: {Inspecao_Colaborador?.Id_Inspecao_Colaborador}, Colaborador: {Colaborador?.Nome_Colaborador}";
        }
    }
}

