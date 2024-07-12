using System.ComponentModel.DataAnnotations;

namespace SmartFishingApp.Dto.UserProfile.TackleCategory;

/// <summary>
///     Dto для редактирвования категории рыболовных приманок.
/// </summary>
public class TackleCategoryUpdateDto
{
    /// <summary>
    ///     ID сущности
    /// </summary>
    public string Id { get; set; }
    
    /// <summary>
    ///     Название категории рыболовных приманок.
    /// </summary>
    [Required]
    [MaxLength(50, ErrorMessage = "Слишком длинное название категории рыболовных приманок")]
    public string? Name { get; set; }
    
    /// <summary>
    ///     Вид ловли
    /// </summary>
    [Required]
    [MaxLength(50, ErrorMessage = "Слишком длинное название вида ловли")]
    public string TypeOfFishing { get; set; }
    
    /// <summary>
    ///     Комментарий
    /// </summary>
    [MaxLength(200, ErrorMessage = "Слишком длинный комменатрий")]
    public string? Commentary { get; set; }
}