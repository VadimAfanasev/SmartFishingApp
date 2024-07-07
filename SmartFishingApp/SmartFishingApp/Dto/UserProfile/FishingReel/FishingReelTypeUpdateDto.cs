using System.ComponentModel.DataAnnotations;

namespace SmartFishingApp.Dto.UserProfile.FishingReel;

/// <summary>
///     Dto для изменения типа катушек.
/// </summary>
public class FishingReelTypeUpdateDto
{
    /// <summary>
    ///     ID сущности
    /// </summary>
    public string Id { get; set; }
    
    /// <summary>
    ///     Название типа катушек
    /// </summary>
    [MaxLength(50, ErrorMessage = "Слишком длинное название типа катушки")]
    public string? Name { get; set; }
    
    /// <summary>
    ///     Комментарий
    /// </summary>
    [MaxLength(200, ErrorMessage = "Слишком длинный комменатрий")]
    public string? Commentary { get; set; }
}