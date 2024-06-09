namespace SmartFishingApp.Models.Tackle.TackleTypes.Spinning;

public class Jig: TackleBase
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
    ///     Длинна приманки
    /// </summary>
    public double? Length { get; set; }
    
    /// <summary>
    ///     Цвет приманки
    /// </summary>
    public string? Color { get; set; }
}