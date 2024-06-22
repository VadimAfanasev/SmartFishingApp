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
    /// <returns> <see cref="FishingReel" /> </returns>
    FishingReel CreationDtoToDomainModel(FishingReelCreateDto createDto);
}