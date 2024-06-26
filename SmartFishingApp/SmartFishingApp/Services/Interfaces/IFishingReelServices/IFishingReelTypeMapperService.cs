using Models.Dto.UserProfile.FishingReel;
using Models.Entities.UserProfile.FishingReel;
using SmartFishingApp.Dto.UserProfile.FishingReel;

namespace SmartFishingApp.Services.Interfaces;

/// <summary>
///     Итерфейс сервиса маппинга рыболовных катушек.
/// </summary>
public interface IFishingReelTypeMapperService
{
    /// <summary>
    ///     Создание доменной модели <see cref="FishingReelType" /> из <see cref="FishingReelTypeCreateDto" />.
    /// </summary>
    /// <param name="createDto"> Дто создаваемой сущности </param>
    /// <returns> <see cref="FishingReel" />. </returns>
    FishingReelType CreationDtoToDomainModel(FishingReelTypeCreateDto createDto);
    
    /// <summary>
    ///     Создание ДТО модели <see cref="FishingReelTypeReadDto" /> из <see cref="FishingReelType" />.
    /// </summary>
    /// <param name="fishingReel"> Доменная модель катушки. </param>
    /// <returns> <see cref="FishingReelReadDto" />. </returns>
    FishingReelTypeReadDto DomainModelToReadDto(FishingReelType fishingReel);
    
    /// <summary>
    ///     Создание списка ДТО моделей <see cref="FishingReelTypeReadDto" /> из списка <see cref="FishingReelType" />.
    /// </summary>
    /// <param name="fishingReels"> Список доменных моделей катушки. </param>
    /// <returns> Список <see cref="FishingReelReadDto" />. </returns>
    List<FishingReelTypeReadDto> DomainModelToReadReelTypesDto(List<FishingReelType> fishingReels);

    /// <summary>
    ///     Создание ДТО модели <see cref="FishingReelTypeAttachmentReadDto" /> из <see cref="FishingReelTypeAttachmentDto" />.
    /// </summary>
    /// <param name="attachmentDto"> Доменная модель типа катушки со списком катушек этого типа </param>
    /// <returns> <see cref="FishingReelTypeAttachmentReadDto" />. </returns>
    FishingReelTypeAttachmentReadDto DomainModelToReadReelTypesAttachmentDto(
        FishingReelTypeAttachmentDto attachmentDto);
    
    /// <summary>
    ///     Создание ДТО для отображения <see cref="FishingReelsReadDto" /> из <see cref="FishingReelsDto" />.
    /// </summary>
    /// <param name="fishingReelsDto"> Дто списка катушек. </param>
    /// <returns> <see cref="FishingReelsReadDto" />. </returns>
    FishingReelsReadDto DomainModelToReadReelsDto(FishingReelsDto fishingReelsDto);
}