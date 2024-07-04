using JetBrains.Annotations;

namespace SmartFishingApp.Dto.UserProfile.Rod;

/// <summary>
///     Dto для отображения типа удилища.
/// </summary>
public class RodTypeReadDto
{
    /// <summary>
    ///     Название типа удилища.
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    ///     Комментарий.
    /// </summary>
    public string? Commentary { get; set; }
}