namespace Models.Dto.UserProfile.Rod;

using SmartFishingApp.Models.Rod;

/// <summary>
///     Dto для для получения из контекста удилищ по переданному типу.
/// </summary>
public class RodsDto
{
    /// <summary>
    ///     Список удилищ
    /// </summary>
    public List<Rod> Rods { get; set; }
}