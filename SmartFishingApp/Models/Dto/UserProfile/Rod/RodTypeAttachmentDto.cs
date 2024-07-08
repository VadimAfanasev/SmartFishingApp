namespace Models.Dto.UserProfile.Rod;

using SmartFishingApp.Models.Rod;

/// <summary>
///     Dto для получения из контекста типа удилища с удилищами этого типа.
/// </summary>
public class RodTypeAttachmentDto
{
    /// <summary>
    ///     ID сущности
    /// </summary>
    public string Id { get; set; }
    
    /// <summary>
    ///     Название типа удилищ
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    ///     Комментарий
    /// </summary>
    public string? Commentary { get; set; } 

    /// <summary>
    ///     Удилища данного типа
    /// </summary>
    public List<Rod> Rods { get; set; }
}