namespace BookstoreAPI.DTOs
{
    public class BookstoreDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public int Price { get; set; } = 0;
        public List<Review> Reviews { get; set; } = new List<Review>();
    }
}