namespace SmartFishingApp.Models.Tackle.TackleTypes.Spinning;

/// <summary>
///     Блесна
/// </summary>
public class Spoon: TackleBase
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
    ///     Форма приманки
    /// </summary>
    public string? Form { get; set; }
    
    /// <summary>
    ///     Размер приманки
    /// </summary>
    public double? SizeNumber { get; set; }
    
    /// <summary>
    ///     Цвет приманки
    /// </summary>
    public string? Color { get; set; }
}