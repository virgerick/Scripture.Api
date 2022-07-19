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
        public async Task<Result<Book>> GetBookByCode(int translationId, string code)
        {
            try
            {
                var result = await _bookService.GetAsync(code, translationId);
                return Result<Book>.Success(result);
            }
            catch (Exception e)
            {

                return Result<Book>.Failure(new string[] { e.Message });
            }

        }

        [HttpGet("{translationId}/{code}/[action]/{chapter}")]
        public async Task<Result<Chapter>> GetChapter(int translationId, string code, int chapter)
        {
            try
            {
                var book = await _bookService.GetAsync(code, translationId);
                var found = book.Chapters.FirstOrDefault(x => x.Number == chapter);
                if (found == null) throw new NotFoundException(nameof(Chapter), chapter);
                return Result<Chapter>.Success(found);
            }
            catch (Exception e)
            {

                return Result<Chapter>.Failure(new string[] { e.Message });
            }
        }

    }
}
