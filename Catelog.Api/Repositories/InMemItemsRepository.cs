using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catelog.Api.Entities;

namespace Catelog.Api.Repositories
{
  
    public class InMemItemsRepository : IItemsRepository
    {

        //readonly here because instance of list should not change after we construct repository object
        public readonly List<Item> items = new()  // Target-typed new expression()
        {
            new Item { Id = Guid.NewGuid(), Name = "Potion", Price = 9, CreatedDate = DateTimeOffset.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "Iron Sword", Price = 20, CreatedDate = DateTimeOffset.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "Bronze Shield", Price = 18, CreatedDate = DateTimeOffset.UtcNow }
        };

        //Enumerable is to return collection of items
        public async Task<IEnumerable<Item>> GetItemsAsync()
        {
            return await Task.FromResult(items);
        }

        public async Task<Item> GetItemAsync(Guid id)
        {
            return await Task.FromResult(items.Where(item => item.Id == id).SingleOrDefault()); //if it finds the item it returns the item else no.
        }

        public async Task CreateItemAsync(Item item)
        {
            items.Add(item);
            await Task.CompletedTask;
        }

        public async Task UpdateItemAsync(Item item)
        {
            var index = items.FindIndex(exItem => exItem.Id == item.Id);
            items[index] = item;
            await Task.CompletedTask;
        }

        public async Task DeleteItemAsync(Guid id)
        {
            var index =  items.FindIndex(exItem => exItem.Id == id);
            items.RemoveAt(index);
            await Task.CompletedTask;
        }
    }
}