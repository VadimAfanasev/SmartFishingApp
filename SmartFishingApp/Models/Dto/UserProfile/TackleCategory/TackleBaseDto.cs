namespace Models.Dto.UserProfile.TackleCategory;

public class TackleBaseDto
{
    /// <summary>
    ///     ID сущности
    /// </summary>
    public Guid Id { get; set; }

    //Оставляем т.к. может пригодиться для насадок на крючок
    /// <summary>
    ///     Название приманки
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    ///     Категория приманки (На уровень ниже вида ловли - бойл, блесна, воблер, червяк)
    /// </summary>
    public string TackleCategory { get; set; }

    /// <summary>
    ///     Фото
    /// </summary>
    public byte[]? Photo { get; set; }

    /// <summary>
    ///     Комментарий
    /// </summary>
    public string? Commentary { get; set; }
}