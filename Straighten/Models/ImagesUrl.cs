namespace Straighten.Models
{
    public class ImagesUrl
    {
        public int Id { get; set; }
        public List<string> ImagesUrlsList { get; set; } = new List<string>();
        public News? News { get; set; }
    }
}
