using System.Collections.Generic;
using System.Linq;

namespace ShoppingCart.Core
{
    public class User
    {
        public User()
        {
            ShoppingItems = new List<Item>();
        }

        public List<Item> ShoppingItems { get; private set; }

        public decimal TotalCost { get; private set; }

        public void AddShoppingItems(List<Item> shoppingItems)
        {
            ShoppingItems.AddRange(shoppingItems);
            ComputeTotalCost();
        }

        private void ComputeTotalCost()
        {
            TotalCost = ShoppingItems.Select(item => item.Cost).Sum();
        }
    }
}
