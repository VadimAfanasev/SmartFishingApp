namespace Interfaces.UserProfile.FishingReel;

using Models.UserProfile.FishingReel;

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
    ///     Получить катушку.
    /// </summary>
    /// <param name="id"> Id сущности. </param>
    Task GetFishingReelAsync(string id);
}