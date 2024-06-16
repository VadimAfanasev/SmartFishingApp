namespace SmartFishingApp.Models.Rod;

using TypeOfFishing;

/// <summary>
///     Класс оприсывающий удилище
/// </summary>
public class Rod
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
    ///     Длинна удилища
    /// </summary>
    public string? Length { get; set; }
    
    /// <summary>
    ///     Класс удилища
    /// </summary>
    public string? Class { get; set; }
    
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