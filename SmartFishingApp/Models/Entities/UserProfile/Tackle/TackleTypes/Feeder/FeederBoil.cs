using System.ComponentModel.DataAnnotations.Schema;
using Models.Entities.UserProfile.Tackle;

namespace SmartFishingApp.Models.Tackle.TackleTypes.Feeder;

/// <summary>
///     Бойл для насадки
/// </summary>
public class FeederBoil: TackleBase
{
    /// <summary>
    ///     Название производителя
    /// </summary>
    public string? Brand { get; set; }
    
    /// <summary>
    ///     Название модели
    /// </summary>
    public string? Model { get; set; }
    
    /// <summary>
    ///     Размер бойла
    /// </summary>
    public double? Size { get; set; }
    
    /// <summary>
    ///     Цвет бойла
    /// </summary>
    public string? Color { get; set; }
    
    /// <summary>
    ///     Прикормка
    /// </summary>
    public string? Lure { get; set; }
}