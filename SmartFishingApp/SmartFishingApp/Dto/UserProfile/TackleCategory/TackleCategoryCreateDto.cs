using System.ComponentModel.DataAnnotations;
using JetBrains.Annotations;
using SmartFishingApp.Models.TypeOfFishing;

namespace SmartFishingApp.Dto.UserProfile.TackleCategory;

/// <summary>
///     Dto для создания категории рыболовных приманок.
/// </summary>
[PublicAPI]
public class TackleCategoryCreateDto
{
    /// <summary>
    ///     Название категории рыболовных приманок.
    /// </summary>
    [Required(ErrorMessage = "Поле \"Название категории\" обязательно для заполнения")]
    public required string Name { get; set; }
    
    /// <summary>
    ///     Вид ловли.
    /// </summary>
    [Required(ErrorMessage = "Поле \"Вид ловли\" обязательно для заполнения")]
    public required TypeOfFishing TypeOfFishing { get; set; }
    
    /// <summary>
    ///     Комментарий.
    /// </summary>
    public string? Commentary { get; set; }
}