namespace SmartFishingApp.Dto.UserProfile.TackleCategory;

public class TackleCategoryAttachmentReadDto
{
    /// <summary>
    ///     ID сущности
    /// </summary>
    public string Id { get; set; }
    
    /// <summary>
    ///     Название типа катушек
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    ///     Комментарий
    /// </summary>
    public string? Commentary { get; set; } 

    /// <summary>
    ///     Катушки данного типа
    /// </summary>
    public List<RodReadDto> Rods { get; set; }
}