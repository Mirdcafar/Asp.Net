namespace WebApplication7.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Comment { get; set;}
        public decimal TottalPrice { get; set; }
        public ICollection<OrderProduct> OrderProducts { get; set; }

    }
}
