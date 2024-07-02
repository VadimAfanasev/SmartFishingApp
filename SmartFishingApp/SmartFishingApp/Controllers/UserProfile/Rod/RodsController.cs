using Interfaces.UserProfile.Rod;
using Microsoft.AspNetCore.Mvc;
using SmartFishingApp.Services.Interfaces.IRodServices;

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
    
    // Подумать как организовать класс удилища
}