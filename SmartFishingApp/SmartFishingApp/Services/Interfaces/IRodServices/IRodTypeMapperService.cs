using Models.Dto.UserProfile.Rod;
using SmartFishingApp.Dto.UserProfile.Rod;
using SmartFishingApp.Models.Rod;

namespace SmartFishingApp.Services.Interfaces.IRodServices;

/// <summary>
///     Итерфейс сервиса маппинга рыболовных удилищ.
/// </summary>
public interface IRodTypeMapperService
{
    /// <summary>
    ///     Создание доменной модели <see cref="RodType" /> из <see cref="RodTypeCreateDto" />.
    /// </summary>
    /// <param name="createDto"> Дто создаваемой сущности </param>
    /// <returns> <see cref="Rod" />. </returns>
    RodType CreationDtoToDomainModel(RodTypeCreateDto createDto);
    
    /// <summary>
    ///     Создание ДТО модели <see cref="RodTypeReadDto" /> из <see cref="RodType" />.
    /// </summary>
    /// <param name="rod"> Доменная модель удилища. </param>
    /// <returns> <see cref="RodReadDto" />. </returns>
    RodTypeReadDto DomainModelToReadDto(RodType rod);
    
    /// <summary>
    ///     Создание списка ДТО моделей <see cref="RodTypeReadDto" /> из списка <see cref="RodType" />.
    /// </summary>
    /// <param name="rods"> Список доменных моделей удилищ. </param>
    /// <returns> Список <see cref="RodReadDto" />. </returns>
    List<RodTypeReadDto> DomainModelToReadReelTypesDto(List<RodType> rods);

    /// <summary>
    ///     Создание ДТО модели <see cref="RodTypeAttachmentReadDto" /> из <see cref="RodTypeAttachmentDto" />.
    /// </summary>
    /// <param name="attachmentDto"> Доменная модель типа удилища со списком удилищ этого типа </param>
    /// <returns> <see cref="RodTypeAttachmentReadDto" />. </returns>
    RodTypeAttachmentReadDto DomainModelToReadReelTypesAttachmentDto(
        RodTypeAttachmentDto attachmentDto);
    
    /// <summary>
    ///     Создание ДТО для отображения <see cref="RodsReadDto" /> из <see cref="RodsDto" />.
    /// </summary>
    /// <param name="rodsDto"> Дто списка удилищ. </param>
    /// <returns> <see cref="RodsReadDto" />. </returns>
    RodsReadDto DomainModelToReadReelsDto(RodsDto rodsDto);
    
    /// <summary>
    ///     Редактирование доменной модели <see cref="RodType" />. />.
    /// </summary>
    /// <param name="updateDto"> Дто изменяемого типа удилища </param>
    /// <returns> <see cref="RodType" />. </returns>
    RodType UpdateDtoToDomainModel(RodTypeUpdateDto updateDto);
}