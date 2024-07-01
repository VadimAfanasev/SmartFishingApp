using Database.Context;
using Microsoft.EntityFrameworkCore;

namespace Services.UserProfile.FishingReel;

using Interfaces.UserProfile.FishingReel;
using Models.Entities.UserProfile.FishingReel;

/// <inheritdoc />
public class FishingReelService: IFishingReelService
{
    /// <summary>
    ///     Контекст БД.
    /// </summary>
    private readonly AppDbContext _context;

    /// <summary>
    ///     Конструктор сервиса.
    /// </summary>
    /// <param name="context"> Контекст БД. </param>
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
    public async Task<FishingReel> GetFishingReelAsync(string id)
    {
        var fishingReel = await _context.FishingReel.AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == Guid.Parse(id));
        
        if (fishingReel != null)
            return fishingReel;
        else
            throw new KeyNotFoundException ($"Катушка не найдена");
    }
    
    /// <inheritdoc />
    public async Task<List<FishingReel>> GetFishingReelsAsync()
    {
        var fishingReels = await _context.FishingReel.AsNoTracking().ToListAsync();
        
        return fishingReels;
    }
}