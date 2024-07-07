using System.ComponentModel.DataAnnotations;
using SmartFishingApp.Models.TypeOfFishing;

namespace Models.Entities.UserProfile.Tackle;

/// <summary>
///     Класс описывающий категорию приманки
///     На уровень ниже вида ловли - бойл, блесна, воблер, червяк
/// </summary>
public class TackleCategory
{
    /// <summary>
    ///     ID сущности
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    ///     Название категории
    /// </summary>
    public string? Name { get; set; }
    
    /// <summary>
    ///     Вид ловли
    /// </summary>
    [Required(ErrorMessage = "Поле \"Вид ловли\" обязательно для заполнения")]
    public required TypeOfFishing TypeOfFishing { get; set; }
    
    /// <summary>
    ///     Комментарий
    /// </summary>
    public string? Commentary { get; set; }
}