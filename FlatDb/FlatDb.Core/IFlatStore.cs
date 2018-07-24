using System;
using System.Linq;
using System.Linq.Expressions;

namespace FlatDb.Core
{
    public interface IFlatStore<TIdentifier, T>: IQueryable<T>
    {
        T Save(T item, Expression<Func<T, TIdentifier>> identifier);
        T Load(TIdentifier identifier);
        void Delete(TIdentifier identifier);
    }
}
