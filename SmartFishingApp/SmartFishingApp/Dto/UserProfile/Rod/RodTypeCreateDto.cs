using System.ComponentModel.DataAnnotations;
using JetBrains.Annotations;

namespace SmartFishingApp.Dto.UserProfile.Rod;

/// <summary>
///     Dto для создания типа удилища.
/// </summary>
[PublicAPI]
public class RodTypeCreateDto
{
    /// <summary>
    ///     Название типа удилища.
    /// </summary>
    [Required]
    [MaxLength(50, ErrorMessage = "Слишком длинное название типа удилища")]
    public string Name { get; set; }
    
    /// <summary>
    ///     Комментарий.
    /// </summary>
    [MaxLength(200, ErrorMessage = "Слишком длинный комменатрий")]
    public string? Commentary { get; set; }
}