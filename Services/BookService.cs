using Scripture.Api.Interfaces;
using Scripture.Api.Models;
using Scripture.Api.ValueObjects;

namespace Scripture.Api.Services
{
    public class BookService : IBookService
    {
        private readonly IVerseService _verseService;

        public BookService(IVerseService verseService)
        {
            _verseService = verseService;
        }

        public async ValueTask<Book> GetAsync(string code, int translationId)
        { 
            var verses = await _verseService.GetByIdAsync(translationId);
            /*var type = BookType.From(code);
            var book = new Book { TranslationId = translationId, Type = type, Chapters = new List<Chapter>() };

           

            foreach (var verse in verses.Where(x => x.Book == code))
            {
                var chapter = book.Chapters.FirstOrDefault(c => c.Number == verse.Chapter);
                bool isANewChapter = chapter == null;
                if (isANewChapter)
                    chapter = new Chapter { Number = verse.Chapter, Verses = new List<string>() };
                chapter.Verses.Add(verse.Text);

                if (isANewChapter)
                    book.Chapters.Add(chapter);
            }
            return book;*/
            return BookBuilder(verses, code, translationId);
        }

        public async ValueTask<ICollection<Book>> GetAsync(int translationId)
        {
            var books=new List<Book>();
            var verses = await _verseService.GetByIdAsync(translationId);
            foreach (var verse in verses.DistinctBy(x=>x.Book))
            {
                var book = BookBuilder(verses, verse.Book,verse.TranslationId);
                books.Add(book);    
            }

            return books;
        }
        private Book BookBuilder(ICollection<Verse> verses,string code, int translationId)
        {
            var type = BookType.From(code);
            var book = new Book { TranslationId=translationId, Type = type, Chapters = new List<Chapter>() };
            foreach (var verse in verses.Where(x => x.Book == code))
            {
                var chapter = book.Chapters.FirstOrDefault(c => c.Number == verse.Chapter);
                bool isANewChapter = chapter == null;
                if (isANewChapter)
                    chapter = new Chapter { Number = verse.Chapter, Verses = new List<string>() };
                chapter.Verses.Add(verse.Text);

                if (isANewChapter)
                    book.Chapters.Add(chapter);
            }
            return book;

        }
    }
}
