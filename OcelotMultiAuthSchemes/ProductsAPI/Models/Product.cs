namespace ProductsAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
    }
}
