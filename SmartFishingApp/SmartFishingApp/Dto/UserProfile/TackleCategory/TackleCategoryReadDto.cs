using SmartFishingApp.Models.TypeOfFishing;

namespace SmartFishingApp.Dto.UserProfile.TackleCategory;

/// <summary>
///     Dto для отображения категории рыболовных приманок.
/// </summary>
public class TackleCategoryReadDto
{
    /// <summary>
    ///     ID сущности
    /// </summary>
    public string Id { get; set; }
    
    /// <summary>
    ///     Название категории рыболовных приманок.
    /// </summary>
    public string? Name { get; set; }
    
    /// <summary>
    ///     Вид ловли
    /// </summary>
    public string TypeOfFishing { get; set; }
    
    /// <summary>
    ///     Комментарий
    /// </summary>
    public string? Commentary { get; set; }
}