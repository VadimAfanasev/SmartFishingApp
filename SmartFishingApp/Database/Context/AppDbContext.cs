using Microsoft.EntityFrameworkCore;
using Models.Entities.UserProfile.FishingReel;
using Models.Entities.UserProfile.Tackle;
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
    ///     Тип удилища.
    /// </summary>
    public DbSet<RodType> RodType => Set<RodType>();
    
    /// <summary>
    ///     Катушка.
    /// </summary>
    public DbSet<FishingReel> FishingReel => Set<FishingReel>();
    
    /// <summary>
    ///     Катушка.
    /// </summary>
    public DbSet<FishingReelType> FishingReelType => Set<FishingReelType>();

    /// <summary>
    ///     Категория приманки.
    /// </summary>
    public DbSet<TackleCategory> TackleCategory => Set<TackleCategory>();
    
    /// <summary>
    ///    Зимняя приманка. Балансир.
    /// </summary>
    public DbSet<WinterRocker> WinterRocker => Set<WinterRocker>();
    
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
    public DbSet<SpinningJig> SpinningJig => Set<SpinningJig>();
    
    /// <summary>
    ///    Спиннинг. Блесна.
    /// </summary>
    public DbSet<SpinningSpoon> SpinningSpoon => Set<SpinningSpoon>();
    
    /// <summary>
    ///    Спиннинг. Воблер.
    /// </summary>
    public DbSet<SpinningVobler> SpinningVobler => Set<SpinningVobler>();
    
    /// <summary>
    ///    Поплавочная удочка. Живая насадка.
    /// </summary>
    public DbSet<FloatAlive> FloatAlive => Set<FloatAlive>();
    
    /// <summary>
    ///    Поплавочная удочка. Растительная насадка.
    /// </summary>
    public DbSet<FloatCorn> FloatCorn => Set<FloatCorn>();
    
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
        modelBuilder.Entity<FloatAlive>().ToTable("FloatAlives");
        modelBuilder.Entity<FloatCorn>().ToTable("FloatCorns");
        modelBuilder.Entity<SpinningJig>().ToTable("SpinningJigs");
        modelBuilder.Entity<SpinningSpoon>().ToTable("SpinningSpoons");
        modelBuilder.Entity<SpinningVobler>().ToTable("SpinningVoblers");
        modelBuilder.Entity<WinterRocker>().ToTable("WinterRockers");
        modelBuilder.Entity<WinterJig>().ToTable("WinterJigs");
        modelBuilder.Entity<WinterSpoon>().ToTable("WinterSpoons");
        modelBuilder.Entity<WinterVobler>().ToTable("WinterVoblers");
        modelBuilder.Entity<FishingReel>().ToTable("FishingReels");
        modelBuilder.Entity<FishingReelType>().ToTable("FishingReelTypes");
        modelBuilder.Entity<Rod>().ToTable("Rods");
        modelBuilder.Entity<RodType>().ToTable("RodTypes");
        modelBuilder.Entity<TackleCategory>().ToTable("TackleCategories");
        modelBuilder.Entity<TypeOfFishing>().ToTable("TypesOfFishing");
        
        base.OnModelCreating(modelBuilder);
    }
}