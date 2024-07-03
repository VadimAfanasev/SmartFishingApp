using Models.Dto.UserProfile.FishingReel;
using Models.Entities.UserProfile.FishingReel;

namespace Interfaces.UserProfile.FishingReel;

/// <summary>
///     Сервис для работы с типами рыболовных катушек.
/// </summary>
public interface IFishingReelTypeService
{
    /// <summary>
    ///     Создание типа катушки.
    /// </summary>
    /// <param name="fishingReel"> Катушка. </param>
    Task CreateFishingReelTypeAsync(FishingReelType fishingReel);

    /// <summary>
    ///     Удаление типа катушки.
    /// </summary>
    /// <param name="id"> Id сущности. </param>
    Task DeleteFishingReelTypeAsync(string id);
    
    /// <summary>
    ///     Получение типа катушки по Id.
    /// </summary>
    /// <param name="id"> Id сущности. </param>
    Task<FishingReelType> GetFishingReelTypeAsync(string id);
    
    /// <summary>
    ///     Получение списка всех типов катушек.
    /// </summary>
    Task<List<FishingReelType>> GetFishingReelTypesAsync();
    
    /// <summary>
    ///     Получение типа катушки с катушками этого типа.
    /// </summary>
    /// <param name="id"> Id типа катушки. </param>
    /// <returns> Тип катушки с катушками этогт типа. </returns>
    Task<FishingReelTypeAttachmentDto> GetFishingReelTypesAttachmentAsync(string id);
    
    /// <summary>
    ///     Получение списка рыболовных катушек по переданному типу катушек.
    /// </summary>
    /// <param name="id"> Id типа катушки. </param>
    /// <returns> Тип катушки с катушками этогт типа. </returns>
    Task<FishingReelsDto> GetFishingReelsAsync(string id);
}