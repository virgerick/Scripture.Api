namespace Scripture.Api.Models
{
    public class Chapter
    {
        public int Number { get; set; }
        public ICollection<string> Verses { get; set; }
    }
}