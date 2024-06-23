using Interfaces.UserProfile.FishingReel;
using SmartFishingApp.Services.Interfaces;

namespace SmartFishingApp.Controllers.UserProfile.FishingReel;

using Microsoft.AspNetCore.Mvc;
using SmartFishingApp.Dto.UserProfile.FishingReel;

/// <inheritdoc />
/// <summary>
///     Контроллер рыболовных катушек
/// </summary>
[Route("api/reels")]
public class FishingReelsController : ControllerBase
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
    public FishingReelsController(IFishingReelMapperService fishingReelMapperService,
        IFishingReelService fishingReelService)
    {
        _fishingReelMapperService = fishingReelMapperService;
        _fishingReelService = fishingReelService;
    }
    
    [HttpPost]
    [Route("")]
    public async Task CreateReelAsync([FromBody] FishingReelCreateDto createDto)
    {
        var reel = _fishingReelMapperService.CreationDtoToDomainModel(createDto);
        await _fishingReelService.CreateAreasAsync(reel);
    }
}