namespace Models.UserProfile.FishingReel;

/// <summary>
///     Класс описывающий тип катушек
/// </summary>
public class FishingReelType
{
    /// <summary>
    ///     ID сущности
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    ///     Название типа катушек
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    ///     Комментарий
    /// </summary>
    public string? Commentary { get; set; }
}