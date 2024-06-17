using System.ComponentModel.DataAnnotations;

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
    public Guid Id { get; set; }
    
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
    
    // определиться какие из моделей будут заполняться через миграцию значениями по умолчанию, и какие это будут значения. TackleCategory (все категории приманок из созданных моделей), TypeOfFishing (по умолчанию
    // поплавок, спинниг, фидер, зимняя)
    
    // Возможно стоит изменить ID на int или string, чтобы было удобно заполнять стандартными значениями.
    // Добавить катушку как сущность? 
}