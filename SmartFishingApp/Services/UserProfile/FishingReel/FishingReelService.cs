using Database.Context;

namespace Services.UserProfile.FishingReel;

using Models.UserProfile.FishingReel;
using Interfaces.UserProfile.FishingReel;

public class FishingReelService: IFishingReelService
{
    /// <summary>
    ///     Контекст БД.
    /// </summary>
    private readonly AppDbContext _context;

    public FishingReelService(AppDbContext context)
    {
        _context = context;
    }
    
    /// <inheritdoc />
    public async Task CreateAreasAsync(FishingReel fishingReel)
    {
        _context.FishingReel.Add(fishingReel);
        await _context.SaveChangesAsync();
    }
}