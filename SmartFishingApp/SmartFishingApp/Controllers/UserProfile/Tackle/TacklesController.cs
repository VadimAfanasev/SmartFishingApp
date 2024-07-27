using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Models.Entities.UserProfile.Tackle;
using Models.Entities.UserProfile.Tackle.TackleTypes.Spinning;
using SmartFishingApp.Models.Tackle.TackleTypes.Feeder;

namespace SmartFishingApp.Controllers.UserProfile.Tackle;

/// <summary>
///     Контроллер для работы с рыболовными приманками.
/// </summary>
[Route("api/tackles")]
public class TacklesController : ControllerBase
{
    // /// <summary>
    // ///     Сервис маппинга сущностей рыболовных приманок.
    // /// </summary>
    // private readonly ITackleMapperService _tackleMapperService;
    //
    // /// <summary>
    // ///     Сервис для работы с рыболовными приманками.
    // /// </summary>
    // private readonly ITackleService _tackleService;
    //
    // /// <summary>
    // ///     Конструктор.
    // /// </summary>
    // /// <param name="tackleMapperService"> Сервис маппинга сущностей рыболовных приманок. </param>
    // /// <param name="tackleService"> Сервис для работы с рыболовными приманками. </param>
    // public TacklesController(ITackleCMapperService tackleMapperService, ITackleService tackleService)
    // {
    //     _tackleMapperService = tackleMapperService;
    //     _tackleService = tackleService;
    // }

    [HttpPost]
    public IActionResult CreateTackle([FromBody] JsonElement jsonElement)
    {
        // Десериализуем JSON-элемент в конкретный тип сущности
        var tackleType = GetTypeFromJsonElement(jsonElement);
        var tackleInstance = (TackleBase)JsonSerializer.Deserialize(jsonElement.GetRawText(), tackleType);
        return Ok();
    }
    
    private Type GetTypeFromJsonElement(JsonElement jsonElement)
    {
        // Определяем тип сущности на основе свойства "tackleCategory"
        var tackleCategory = jsonElement.GetProperty("tackleCategory").GetString();
        switch (tackleCategory)
        {
            case "FeederAlive":
                return typeof(FeederAlive);
            case "FeederBoil":
                return typeof(FeederBoil);
            case "SpinningJig":
                return typeof(SpinningJig);
            // Добавляем другие типы сущностей
            default:
                throw new ArgumentException("Неизвестный тип сущности");
        }
    }
}