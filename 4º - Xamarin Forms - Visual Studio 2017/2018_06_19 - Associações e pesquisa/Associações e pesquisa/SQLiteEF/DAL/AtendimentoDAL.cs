using Microsoft.EntityFrameworkCore;
using OficinaModels.Atendimentos;
using SQLiteEF.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteEF.DAL
{
    public class AtendimentoDAL : DALBase<Atendimento>
    {
        public AtendimentoDAL(DatabaseContext context) : base(context) { }

        public override async Task<IEnumerable<Atendimento>> GetAllAsync (bool forceRefresh = false)
        {
            return await context.Atendimentos.Include(c => c.Cliente).ToListAsync();
        }

        public override async Task<bool> UpdateAsync(Atendimento atendimento, long? atendimentoID)
        {
            if (atendimentoID == null)
                context.Entry(atendimento.Cliente).State = EntityState.Unchanged;
            await base.UpdateAsync(atendimento, atendimentoID);
            return await Task.FromResult(true);
        }

        public override async Task<Atendimento> GetByIdAsync(long? id)
        {
            return await context.Atendimentos.Include(c => c.Cliente).SingleOrDefaultAsync(a => a.AtendimentoID == id);
        }
    }
}
