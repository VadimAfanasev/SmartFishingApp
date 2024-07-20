using Models.Dto.UserProfile.TackleCategory;
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
    
    /// <summary>
    ///     Изменение категории рыболовных приманок.
    /// </summary>
    /// <param name="tackleCategory"> Сущность категории рыболовных приманок с новыми данными. </param>
    Task UpdateTackleCategoryAsync(TackleCategory tackleCategory);
    
    /// <summary>
    ///     Получение категории рыболовных приманок с приманками этой категории.
    /// </summary>
    /// <param name="id"> Id категории рыболовных приманок. </param>
    /// <returns> Категория рыболовных приманок с приманками этой категории. </returns>
    Task<TackleCategoryAttachmentDto> GetTackleCategoryAttachmentAsync(string id);
}