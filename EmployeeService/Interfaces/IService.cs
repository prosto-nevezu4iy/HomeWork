using System;
using System.Collections.Generic;
using System.Text;

namespace Source.Interfaces
{
    public interface IService<T> where T : class
    {
        void Add(T entity);
        IEnumerable<T> Get();
    }
}
