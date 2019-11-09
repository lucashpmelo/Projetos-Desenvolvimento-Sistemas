using OficinaModels.Cadastros;
using SQLiteEF.DataAccess;
using IDPropertiesEF.Models;

namespace SQLiteEF.DAL
{
    public class ClienteDAL : DALBase<Cliente>
    {
        public ClienteDAL(DatabaseContext contexto) : base(contexto)
        {
        }
    }
}
