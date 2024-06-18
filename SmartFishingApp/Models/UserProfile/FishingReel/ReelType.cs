namespace Models.UserProfile.FishingReel;

/// <summary>
///     Класс описывающий тип катушек
/// </summary>
public class ReelType
{
    /// <summary>
    ///     ID сущности
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    ///     Название типа катушек
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    ///     Комментарий
    /// </summary>
    public string? Commentary { get; set; }
}