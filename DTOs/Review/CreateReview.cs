namespace BookstoreAPI.DTOs
{
    public class CreateReviewDto
    {
        public string ReviewerName { get; set; } = string.Empty;
        public string ReviewerEmail { get; set; } = string.Empty;
        public string ReviewTitle { get; set; } = string.Empty;
        public int Rating { get; set; } = 0;
    }
}