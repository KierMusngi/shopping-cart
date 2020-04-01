namespace ShoppingCart.Core
{
    public class Item
    {
        public Item(string name, decimal cost)
        {
            Name = name;
            Cost = cost;
        }

        public string Name { get; private set; }

        public decimal Cost { get; private set; }
    }
}
