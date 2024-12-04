using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckList_Digital.model
{
    /// <summary>
    /// Representa o resultado de um checklist realizado durante uma inspeção.
    /// </summary>
    internal class Resultado_Checklist
    {
        /// <summary>
        /// Identificador único do resultado do checklist.
        /// </summary>
        public int Id_Resultado_Checklist { get; set; }

        /// <summary>
        /// Condição encontrada durante a inspeção.
        /// </summary>
        public string Condicao_Encontrada { get; set; }

        /// <summary>
        /// Ação corretiva proposta ou realizada.
        /// </summary>
        public string Acao_Corretiva { get; set; }

        /// <summary>
        /// Inspeção relacionada ao resultado.
        /// </summary>
        public Inspecao Inspecao { get; set; }

        /// <summary>
        /// Item do checklist associado ao resultado.
        /// </summary>
        public Item_Checklist Item_Checklist { get; set; }

        /// <summary>
        /// Construtor padrão.
        /// </summary>
        public Resultado_Checklist() { }

        /// <summary>
        /// Construtor completo para inicializar todas as propriedades.
        /// </summary>
        /// <param name="idResultadoChecklist">Identificador único do resultado do checklist.</param>
        /// <param name="condicaoEncontrada">Condição encontrada durante a inspeção.</param>
        /// <param name="acaoCorretiva">Ação corretiva proposta ou realizada.</param>
        /// <param name="inspecao">Inspeção relacionada ao resultado.</param>
        /// <param name="itemChecklist">Item do checklist associado ao resultado.</param>
        public Resultado_Checklist(int idResultadoChecklist, string condicaoEncontrada, string acaoCorretiva, Inspecao inspecao, Item_Checklist itemChecklist)
        {
            Id_Resultado_Checklist = idResultadoChecklist;
            Condicao_Encontrada = condicaoEncontrada ?? throw new ArgumentNullException(nameof(condicaoEncontrada), "A condição encontrada é obrigatória.");
            Acao_Corretiva = acaoCorretiva ?? throw new ArgumentNullException(nameof(acaoCorretiva), "A ação corretiva é obrigatória.");
            Inspecao = inspecao ?? throw new ArgumentNullException(nameof(inspecao), "A inspeção associada é obrigatória.");
            Item_Checklist = itemChecklist ?? throw new ArgumentNullException(nameof(itemChecklist), "O item do checklist associado é obrigatório.");
        }

        /// <summary>
        /// Representação em string do objeto.
        /// </summary>
        /// <returns>Descrição textual do resultado do checklist.</returns>
        public override string ToString()
        {
            return $"ID: {Id_Resultado_Checklist}, Condição: {Condicao_Encontrada}, Ação: {Acao_Corretiva}, Inspeção: {Inspecao?.Id_Inspecao}, Item: {Item_Checklist?.Descricao}";
        }
    }
}

