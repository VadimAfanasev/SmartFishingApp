using Models.UserProfile.FishingReel;
using SmartFishingApp.Dto.UserProfile.FishingReel;

namespace SmartFishingApp.Services.Interfaces;

/// <summary>
///     Итерфейс сервиса маппинга рыболовных катушек.
/// </summary>
public interface IFishingReelMapperService
{
    /// <summary>
    ///     Создание доменной модели <see cref="FishingReel" /> из <see cref="FishingReelCreateDto" />.
    /// </summary>
    /// <param name="createDto"> Дто создаваемой сущности </param>
    /// <returns> <see cref="FishingReel" />. </returns>
    FishingReel CreationDtoToDomainModel(FishingReelCreateDto createDto);
    
    /// <summary>
    ///     Создание ДТО модели <see cref="FishingReelReadDto" /> из <see cref="FishingReel" />.
    /// </summary>
    /// <param name="fishingReel"> Доменная модель катушки. </param>
    /// <returns> <see cref="FishingReelReadDto" />. </returns>
    FishingReelReadDto DomainModelToReadDto(FishingReel fishingReel);
    
    /// <summary>
    ///     Создание списка ДТО моделей <see cref="FishingReelReadDto" /> из списка <see cref="FishingReel" />.
    /// </summary>
    /// <param name="fishingReels"> Список доменных моделей катушки. </param>
    /// <returns> Список <see cref="FishingReelReadDto" />. </returns>
    List<FishingReelReadDto> DomainModelToReadReelsDto(List<FishingReel> fishingReels);
    
    /// <summary>
    ///     Создание ДТО модели <see cref="FishingReelAttachmentReadDto" /> из <see cref="FishingReel" />
    /// </summary>
    /// <param name="fishingReelAttachment"> Катушка с вложенными сущностями. </param>
    /// <returns> <see cref="FishingReelAttachmentReadDto" />. </returns>
    FishingReelAttachmentReadDto DomainModelToReadReelAttachmentDto(FishingReel fishingReelAttachment);
}