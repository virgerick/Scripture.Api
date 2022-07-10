using Scripture.Api.Models;

namespace Scripture.Api.Interfaces;

public interface IBookService
{
    ValueTask<Book> GetAsync(string code, int translationId);
    ValueTask<ICollection<Book>> GetAsync(int translationId);
}
