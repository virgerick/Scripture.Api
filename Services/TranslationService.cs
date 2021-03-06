using Scripture.Api.Exceptions;
using Scripture.Api.Extensions;
using Scripture.Api.Interfaces;
using Scripture.Api.Models;

namespace Scripture.Api.Services;

public class TranslationService : ITranslationService
{
    private List<TranslationDto> _translatios = new List<TranslationDto>();
    public TranslationService()
    {
       LoadTranslationsAsync().GetAwaiter().GetResult();
    }

    private async Task LoadTranslationsAsync()
    {
        string json;
        try
        {
            var path = $@"{Environment.CurrentDirectory}\Assert\translations.json";
            json = await File.ReadAllTextAsync(path);
        }
        catch
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://raw.githubusercontent.com/virgerick/Scripture.Api/master/Assert/translations.json");
            json = await httpClient.GetStringAsync("");
        }

        var translarions = json.Deserialize<Translations>();
        var type = translarions.GetType();
        foreach (var info in type.GetProperties())
        {
            var value = info.GetValue(translarions, null);
            if (value is TranslationDto translation) _translatios.Add(translation);
        }
    }

    public async ValueTask<List<TranslationDto>> GetAsync()
    {
        return _translatios;
    }

    public async ValueTask<TranslationDto> GetAsync(int id)
    {
        var found = _translatios.FirstOrDefault(t => t.Id == id);
        if (found == null) throw new NotFoundException("Translation", id);
        return found;
    }

    public async ValueTask<TranslationDto> GetAsync(string name)
    {
        var found = _translatios.FirstOrDefault(t => t.Translation == name);
        if (found == null) throw new NotFoundException("Translation", name);
        return found;
    }

    public async ValueTask<TranslationDto> GetByAbbreviationAsync(string abbreviation)
    {
        var found = _translatios.FirstOrDefault(t => t.Abbreviation == abbreviation);
        if (found == null) throw new NotFoundException("Translation", abbreviation);
        return found;
    }

    public async ValueTask<List<TranslationDto>> GetByLanguageAsync(string language)
    {
        var found = _translatios.Where(t => t.Language == language).ToList();
        if (found == null) throw new NotFoundException("Translation", language);
        return found;
    }
}
