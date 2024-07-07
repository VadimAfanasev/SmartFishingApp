using System.ComponentModel.DataAnnotations.Schema;
using Models.Entities.UserProfile.Tackle;

namespace SmartFishingApp.Models.Tackle.TackleTypes.Winter;

/// <summary>
///     Зимняя блесна
/// </summary>
public class WinterSpoon: TackleBase
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
    ///     Вес приманки
    /// </summary>
    public double? Weight { get; set; }
    
    /// <summary>
    ///     Длинна приманки
    /// </summary>
    public double? Length { get; set; }
    
    /// <summary>
    ///     Цвет приманки
    /// </summary>
    public string? Color { get; set; }
}