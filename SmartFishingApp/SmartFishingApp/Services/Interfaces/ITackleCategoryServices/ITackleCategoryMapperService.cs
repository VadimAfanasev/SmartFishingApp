using Models.Entities.UserProfile.Tackle;
using SmartFishingApp.Dto.UserProfile.TackleCategory;

namespace SmartFishingApp.Services.Interfaces.ITackleCategoryServices;

/// <summary>
///     Итерфейс сервиса маппинга сущностей категории рыболовной приманки.
/// </summary>
public interface ITackleCategoryMapperService
{
    /// <summary>
    ///     Создание доменной модели <see cref="TackleCategory" /> из <see cref="TackleCategoryCreateDto" />.
    /// </summary>
    /// <param name="createDto"> Дто создаваемой сущности </param>
    /// <returns> <see cref="TackleCategory" />. </returns>
    TackleCategory CreationDtoToDomainModel(TackleCategoryCreateDto createDto);
    
    /// <summary>
    ///     Создание ДТО модели <see cref="TackleCategoryReadDto" /> из <see cref="TackleCategory" />.
    /// </summary>
    /// <param name="tackleCategory"> Доменная модель категории рыболовной приманки. </param>
    /// <returns> <see cref="TackleCategoryReadDto" />. </returns>
    TackleCategoryReadDto DomainModelToReadDto(TackleCategory tackleCategory);
}