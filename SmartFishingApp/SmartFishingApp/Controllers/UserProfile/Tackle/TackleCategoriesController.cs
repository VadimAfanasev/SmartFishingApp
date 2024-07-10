using Microsoft.AspNetCore.Mvc;

namespace SmartFishingApp.Controllers.UserProfile.Tackle;

/// <summary>
///     Контроллер для работы с типами рыболовных приманок.
/// </summary>
[Route("api/tackle-categories")]
public class TackleCategoriesController : ControllerBase
{
    /// <summary>
    ///     Сервис Маппинга сущностей типов рыболовных приманок.
    /// </summary>
    private readonly ITackleCategoryMapperService _tackleCategoryMapperService;
    
    /// <summary>
    ///     Сервис для работы с типами рыболовных приманок.
    /// </summary>
    private readonly ITackleCategoryService _tackleCategoryService;
}