using Database.Context;
using Models.UserProfile.FishingReel;
using SmartFishingApp.Dto.UserProfile.FishingReel;
using SmartFishingApp.Services.Interfaces;

namespace SmartFishingApp.Services.Implementations.FishingReelServices;

/// <summary>
///     Сервис маппинга типов катушек.
/// </summary>
public class FishingReelTypeMapperService : IFishingReelTypeMapperService
{
    /// <summary>
    ///     Контекст БД.
    /// </summary>
    private readonly AppDbContext _context;
    
    /// <summary>
    ///     Конструктор по умолчанию.
    /// </summary>
    /// <param name="context"> Контекст БД. </param>
    public FishingReelTypeMapperService(AppDbContext context)
    {
        _context = context;
    }
    
    /// <inheritdoc />
    public FishingReelType CreationDtoToDomainModel(FishingReelTypeCreateDto createDto)
    {
        var fishingReelType = new FishingReelType
        {
            Name = createDto.Name,
            Commentary =  createDto.Commentary
        };

        return fishingReelType;
    }
    
    /// <inheritdoc />
    public FishingReelTypeReadDto DomainModelToReadDto(FishingReelType fishingReel)
    {
        var fishingReelTypeOut = new FishingReelTypeReadDto
        {
            Name = fishingReel.Name,
            Commentary =  fishingReel.Commentary
        };
        
        return fishingReelTypeOut;
    }
    
    /// <inheritdoc />
    public List<FishingReelTypeReadDto> DomainModelToReadReelTypesDto(List<FishingReelType> fishingReelTypes)
    {
        return fishingReelTypes.Select(fishingReel => new FishingReelTypeReadDto
        {
            Name = fishingReel.Name,
            Commentary =  fishingReel.Commentary
        }).ToList();
    }
}