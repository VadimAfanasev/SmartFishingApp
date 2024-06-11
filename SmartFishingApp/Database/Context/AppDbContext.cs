using Microsoft.AspNetCore.HttpLogging;
using SmartFishingApp.Models.Rod;
using SmartFishingApp.Models.Tackle;
using SmartFishingApp.Models.Tackle.TackleTypes.Spinning;
using SmartFishingApp.Models.Tackle.TackleTypes.Winter;
using SmartFishingApp.Models.TypeOfFishing;

namespace Database.Context;

using Microsoft.EntityFrameworkCore;

public class AppDbContext: DbContext
{
    /// <summary>
    ///     Конструктор.
    /// </summary>
    /// <param name="options"> Настройки контекста сущностей Postgis. </param>
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    
    /// <summary>
    ///     Тип рыбалки.
    /// </summary>
    public DbSet<TypeOfFishing> TypeOfFishing => Set<TypeOfFishing>();
    
    /// <summary>
    ///     Удилище.
    /// </summary>
    public DbSet<Rod> Rod => Set<Rod>();
    
    /// <summary>
    ///     Категория приманки.
    /// </summary>
    public DbSet<TackleCategory> TackleCategory => Set<TackleCategory>();
    
    /// <summary>
    ///    Зимняя приманка. Балансир.
    /// </summary>
    public DbSet<Rocker> Rocker => Set<Rocker>();
    
    /// <summary>
    ///    Зимняя приманка. Мормышка.
    /// </summary>
    public DbSet<WinterJig> WinterJig => Set<WinterJig>();
    
    /// <summary>
    ///    Зимняя приманка. Блесна.
    /// </summary>
    public DbSet<WinterSpoon> WinterSpoon => Set<WinterSpoon>();
    
    /// <summary>
    ///    Зимняя приманка. Воблер.
    /// </summary>
    public DbSet<WinterVobler> WinterVobler => Set<WinterVobler>();
    
    /// <summary>
    ///    Спиннинг. Джиг.
    /// </summary>
    public DbSet<Jig> Jig => Set<Jig>();
    
    /// <summary>
    ///    Спиннинг. Блесна.
    /// </summary>
    public DbSet<Spoon> Spoon => Set<Spoon>();
}