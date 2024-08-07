namespace Shop.Models
{
    public class Hotels
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public ICollection<HotelComment> HotelComments { get; set; }
    }
}
