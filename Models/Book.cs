using Scripture.Api.ValueObjects;

namespace Scripture.Api.Models;

public class Book
{
    public int TranslationId { get; set; }
    public BookType Type { get; set; }
    public ICollection<Chapter> Chapters { get; set; }
}
