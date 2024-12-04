using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckList_Digital.model
{
    internal class Inspecao
    {
        public int Id_Inspecao { get; set; }

        public DateTime Data { get; set; }

        public TimeSpan Hora { get; set; }

        public Setor Setor { get; set; }

        public Inspecao_Setor Inspecao_Setor { get; set; }

        public Usuario Usuario { get; set; }

        public DateTime DataHora => Data.Add(Hora);

        public Inspecao() { }

        public Inspecao(int idInspecao, DateTime data, TimeSpan hora, Setor setor, Inspecao_Setor inspecaoSetor, Usuario usuario)
        {
            Id_Inspecao = idInspecao;
            Data = data;
            Hora = hora;
            Setor = setor;
            Inspecao_Setor = inspecaoSetor;
            Usuario = usuario;
        }


    }
}
