# FlatDB

It's not a database it's a very naughty file store.
This provides flat file storage with file system or Azure blob storage implementations.

Usage:

```cs
var item = new MyItem { Id = Guid.NewGuid().ToString(), Name = "MyName" };

// Create a store.
var store = new FlatStore<string, MyItem>();

// Get an item.
var itemFromStore = store.Load("Id");

// Query the store.
var items = store.Where(x => x.Name == "MyName");

// Save an item.
store.Save(item, x => x.Id);

// Delete
store.Delete(item.Id);
```
