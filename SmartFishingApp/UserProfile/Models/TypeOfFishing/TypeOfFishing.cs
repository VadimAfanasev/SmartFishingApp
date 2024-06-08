using System.ComponentModel.DataAnnotations;

namespace SmartFishingApp.Models.TypeOfFishing;

using Rod;

/// <summary>
///     Класс оприсывающий вид ловли
/// </summary>
public class TypeOfFishing
{
    /// <summary>
    ///     Название
    /// </summary>
    [Required]
    public string? Name { get; set; }
    
    /// <summary>
    ///     ID сущности
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    ///     Удилища
    /// </summary>
    public List<Rod>? Rods { get; set; }
}