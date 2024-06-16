using Microsoft.EntityFrameworkCore;
using SmartFishingApp.Models.Rod;
using SmartFishingApp.Models.Tackle;
using SmartFishingApp.Models.Tackle.TackleTypes.Feeder;
using SmartFishingApp.Models.Tackle.TackleTypes.Float;
using SmartFishingApp.Models.Tackle.TackleTypes.Spinning;
using SmartFishingApp.Models.Tackle.TackleTypes.Winter;
using SmartFishingApp.Models.TypeOfFishing;

namespace Database.Context;

public class AppDbContext: DbContext
{
    /// <summary>
    ///     Конструктор.
    /// </summary>
    /// <param name="options"> Настройки контекста. </param>
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
    
    /// <summary>
    ///    Спиннинг. Воблер.
    /// </summary>
    public DbSet<Vobler> Vobler => Set<Vobler>();
    
    /// <summary>
    ///    Поплавочная удочка. Живая насадка.
    /// </summary>
    public DbSet<Alive> Alive => Set<Alive>();
    
    /// <summary>
    ///    Поплавочная удочка. Растительная насадка.
    /// </summary>
    public DbSet<Corn> Corn => Set<Corn>();
    
    /// <summary>
    ///    Фидер / Донка. Живая насадка.
    /// </summary>
    public DbSet<FeederAlive> FeederAlive => Set<FeederAlive>();
    
    /// <summary>
    ///    Фидер / Донка. Бойл.
    /// </summary>
    public DbSet<FeederBoil> FeederBoil => Set<FeederBoil>();
    
    /// <summary>
    ///    Фидер / Донка. Растительная насадка.
    /// </summary>
    public DbSet<FeederCorn> FeederCorn => Set<FeederCorn>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<FeederAlive>().ToTable("FeederAlives");
        modelBuilder.Entity<FeederBoil>().ToTable("FeederBoils");
        modelBuilder.Entity<FeederCorn>().ToTable("FeederCorns");
        modelBuilder.Entity<Alive>().ToTable("Alives");
        modelBuilder.Entity<Corn>().ToTable("Corns");
        modelBuilder.Entity<Jig>().ToTable("Jigs");
        modelBuilder.Entity<Spoon>().ToTable("Spoons");
        modelBuilder.Entity<Vobler>().ToTable("Voblers");
        modelBuilder.Entity<Rocker>().ToTable("Rockers");
        modelBuilder.Entity<WinterJig>().ToTable("WinterJigs");
        modelBuilder.Entity<WinterSpoon>().ToTable("WinterSpoons");
        modelBuilder.Entity<WinterVobler>().ToTable("WinterVobler");
        
        base.OnModelCreating(modelBuilder);
    }
}