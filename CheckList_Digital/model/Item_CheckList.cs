using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckList_Digital.model
{
    /// <summary>
    /// Representa um item do checklist.
    /// </summary>
    internal class Item_Checklist
    {
        /// <summary>
        /// Identificador único do item do checklist.
        /// </summary>
        public int Id_Item_Checklist { get; set; }

        /// <summary>
        /// Descrição do item do checklist.
        /// </summary>
        public string Descricao { get; set; }

        /// <summary>
        /// Construtor padrão.
        /// </summary>
        public Item_Checklist() { }

        /// <summary>
        /// Construtor completo para inicializar todas as propriedades.
        /// </summary>
        /// <param name="idItemChecklist">Identificador único do item.</param>
        /// <param name="descricao">Descrição do item.</param>
        public Item_Checklist(int idItemChecklist, string descricao)
        {
            Id_Item_Checklist = idItemChecklist;
            Descricao = descricao ?? throw new ArgumentNullException(nameof(descricao), "A descrição do item é obrigatória.");
        }

        /// <summary>
        /// Representação em string do objeto.
        /// </summary>
        /// <returns>Descrição textual do item do checklist.</returns>
        public override string ToString()
        {
            return $"ID: {Id_Item_Checklist}, Descrição: {Descricao}";
        }
    }
}
