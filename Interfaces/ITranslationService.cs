using Scripture.Api.Models;

namespace Scripture.Api.Interfaces;

public interface ITranslationService
{
    ValueTask<List<TranslationDto>> GetAsync();
    ValueTask<TranslationDto> GetAsync(int id);
    ValueTask<TranslationDto> GetAsync(string name);
    ValueTask<TranslationDto> GetByAbbreviationAsync(string abbreviation);
    ValueTask<List<TranslationDto>> GetByLanguageAsync(string language);
}
