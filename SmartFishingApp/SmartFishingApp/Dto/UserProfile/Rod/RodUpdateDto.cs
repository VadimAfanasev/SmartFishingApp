using System.ComponentModel.DataAnnotations;
using JetBrains.Annotations;

namespace SmartFishingApp.Dto.UserProfile.Rod;

/// <summary>
///     Dto для редактирования удилища.
/// </summary>
[PublicAPI]
public class RodUpdateDto
{
    /// <summary>
    ///     ID сущности
    /// </summary>
    public string Id { get; set; }
    
    /// <summary>
    ///     Название марки
    /// </summary>
    [MaxLength(50, ErrorMessage = "Слишком длинное название марки удилища")]
    public string? Brand { get; set; }
    
    /// <summary>
    ///     Название модели
    /// </summary>
    [MaxLength(50, ErrorMessage = "Слишком длинное название модели удилища")]
    public string? Type { get; set; }
    
    /// <summary>
    ///     Тест удилища
    /// </summary>
    [MaxLength(15, ErrorMessage = "Введен некорректный тест удилища")]
    public string? Test { get; set; }
    
    /// <summary>
    ///     Длинна удилища
    /// </summary>
    public string? Length { get; set; }
    
    /// <summary>
    ///     Класс удилища
    /// </summary>
    public string? Class { get; set; }
    
    /// <summary>
    ///     Тип удилища
    /// </summary>
    public string? RodType { get; set; }
    
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