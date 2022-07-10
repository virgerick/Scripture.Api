using Scripture.Api.Exceptions;
using Scripture.Api.Interfaces;
using Scripture.Api.Models;

using System.Collections.ObjectModel;
using System.IO;

namespace Scripture.Api.Services;

public class VerseService : IVerseService
{
    private readonly ITranslationService _translationService;

    public VerseService(ITranslationService translationService)
    {
        _translationService = translationService;
    }

    public async ValueTask<ICollection<Verse>> GetByIdAsync(int idTranslation)
    {
        var result = new Collection<Verse>();
        var translation = await _translationService.GetAsync(idTranslation);
        var uri = $"https://raw.githubusercontent.com/virgerick/Scripture.Api/master/Assert/Resources/{translation.Filename}.txt";
        if (translation == null) throw new NotFoundException("Translation", idTranslation);
        var httpClient = new HttpClient();
        var stream = await httpClient.GetStreamAsync(uri);
        using StreamReader streamReader = new StreamReader(stream);
        string text = streamReader.ReadToEnd();
        if (text == null) throw new NotFoundException($"Translation", idTranslation);
        string[] lines = text.Split("\n");

        foreach (string line in lines)
        {
            if (string.IsNullOrEmpty(line)) continue;
            var array = line.Split("||");
            if (array.Length == 0) continue;
            if (string.IsNullOrEmpty(array[3])) continue;
            var verse = new Verse
            {
                TranslationId = idTranslation,
                Book = array[0],
                Chapter = Convert.ToInt32(array[1]),
                Number = Convert.ToInt32(array[2]),
                Text = array[3]
            };
            result.Add(verse);
        }

        return result;
    }
}
