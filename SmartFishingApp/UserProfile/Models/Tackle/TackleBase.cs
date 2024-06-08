namespace SmartFishingApp.Models.Tackle;

using TypeOfFishing;

/// <summary>
///     Базовый класс описывающий приманки
/// </summary>
public class TackleBase
{
    /// <summary>
    ///     ID сущности
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    ///     Название приманки
    /// </summary>
    public string? Name { get; set; }
    
    /// <summary>
    ///     Категория приманки (На уровень ниже вида ловли - бойл, блесна, воблер, червяк)
    /// </summary>
    public TackleCategory? Category { get; set; }
    
    /// <summary>
    ///     Вид ловли
    /// </summary>
    public TypeOfFishing? TypeOfFishing { get; set; }
}