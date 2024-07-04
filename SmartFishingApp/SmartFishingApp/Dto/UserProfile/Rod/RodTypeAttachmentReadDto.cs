namespace SmartFishingApp.Dto.UserProfile.Rod;

/// <summary>
///     Dto для отображения типа удилища с удилищами этого типа.
/// </summary>
public class RodTypeAttachmentReadDto
{
    /// <summary>
    ///     Название типа катушек
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    ///     Комментарий
    /// </summary>
    public string? Commentary { get; set; } 

    /// <summary>
    ///     Катушки данного типа
    /// </summary>
    public List<RodReadDto> Rods { get; set; }
}