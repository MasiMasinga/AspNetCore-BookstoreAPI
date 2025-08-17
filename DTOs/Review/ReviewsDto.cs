namespace BookstoreAPI.DTOs
{
    public class ReviewsDto
    {
        public int Id { get; set; }
        public string ReviewerName { get; set; } = string.Empty;
        public string ReviewerEmail { get; set; } = string.Empty;
        public string ReviewTitle { get; set; } = string.Empty;
        public int Rating { get; set; } = 0;
    }
}