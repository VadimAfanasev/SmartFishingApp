using Database.Context;
using Interfaces.UserProfile.FishingReel;
using Microsoft.EntityFrameworkCore;
using Models.UserProfile.FishingReel;

namespace Services.UserProfile.FishingReel;

public class FishingReelTypeService: IFishingReelTypeService
{
    /// <summary>
    ///     Контекст БД.
    /// </summary>
    private readonly AppDbContext _context;

    public FishingReelTypeService(AppDbContext context)
    {
        _context = context;
    }
    
    /// <inheritdoc />
    public async Task CreateFishingReelTypeAsync(FishingReelType fishingReelType)
    {
        _context.FishingReelType.Add(fishingReelType);
        await _context.SaveChangesAsync();
    }
    
    /// <inheritdoc />
    public async Task DeleteFishingReelTypeAsync(string id)
    {
        var fishingReelType = await _context.FishingReelType.FindAsync(int.Parse(id));
        if (fishingReelType != null)
        {
            _context.FishingReelType.Remove(fishingReelType);
            await _context.SaveChangesAsync();
        }
        else
            throw new KeyNotFoundException ($"Удаляемый тип катушки не найден");
    }

    /// <inheritdoc />
    public async Task<FishingReelType> GetFishingReelTypeAsync(string id)
    {
        var fishingReelType = await _context.FishingReelType.AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == int.Parse(id));
        
        if (fishingReelType != null)
            return fishingReelType;
        else
            throw new KeyNotFoundException ($"Тип катушек не найден");
    }
    
    /// <inheritdoc />
    public async Task<List<FishingReelType>> GetFishingReelTypesAsync()
    {
        var fishingReelTypes = await _context.FishingReelType.AsNoTracking().ToListAsync();
        
        return fishingReelTypes;
    }

    public async Task<FishingReelType> GetFishingReelTypesAttachmentAsync(string id)
    {
        var fishingReelType = await _context.FishingReelType
            .Include(frt => frt.) // Включаем сущности FishingReel
            .FirstOrDefaultAsync(frt => frt.Id == id); 

        return fishingReelsWithType;
        
        // возможно стоит получать только список катушек типа переданного по Id
    }
}