namespace Straighten.Models
{
    public class SubHeading
    {
        public int Id { get; set; }
        public List<string> TitlesList { get; set; } = new List<string>();
        public News? News { get; set; }
    }
}
