using Models.Dto.UserProfile.Rod;
using SmartFishingApp.Models.Rod;

namespace Interfaces.UserProfile.Rod;

/// <summary>
///     Сервис для работы с типами рыболовных удилищ.
/// </summary>
public interface IRodTypeService 
{
    /// <summary>
    ///     Создание типа удилища.
    /// </summary>
    /// <param name="rod"> Катушка. </param>
    Task CreateRodTypeAsync(RodType rod);

    /// <summary>
    ///     Удаление типа удилища.
    /// </summary>
    /// <param name="id"> Id сущности. </param>
    Task DeleteRodTypeAsync(string id);
    
    /// <summary>
    ///     Получение типа удилища по Id.
    /// </summary>
    /// <param name="id"> Id сущности. </param>
    Task<RodType> GetRodTypeAsync(string id);
    
    /// <summary>
    ///     Получение списка всех типов удилищ.
    /// </summary>
    Task<List<RodType>> GetRodTypesAsync();
    
    /// <summary>
    ///     Получение типа удилища с удилищами этого типа.
    /// </summary>
    /// <param name="id"> Id типа катушки. </param>
    /// <returns> Тип катушки с катушками этогт типа. </returns>
    Task<RodTypeAttachmentDto> GetRodTypesAttachmentAsync(string id);
    
    /// <summary>
    ///     Получение списка удилищ по переданному типу удилища.
    /// </summary>
    /// <param name="id"> Id типа катушки. </param>
    /// <returns> Тип катушки с катушками этогт типа. </returns>
    Task<RodsDto> GetRodsAsync(string id);
}