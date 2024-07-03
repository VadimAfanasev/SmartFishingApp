using Interfaces.UserProfile.Rod;
using Microsoft.AspNetCore.Mvc;
using SmartFishingApp.Dto.UserProfile.Rod;
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
    
    /// <summary>
    ///     Конструктор.
    /// </summary>
    /// <param name="rodMapperService"> Сервис Маппинга сущностей Rod. </param>
    /// <param name="rodService"> Сервис для работы с сущностями Rod. </param>
    public RodsController(IRodMapperService rodMapperService,
        IRodService rodService)
    {
        _rodMapperService = rodMapperService;
        _rodService = rodService;
    }
    
    /// <summary>
    ///     Создание сущности рыболовного удилища.
    /// </summary>
    /// <param name="createDto"> Дто создаваемого объекта удилища </param>
    [HttpPost]
    public async Task CreateReelAsync([FromQuery] RodCreateDto createDto)
    {
        var reel = _rodMapperService.CreationDtoToDomainModel(createDto);
        await _rodService.CreateRodAsync(reel);
    }
    
    /// <summary>
    ///     Удаление рыболовного удилища.
    /// </summary>
    /// <param name="id"> Id сущности. </param>
    [HttpDelete]
    public async Task DeleteReelAsync([FromQuery] string id)
    {
        await _rodService.DeleteRodAsync(id);
    }
    
    /// <summary>
    ///     Получение одного экземпляра рыболовного удилища.
    /// </summary>
    /// <param name="id"> Id сущности. </param>
    /// <returns> DTO удилища. </returns>
    [HttpGet]
    public async Task<RodReadDto> GetReelAsync([FromQuery] string id)
    {
        var rod = await _rodService.GetRodAsync(id);
        return _rodMapperService.DomainModelToReadDto(rod);
    }
    
    /// <summary>
    ///     Получение списка рыболовных удилищ.
    /// </summary>
    /// <returns> Список DTO всех удилищ.  </returns>
    [HttpGet]
    [Route("rods")]
    public async Task<List<RodReadDto>> GetReelsAsync()
    {
        var rods = await _rodService.GetRodsAsync();
        return _rodMapperService.DomainModelToReadRodsDto(rods);
    }
}