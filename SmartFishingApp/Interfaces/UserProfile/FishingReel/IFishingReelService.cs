namespace Interfaces.UserProfile.FishingReel;

using Models.Entities.UserProfile.FishingReel;

/// <summary>
///     Сервис для работы с рыболовными катушками.
/// </summary>
public interface IFishingReelService
{
    /// <summary>
    ///     Создание катушки.
    /// </summary>
    /// <param name="fishingReel"> Катушка. </param>
    Task CreateFishingReelAsync(FishingReel fishingReel);

    /// <summary>
    ///     Удаление катушки.
    /// </summary>
    /// <param name="id"> Id сущности. </param>
    Task DeleteFishingReelAsync(string id);
    
    /// <summary>
    ///     Получение катушки по Id.
    /// </summary>
    /// <param name="id"> Id сущности. </param>
    Task<FishingReel> GetFishingReelAsync(string id);
    
    /// <summary>
    ///     Получение списка всех катушек.
    /// </summary>
    Task<List<FishingReel>> GetFishingReelsAsync();

    /// <summary>
    ///     Изменение катушки.
    /// </summary>
    /// <param name="fishingReel"> Сущность катушки с новыми данными. </param>
    Task UpdateFishingReelAsync(FishingReel fishingReel);
}