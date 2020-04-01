using System.Collections.Generic;

namespace ShoppingCart.Core
{
    public class Shop
    {
        public Shop()
        {
            Items = new List<Item>();
        }

        public List<Item> Items { get; private set; }

        public void AddItems(List<Item> items)
        {
            Items.AddRange(items);
        }
    }
}
