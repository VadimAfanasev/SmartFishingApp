using Database.Context;
using Models.Dto.UserProfile.TackleCategory;
using Models.Entities.UserProfile.Tackle;
using SmartFishingApp.Dto.UserProfile.TackleCategory;
using SmartFishingApp.Services.Interfaces.ITackleCategoryServices;

namespace SmartFishingApp.Services.Implementations.TackleServices;

/// <inheritdoc />
public class TackleCategoryMapperService: ITackleCategoryMapperService
{
    /// <summary>
    ///     Контекст БД.
    /// </summary>
    private readonly AppDbContext _context;
    
    /// <summary>
    ///     Конструктор по умолчанию.
    /// </summary>
    /// <param name="context"> Контекст БД. </param>
    public TackleCategoryMapperService(AppDbContext context)
    {
        _context = context;
    }
    
    /// <inheritdoc />
    public TackleCategory CreationDtoToDomainModel(TackleCategoryCreateDto createDto)
    {
        var tackleCategory = new TackleCategory
        {
            Name = createDto.Name,
            TypeOfFishing = createDto.TypeOfFishing,
            Commentary =  createDto.Commentary
        };

        return tackleCategory;
    }

    /// <inheritdoc />
    public TackleCategoryReadDto DomainModelToTackleCategoryReadDto(TackleCategory tackleCategory)
    {
        var tackleCategoryOut = new TackleCategoryReadDto
        {
            Id = tackleCategory.Id.ToString(),
            Name = tackleCategory.Name,
            TypeOfFishing = tackleCategory.TypeOfFishing.Name,
            Commentary =  tackleCategory.Commentary
        };
        
        return tackleCategoryOut;
    }

    /// <inheritdoc />
    public List<TackleCategoryReadDto> DomainModelToTackleCategoriesReadDto(List<TackleCategory> tackleCategories)
    {
        return tackleCategories.Select(rod => new TackleCategoryReadDto
        {
            Id = rod.Id.ToString(),
            Name = rod.Name,
            TypeOfFishing = rod.TypeOfFishing.Name,
            Commentary =  rod.Commentary
        }).ToList();
    }

    /// <inheritdoc />
    public TackleCategory UpdateDtoToDomainModel(TackleCategoryUpdateDto updateDto)
    {
        var tackleCategory = new TackleCategory
        {
            Id = int.Parse(updateDto.Id),
            Name = updateDto.Name,
            TypeOfFishing = _context.TypeOfFishing.FirstOrDefault(c=>c.Id == int.Parse(updateDto.TypeOfFishing))!,
            Commentary =  updateDto.Commentary
        };

        return tackleCategory;
    }

    /// <inheritdoc />
    public TackleCategoryAttachmentReadDto DomainModelToReadTackleCategoryAttachmentDto(TackleCategoryAttachmentDto tackleCategory)
    {
        var tackleCategoryOut = new TackleCategoryAttachmentReadDto
        {
            Id = tackleCategory.Id.ToString(),
            Name = tackleCategory.Name,
            Commentary =  tackleCategory.Commentary,
            TackleBases = tackleCategory.Tackles.Select(c => new TackleBaseReadDto
            {
                Id = c.Id.ToString(),
                Name = c.Name,
                TackleCategory = c.TackleCategory,
                NozzleType = c.NozzleType,
                Brand = c.Brand,
                Model = c.Model,
                Photo = c.Photo,
                Commentary = c.Commentary
            }).ToList()
        };
        
        return tackleCategoryOut;
    }
}