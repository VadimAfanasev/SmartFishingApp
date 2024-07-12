using Database.Context;
using Interfaces.UserProfile.Tackle;
using Microsoft.EntityFrameworkCore;
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
}