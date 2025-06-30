namespace mayden.shoppingapp.models
{
    public class ShoppingList
    {
        public int Id { get; set; }

        public float Limit { get; set; }

        public float TotalCost { get; set; }

        public List<Product>? Items { get; set; }
    }
}