using Models.Entities.UserProfile.Tackle;
using SmartFishingApp.Dto.UserProfile.TackleCategory;
using SmartFishingApp.Services.Interfaces.ITackleCategoryServices;

namespace SmartFishingApp.Services.Implementations.TackleServices;

/// <inheritdoc />
public class TackleCategoryMapperService: ITackleCategoryMapperService
{
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
    public TackleCategoryReadDto DomainModelToReadDto(TackleCategory tackleCategory)
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
}