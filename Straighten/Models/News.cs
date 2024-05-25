namespace Straighten.Models
{
    public class News
    {
        public int Id { get; set; }
        public string? MainHeading { get; set; }
        public List<SubHeading>? SubHeadingList { get; set; }
        public string? Description { get; set; }
        public List<Paragraph>? ParagraphList { get; set; }
        public List<ImagesUrl>? ImagesUrls { get; set; }
    }
}
