namespace SmartFishingApp.Dto.UserProfile.FishingReel;

/// <summary>
///     Dto для отображения типа катушки с катушками этого типа.
/// </summary>
public class FishingReelTypeAttachmentReadDto
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
    public List<FishingReelReadDto> FishingReels { get; set; }
}