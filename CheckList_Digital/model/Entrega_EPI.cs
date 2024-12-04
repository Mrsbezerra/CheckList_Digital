using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckList_Digital.model
{
    /// <summary>
    /// Representa a entrega de Equipamento de Proteção Individual (EPI) para um colaborador.
    /// </summary>
    internal class Entrega_EPI
    {
        /// <summary>
        /// Identificador único da entrega de EPI.
        /// </summary>
        public int Id_Entrega_EPI { get; set; }

        /// <summary>
        /// Data da entrega do EPI.
        /// </summary>
        public DateTime Data_Entrega_EPI { get; set; }

        /// <summary>
        /// Colaborador que recebeu o EPI.
        /// </summary>
        public Colaborador Colaborador { get; set; }

        /// <summary>
        /// Construtor padrão.
        /// </summary>
        public Entrega_EPI() { }

        /// <summary>
        /// Construtor completo para inicializar todas as propriedades.
        /// </summary>
        /// <param name="idEntregaEPI">Identificador único da entrega de EPI.</param>
        /// <param name="dataEntregaEPI">Data da entrega do EPI.</param>
        /// <param name="colaborador">Colaborador que recebeu o EPI.</param>
        public Entrega_EPI(int idEntregaEPI, DateTime dataEntregaEPI, Colaborador colaborador)
        {
            Id_Entrega_EPI = idEntregaEPI;
            Data_Entrega_EPI = dataEntregaEPI;
            Colaborador = colaborador ?? throw new ArgumentNullException(nameof(colaborador), "O colaborador é obrigatório.");
        }

        /// <summary>
        /// Representação em string do objeto.
        /// </summary>
        /// <returns>Descrição textual da entrega de EPI.</returns>
        public override string ToString()
        {
            return $"ID: {Id_Entrega_EPI}, Data de Entrega: {Data_Entrega_EPI.ToShortDateString()}, Colaborador: {Colaborador.Nome_Colaborador}";
        }
    }
}

