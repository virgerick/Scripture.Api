using Microsoft.AspNetCore.Mvc;

using Scripture.Api.Interfaces;
using Scripture.Api.Models;

namespace Scripture.Api.Controllers;

public class TranslationsController : ApiControllerBase
{
    private readonly ILogger<TranslationsController> _logger;
    private readonly ITranslationService _translationService;

    public TranslationsController(ILogger<TranslationsController> logger, ITranslationService translationService)
    {
        _logger = logger;
        _translationService = translationService;
    }


    [HttpGet]
    public async Task<List<TranslationDto>> GetAsync()
    {
        return await _translationService.GetAsync();
    }
    [HttpGet("{id}")]
    public async Task<TranslationDto> Get(int id)
    {

        return await _translationService.GetAsync(id);
    }

    [HttpGet("[action]/{name}")]
    public async Task<TranslationDto> GetByName(string name)
    {

        return await _translationService.GetAsync(name);
    }
}

