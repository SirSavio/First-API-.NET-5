using First_API.Entities;
using System;
using System.Collections.Generic;

namespace First_API.Repositories
{
    public interface IItemsRepository
    {
        Item GetItem(Guid id);
        IEnumerable<Item> GetItems();
        void CreateItem(Item item);

        void UpdateItem(Item item);
    }
}