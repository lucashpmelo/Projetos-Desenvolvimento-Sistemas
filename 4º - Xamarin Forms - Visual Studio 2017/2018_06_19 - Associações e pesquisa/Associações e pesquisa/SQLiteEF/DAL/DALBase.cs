using Interfaces.DataAccess;
using SQLiteEF.DataAccess;
using IDPropertiesEF.Models;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Reflection;
using System.Linq;

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

        /*public virtual Task<T> GetByIdAsync(long? id)
        {
            throw new NotImplementedException();
        }*/

        public virtual async Task<T> GetByIdAsync(long? id)
        {
            return await context.Set<T>().FindAsync(id);
        }

        /*public virtual Task<IEnumerable<T>> GetStartsWithByFieldAsync(string field, string value)
        {
            throw new NotImplementedException();
        }*/

        public async Task<System.Collections.Generic.IEnumerable<T>> GetStartsWithByFieldAsync(string field, string value)
        {
            ParameterExpression parameterExpression = Expression.Parameter(typeof(T), "t");
            MemberExpression memberExpression = Expression.Property(parameterExpression, field);
            ConstantExpression constantExpression = Expression.Constant(value, typeof(string));
            MethodInfo methodInfo = typeof(string).GetMethod("StartsWith", new Type[] { typeof(string) });
            Expression call = Expression.Call(memberExpression, methodInfo, constantExpression);

            Expression<Func<T, bool>> lambda = Expression.Lambda<Func<T, bool>>(call, parameterExpression);
            return await Task.FromResult(context.Set<T>().Where(lambda));
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
