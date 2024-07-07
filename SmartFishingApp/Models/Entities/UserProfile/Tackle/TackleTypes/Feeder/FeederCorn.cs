using System.ComponentModel.DataAnnotations.Schema;
using Models.Entities.UserProfile.Tackle;

namespace SmartFishingApp.Models.Tackle.TackleTypes.Feeder;

/// <summary>
///     Зерновая насадка на крючок
/// </summary>
public class FeederCorn: TackleBase
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