using Scripture.Api.Interfaces;
using Scripture.Api.Models;

using System.Collections.ObjectModel;

namespace Scripture.Api.Services
{
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
            if (translation == null) throw new Exception($"Translation {idTranslation} could no be found.");
            var path = $@"{Environment.CurrentDirectory}\Assert\Resources\{translation.Filename}.txt";
            using (StreamReader streamReader = File.OpenText(path))
            {
                string text = streamReader.ReadToEnd();
                if (text == null) throw new Exception($"Translation {idTranslation} could no be load.");
                string[] lines = text.Split(Environment.NewLine);

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                    if (string.IsNullOrEmpty(line)) continue;
                    var array = line.Split("||");
                   if (array.Length == 0) continue;
                     var verse = new Verse { TranslationId = idTranslation, Book = array[0], Chapter = Convert.ToInt32(array[1]), Number = Convert.ToInt32(array[2]), Text = array[3] };
                    result.Add(verse);
                }
            }
            return result;
        }
    }
}
