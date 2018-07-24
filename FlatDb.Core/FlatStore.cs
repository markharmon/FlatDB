using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace FlatDb.Core
{
    public class FlatStore<TIdentifier, T> : IFlatStore<TIdentifier, T>
    {
        public Type ElementType => throw new NotImplementedException();

        public Expression Expression => throw new NotImplementedException();

        public IQueryProvider Provider => throw new NotImplementedException();

        public void Delete(TIdentifier identifier)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public T Load(TIdentifier identifier)
        {
            throw new NotImplementedException();
        }

        public T Save(T item, Expression<Func<T, TIdentifier>> identifier)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
