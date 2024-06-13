namespace SmartFishingApp.Models.Tackle.TackleTypes.Float;

/// <summary>
///     Живая насадка на крючок
/// </summary>
public class Alive: TackleBase
{
    /// <summary>
    ///     Вид насадки
    /// </summary>
    public string? NozzleType { get; set; }
}