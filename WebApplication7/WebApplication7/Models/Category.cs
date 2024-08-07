namespace WebApplication7.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public IEnumerable<OrderProduct> OrderProducts { get; set; }

    }
}
