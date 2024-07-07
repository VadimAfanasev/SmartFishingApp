using System.ComponentModel.DataAnnotations;
using JetBrains.Annotations;

namespace SmartFishingApp.Dto.UserProfile.FishingReel;

/// <summary>
///     Дто для изменения сущности рыболовной катушки.
/// </summary>
[PublicAPI]
public class FishingReelUpdateDto
{
    /// <summary>
    ///     ID сущности
    /// </summary>
    public string Id { get; set; }
    
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
    [MaxLength(200, ErrorMessage = "Слишком длинный комменатрий")]
    public string? Commentary { get; set; }    
}