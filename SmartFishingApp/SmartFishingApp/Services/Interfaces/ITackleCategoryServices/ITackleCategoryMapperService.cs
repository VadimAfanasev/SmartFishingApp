using Models.Dto.UserProfile.TackleCategory;
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
    TackleCategoryReadDto DomainModelToTackleCategoryReadDto(TackleCategory tackleCategory);
    
    /// <summary>
    ///     Создание списка ДТО моделей <see cref="TackleCategoryReadDto" /> из <see cref="TackleCategory" />.
    /// </summary>
    /// <param name="tackleCategory"> Список доменных моделей категорий рыболовных приманок. </param>
    /// <returns> Список <see cref="TackleCategoryReadDto" />. </returns>
    List<TackleCategoryReadDto> DomainModelToTackleCategoriesReadDto(List<TackleCategory> tackleCategory);
    
    /// <summary>
    ///     Редактирование доменной модели <see cref="TackleCategory" />. />.
    /// </summary>
    /// <param name="updateDto"> Дто изменяемой категории рыболовной приманки </param>
    /// <returns> <see cref="TackleCategory" />. </returns>
    TackleCategory UpdateDtoToDomainModel(TackleCategoryUpdateDto updateDto);

    /// <summary>
    ///     Создание ДТО модели <see cref="TackleCategoryAttachmentReadDto" /> из <see cref="TackleCategoryAttachmentDto" />.
    /// </summary>
    /// <param name="tackleCategory"> Доменная модель типа удилища со списком удилищ этого типа </param>
    /// <returns> <see cref="TackleCategoryAttachmentReadDto" />. </returns>
    TackleCategoryAttachmentReadDto DomainModelToReadTackleCategoryAttachmentDto(TackleCategoryAttachmentDto tackleCategory);
}