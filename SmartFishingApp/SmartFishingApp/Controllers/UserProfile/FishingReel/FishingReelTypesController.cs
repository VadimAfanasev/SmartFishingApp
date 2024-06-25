using Microsoft.AspNetCore.Mvc;

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
    private readonly IFishingReelMapperService _fishingReelMapperService;
    
    /// <summary>
    ///     Сервис для работы с сущностью катушки.
    /// </summary>
    private readonly IFishingReelService _fishingReelService;
    
    /// <summary>
    ///     Конструктор.
    /// </summary>
    /// <param name="fishingReelMapperService"> Сервис Маппинга сущностей FishingReel. </param>
    /// <param name="fishingReelService"> Сервис для работы с сущностями FishingReel. </param>
    public FishingReelTypesController(IFishingReelMapperService fishingReelMapperService,
        IFishingReelService fishingReelService)
    {
        _fishingReelMapperService = fishingReelMapperService;
        _fishingReelService = fishingReelService;
    }
    
    /// <summary>
    ///     Создание сущности рыболовной катушки.
    /// </summary>
    /// <param name="createDto"> Дто создаваемого объекта катушки </param>
    [HttpPost]
    [Route("")]
    public async Task CreateReelAsync([FromBody] FishingReelCreateDto createDto)
    {
        var reel = _fishingReelMapperService.CreationDtoToDomainModel(createDto);
        await _fishingReelService.CreateFishingReelAsync(reel);
    }
    
    /// <summary>
    ///     Удаление рыболовной катушки.
    /// </summary>
    /// <param name="id"> Id сущности. </param>
    [HttpDelete]
    [Route("")]
    public async Task DeleteReelAsync([FromQuery] string id)
    {
        await _fishingReelService.DeleteFishingReelAsync(id);
    }
    
    /// <summary>
    ///     Получение одного экземпляра рыболовной катушки.
    /// </summary>
    /// <param name="id"> Id сущности. </param>
    /// <returns> DTO катушки. </returns>
    [HttpGet]
    [Route("")]
    public async Task<FishingReelReadDto> GetReelAsync([FromQuery] string id)
    {
        var fishingReel = await _fishingReelService.GetFishingReelAsync(id);
        return _fishingReelMapperService.DomainModelToReadDto(fishingReel);
    }
    
    /// <summary>
    ///     Получение списка рыболовных катушек.
    /// </summary>
    /// <returns> Список DTO всех катушек.  </returns>
    [HttpGet]
    [Route("reels")]
    public async Task<List<FishingReelReadDto>> GetReelsAsync()
    {
        var fishingReels = await _fishingReelService.GetFishingReelsAsync();
        return _fishingReelMapperService.DomainModelToReadReelsDto(fishingReels);
    }

    // Помимо основных CRUD, нужен эндпоинт на получение типа катушки со списком катушек этого типа.
}