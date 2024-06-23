using Database.Context;
using Microsoft.EntityFrameworkCore;

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
    public async Task CreateFishingReelAsync(FishingReel fishingReel)
    {
        _context.FishingReel.Add(fishingReel);
        await _context.SaveChangesAsync();
    }
    
    /// <inheritdoc />
    public async Task DeleteFishingReelAsync(string id)
    {
        var fishingReel = await _context.FishingReel.FindAsync(Guid.Parse(id));
        if (fishingReel != null)
        {
            _context.FishingReel.Remove(fishingReel);
            await _context.SaveChangesAsync();
        }
        else
            throw new KeyNotFoundException ($"Удаляемая катушка не найдена");
    }

    /// <inheritdoc />
    public async Task GetFishingReelAsync(string id)
    {
        throw new NotImplementedException();
    }
}