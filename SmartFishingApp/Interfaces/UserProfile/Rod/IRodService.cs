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
    /// <param name="rod"> Удилище. </param>
    Task CreateRodAsync(Rod rod);

    /// <summary>
    ///     Удаление удилища.
    /// </summary>
    /// <param name="id"> Id сущности. </param>
    Task DeleteRodAsync(string id);
    
    /// <summary>
    ///     Получение удилища по Id.
    /// </summary>
    /// <param name="id"> Id сущности. </param>
    Task<Rod> GetRodAsync(string id);
    
    /// <summary>
    ///     Получение списка всех удилищ.
    /// </summary>
    Task<List<Rod>> GetRodsAsync();
    
    /// <summary>
    ///     Изменение удилища.
    /// </summary>
    /// <param name="rod"> Сущность удилища с новыми данными. </param>
    Task UpdateRodAsync(Rod rod);
}