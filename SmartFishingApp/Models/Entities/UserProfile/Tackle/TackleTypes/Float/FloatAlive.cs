using System.ComponentModel.DataAnnotations.Schema;
using Models.Entities.UserProfile.Tackle;

namespace SmartFishingApp.Models.Tackle.TackleTypes.Float;

/// <summary>
///     Живая насадка на крючок
/// </summary>
public class FloatAlive: TackleBase
{
    /// <summary>
    ///     Вид насадки
    /// </summary>
    public string? NozzleType { get; set; }
}