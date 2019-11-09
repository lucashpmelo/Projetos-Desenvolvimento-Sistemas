using Interfaces.DataAccess;
using SQLiteEF.DataAccess;
using IDPropertiesEF.Models;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;



namespace SQLiteEF.DAL
{
    public abstract class DALBase<T> : IDAL<T> where T : class
    {
        protected DatabaseContext context;
        public DALBase(DatabaseContext context)
        {
            this.context = context;
        }

        /*public virtual Task<bool> DeleteAsync(T item)
        {
            throw new NotImplementedException();
        }*/
        public virtual async Task<bool> DeleteAsync(T item)
        {
            context.Remove(item);
            await context.SaveChangesAsync();
            return await Task.FromResult(true);
        }

        /*public Task<IEnumerable<T>> GetAllAsync(bool forceRefresh = false)
        {
            throw new NotImplementedException();
        }*/
        public async virtual Task<System.Collections.Generic.IEnumerable<T>> GetAllAsync(bool forceRefresh = false)
        {
            return await context.Set<T>().ToListAsync(); ;
        }

        public virtual Task<T> GetByIdAsync(long? id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<IEnumerable<T>> GetStartsWithByFieldAsync(string field, string value)
        {
            throw new NotImplementedException();
        }

        /*public virtual Task<bool> UpdateAsync(T item, long? itemID)
        {
            throw new NotImplementedException();
        }*/
        public virtual async Task<bool> UpdateAsync(T item, long? itemID)
        {
            if (itemID != null)
            {
                context.Update(item);
            }
            else
            {
                await context.AddAsync(item);
            }
            await context.SaveChangesAsync();
            return await Task.FromResult(true);
        }
    }
}
