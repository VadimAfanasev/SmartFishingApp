using System.ComponentModel.DataAnnotations;

namespace SmartFishingApp.Dto.UserProfile.FishingReel;

/// <summary>
///     Dto для создания типа катушек.
/// </summary>
public class FishingReelTypeCreateDto
{
    /// <summary>
    ///     Название типа катушек
    /// </summary>
    [Required]
    [MaxLength(50, ErrorMessage = "Слишком длинное название типа катушки")]
    public string Name { get; set; }
    
    /// <summary>
    ///     Комментарий
    /// </summary>
    [MaxLength(200, ErrorMessage = "Слишком длинный комменатрий")]
    public string? Commentary { get; set; }
}