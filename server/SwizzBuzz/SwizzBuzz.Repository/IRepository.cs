using System;
using System.Collections.Generic;

namespace SwizzBuzz.Repository
{
    public interface IRepository<T,TKey>
    {
        abstract IEnumerable<T> RetrieveAll();
        abstract T Retrieve(TKey key);
        abstract TKey Create(T item);
        abstract T Update(TKey key, dynamic parameters);
        abstract void Delete(TKey key);
    }
}
