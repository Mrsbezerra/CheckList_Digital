using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckList_Digital.model
{
    internal class Itens_Inspecao_Setor
    {

        public Inspecao_Setor Inspecao_Setor { get; set; }

        public Setor Setor { get; set; }

        public Itens_Inspecao_Setor() { }
        public Itens_Inspecao_Setor(Inspecao_Setor inspecaoSetor, Setor setor)
        {
            Inspecao_Setor = inspecaoSetor ?? throw new ArgumentNullException(nameof(inspecaoSetor), "O objeto Inspecao_Setor não pode ser nulo.");
            Setor = setor ?? throw new ArgumentNullException(nameof(setor), "O objeto Setor não pode ser nulo.");
        }

        public override string ToString()
        {
            return $"{Setor?.Nome_Setor} - {Inspecao_Setor?.Usuario}";
        }

    }
}
