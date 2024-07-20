using System.Collections.Specialized;
using Database.Context;
using Interfaces.UserProfile.Tackle;
using Microsoft.EntityFrameworkCore;
using Models.Dto.UserProfile.TackleCategory;
using Models.Entities.UserProfile.Tackle;

namespace Services.UserProfile.Tackle;

/// <inheritdoc />
public class TackleCategoryService: ITackleCategoryService
{
    /// <summary>
    ///     Контекст БД.
    /// </summary>
    private readonly AppDbContext _context;

    /// <summary>
    ///     Конструктор по умолчанию.
    /// </summary>
    /// <param name="context"> Контекст БД. </param>
    public TackleCategoryService(AppDbContext context)
    {
        _context = context;
    }
    
    /// <inheritdoc />
    public async Task CreateTackleCategoryAsync(TackleCategory tackleCategory)
    {
        _context.TackleCategory.Add(tackleCategory);
        await _context.SaveChangesAsync();
    }

    /// <inheritdoc />
    public async Task DeleteTackleCategoryAsync(string id)
    {
        var tackleCategory = await _context.TackleCategory.FindAsync(int.Parse(id));
        if (tackleCategory != null)
        {
            _context.TackleCategory.Remove(tackleCategory);
            await _context.SaveChangesAsync();
        }
        else
            throw new KeyNotFoundException ($"Удаляемая категория рыболовных приманок не найдена");
    }

    /// <inheritdoc />
    public async Task<TackleCategory> GetTackleCategoryAsync(string id)
    {
        var rodType = await _context.TackleCategory.AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == int.Parse(id));
        
        if (rodType != null)
            return rodType;
        else
            throw new KeyNotFoundException ($"Категория рыболовных приманок не найдена");
    }

    /// <inheritdoc />
    public async Task UpdateTackleCategoryAsync(TackleCategory tackleCategory)
    {
        _context.TackleCategory.Update(tackleCategory);
        await _context.SaveChangesAsync();
    }
    
    /// <inheritdoc />
    public async Task<TackleCategoryAttachmentDto> GetTackleCategoryAttachmentAsync(string id)
    {
        var tackleCategory = await _context.TackleCategory
            .FirstOrDefaultAsync(cat => cat.Id == int.Parse(id));
        
        var resultTackles = await _context.FeederAlive
            .Where(c => c.TackleCategory.Id == int.Parse(id))
            .Cast<TackleBaseDto>()
            .Union(_context.FeederBoil
                .Where(c => c.TackleCategory.Id == int.Parse(id))
                .Cast<TackleBaseDto>())
            .Union(_context.FeederCorn
                .Where(c => c.TackleCategory.Id == int.Parse(id))
                .Cast<TackleBaseDto>())
            .Union(_context.FloatAlive
                .Where(c => c.TackleCategory.Id == int.Parse(id))
                .Cast<TackleBaseDto>())
            .Union(_context.FloatCorn
                .Where(c => c.TackleCategory.Id == int.Parse(id))
                .Cast<TackleBaseDto>())
            .Union(_context.SpinningJig
                .Where(c => c.TackleCategory.Id == int.Parse(id))
                .Cast<TackleBaseDto>())
            .Union(_context.SpinningSpoon
                .Where(c => c.TackleCategory.Id == int.Parse(id))
                .Cast<TackleBaseDto>())
            .Union(_context.SpinningVobler
                .Where(c => c.TackleCategory.Id == int.Parse(id))
                .Cast<TackleBaseDto>())
            .Union(_context.WinterJig
                .Where(c => c.TackleCategory.Id == int.Parse(id))
                .Cast<TackleBaseDto>())
            .Union(_context.WinterRocker
                .Where(c => c.TackleCategory.Id == int.Parse(id))
                .Cast<TackleBaseDto>())
            .Union(_context.WinterSpoon
                .Where(c => c.TackleCategory.Id == int.Parse(id))
                .Cast<TackleBaseDto>())
            .Union(_context.WinterVobler
                .Where(c => c.TackleCategory.Id == int.Parse(id))
                .Cast<TackleBaseDto>())
            .ToListAsync();
        
        var tackleCategoryAttachment = new TackleCategoryAttachmentDto()
        {
            Id = tackleCategory!.Id.ToString(),
            Name = tackleCategory!.Name,
            TypeOfFishing = tackleCategory.TypeOfFishing.ToString(),
            Commentary = tackleCategory.Commentary,
            Tackles = resultTackles
        };
        
        return tackleCategoryAttachment;
    }
}
