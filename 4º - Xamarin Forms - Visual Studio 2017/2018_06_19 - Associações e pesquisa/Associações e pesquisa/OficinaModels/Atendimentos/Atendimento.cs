using IDPropertiesEF.Models;
using OficinaModels.Cadastros;
using System;
using System.Collections.Generic;
using System.Text;

namespace OficinaModels.Atendimentos
{
    public class Atendimento : AtendimentoIDProperty
    {
        public string Veiculo { get; set; }
        public DateTime DataHoraChegada { get; set; }
        public DateTime DataHoraPrometida { get; set; }
        public DateTime? DataHoraEntrega { get; set; }

        public Cliente Cliente { get; set; }
        public Atendimento()
        {
            this.DataHoraChegada = DateTime.Now;
            this.DataHoraPrometida = DateTime.Now;
            this.DataHoraEntrega = null;
        }

        public bool EstaFinalizado { get { return DataHoraEntrega != null; } }
    }
}
