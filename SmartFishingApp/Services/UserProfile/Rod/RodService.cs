using Database.Context;
using Interfaces.UserProfile.Rod;
using Microsoft.EntityFrameworkCore;

namespace Services.UserProfile.Rod;

using SmartFishingApp.Models.Rod;

/// <inheritdoc />
public class RodService : IRodService
{
    /// <summary>
    ///     Контекст БД.
    /// </summary>
    private readonly AppDbContext _context;

    /// <summary>
    ///     Конструктор сервиса.
    /// </summary>
    /// <param name="context"> Контекст БД. </param>
    public RodService(AppDbContext context)
    {
        _context = context;
    }
    
    /// <inheritdoc />
    public async Task CreateRodAsync(Rod rod)
    {
        _context.Rod.Add(rod);
        await _context.SaveChangesAsync();
    }

    /// <inheritdoc />
    public async Task DeleteRodAsync(string id)
    {
        var rod = await _context.Rod.FindAsync(Guid.Parse(id));
        if (rod != null)
        {
            _context.Rod.Remove(rod);
            await _context.SaveChangesAsync();
        }
        else
            throw new KeyNotFoundException ($"Удаляемое удилище не найдено");
    }

    /// <inheritdoc />
    public async Task<Rod> GetFishingReelAsync(string id)
    {
        var rod = await _context.Rod.AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == Guid.Parse(id));
        
        if (rod != null)
            return rod;
        else
            throw new KeyNotFoundException ($"Удилище не найдено");
    }

    /// <inheritdoc />
    public async Task<List<Rod>> GetFishingReelsAsync()
    {
        var rod = await _context.Rod.AsNoTracking().ToListAsync();
        
        return rod;
    }
}