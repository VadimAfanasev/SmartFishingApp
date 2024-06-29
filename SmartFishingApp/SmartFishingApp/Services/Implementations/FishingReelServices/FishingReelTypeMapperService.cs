using Database.Context;
using Models.Dto.UserProfile.FishingReel;
using Models.Entities.UserProfile.FishingReel;
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
    
    /// <inheritdoc />
    public FishingReelTypeAttachmentReadDto DomainModelToReadReelTypesAttachmentDto(
        FishingReelTypeAttachmentDto attachmentDto)
    {
        var readDto = new FishingReelTypeAttachmentReadDto
        {
            Name = attachmentDto.Name,
            Commentary = attachmentDto.Commentary,
            FishingReels = attachmentDto.FishingReels.Select(c => new FishingReelReadDto
            {
                Brand = c.Brand,
                Type = c.Type,
                ReelType = c.ReelType.Name,
                TypeOfFishing = c.TypeOfFishing.Name,
                Photo = c.Photo,
                Commentary = c.Commentary
            }).ToList()
        };

        return readDto;
    }

    /// <inheritdoc />
    public FishingReelsReadDto DomainModelToReadReelsDto(FishingReelsDto fishingReelsDto)
    {
        var readDto = new FishingReelsReadDto
        {
            FishingReels = fishingReelsDto
        };
        return readDto;
    }
}