using System.Text.Json;
using System.Text.Json.Serialization;
using Interfaces.UserProfile.Tackle;
using Microsoft.AspNetCore.Mvc;
using Models.Entities.UserProfile.Tackle;
using Models.Entities.UserProfile.Tackle.TackleTypes.Spinning;
using SmartFishingApp.Models.Tackle.TackleTypes.Feeder;
using SmartFishingApp.Services.Interfaces.ITackleServices;

namespace SmartFishingApp.Controllers.UserProfile.Tackle;

/// <summary>
///     Контроллер для работы с рыболовными приманками.
/// </summary>
[Route("api/tackles")]
public class TacklesController : ControllerBase
{
    /// <summary>
    ///     Сервис маппинга сущностей рыболовных приманок.
    /// </summary>
    private readonly ITackleMapperService _tackleMapperService;
    
    /// <summary>
    ///     Сервис для работы с рыболовными приманками.
    /// </summary>
    private readonly ITackleService _tackleService;
    
    /// <summary>
    ///     Конструктор.
    /// </summary>
    /// <param name="tackleMapperService"> Сервис маппинга сущностей рыболовных приманок. </param>
    /// <param name="tackleService"> Сервис для работы с рыболовными приманками. </param>
    public TacklesController(ITackleMapperService tackleMapperService, ITackleService tackleService)
    {
        _tackleMapperService = tackleMapperService;
        _tackleService = tackleService;
    }

    [HttpPost]
    public IActionResult CreateTackle([FromBody] JsonElement jsonElement)
    {
        // Десериализуем JSON-элемент в конкретный тип сущности
        var tackleType = GetTypeFromJsonElement(jsonElement);
        var tackleTypeOfFishing = GetTackleTypeOfFishingFromJson(jsonElement);
        
        var jsonSerializerOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            ReferenceHandler = ReferenceHandler.Preserve
        };

        var tackleInstance = (TackleBase)JsonSerializer.Deserialize(jsonElement.GetRawText(), tackleType, jsonSerializerOptions)!;
        
        return Ok();
    }
    
    private Type GetTypeFromJsonElement(JsonElement jsonElement)
    {
        // Определяем тип сущности на основе свойства "tackleCategory"
        var tackleCategory = jsonElement.GetProperty("TackleCategory").GetProperty("Name").GetString();
        
        switch (tackleCategory)
        {
            case "Живая насадка":
                return typeof(FeederAlive);
            case "Бойл":
                return typeof(FeederBoil);
            case "Зерновая насадка":
                return typeof(FeederCorn);
            case "Джиг":
                return typeof(SpinningJig);
            // Добавляем другие типы сущностей
            default:
                throw new ArgumentException("Неизвестный тип сущности");
        }
    }

    private Type GetTackleTypeOfFishingFromJson(JsonElement jsonElement)
    {
        var tackleTypeFromJson = jsonElement.GetProperty("TackleCategory").GetProperty("TypeOfFishing").GetString();
        var tackleType = _context.TackleTypes.FirstOrDefault(x => x.id == tackleTypeFromJson.Id);
    }
    
    
    // нужно сохранить этот json для примера
    // {
    //     "TackleCategory": {
    //         "Id": 6,
    //         "Name": "Джиг",
    //         "TypeOfFishing": {
    //             "Name": "Джиг",
    //             "Id": 6
    //         }
    //     },
    //     "name": "Джиг для спиннинга",
    //     "brand": "Rapala",
    //     "model": "Jigging Rap",
    //     "form": "Овальная",
    //     "length": 5,
    //     "color": "Серебристый"
    // }
}