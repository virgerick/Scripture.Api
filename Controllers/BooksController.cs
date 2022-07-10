using Microsoft.AspNetCore.Mvc;

using Scripture.Api.Interfaces;
using Scripture.Api.Models;
using Scripture.Api.ValueObjects;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripture.Api.Controllers
{
    public class BooksController:ApiControllerBase
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }
        [HttpGet("[action]")]
        public async Task<Book> GetBookByCode(string code, int translationId)
        {
             var result=await _bookService.GetAsync(code, translationId);
            return result;
        }
        [HttpGet]
        public async Task<ICollection<Book>> GetBooks( int translationId)
        {
             var result=await _bookService.GetAsync( translationId);
            return result;
        }
        [HttpGet("[action]")]
        public async Task<ICollection<BookType>> GetBookTypes( int translationId)
        {
             var result=await _bookService.GetAsync( translationId);
            return result.Select(b=>b.Type).ToList();
        }
    }
}
