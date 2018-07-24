using System;
using System.Linq;
using FlatDb.Core;

namespace FlatDb.Console
{
    class Program
    {
        public class MyItem
        {
            public string Id { get; set; }
            public string Name { get; set; }
        }

        static void Main(string[] args)
        {
            var store = new FlatStore<string, MyItem>();
            var item = new MyItem {Id = Guid.NewGuid().ToString(), Name = "MyName"};

            store.Save(item, x => x.Id);

            var itemFromStore = store.Load("Id");

            var items = store.Where(x => x.Name == "MyName");

            store.Delete(item.Id);
        }
    }
}
