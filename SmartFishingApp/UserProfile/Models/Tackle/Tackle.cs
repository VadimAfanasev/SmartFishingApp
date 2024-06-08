namespace SmartFishingApp.Models.Tackle;

using TypeOfFishing;

/// <summary>
///     Класс описывающий приманку
/// </summary>
public class Tackle
{
    /// <summary>
    ///     ID сущности
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    ///     Название марки
    /// </summary>
    public string? Brand { get; set; }
    
    /// <summary>
    ///     Название модели
    /// </summary>
    public string? Type { get; set; }
}