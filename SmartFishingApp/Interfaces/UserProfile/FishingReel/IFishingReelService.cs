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
    ///     Получение катушки по Id.
    /// </summary>
    /// <param name="id"> Id сущности. </param>
    Task<FishingReel> GetFishingReelAsync(string id);
    
    /// <summary>
    ///     Получение списка всех катушек.
    /// </summary>
    Task<List<FishingReel>> GetFishingReelsAsync();
    
    /// <summary>
    ///     Получение катушки с вложениями по Id.
    /// </summary>
    /// <param name="id"> Id сущности. </param>
    /// <returns> Объект катушки с вложениями </returns>
    Task<FishingReel> GetFishingReelAttachmentAsync(string id);
}