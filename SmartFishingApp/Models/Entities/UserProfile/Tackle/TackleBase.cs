using System.ComponentModel.DataAnnotations;

namespace SmartFishingApp.Models.Tackle;

using TypeOfFishing;

/// <summary>
///     Базовый класс описывающий приманки
/// </summary>
public class TackleBase
{
    /// <summary>
    ///     ID сущности
    /// </summary>
    public Guid Id { get; set; }
    
    //Оставляем т.к. может пригодиться для насадок на крючок
    /// <summary>
    ///     Название приманки
    /// </summary>
    public string? Name { get; set; }
    
    /// <summary>
    ///     Категория приманки (На уровень ниже вида ловли - бойл, блесна, воблер, червяк)
    /// </summary>
    [Required(ErrorMessage = "Поле \"Категория приманки\" обязательно для заполнения")]
    public required TackleCategory TackleCategory { get; set; } 
    
    /// <summary>
    ///     Фото
    /// </summary>
    public byte[]? Photo { get; set; }
    
    /// <summary>
    ///     Комментарий
    /// </summary>
    public string? Commentary { get; set; }
}