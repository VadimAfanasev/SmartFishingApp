using JetBrains.Annotations;

namespace SmartFishingApp.Dto.UserProfile.FishingReel;

/// <summary>
///     Dto для отображения типа катушек.
/// </summary>
[PublicAPI]
public class FishingReelTypeReadDto
{
    /// <summary>
    ///     ID сущности
    /// </summary>
    public string Id { get; set; }
    
    /// <summary>
    ///     Название типа катушек
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    ///     Комментарий
    /// </summary>
    public string? Commentary { get; set; }
}