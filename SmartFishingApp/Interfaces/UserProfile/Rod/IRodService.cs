namespace Interfaces.UserProfile.Rod;
using SmartFishingApp.Models.Rod;
/// <summary>
///     Сервис для работы с рыболовными удилищами.
/// </summary>
public interface IRodService
{
    /// <summary>
    ///     Создание удилища.
    /// </summary>
    /// <param name="fishingReel"> Катушка. </param>
    Task CreateRodAsync(Rod fishingReel);

    /// <summary>
    ///     Удаление удилища.
    /// </summary>
    /// <param name="id"> Id сущности. </param>
    Task DeleteRodAsync(string id);
    
    /// <summary>
    ///     Получение удилища по Id.
    /// </summary>
    /// <param name="id"> Id сущности. </param>
    Task<Rod> GetFishingReelAsync(string id);
    
    /// <summary>
    ///     Получение списка всех удилищ.
    /// </summary>
    Task<List<Rod>> GetFishingReelsAsync();
}