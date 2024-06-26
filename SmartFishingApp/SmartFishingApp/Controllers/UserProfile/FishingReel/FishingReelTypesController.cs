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
    private readonly IFishingReelTypeMapperService _fishingReelTypeMapperService;
    
    /// <summary>
    ///     Сервис для работы с сущностью катушки.
    /// </summary>
    private readonly IFishingReelTypeService _fishingReelTypeService;
    
    /// <summary>
    ///     Конструктор.
    /// </summary>
    /// <param name="fishingReelTypeMapperService"> Сервис Маппинга сущностей FishingReelType. </param>
    /// <param name="fishingReelTypeService"> Сервис для работы с сущностями FishingReelType. </param>
    public FishingReelTypesController(IFishingReelTypeMapperService fishingReelTypeMapperService,
        IFishingReelTypeService fishingReelTypeService)
    {
        _fishingReelTypeMapperService = fishingReelTypeMapperService;
        _fishingReelTypeService = fishingReelTypeService;
    }
    
    /// <summary>
    ///     Создание типа рыболовных катушек.
    /// </summary>
    /// <param name="createDto"> Дто создаваемого типа. </param>
    [HttpPost]
    [Route("")]
    public async Task CreateReelAsync([FromQuery] FishingReelTypeCreateDto createDto)
    {
        var reel = _fishingReelTypeMapperService.CreationDtoToDomainModel(createDto);
        await _fishingReelTypeService.CreateFishingReelTypeAsync(reel);
    }
    
    /// <summary>
    ///     Удаление типа рыболовной катушки.
    /// </summary>
    /// <param name="id"> Id сущности. </param>
    [HttpDelete]
    [Route("")]
    public async Task DeleteReelTypeAsync([FromQuery] string id)
    {
        await _fishingReelTypeService.DeleteFishingReelTypeAsync(id);
    }
    
    /// <summary>
    ///     Получение одного экземпляра типа рыболовных катушек.
    /// </summary>
    /// <param name="id"> Id сущности. </param>
    /// <returns> DTO типа катушек. </returns>
    [HttpGet]
    [Route("")]
    public async Task<FishingReelTypeReadDto> GetReelTypeAsync([FromQuery] string id)
    {
        var fishingReel = await _fishingReelTypeService.GetFishingReelTypeAsync(id);
        return _fishingReelTypeMapperService.DomainModelToReadDto(fishingReel);
    }
    
    /// <summary>
    ///     Получение списка типов рыболовных катушек.
    /// </summary>
    /// <returns> Список DTO всех типов катушек.  </returns>
    [HttpGet]
    [Route("reelTypes")]
    public async Task<List<FishingReelTypeReadDto>> GetReelTypesAsync()
    {
        var fishingReelTypes = await _fishingReelTypeService.GetFishingReelTypesAsync();
        return _fishingReelTypeMapperService.DomainModelToReadReelTypesDto(fishingReelTypes);
    }
    
    /// <summary>
    ///     Получение типа катушки c катушками этого типа.
    /// </summary>
    /// <returns> DTO катушки c катушками этого типа.  </returns>
    [HttpGet]
    [Route("reelTypeAttachment")]
    public async Task<FishingReelTypeAttachmentReadDto> GetReelTypesAttachmentAsync([FromQuery] string id)
    {
        var fishingReelTypesAttachment = await _fishingReelTypeService.GetFishingReelTypesAttachmentAsync(id);
        return _fishingReelTypeMapperService.DomainModelToReadReelTypesAttachmentDto(fishingReelTypesAttachment);
    }
    
    /// <summary>
    ///     Получение списка рыболовных катушек по переданному типу катушек.
    /// </summary>
    /// <returns> Список DTO всех катушек данного типа.  </returns>
    [HttpGet]
    [Route("reels")]
    public async Task<FishingReelsReadDto> GetReelsAsync([FromQuery] string id)
    {
        var fishingReels = await _fishingReelTypeService.GetFishingReelsAsync(id);
        return _fishingReelTypeMapperService.DomainModelToReadReelsDto(fishingReels);
    }
}