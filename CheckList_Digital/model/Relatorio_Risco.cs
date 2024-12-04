using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckList_Digital.model
{
    /// <summary>
    /// Representa um relatório de risco associado a uma inspeção.
    /// </summary>
    internal class Relatorio_Risco
    {
        /// <summary>
        /// Identificador único do relatório de risco.
        /// </summary>
        public int Id_Relatorio_Risco { get; set; }

        /// <summary>
        /// Descrição do relatório de risco.
        /// </summary>
        public string Descricao { get; set; }

        /// <summary>
        /// Áreas de alto risco identificadas no relatório.
        /// </summary>
        public string Areas_Alto_Risco { get; set; }

        /// <summary>
        /// Inspeção relacionada ao relatório de risco.
        /// </summary>
        public Inspecao Inspecao { get; set; }

        /// <summary>
        /// Construtor padrão.
        /// </summary>
        public Relatorio_Risco() { }

        /// <summary>
        /// Construtor completo para inicializar todas as propriedades.
        /// </summary>
        /// <param name="idRelatorioRisco">Identificador único do relatório de risco.</param>
        /// <param name="descricao">Descrição do relatório de risco.</param>
        /// <param name="areasAltoRisco">Áreas de alto risco identificadas.</param>
        /// <param name="inspecao">Inspeção associada ao relatório de risco.</param>
        public Relatorio_Risco(int idRelatorioRisco, string descricao, string areasAltoRisco, Inspecao inspecao)
        {
            Id_Relatorio_Risco = idRelatorioRisco;
            Descricao = descricao ?? throw new ArgumentNullException(nameof(descricao), "A descrição é obrigatória.");
            Areas_Alto_Risco = areasAltoRisco ?? throw new ArgumentNullException(nameof(areasAltoRisco), "As áreas de alto risco são obrigatórias.");
            Inspecao = inspecao ?? throw new ArgumentNullException(nameof(inspecao), "A inspeção associada é obrigatória.");
        }

        /// <summary>
        /// Representação em string do objeto.
        /// </summary>
        /// <returns>Descrição textual do relatório de risco.</returns>
        public override string ToString()
        {
            return $"ID: {Id_Relatorio_Risco}, Descrição: {Descricao}, Áreas de Alto Risco: {Areas_Alto_Risco}, Inspeção: {Inspecao?.Id_Inspecao}";
        }
    }
}

