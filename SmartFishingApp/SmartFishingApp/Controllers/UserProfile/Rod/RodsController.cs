using Microsoft.AspNetCore.Mvc;

namespace SmartFishingApp.Controllers.UserProfile.Rod;

/// <summary>
///     Контроллер для работы с рыболовными удилищами.
/// </summary>
[Route("api/rods")]
public class RodsController : ControllerBase
{
    /// <summary>
    ///     Сервис Маппинга сущностей Rod.
    /// </summary>
    private readonly IRodMapperService _rodMapperService;
    
    /// <summary>
    ///     Сервис для работы с сущностью удилища.
    /// </summary>
    private readonly IRodService _rodService;
}