using System.ComponentModel.DataAnnotations;

namespace WebApplication7.Models;

public class Product
{
    public int Id { get; set; }
    [Required]
    public string ImageUrl { get; set; }
    public string Title { get; set; }
    public int Count { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public Category Category { get; set;}
    public int CategoryId { get; set; }
    public IEnumerable<OrderProduct> OrderProducts { get; set;}
}
