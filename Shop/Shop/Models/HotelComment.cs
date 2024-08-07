namespace Shop.Models
{
    public class HotelComment
    {
        public int Id { get; set; }
        public Comment Comment { get; set; }
        public int CommentId { get; set; }
        public Hotels Hotels { get; set; }
        public int HotelsId { get; set; }
    }
}
