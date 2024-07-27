using Interfaces.UserProfile.Tackle;
using Microsoft.AspNetCore.Mvc;
using Models.Dto.UserProfile.TackleCategory;
using SmartFishingApp.Dto.UserProfile.TackleCategory;
using SmartFishingApp.Services.Interfaces.ITackleCategoryServices;

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
    ///     Создание категории рыболовных приманок.
    /// </summary>
    /// <param name="createDto"> Дто создаваемого объекта категории рыболовных приманок. </param>
    [HttpPost]
    public async Task CreateTackleCategoryAsync([FromQuery] TackleCategoryCreateDto createDto)
    {
        var reel = _tackleCategoryMapperService.CreationDtoToDomainModel(createDto);
        await _tackleCategoryService.CreateTackleCategoryAsync(reel);
    }
    
    /// <summary>
    ///     Удаление категории рыболовных приманок.
    /// </summary>
    /// <param name="id"> Id сущности. </param>
    [HttpDelete]
    public async Task DeleteTackleCategoryAsync([FromQuery] string id)
    {
        await _tackleCategoryService.DeleteTackleCategoryAsync(id);
    }
    
    /// <summary>
    ///     Получение категории рыболовных приманок по Id.
    /// </summary>
    /// <param name="id"> Id сущности. </param>
    /// <returns> DTO категории рыболовных приманок. </returns>
    [HttpGet]
    public async Task<TackleCategoryReadDto> GetTackleCategoryAsync([FromQuery] string id)
    {
        var tackleCategory = await _tackleCategoryService.GetTackleCategoryAsync(id);
        return _tackleCategoryMapperService.DomainModelToTackleCategoryReadDto(tackleCategory);
    }
    
    /// <summary>
    ///     Получение списка категорий рыболовных приманок.
    /// </summary>
    /// <returns> Список DTO категории рыболовных приманок. </returns>
    [HttpGet]
    [Route("tackle-categories")]
    public async Task<List<TackleCategoryReadDto>> GetTackleCategoriesAsync()
    {
        var tackleCategories = await _tackleCategoryService.GetTackleCategoriesAsync();
        return _tackleCategoryMapperService.DomainModelToTackleCategoriesReadDto(tackleCategories);
    }
    
    /// <summary>
    ///     Редактирование категории рыболовных приманок.
    /// </summary>
    /// <param name="updateDto"> Dto для редактирования категории рыболовных приманок. </param>
    [HttpPut]
    public async Task UpdateTackleCategoryAsync([FromQuery] TackleCategoryUpdateDto updateDto)
    {
        var updateRod = _tackleCategoryMapperService.UpdateDtoToDomainModel(updateDto);
        await _tackleCategoryService.UpdateTackleCategoryAsync(updateRod);
    }
    
    /// <summary>
    ///     Получение всех приманок, соответсвующих данной категории.
    /// </summary>
    /// <param name="id"> Id категории. </param>
    /// <returns> Список приманок. </returns>
    [HttpGet]
    [Route("tackles-from-categories")]
    public async Task<TackleCategoryAttachmentReadDto> GetTacklesFromCategoryAsync([FromQuery] string id)
    {
        var tackleCategory = await _tackleCategoryService.GetTackleCategoryAttachmentAsync(id);
        return _tackleCategoryMapperService.DomainModelToReadTackleCategoryAttachmentDto(tackleCategory);
    }
}