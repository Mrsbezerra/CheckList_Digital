using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckList_Digital.model
{
    /// <summary>
    /// Representa os itens associados a uma entrega de Equipamento de Proteção Individual (EPI).
    /// </summary>
    internal class Itens_Entrega_EPI
    {
        /// <summary>
        /// Referência à entrega de EPI.
        /// </summary>
        public Entrega_EPI Entrega_EPI { get; set; }

        /// <summary>
        /// Referência ao EPI associado.
        /// </summary>
        public EPI EPI { get; set; }

        /// <summary>
        /// Construtor padrão.
        /// </summary>
        public Itens_Entrega_EPI() { }

        /// <summary>
        /// Construtor completo para inicializar todas as propriedades.
        /// </summary>
        /// <param name="entregaEPI">A entrega de EPI associada.</param>
        /// <param name="epi">O EPI associado à entrega.</param>
        public Itens_Entrega_EPI(Entrega_EPI entregaEPI, EPI epi)
        {
            Entrega_EPI = entregaEPI ?? throw new ArgumentNullException(nameof(entregaEPI), "A entrega de EPI é obrigatória.");
            EPI = epi ?? throw new ArgumentNullException(nameof(epi), "O EPI é obrigatório.");
        }

        /// <summary>
        /// Representação em string do objeto.
        /// </summary>
        /// <returns>Descrição textual do item da entrega de EPI.</returns>
        public override string ToString()
        {
            return $"Entrega ID: {Entrega_EPI.Id_Entrega_EPI}, EPI: {EPI.Nome_EPI}, Data de Entrega: {Entrega_EPI.Data_Entrega_EPI.ToShortDateString()}";
        }
    }
}

