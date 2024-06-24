using System.ComponentModel.DataAnnotations;

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
    [MaxLength(50, ErrorMessage = "Слишком длинное название типа катушки")]
    public string Name { get; set; }
    
    /// <summary>
    ///     Комментарий
    /// </summary>
    [MaxLength(200, ErrorMessage = "Слишком длинный комменатрий")]
    public string? Commentary { get; set; }
}