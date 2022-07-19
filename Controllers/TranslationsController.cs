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
    public async Task<ResultList<TranslationDto>> GetAsync()
    {
        try
        {
            var result = await _translationService.GetAsync();
            return ResultList<TranslationDto>.Success(result);
        }
        catch (Exception e)
        {

            return ResultList<TranslationDto>.Failure(new string[] { e.Message });
        }

    }
    [HttpGet("{id}")]
    public async Task<Result<TranslationDto>> Get(int id)
    {
        try
        {
            var result = await _translationService.GetAsync(id);
            return Result<TranslationDto>.Success(result);
        }
        catch (Exception e)
        {

            return Result<TranslationDto>.Failure(new string[] { e.Message });
        }

    }

    [HttpGet("[action]/{name}")]
    public async Task<Result<TranslationDto>> GetByName(string name)
    {


        try
        {
            var result = await _translationService.GetAsync(name);
            return Result<TranslationDto>.Success(result);
        }
        catch (Exception e)
        {

            return Result<TranslationDto>.Failure(new string[] { e.Message });
        }
    }

    [HttpGet("[action]/{language}")]
    public async Task<ResultList<TranslationDto>> GetByLanguage(string language)
    {
        try
        {
            var result = await _translationService.GetByLanguageAsync(language);
            return ResultList<TranslationDto>.Success(result);
        }
        catch (Exception e)
        {

            return ResultList<TranslationDto>.Failure(new string[] { e.Message });
        }
    }
}

