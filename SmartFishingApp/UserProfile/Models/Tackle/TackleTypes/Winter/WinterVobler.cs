namespace SmartFishingApp.Models.Tackle.TackleTypes.Winter;

/// <summary>
///     Воблер для зимней рыбалки
/// </summary>
public class WinterVobler: TackleBase
{
    /// <summary>
    ///     Название производителя
    /// </summary>
    public string? Brand { get; set; }
    
    /// <summary>
    ///     Название модели
    /// </summary>
    public string? Model { get; set; }
    
    /// <summary>
    ///     Вес приманки
    /// </summary>
    public double? Weight { get; set; }
    
    /// <summary>
    ///     Длинна приманки
    /// </summary>
    public double? Length { get; set; }
    
    /// <summary>
    ///     Цвет приманки
    /// </summary>
    public string? Color { get; set; }
}