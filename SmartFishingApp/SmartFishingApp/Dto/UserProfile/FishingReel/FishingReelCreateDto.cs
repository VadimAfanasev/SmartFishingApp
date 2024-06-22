namespace SmartFishingApp.Dto.UserProfile.FishingReel;

using JetBrains.Annotations;
    
[PublicAPI]
public class FishingReelCreateDto
{
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