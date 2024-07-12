using Models.Entities.UserProfile.Tackle;

namespace Interfaces.UserProfile.Tackle;

/// <summary>
///     Интерфейс сервиса категорий рыболовных приманок.
/// </summary>
public interface ITackleCategoryService
{
    /// <summary>
    ///     Создание категории рыболовных приманок.
    /// </summary>
    /// <param name="tackleCategory"> Категория рыболовных приманок. </param>
    Task CreateTackleCategoryAsync(TackleCategory tackleCategory);

    /// <summary>
    ///     Удаление категории рыболовных приманок.
    /// </summary>
    /// <param name="id"> Id сущности. </param>
    Task DeleteTackleCategoryAsync(string id);
    
    /// <summary>
    ///     Получение категории рыболовных приманок по Id.
    /// </summary>
    /// <param name="id"> Id сущности. </param>
    Task<TackleCategory> GetTackleCategoryAsync(string id);
}