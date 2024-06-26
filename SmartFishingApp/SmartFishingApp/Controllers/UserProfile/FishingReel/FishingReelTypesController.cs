using Interfaces.UserProfile.FishingReel;
using Microsoft.AspNetCore.Mvc;
using SmartFishingApp.Dto.UserProfile.FishingReel;
using SmartFishingApp.Services.Interfaces;

namespace SmartFishingApp.Controllers.UserProfile.FishingReel;

/// <summary>
///     Контроллер для работы с рыболовными катушками.
/// </summary>
[Route("api/reelTypes")]
public class FishingReelTypesController : ControllerBase
{
    /// <summary>
    ///     Сервис Маппинга сущностей FishingReel.
    /// </summary>
    private readonly IFishingReelTypeMapperService _fishingReelMapperService;
    
    /// <summary>
    ///     Сервис для работы с сущностью катушки.
    /// </summary>
    private readonly IFishingReelTypeService _fishingReelService;
    
    /// <summary>
    ///     Конструктор.
    /// </summary>
    /// <param name="fishingReelMapperService"> Сервис Маппинга сущностей FishingReel. </param>
    /// <param name="fishingReelService"> Сервис для работы с сущностями FishingReel. </param>
    public FishingReelTypesController(IFishingReelTypeMapperService fishingReelTypeMapperService,
        IFishingReelTypeService fishingReelTypeService)
    {
        _fishingReelTypeMapperService = fishingReelTypeMapperService;
        _fishingReelTypeService = fishingReelTypeService;
    }
    
    /// <summary>
    ///     Создание сущности рыболовной катушки.
    /// </summary>
    /// <param name="createDto"> Дто создаваемого объекта катушки </param>
    [HttpPost]
    [Route("")]
    public async Task CreateReelAsync([FromBody] FishingReelTypeCreateDto createDto)
    {
        var reel = _fishingReelTypeMapperService.CreationDtoToDomainModel(createDto);
        await _fishingReelTypeService.CreateFishingReelTypeAsync(reel);
    }
    
    /// <summary>
    ///     Удаление рыболовной катушки.
    /// </summary>
    /// <param name="id"> Id сущности. </param>
    [HttpDelete]
    [Route("")]
    public async Task DeleteReelAsync([FromQuery] string id)
    {
        await _fishingReelTypeService.DeleteFishingReelTypeAsync(id);
    }
    
    /// <summary>
    ///     Получение одного экземпляра рыболовной катушки.
    /// </summary>
    /// <param name="id"> Id сущности. </param>
    /// <returns> DTO катушки. </returns>
    [HttpGet]
    [Route("")]
    public async Task<FishingReelTypeReadDto> GetReelTypeAsync([FromQuery] string id)
    {
        var fishingReel = await _fishingReelTypeService.GetFishingReelAsync(id);
        return _fishingReelTypeMapperService.DomainModelToReadDto(fishingReel);
    }
    
    /// <summary>
    ///     Получение списка рыболовных катушек.
    /// </summary>
    /// <returns> Список DTO всех катушек.  </returns>
    [HttpGet]
    [Route("reelTypes")]
    public async Task<List<FishingReelTypeReadDto>> GetReelsAsync()
    {
        var fishingReelTypes = await _fishingReelTypeService.GetFishingReelsAsync();
        return _fishingReelTypeMapperService.DomainModelToReadReelsDto(fishingReelTypes);
    }

    // Помимо основных CRUD, нужен эндпоинт на получение типа катушки со списком катушек этого типа.
}