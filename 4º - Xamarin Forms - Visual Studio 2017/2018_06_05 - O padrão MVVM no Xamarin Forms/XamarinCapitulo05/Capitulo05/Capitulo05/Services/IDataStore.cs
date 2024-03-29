﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo05.Services
{
    public interface IDataStore<T>
    {
        Task<bool> AddAsync(T item);
        Task<bool> UpdateAsync(T item);
        Task<bool> DeleteAsync(T item);
        Task<T> GetByIdAsync(long? id);
        Task<IEnumerable<T>> GetAllAsync(bool forceRefresh = false);
    }
}
