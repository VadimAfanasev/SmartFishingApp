using JetBrains.Annotations;

namespace SmartFishingApp.Dto.UserProfile.FishingReel;

/// <summary>
///     Dto для отображения типа катушек.
/// </summary>
[PublicAPI]
public class FishingReelTypeReadDto
{
    /// <summary>
    ///     Название типа катушек
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    ///     Комментарий
    /// </summary>
    public string? Commentary { get; set; }
}