using System.ComponentModel.DataAnnotations;

namespace SmartFishingApp.Dto.UserProfile.Rod;

public class RodTypeUpdateDto
{
    /// <summary>
    ///     ID сущности
    /// </summary>
    public string Id { get; set; }
    
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