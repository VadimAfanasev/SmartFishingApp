namespace SmartFishingApp.Models.Tackle.TackleTypes.Spinning;

/// <summary>
///     Воблер
/// </summary>
public class Vobler: TackleBase
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
    ///     Заглубление
    /// </summary>
    public double? Depenning { get; set; }
    
    /// <summary>
    ///     Цвет приманки
    /// </summary>
    public string? Color { get; set; }

    /// <summary>
    ///     Плавучесть
    /// </summary>
    public string? Flotation { get; set; }
}