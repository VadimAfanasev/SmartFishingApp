namespace SmartFishingApp.Models.Rod;

/// <summary>
///     Класс описывающий тип удилища
/// </summary>
public class RodType
{
    /// <summary>
    ///     ID сущности
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    ///     Название типа удилища
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    ///     Комментарий
    /// </summary>
    public string? Commentary { get; set; }
}