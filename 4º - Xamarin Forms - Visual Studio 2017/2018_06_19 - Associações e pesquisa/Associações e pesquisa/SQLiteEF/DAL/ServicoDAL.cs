using OficinaModels.Cadastros;
using SQLiteEF.DataAccess;

namespace SQLiteEF.DAL
{
    public class ServicoDAL: DALBase<Servico>
    {
        public ServicoDAL(DatabaseContext context) : base(context
        )
        {
        }
    }
}
