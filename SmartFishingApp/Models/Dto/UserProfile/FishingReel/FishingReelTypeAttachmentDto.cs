namespace Models.Dto.UserProfile.FishingReel;

/// <summary>
///     Dto для получения из контекста типа катушки с катушками этого типа.
/// </summary>
public class FishingReelTypeAttachmentDto
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
    public List<Entities.UserProfile.FishingReel.FishingReel> FishingReels { get; set; }
}