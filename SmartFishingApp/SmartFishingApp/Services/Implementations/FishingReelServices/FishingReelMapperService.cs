using Database.Context;
using Models.UserProfile.FishingReel;
using SmartFishingApp.Dto.UserProfile.FishingReel;
using SmartFishingApp.Services.Interfaces;

namespace SmartFishingApp.Services.Implementations.FishingReelServices;

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
            ReelType = _context.FishingReelType.FirstOrDefault(c=>c.Id == int.Parse(createDto.ReelType)),
            TypeOfFishing = _context.TypeOfFishing.FirstOrDefault(c=>c.Id == int.Parse(createDto.TypeOfFishing)),
            Photo = createDto.Photo,
            Commentary =  createDto.Commentary
        };

        return fishingReel;
    }
}