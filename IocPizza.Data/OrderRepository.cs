using System;
using System.Collections.Generic;

namespace IocPizza.Data
{
    using IocPizza.Domain;

    public class OrderRepository<TOrder> : IRepository<TOrder> where TOrder : IOrder
    {
        public TOrder Add(TOrder item)
        {
            throw new NotImplementedException();
        }

        public TOrder Update(TOrder item)
        {
            throw new NotImplementedException();
        }

        public TOrder Delete(TOrder item)
        {
            throw new NotImplementedException();
        }

        public TOrder Find(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TOrder> FindAll()
        {
            throw new NotImplementedException();
        }
    }
}
