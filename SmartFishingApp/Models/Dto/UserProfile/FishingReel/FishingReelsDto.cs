namespace Models.Dto.UserProfile.FishingReel;
using Entities.UserProfile.FishingReel;

/// <summary>
///     Dto для для получения из контекста катушек по переданному типу.
/// </summary>
public class FishingReelsDto
{
    /// <summary>
    ///     Список катушек
    /// </summary>
    public List<FishingReel> FishingReels { get; set; }
}