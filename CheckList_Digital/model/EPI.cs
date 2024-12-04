using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckList_Digital.model
{
    /// <summary>
    /// Representa um Equipamento de Proteção Individual (EPI).
    /// </summary>
    internal class EPI
    {
        /// <summary>
        /// Identificador único do EPI.
        /// </summary>
        public int Id_EPI { get; set; }

        /// <summary>
        /// Nome do EPI.
        /// </summary>
        public string Nome_EPI { get; set; }

        /// <summary>
        /// Data da inspeção do EPI.
        /// </summary>
        public DateTime Data_Inspecao { get; set; }

        /// <summary>
        /// Substituição do EPI.
        /// </summary>
        public string Substituicao { get; set; }

        /// <summary>
        /// Descrição do EPI.
        /// </summary>
        public string Descricao { get; set; }

        /// <summary>
        /// Data de validade do EPI.
        /// </summary>
        public DateTime? Validade { get; set; }

        /// <summary>
        /// Construtor padrão.
        /// </summary>
        public EPI() { }

        /// <summary>
        /// Construtor completo para inicializar todas as propriedades.
        /// </summary>
        /// <param name="idEPI">Identificador único do EPI.</param>
        /// <param name="nomeEPI">Nome do EPI.</param>
        /// <param name="dataInspecao">Data da inspeção do EPI.</param>
        /// <param name="substituicao">Substituição do EPI.</param>
        /// <param name="descricao">Descrição do EPI.</param>
        /// <param name="validade">Data de validade do EPI.</param>
        public EPI(int idEPI, string nomeEPI, DateTime dataInspecao, string substituicao, string descricao, DateTime? validade)
        {
            Id_EPI = idEPI;
            Nome_EPI = nomeEPI ?? throw new ArgumentNullException(nameof(nomeEPI), "O nome do EPI é obrigatório.");
            Data_Inspecao = dataInspecao;
            Substituicao = substituicao ?? throw new ArgumentNullException(nameof(substituicao), "A substituição do EPI é obrigatória.");
            Descricao = descricao ?? throw new ArgumentNullException(nameof(descricao), "A descrição do EPI é obrigatória.");
            Validade = validade;
        }

        /// <summary>
        /// Representação em string do objeto.
        /// </summary>
        /// <returns>Descrição textual do EPI.</returns>
        public override string ToString()
        {
            return $"ID: {Id_EPI}, Nome: {Nome_EPI}, Inspeção: {Data_Inspecao.ToShortDateString()}, Substituição: {Substituicao}, Validade: {Validade?.ToShortDateString() ?? "N/A"}";
        }
    }
}

