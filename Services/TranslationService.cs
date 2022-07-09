using Scripture.Api.Extensions;
using Scripture.Api.Interfaces;
using Scripture.Api.Models;

using System.Xml.Linq;

namespace Scripture.Api.Services
{
    public class TranslationService : ITranslationService
    {
        private List<TranslationDto> _translatios = new List<TranslationDto>();
        public TranslationService()
        {
            
            var path = $@"{Environment.CurrentDirectory}\Assert\translations.json";
            var json = File.ReadAllTextAsync(path).GetAwaiter().GetResult();
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
            if (found == null) throw new Exception($"Translation {id} could no be found.");
            return  found;
        }

        public async ValueTask<TranslationDto> GetAsync(string name)
        {
            var found = _translatios.FirstOrDefault(t => t.Translation == name);
            if (found == null) throw new Exception($"Translation {name} could no be found.");
            return found;
        }

        public async ValueTask<TranslationDto> GetByAbbreviationAsync(string abbreviation)
{
            var found = _translatios.FirstOrDefault(t => t.Abbreviation == abbreviation);
            if (found == null) throw new Exception($"Translation {abbreviation} could no be found.");
            return found;
        }

        public async ValueTask<TranslationDto> GetByLanguageAsync(string language)
        {
            var found = _translatios.FirstOrDefault(t => t.Language == language);
            if (found == null) throw new Exception($"Translation {language} could no be found.");
            return found;
        }
    }
}
