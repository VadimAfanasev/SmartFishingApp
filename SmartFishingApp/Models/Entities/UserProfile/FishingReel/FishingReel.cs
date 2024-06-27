using System.ComponentModel.DataAnnotations;
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
    [MaxLength(50, ErrorMessage = "Слишком длинное название марки катушки")]
    public string? Brand { get; set; }
    
    /// <summary>
    ///     Название модели
    /// </summary>
    [MaxLength(50, ErrorMessage = "Слишком длинное название модели катушки")]
    public string? Type { get; set; }
    
    /// <summary>
    ///     Тип катушки
    /// </summary>
    public FishingReelType? ReelType { get; set; }
    
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
    [MaxLength(200, ErrorMessage = "Слишком длинный комменатрий")]
    public string? Commentary { get; set; }
}