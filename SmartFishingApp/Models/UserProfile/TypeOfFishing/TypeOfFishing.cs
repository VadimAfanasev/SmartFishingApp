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
    
    // Приступить к написанию эндпоинтов
    // Подумать над реализацией softDelete
    // Добавить поле размер шпули к катушке
    // Добавить логгирование
    // Пробросить маппер сервис
}