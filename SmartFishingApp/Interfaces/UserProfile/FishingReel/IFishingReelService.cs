namespace Interfaces.UserProfile.FishingReel;

public interface IFishingReelService
{
    /// <summary>
    ///     Создание катушки.
    /// </summary>
    /// <param name="fishingReel"> Катушка. </param>
    Task CreateFishingReelAsync(Models.Entities.UserProfile.FishingReel.FishingReel fishingReel);

    /// <summary>
    ///     Удаление катушки.
    /// </summary>
    /// <param name="id"> Id сущности. </param>
    Task DeleteFishingReelAsync(string id);
    
    /// <summary>
    ///     Получение катушки по Id.
    /// </summary>
    /// <param name="id"> Id сущности. </param>
    Task<Models.Entities.UserProfile.FishingReel.FishingReel> GetFishingReelAsync(string id);
    
    /// <summary>
    ///     Получение списка всех катушек.
    /// </summary>
    Task<List<Models.Entities.UserProfile.FishingReel.FishingReel>> GetFishingReelsAsync();
}