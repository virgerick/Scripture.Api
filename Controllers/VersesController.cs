using Microsoft.AspNetCore.Mvc;

using Scripture.Api.Interfaces;
using Scripture.Api.Models;

using System.Linq;

namespace Scripture.Api.Controllers
{
    public class VersesController : ApiControllerBase
    {
        private readonly ILogger<VersesController> _logger;
        private readonly IVerseService _verseService;

        public VersesController(ILogger<VersesController> logger, IVerseService verseService)
        {
            _logger = logger;
            _verseService = verseService;
        }
        [HttpGet("{idTranslation}")]
        public  async Task<ICollection<Verse>> GetByIdAsync(int idTranslation)
        {
            var result= await _verseService.GetByIdAsync(idTranslation);
            return result.Take(10).Skip(0).ToList();
        }
    }
}
