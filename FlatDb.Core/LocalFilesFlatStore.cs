using Microsoft.Extensions.FileProviders;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace FlatDb.Core
{
    class LocalFilesFlatStore<TIdentifier, T> : IFlatStore<TIdentifier, T>
    {
        private const string ItemFileExtension = "json";
        private readonly IFileProvider _fileProvider;

        public LocalFilesFlatStore(IFileProvider fileProvider)
        {
            _fileProvider = fileProvider;
        }

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
            // TODO: Lock file.
            // TODO: Update an index.
            var itemType = typeof(T).Name.ToLower();
            var identifierValue = identifier.Compile()(item);

            File.WriteAllText($"/{itemType}/{identifierValue}.{ItemFileExtension}", JsonConvert.SerializeObject(item));

            return item;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
