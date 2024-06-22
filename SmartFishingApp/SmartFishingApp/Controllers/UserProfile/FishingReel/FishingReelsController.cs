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
    /// <inheritdoc />
    private readonly IFishingReelMapperService _fishingReelMapperService;

    public FishingReelsController(IFishingReelMapperService fishingReelMapperService)
    {
        fishingReelMapperService = _fishingReelMapperService;
    }
    
    [HttpPost]
    [Route("")]
    public async Task CreateReelAsync([FromBody] FishingReelCreateDto createDto)
    {
        var reel = _fishingReelMapperService.CreationDtoToDomainModel(createDto);
        await _fishingReelService.CreateAreasAsync(reel);
    }
}