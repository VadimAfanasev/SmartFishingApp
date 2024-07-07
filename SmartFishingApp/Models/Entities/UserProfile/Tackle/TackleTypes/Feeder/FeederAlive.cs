using System.ComponentModel.DataAnnotations.Schema;
using Models.Entities.UserProfile.Tackle;

namespace SmartFishingApp.Models.Tackle.TackleTypes.Feeder;

/// <summary>
///     Живая насадка на крючок
/// </summary>
public class FeederAlive: TackleBase
{
    /// <summary>
    ///     Вид насадки
    /// </summary>
    public string? NozzleType { get; set; }
    
    /// <summary>
    ///     Прикормка
    /// </summary>
    public string? Lure { get; set; }
}