using Database.Context;
using Models.UserProfile.FishingReel;
using SmartFishingApp.Dto.UserProfile.FishingReel;
using SmartFishingApp.Services.Interfaces;

namespace SmartFishingApp.Services.Implementations.FishingReelServices;

/// <summary>
///     Сервис маппинга типов катушек.
/// </summary>
public class FishingReelTypeMapperService : IFishingReelMapperService
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
        var fishingReel = new FishingReelType
        {
            Brand = createDto.Brand,
            Type = createDto.Type,
            ReelType = _context.FishingReelType.FirstOrDefault(c=>c.Id == Convert.ToInt32(createDto.ReelType)),
            TypeOfFishing = _context.TypeOfFishing.FirstOrDefault(c=>c.Id == Convert.ToInt32(createDto.TypeOfFishing)),
            Photo = createDto.Photo,
            Commentary =  createDto.Commentary
        };

        return fishingReelType;
    }
    
    /// <inheritdoc />
    public FishingReelTypeReadDto DomainModelToReadDto(FishingReelType fishingReel)
    {
        var fishingReelOut = new FishingReelTypeReadDto
        {
            Brand = fishingReel.Brand,
            Type  = fishingReel.Type,
            ReelType  = fishingReel.ReelType?.Name,    
            TypeOfFishing =  fishingReel.TypeOfFishing?.Name,
            Photo  = fishingReel.Photo,
            Commentary  = fishingReel.Commentary
        };
        
        return fishingReelTypeOut;
    }
    
    /// <inheritdoc />
    public List<FishingReelTypeReadDto> DomainModelToReadReelTypesDto(List<FishingReelType> fishingReelTypes)
    {
        return fishingReelTypes.Select(fishingReel => new FishingReelTypeReadDto
        {
            Brand = fishingReel.Brand,
            Type = fishingReel.Type,
            ReelType = fishingReel.ReelType?.Name,
            TypeOfFishing = fishingReel.TypeOfFishing?.Name,
            Photo = fishingReel.Photo,
            Commentary = fishingReel.Commentary
        }).ToList();
    }
}