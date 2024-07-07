using System.ComponentModel.DataAnnotations;
using Models.Entities.UserProfile.Tackle;

namespace SmartFishingApp.Models.TypeOfFishing;

using Rod;
using Tackle;

/// <summary>
///     Класс оприсывающий вид ловли
/// </summary>
public class TypeOfFishing
{
    /// <summary>
    ///     Название
    /// </summary>
    [Required(ErrorMessage = "Поле \"Название\" обязательно для заполнения")]
    public required string Name { get; set; }
    
    /// <summary>
    ///     ID сущности
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    ///     Удилища
    /// </summary>
    public List<Rod>? Rods { get; set; }
    
    /// <summary>
    ///     Приманки
    /// </summary>
    public List<TackleCategory>? TackleCategories { get; set; }
    
    /// <summary>
    ///     Комментарий
    /// </summary>
    public string? Commentary { get; set; }
    
    // Добавить поле размер шпули к катушке
    // Добавить логгирование
}