using Microsoft.AspNetCore.Mvc;

using Scripture.Api.Interfaces;
using Scripture.Api.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripture.Api.Controllers
{
    public class BiblesController:ApiControllerBase
    {
        private readonly ITranslationService _translationService;
        private readonly IBookService _bookService;

        public BiblesController(ITranslationService translationService, IBookService bookService)
        {
            _translationService = translationService;
            _bookService = bookService;
        }
        [HttpGet("{translationId}")]
        public async Task<Bible> GetBibleAsync(int translationId)
        {
            var translation = await _translationService.GetAsync(translationId);
            if (translation is null) throw new Exception($"Translation {translation} could not be found.");
            var books = await _bookService.GetAsync(translationId);
            if (books is null || books.Count<=0) throw new Exception($"Bible {translation} Could not found any book ");
            var bookTypes = books.Select(x => x.Type).ToList();
           
            return new Bible(translation,bookTypes);
        }
    }
}
