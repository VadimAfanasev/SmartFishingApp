using Models.Dto.UserProfile.FishingReel;

namespace Interfaces.UserProfile.FishingReel;

using Models.UserProfile.FishingReel;

public interface IFishingReelTypeService
{
    /// <summary>
    ///     Создание катушки.
    /// </summary>
    /// <param name="fishingReel"> Катушка. </param>
    Task CreateFishingReelTypeAsync(FishingReelType fishingReel);

    /// <summary>
    ///     Удаление катушки.
    /// </summary>
    /// <param name="id"> Id сущности. </param>
    Task DeleteFishingReelTypeAsync(string id);
    
    /// <summary>
    ///     Получение катушки по Id.
    /// </summary>
    /// <param name="id"> Id сущности. </param>
    Task<FishingReelType> GetFishingReelTypeAsync(string id);
    
    /// <summary>
    ///     Получение списка всех катушек.
    /// </summary>
    Task<List<FishingReelType>> GetFishingReelTypesAsync();
    
    /// <summary>
    ///     Получение типа катушки с катушками этого типа.
    /// </summary>
    /// <param name="id"> Id типа катушки. </param>
    /// <returns> Тип катушки с катушками этогт типа. </returns>
    Task<FishingReelTypeAttachmentDto> GetFishingReelTypesAttachmentAsync(string id);
}