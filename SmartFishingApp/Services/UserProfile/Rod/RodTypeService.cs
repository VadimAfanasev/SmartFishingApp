using Database.Context;
using Interfaces.UserProfile.Rod;
using Microsoft.EntityFrameworkCore;
using Models.Dto.UserProfile.Rod;
using SmartFishingApp.Models.Rod;

namespace Services.UserProfile.Rod;

/// <inheritdoc />
public class RodTypeService : IRodTypeService
{
    /// <summary>
    ///     Контекст БД.
    /// </summary>
    private readonly AppDbContext _context;

    public RodTypeService(AppDbContext context)
    {
        _context = context;
    }
    
    /// <inheritdoc />
    public async Task CreateRodTypeAsync(RodType rodType)
    {
        _context.RodType.Add(rodType);
        await _context.SaveChangesAsync();
    }
    
    /// <inheritdoc />
    public async Task DeleteRodTypeAsync(string id)
    {
        var rodType = await _context.RodType.FindAsync(int.Parse(id));
        if (rodType != null)
        {
            _context.RodType.Remove(rodType);
            await _context.SaveChangesAsync();
        }
        else
            throw new KeyNotFoundException ($"Удаляемый тип катушки не найден");
    }

    /// <inheritdoc />
    public async Task<RodType> GetRodTypeAsync(string id)
    {
        var rodType = await _context.RodType.AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == int.Parse(id));
        
        if (rodType != null)
            return rodType;
        else
            throw new KeyNotFoundException ($"Тип катушек не найден");
    }
    
    /// <inheritdoc />
    public async Task<List<RodType>> GetRodTypesAsync()
    {
        var rodTypes = await _context.RodType.AsNoTracking().ToListAsync();
        
        return rodTypes;
    }

    /// <inheritdoc />
    public async Task<RodTypeAttachmentDto> GetRodTypesAttachmentAsync(string id)
    {
        var rodType = await _context.RodType
            .FirstOrDefaultAsync(frt => frt.Id == int.Parse(id));

        var rods = await _context.Rod
            .Include(c=>c.RodType)
            .Include(c=>c.TypeOfFishing)
            .Where(c => c.RodType == rodType)
            .ToListAsync();

        var rodTypeAttachment = new RodTypeAttachmentDto()
        {
            Name = rodType!.Name,
            Commentary = rodType.Commentary,
            Rods = rods
        };
        
        return rodTypeAttachment;
        
        // возможно стоит получать только список катушек типа переданного по Id
    }

    public async Task<RodsDto> GetRodsAsync(string id)
    {
        var rods = await _context.Rod
            .Include(c=>c.RodType)
            .Where(c => c.RodType.Id == int.Parse(id)).ToListAsync();

        var rodsDto = new RodsDto()
        {
            Rods = rods
        };
        return rodsDto;
    }
}