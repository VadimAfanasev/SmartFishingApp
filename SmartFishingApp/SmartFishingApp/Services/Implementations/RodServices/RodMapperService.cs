using Database.Context;
using Models.Dto.UserProfile.Rod;
using SmartFishingApp.Dto.UserProfile.Rod;
using SmartFishingApp.Models.Rod;
using SmartFishingApp.Services.Interfaces.IRodServices;

namespace SmartFishingApp.Services.Implementations.RodServices;

/// <inheritdoc />
public class RodMapperService : IRodMapperService
{
    /// <summary>
    ///     Контекст БД.
    /// </summary>
    private readonly AppDbContext _context;
    
    /// <summary>
    ///     Конструктор по умолчанию.
    /// </summary>
    /// <param name="context"> Контекст БД. </param>
    public RodMapperService(AppDbContext context)
    {
        _context = context;
    }
    
    /// <inheritdoc />
    public Rod CreationDtoToDomainModel(RodCreateDto createDto)
    {
        var rod = new Rod
        {
            Brand = createDto.Brand,
            Type = createDto.Type,
            Test = createDto.Test,
            Length = createDto.Length,
            Class = Enum.Parse(typeof(RodClassEnum), createDto.Class, true).ToString(),
            RodType = _context.RodType.FirstOrDefault(c=>c.Id == Convert.ToInt32(createDto.RodType)),
            TypeOfFishing = _context.TypeOfFishing.FirstOrDefault(c=>c.Id == Convert.ToInt32(createDto.TypeOfFishing)),
            Photo = createDto.Photo,
            Commentary =  createDto.Commentary
        };

        return rod;
    }
    
    /// <inheritdoc />
    public RodReadDto DomainModelToReadDto(Rod rod)
    {
        var rodOut = new RodReadDto
        {
            Id = rod.Id.ToString(),
            Brand = rod.Brand,
            Type  = rod.Type,
            Test = rod.Test,
            Length = rod.Length,
            Class = rod.Class,
            RodType  = rod.RodType?.Name,    
            TypeOfFishing =  rod.TypeOfFishing?.Name,
            Photo  = rod.Photo,
            Commentary  = rod.Commentary
        };
        
        return rodOut;
    }
    
    /// <inheritdoc />
    public List<RodReadDto> DomainModelToReadRodsDto(List<Rod> rods)
    {
        return rods.Select(rod => new RodReadDto
        {
            Id = rod.Id.ToString(),
            Brand = rod.Brand,
            Type = rod.Type,
            Test = rod.Test,
            Length = rod.Length,
            Class = rod.Class,
            RodType = rod.RodType?.Name,
            TypeOfFishing = rod.TypeOfFishing?.Name,
            Photo = rod.Photo,
            Commentary = rod.Commentary
        }).ToList();
    }

    /// <inheritdoc />
    public Rod UpdateDtoToDomainModel(RodUpdateDto updateDto)
    {
        var rod = new Rod
        {
            Id = Guid.Parse(updateDto.Id),
            Brand = updateDto.Brand,
            Type = updateDto.Type,
            Test = updateDto.Test,
            Length = updateDto.Length,
            Class = Enum.Parse(typeof(RodClassEnum), updateDto.Class, true).ToString(),
            RodType = _context.RodType.FirstOrDefault(c=>c.Id == Convert.ToInt32(updateDto.RodType)),
            TypeOfFishing = _context.TypeOfFishing.FirstOrDefault(c=>c.Id == Convert.ToInt32(updateDto.TypeOfFishing)),
            Photo = updateDto.Photo,
            Commentary =  updateDto.Commentary
        };

        return rod;
    }
}