using Database.Context;
using Interfaces.UserProfile.FishingReel;
using Microsoft.EntityFrameworkCore;
using Models.Dto.UserProfile.FishingReel;
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

    /// <inheritdoc />
    public async Task<FishingReelTypeAttachmentDto> GetFishingReelTypesAttachmentAsync(string id)
    {
        var fishingReelType = await _context.FishingReelType
            .FirstOrDefaultAsync(frt => frt.Id == int.Parse(id));

        var fishingReels = await _context.FishingReel
            .Include(c=>c.ReelType)
            .Include(c=>c.TypeOfFishing)
            .Where(c => c.ReelType == fishingReelType)
            .ToListAsync();

        var fishingReelTypeAttachment = new FishingReelTypeAttachmentDto()
        {
            Name = fishingReelType!.Name,
            Commentary = fishingReelType.Commentary,
            FishingReels = fishingReels
        };
        
        return fishingReelTypeAttachment;
        
        // возможно стоит получать только список катушек типа переданного по Id
    }

    public async Task<List<FishingReelsDto>> GetFishingReelsAsync(string id)
    {
        var fishingReelsDto = await _context.FishingReel
            .Include(c=>c.ReelType)
            .Where(c => c.ReelType.Id == int.Parse(id)).ToListAsync();
        
        
        return fishingReelsDto;
    }
}