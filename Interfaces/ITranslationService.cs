using Scripture.Api.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripture.Api.Interfaces
{
    public interface ITranslationService
    {
        ValueTask<List<TranslationDto>> GetAsync();
        ValueTask<TranslationDto> GetAsync(int id);
        ValueTask<TranslationDto> GetAsync(string name);
        ValueTask<TranslationDto> GetByAbbreviationAsync(string abbreviation);
        ValueTask<TranslationDto> GetByLanguageAsync(string language);
    }
}
