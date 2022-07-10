using Microsoft.AspNetCore.Mvc;

using Scripture.Api.Exceptions;
using Scripture.Api.Interfaces;
using Scripture.Api.Models;

namespace Scripture.Api.Controllers
{
    public class BooksController : ApiControllerBase
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }
        [HttpGet("{translationId}/{code}")]
        public async Task<Book> GetBookByCode(int translationId, string code)
        {
            var result = await _bookService.GetAsync(code, translationId);
            return result;
        }

        [HttpGet("{translationId}/{code}/[action]/{chapter}")]
        public async Task<Chapter> GetChapter(int translationId, string code, int chapter)
        {
            var book = await _bookService.GetAsync(code, translationId);
            var found = book.Chapters.FirstOrDefault(x => x.Number == chapter);
            if (found == null) throw new NotFoundException(nameof(Chapter), chapter);
            return found;
        }

    }
}
