using System.ComponentModel.DataAnnotations.Schema;

namespace SmartFishingApp.Models.Tackle.TackleTypes.Float;

/// <summary>
///     Растительная насадка на крючок
/// </summary>
public class FloatCorn: TackleBase
{
    /// <summary>
    ///     Вид насадки
    /// </summary>
    public string? NozzleType { get; set; }
}