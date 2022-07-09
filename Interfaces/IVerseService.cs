using Scripture.Api.Models;

namespace Scripture.Api.Interfaces
{
    public interface IVerseService
    {

        ValueTask<ICollection<Verse>> GetByIdAsync(int idTranslation);
    }
}
