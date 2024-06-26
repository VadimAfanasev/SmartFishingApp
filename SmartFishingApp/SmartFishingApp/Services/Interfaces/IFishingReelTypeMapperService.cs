using Models.UserProfile.FishingReel;
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

    
}