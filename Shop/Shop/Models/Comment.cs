namespace Shop.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<HotelComment> HotelComments { get; set; }
    }
}
