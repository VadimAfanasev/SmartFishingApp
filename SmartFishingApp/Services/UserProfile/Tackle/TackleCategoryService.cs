using Database.Context;
using Interfaces.UserProfile.Tackle;
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
    public Task DeleteTackleCategoryAsync(string id)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public Task<TackleCategory> GetTackleCategoryAsync(string id)
    {
        throw new NotImplementedException();
    }
}