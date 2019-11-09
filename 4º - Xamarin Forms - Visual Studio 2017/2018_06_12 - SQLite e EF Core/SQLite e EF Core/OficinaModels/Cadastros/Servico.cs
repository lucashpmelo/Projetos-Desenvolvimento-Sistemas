using IDPropertiesEF.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OficinaModels.Cadastros
{
    public class Servico : ServicoIDProperty
    {
        public string Nome { get; set; }
        public double Valor { get; set; }
        public string ValorFormatado
        {
            get
            {
                return string.Format("R$ {0:N2}", this.Valor);
            }
        }
    }
}
