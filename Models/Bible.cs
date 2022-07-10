using Scripture.Api.ValueObjects;

namespace Scripture.Api.Models;

public class Bible
{
    public int Id { get; private set; }
    public string Language { get; private set; }
    public string Translation { get; private set; }
    public string Abbreviation { get; private set; }
    public string Textdirection { get; private set; }
    public ICollection<BookType> Books { get; private set; }

    public Bible(TranslationDto translationDto, ICollection<BookType> books)
    {
        Abbreviation = translationDto.Abbreviation;
        Id = translationDto.Id;
        Language = translationDto.Language;
        Textdirection = translationDto.Textdirection;
        Translation = translationDto.Translation;
        Books = books.ToList();
    }


}

