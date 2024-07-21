namespace SmartFishingApp.Dto.UserProfile.TackleCategory;

/// <summary>
///  Универсально Dto для всех сущностей приманок.
/// </summary>
public class TackleBaseReadDto
{
    /// <summary>
    ///     ID сущности
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    ///     Название приманки
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    ///     Категория приманки (На уровень ниже вида ловли - бойл, блесна, воблер, червяк)
    /// </summary>
    public string TackleCategory { get; set; }

    /// <summary>
    ///     Вид насадки
    /// </summary>
    public string? NozzleType { get; set; }

    /// <summary>
    ///     Название производителя
    /// </summary>
    public string? Brand { get; set; }

    /// <summary>
    ///     Название модели
    /// </summary>
    public string? Model { get; set; }

    /// <summary>
    ///     Фото
    /// </summary>
    public byte[]? Photo { get; set; }

    /// <summary>
    ///     Комментарий
    /// </summary>
    public string? Commentary { get; set; }
    
}