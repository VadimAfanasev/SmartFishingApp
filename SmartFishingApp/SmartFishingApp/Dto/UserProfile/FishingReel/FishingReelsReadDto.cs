using Models.Dto.UserProfile.FishingReel;

namespace SmartFishingApp.Dto.UserProfile.FishingReel;
using global::Models.Entities.UserProfile.FishingReel;

/// <summary>
///     Дто для отображения списка катушек
/// </summary>
public class FishingReelsReadDto
{
    /// <summary>
    ///     Список катушек
    /// </summary>
    public FishingReelsDto FishingReels { get; set; }
}