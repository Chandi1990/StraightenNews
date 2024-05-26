namespace Straighten.Models
{
    public class News
    {
        public int Id { get; set; }
        public string? MainHeading { get; set; }
        public List<int>? SubHeadingIdList { get; set; }
        public string? Description { get; set; }
        public List<int>? ParagraphIdList { get; set; }
        public List<int>? ImagesIdUrls { get; set; }
    }
}
