namespace SmartFishingApp.Dto.UserProfile.Rod;

/// <summary>
///     Dto для отображения сущности удилища. 
/// </summary>
public class RodReadDto
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
    ///     Тест удилища
    /// </summary>
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
    public string? Commentary { get; set; }
}