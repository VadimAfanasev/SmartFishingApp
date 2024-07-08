using Database.Context;
using Models.Dto.UserProfile.Rod;
using SmartFishingApp.Dto.UserProfile.Rod;
using SmartFishingApp.Models.Rod;
using SmartFishingApp.Services.Interfaces.IRodServices;

namespace SmartFishingApp.Services.Implementations.RodServices;

/// <summary>
///     Сервис маппинга типов удилищ.
/// </summary>
public class RodTypeMapperService : IRodTypeMapperService
{
    /// <summary>
    ///     Контекст БД.
    /// </summary>
    private readonly AppDbContext _context;
    
    /// <summary>
    ///     Конструктор по умолчанию.
    /// </summary>
    /// <param name="context"> Контекст БД. </param>
    public RodTypeMapperService(AppDbContext context)
    {
        _context = context;
    }
    
    /// <inheritdoc />
    public RodType CreationDtoToDomainModel(RodTypeCreateDto createDto)
    {
        var rodType = new RodType
        {
            Name = createDto.Name,
            Commentary =  createDto.Commentary
        };

        return rodType;
    }
    
    /// <inheritdoc />
    public RodTypeReadDto DomainModelToReadDto(RodType rod)
    {
        var rodTypeOut = new RodTypeReadDto
        {
            Id = rod.Id.ToString(),
            Name = rod.Name,
            Commentary =  rod.Commentary
        };
        
        return rodTypeOut;
    }
    
    /// <inheritdoc />
    public List<RodTypeReadDto> DomainModelToReadReelTypesDto(List<RodType> rodTypes)
    {
        return rodTypes.Select(rod => new RodTypeReadDto
        {
            Id = rod.Id.ToString(),
            Name = rod.Name,
            Commentary =  rod.Commentary
        }).ToList();
    }
    
    /// <inheritdoc />
    public RodTypeAttachmentReadDto DomainModelToReadReelTypesAttachmentDto(
        RodTypeAttachmentDto attachmentDto)
    {
        var readDto = new RodTypeAttachmentReadDto
        {
            Id = attachmentDto.Id,
            Name = attachmentDto.Name,
            Commentary = attachmentDto.Commentary,
            Rods = attachmentDto.Rods.Select(c => new RodReadDto
            {
                Brand = c.Brand,
                Type = c.Type,
                RodType = c.RodType.Name,
                TypeOfFishing = c.TypeOfFishing.Name,
                Photo = c.Photo,
                Commentary = c.Commentary
            }).ToList()
        };

        return readDto;
    }

    /// <inheritdoc />
    public RodsReadDto DomainModelToReadReelsDto(RodsDto rodsDto)
    {
        var readDto = new RodsReadDto
        {
            Rods = rodsDto
        };
        return readDto;
    }

    /// <inheritdoc />
    public RodType UpdateDtoToDomainModel(RodTypeUpdateDto updateDto)
    {
        var rodType = new RodType
        {
            Id = int.Parse(updateDto.Id),
            Name = updateDto.Name,
            Commentary =  updateDto.Commentary
        };

        return rodType;
    }
}