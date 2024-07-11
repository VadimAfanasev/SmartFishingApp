using Microsoft.AspNetCore.Mvc;

namespace SmartFishingApp.Controllers.UserProfile.Tackle;

/// <summary>
///     Контроллер для работы с категориями рыболовных приманок.
/// </summary>
[Route("api/tackle-categories")]
public class TackleCategoriesController : ControllerBase
{
    /// <summary>
    ///     Сервис Маппинга сущностей категорий рыболовных приманок.
    /// </summary>
    private readonly ITackleCategoryMapperService _tackleCategoryMapperService;
    
    /// <summary>
    ///     Сервис для работы с категориями рыболовных приманок.
    /// </summary>
    private readonly ITackleCategoryService _tackleCategoryService;

    /// <summary>
    ///     Конструктор.
    /// </summary>
    /// <param name="tackleCategoryMapperService"> Сервис Маппинга сущностей категорий рыболовных приманок. </param>
    /// <param name="tackleCategoryService"> Сервис для работы с категориями рыболовных приманок. </param>
    public TackleCategoriesController(ITackleCategoryMapperService tackleCategoryMapperService, ITackleCategoryService tackleCategoryService)
    {
        _tackleCategoryMapperService = tackleCategoryMapperService;
        _tackleCategoryService = tackleCategoryService;
    }
    
    /// <summary>
    ///     Создание сущности рыболовного удилища.
    /// </summary>
    /// <param name="createDto"> Дто создаваемого объекта удилища </param>
    [HttpPost]
    public async Task CreateTackleCategoryAsync([FromQuery] TackleCategoryCreateDto createDto)
    {
        var reel = _tackleCategoryMapperService.CreationDtoToDomainModel(createDto);
        await _tackleCategoryService.CreateTackleCategoryAsync(reel);
    }
    
    /// <summary>
    ///     Удаление рыболовного удилища.
    /// </summary>
    /// <param name="id"> Id сущности. </param>
    [HttpDelete]
    public async Task DeleteTackleCategoryAsync([FromQuery] string id)
    {
        await _tackleCategoryService.DeleteTackleCategoryAsync(id);
    }
    
    /// <summary>
    ///     Получение одного экземпляра рыболовного удилища.
    /// </summary>
    /// <param name="id"> Id сущности. </param>
    /// <returns> DTO удилища. </returns>
    [HttpGet]
    public async Task<TackleCategoryReadDto> GetTackleCategoryAsync([FromQuery] string id)
    {
        var tackleCategory = await _tackleCategoryService.GetTackleCategoryAsync(id);
        return _tackleCategoryMapperService.DomainModelToReadDto(tackleCategory);
    }
}