namespace BookstoreAPI.DTOs
{
    public class UpdateBookstoreDto
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public int Price { get; set; } = 0;
    }
}