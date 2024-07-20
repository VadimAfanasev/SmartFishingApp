using Models.Entities.UserProfile.Tackle;

namespace Models.Dto.UserProfile.TackleCategory;

/// <summary>
///     Dto для получения из контекста категории приманок с приманками этой категории.
/// </summary>
public class TackleCategoryAttachmentDto
{
    /// <summary>
    ///     ID сущности
    /// </summary>
    public string? Id { get; set; }
    
    /// <summary>
    ///     Название категории рыболовных приманок.
    /// </summary>
    public string? Name { get; set; }
    
    /// <summary>
    ///     Вид ловли
    /// </summary>
    public string? TypeOfFishing { get; set; }
    
    /// <summary>
    ///     Комментарий
    /// </summary>
    public string? Commentary { get; set; }
    
    /// <summary>
    ///     Приманки данной категории
    /// </summary>
    public List<TackleBaseDto>? Tackles { get; set; }
}