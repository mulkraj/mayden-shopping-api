namespace mayden.shoppingapp.models
{
    public class Product
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public float Price { get; set; }

        public bool Purchased { get; set; }
    }
}
