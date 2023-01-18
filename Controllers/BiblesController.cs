using Microsoft.AspNetCore.Mvc;

using Scripture.Api.Interfaces;
using Scripture.Api.Models;

namespace Scripture.Api.Controllers
{
    public class BiblesController : ApiControllerBase
    {
        private readonly ITranslationService _translationService;
        private readonly IBookService _bookService;

        public BiblesController(ITranslationService translationService, IBookService bookService)
        {
            _translationService = translationService;
            _bookService = bookService;
        }

        [HttpGet("{translationId}")]
        public async Task<Result<Bible>> GetBibleAsync(int translationId)
        {
            try
            {
                var translation = await _translationService.GetAsync(translationId);
                if (translation is null) throw new Exception($"Translation {translation} could not be found.");
                var books = await _bookService.GetAsync(translationId);
                if (books is null || books.Count <= 0) throw new Exception($"Bible {translation} Could not found any book ");
                var bookTypes = books.Select(x => x.Type).ToList();

                var bible = new Bible(translation, bookTypes);
                return Result<Bible>.Success(bible);

            }
            catch (Exception e)
            {

                return Result<Bible>.Failure(new string[] { e.Message });
            }

        }

        [HttpGet("{translationId}/CompleteVersion")]
        public async Task<Result<BibleRecord>> GetComplete(int translationId)
        {
            try
            {
                var translation = await _translationService.GetAsync(translationId);
                if (translation is null) throw new Exception($"Translation {translation} could not be found.");
                var books = await _bookService.GetAsync(translationId);
                if (books is null || books.Count <= 0) throw new Exception($"Bible {translation} Could not found any book ");


                var bible = new BibleRecord(translation.Id,
                translation.Language,
                translation.Abbreviation,
                translation.Textdirection,
                books.Select(x => new BookRecord(x.Type.Name, x.Chapters)).ToList());
                return Result<BibleRecord>.Success(bible);

            }
            catch (Exception e)
            {

                return Result<BibleRecord>.Failure(new string[] { e.Message });
            }

        }

    }
}
