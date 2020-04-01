using ShoppingCart.Core;
using System.Collections.Generic;
using Xunit;

namespace ShoppingCart.UnitTests
{
    public class ShopTests
    {
        // A shop contains at least 10 types of items.
        [Fact]
        public void ShopContainsNumberOfItems()
        {
            // Arrange
            var items = new List<Item>()
            {
                new Item("a", 10M),
                new Item("b", 20M),
                new Item("c", 30M),
                new Item("d", 40M),
                new Item("e", 50M),
                new Item("f", 60M),
                new Item("g", 70M),
                new Item("h", 80M),
                new Item("i", 90M),
                new Item("j", 100M),
            };
            var shop = new Shop();

            // Act
            shop.AddItems(items);

            // Assert
            Assert.Equal(10, shop.Items.Count);
        }

        // The user can enter several shopping items.
        [Fact]
        public void UserCanEnterSeveralShoppingItems()
        {
            // Arrange
            var items = new List<Item>()
            {
                new Item("a", 10M),
                new Item("b", 20M),
                new Item("c", 30M),
                new Item("d", 40M),
                new Item("e", 50M)
            };

            var shop = new Shop();
            var user = new User();

            // Act
            shop.AddItems(items);
            user.AddShoppingItems(shop.Items);

            // Assert
            Assert.Equal(5, user.ShoppingItems.Count);
        }
        // The program returns a total cost.
        [Fact]
        public void ReturnsTotalCost()
        {
            // Arrange
            var items = new List<Item>()
            {
                new Item("a", 10M),
                new Item("b", 20M),
                new Item("c", 30M),
                new Item("d", 40M),
                new Item("e", 50M)
            };

            var shop = new Shop();
            var user = new User();

            // Act
            shop.AddItems(items);
            user.AddShoppingItems(shop.Items);

            // Assert
            Assert.Equal(150M, user.TotalCost);
        }
    }
}
