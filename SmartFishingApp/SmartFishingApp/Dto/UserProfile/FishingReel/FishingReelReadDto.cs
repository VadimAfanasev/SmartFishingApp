using JetBrains.Annotations;

namespace SmartFishingApp.Dto.UserProfile.FishingReel;

/// <summary>
///     Дто для получения катушки.
/// </summary>
[PublicAPI]
public class FishingReelReadDto
{
    /// <summary>
    ///     ID сущности
    /// </summary>
    public string Id { get; set; }
    
    /// <summary>
    ///     Название марки
    /// </summary>
    public string? Brand { get; set; }
    
    /// <summary>
    ///     Название модели
    /// </summary>
    public string? Type { get; set; }
    
    /// <summary>
    ///     Тип катушки
    /// </summary>
    public string? ReelType { get; set; }
    
    /// <summary>
    ///     Вид ловли
    /// </summary>
    public string? TypeOfFishing { get; set; }
    
    /// <summary>
    ///     Фото
    /// </summary>
    public byte[]? Photo { get; set; }
    
    /// <summary>
    ///     Комментарий
    /// </summary>
    public string? Commentary { get; set; }
}