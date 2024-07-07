using Database.Context;
using Models.Entities.UserProfile.FishingReel;
using SmartFishingApp.Dto.UserProfile.FishingReel;
using SmartFishingApp.Services.Interfaces;

namespace SmartFishingApp.Services.Implementations.FishingReelServices;

/// <summary>
///     Сервис маппинга моделей катушек.
/// </summary>
public class FishingReelMapperService : IFishingReelMapperService
{
    /// <summary>
    ///     Контекст БД.
    /// </summary>
    private readonly AppDbContext _context;
    
    /// <summary>
    ///     Конструктор по умолчанию.
    /// </summary>
    /// <param name="context"> Контекст БД. </param>
    public FishingReelMapperService(AppDbContext context)
    {
        _context = context;
    }
    
    /// <inheritdoc />
    public FishingReel CreationDtoToDomainModel(FishingReelCreateDto createDto)
    {
        var fishingReel = new FishingReel
        {
            Brand = createDto.Brand,
            Type = createDto.Type,
            ReelType = _context.FishingReelType.FirstOrDefault(c=>c.Id == Convert.ToInt32(createDto.ReelType)),
            TypeOfFishing = _context.TypeOfFishing.FirstOrDefault(c=>c.Id == Convert.ToInt32(createDto.TypeOfFishing)),
            Photo = createDto.Photo,
            Commentary =  createDto.Commentary
        };

        return fishingReel;
    }
    
    /// <inheritdoc />
    public FishingReelReadDto DomainModelToReadDto(FishingReel fishingReel)
    {
        var fishingReelOut = new FishingReelReadDto
        {
            Id = fishingReel.Id.ToString(),
            Brand = fishingReel.Brand,
            Type  = fishingReel.Type,
            ReelType  = fishingReel.ReelType?.Name,    
            TypeOfFishing =  fishingReel.TypeOfFishing?.Name,
            Photo  = fishingReel.Photo,
            Commentary  = fishingReel.Commentary
        };
        
        return fishingReelOut;
    }
    
    /// <inheritdoc />
    public List<FishingReelReadDto> DomainModelToReadReelsDto(List<FishingReel> fishingReels)
    {
        return fishingReels.Select(fishingReel => new FishingReelReadDto
        {
            Id = fishingReel.Id.ToString(),
            Brand = fishingReel.Brand,
            Type = fishingReel.Type,
            ReelType = fishingReel.ReelType?.Name,
            TypeOfFishing = fishingReel.TypeOfFishing?.Name,
            Photo = fishingReel.Photo,
            Commentary = fishingReel.Commentary
        }).ToList();
    }

    /// <inheritdoc />
    public FishingReel UpdateDtoToDomainModel(FishingReelUpdateDto updateDto)
    {
        var fishingReel = new FishingReel
        {
            Id = Guid.Parse(updateDto.Id),
            Brand = updateDto.Brand,
            Type = updateDto.Type,
            ReelType = _context.FishingReelType.FirstOrDefault(c=>c.Id == Convert.ToInt32(updateDto.ReelType)),
            TypeOfFishing = _context.TypeOfFishing.FirstOrDefault(c=>c.Id == Convert.ToInt32(updateDto.TypeOfFishing)),
            Photo = updateDto.Photo,
            Commentary =  updateDto.Commentary
        };

        return fishingReel;
    }
}