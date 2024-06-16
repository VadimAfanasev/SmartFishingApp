namespace SmartFishingApp.Models.Tackle;

using TypeOfFishing;

/// <summary>
///     Класс описывающий категорию приманки
///     На уровень ниже вида ловли - бойл, блесна, воблер, червяк
/// </summary>
public class TackleCategory
{
    /// <summary>
    ///     ID сущности
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    ///     Название категории
    /// </summary>
    public string? Name { get; set; }
    
    /// <summary>
    ///     Вид ловли
    /// </summary>
    public TypeOfFishing? TypeOfFishing { get; set; }
    
    /// <summary>
    ///     Комментарий
    /// </summary>
    public string? Commentary { get; set; }
}