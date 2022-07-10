using Scripture.Api.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripture.Api.Interfaces
{
    public interface IBookService
    {
        ValueTask<Book> GetAsync(string code, int translationId);
        ValueTask<ICollection<Book>> GetAsync(int translationId);
    }
}
