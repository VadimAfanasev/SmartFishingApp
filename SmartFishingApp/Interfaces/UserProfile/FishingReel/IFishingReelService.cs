namespace Interfaces.UserProfile.FishingReel;

using Models.UserProfile.FishingReel;

public interface IFishingReelService
{
    /// <summary>
    ///     Создание катушки.
    /// </summary>
    /// <param name="fishingReel"> Катушка. </param>
    Task CreateAreasAsync(FishingReel fishingReel);
}