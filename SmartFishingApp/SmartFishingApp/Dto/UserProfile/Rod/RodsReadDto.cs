using Models.Dto.UserProfile.Rod;

namespace SmartFishingApp.Dto.UserProfile.Rod;

/// <summary>
///     Дто для отображения списка удилищ.
/// </summary>
public class RodsReadDto
{
    /// <summary>
    ///     Список удилищ
    /// </summary>
    public RodsDto Rods { get; set; }
}