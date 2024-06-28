namespace Models.Dto.UserProfile.FishingReel;
using Models.UserProfile.FishingReel;
/// <summary>
///     Dto для для получения из контекста катушек по переданному типу.
/// </summary>
public class FishingReelsDto
{
    /// <summary>
    ///     Список катушек
    /// </summary>
    private List<FishingReel> FishingReels { get; set; }
}