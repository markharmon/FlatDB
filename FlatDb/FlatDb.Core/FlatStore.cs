using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace FlatDb.Core
{
    public class FlatStore<TIdentifier, T>: IFlatStore<TIdentifier, T>
    {
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Type ElementType { get; }
        public Expression Expression { get; }
        public IQueryProvider Provider { get; }

        public T Save(T item, Expression<Func<T, TIdentifier>> identifier)
        {
            throw new NotImplementedException();
        }

        public T Load(TIdentifier identifier)
        {
            throw new NotImplementedException();
        }

        public void Delete(TIdentifier identifier)
        {
            throw new NotImplementedException();
        }
    }
}
