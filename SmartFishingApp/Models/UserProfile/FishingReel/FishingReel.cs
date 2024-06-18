using SmartFishingApp.Models.TypeOfFishing;

namespace Models.UserProfile.FishingReel;

/// <summary>
///     Класс описывающий катушку
/// </summary>
public class FishingReel
{
    /// <summary>
    ///     ID сущности
    /// </summary>
    public Guid Id { get; set; }
    
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
    public ReelType? ReelType { get; set; }
    
    /// <summary>
    ///     Вид ловли
    /// </summary>
    public TypeOfFishing? TypeOfFishing { get; set; }
    
    /// <summary>
    ///     Фото
    /// </summary>
    public byte[]? Photo { get; set; }
    
    /// <summary>
    ///     Комментарий
    /// </summary>
    public string? Commentary { get; set; }
}