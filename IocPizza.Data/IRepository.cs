namespace IocPizza.Data
{
    using System;
    using System.Collections.Generic;

    public interface IRepository<T>
    {
        T Add(T item);

        T Update(T item);

        T Delete(T item);

        T Find(Guid id);

        IEnumerable<T> FindAll();
    }
}