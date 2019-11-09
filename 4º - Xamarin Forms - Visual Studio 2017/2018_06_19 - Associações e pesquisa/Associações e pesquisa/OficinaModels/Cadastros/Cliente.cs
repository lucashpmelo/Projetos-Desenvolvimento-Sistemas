using IDPropertiesEF.Models;

namespace OficinaModels.Cadastros
{
    public class Cliente : ClienteIDProperty
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string EMail { get; set; }
    }
}
