﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.DataAccess
{
    public interface IDAL<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync(bool forceRefresh = false);
        Task<bool> UpdateAsync(T item, long? itemID);
        Task<bool> DeleteAsync(T item);
        Task<T> GetByIdAsync(long? id);
        Task<IEnumerable<T>> GetStartsWithByFieldAsync(string field, string value);
    }
}
