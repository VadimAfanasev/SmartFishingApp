using Database.Context;
using Interfaces.UserProfile.Rod;

namespace Services.UserProfile.Rod;

using SmartFishingApp.Models.Rod;

public class RodService : IRodService
{
    /// <summary>
    ///     Контекст БД.
    /// </summary>
    private readonly AppDbContext _context;

    public RodService(AppDbContext context)
    {
        _context = context;
    }
    
    public Task CreateRodAsync(Rod fishingReel)
    {
        throw new NotImplementedException();
    }

    public Task DeleteRodAsync(string id)
    {
        throw new NotImplementedException();
    }

    public Task<Rod> GetFishingReelAsync(string id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Rod>> GetFishingReelsAsync()
    {
        throw new NotImplementedException();
    }
}