using Interfaces.UserProfile.Rod;
using Microsoft.AspNetCore.Mvc;
using SmartFishingApp.Dto.UserProfile.Rod;
using SmartFishingApp.Services.Interfaces.IRodServices;

namespace SmartFishingApp.Controllers.UserProfile.Rod;

[Route("api/rod-types")]
public class RodTypesController : ControllerBase
{
    /// <summary>
    ///     Сервис Маппинга сущностей Rod.
    /// </summary>
    private readonly IRodTypeMapperService _rodTypeMapperService;
    
    /// <summary>
    ///     Сервис для работы с сущностью удилища.
    /// </summary>
    private readonly IRodTypeService _rodTypeService;
    
    /// <summary>
    ///     Конструктор.
    /// </summary>
    /// <param name="rodTypeMapperService"> Сервис Маппинга сущностей RodType. </param>
    /// <param name="rodTypeService"> Сервис для работы с сущностями RodType. </param>
    public RodTypesController(IRodTypeMapperService rodTypeMapperService,
        IRodTypeService rodTypeService)
    {
        _rodTypeMapperService = rodTypeMapperService;
        _rodTypeService = rodTypeService;
    }
    
    /// <summary>
    ///     Создание типа рыболовных удилищ.
    /// </summary>
    /// <param name="createDto"> Дто создаваемого типа. </param>
    [HttpPost]
    public async Task CreateReelAsync([FromQuery] RodTypeCreateDto createDto)
    {
        var reel = _rodTypeMapperService.CreationDtoToDomainModel(createDto);
        await _rodTypeService.CreateRodTypeAsync(reel);
    }
    
    /// <summary>
    ///     Удаление типа рыболовного удилища.
    /// </summary>
    /// <param name="id"> Id сущности. </param>
    [HttpDelete]
    public async Task DeleteReelTypeAsync([FromQuery] string id)
    {
        await _rodTypeService.DeleteRodTypeAsync(id);
    }
    
    /// <summary>
    ///     Получение одного экземпляра типа рыболовных удилищ.
    /// </summary>
    /// <param name="id"> Id сущности. </param>
    /// <returns> DTO типа удилищ. </returns>
    [HttpGet]
    public async Task<RodTypeReadDto> GetReelTypeAsync([FromQuery] string id)
    {
        var rod = await _rodTypeService.GetRodTypeAsync(id);
        return _rodTypeMapperService.DomainModelToReadDto(rod);
    }
    
    /// <summary>
    ///     Получение списка типов рыболовных удилищ.
    /// </summary>
    /// <returns> Список DTO всех типов удилищ.  </returns>
    [HttpGet]
    [Route("rodTypes")]
    public async Task<List<RodTypeReadDto>> GetReelTypesAsync()
    {
        var rodTypes = await _rodTypeService.GetRodTypesAsync();
        return _rodTypeMapperService.DomainModelToReadReelTypesDto(rodTypes);
    }
    
    /// <summary>
    ///     Получение типа удилища c удилищами этого типа.
    /// </summary>
    /// <returns> DTO удилища c удилищами этого типа.  </returns>
    [HttpGet]
    [Route("rodTypeAttachment")]
    public async Task<RodTypeAttachmentReadDto> GetReelTypesAttachmentAsync([FromQuery] string id)
    {
        var rodTypesAttachment = await _rodTypeService.GetRodTypesAttachmentAsync(id);
        return _rodTypeMapperService.DomainModelToReadReelTypesAttachmentDto(rodTypesAttachment);
    }
    
    /// <summary>
    ///     Получение списка рыболовных удилищ по переданному типу удилища.
    /// </summary>
    /// <returns> Список DTO всех удилищ данного типа.  </returns>
    [HttpGet]
    [Route("rods")]
    public async Task<RodsReadDto> GetReelsAsync([FromQuery] string id)
    {
        var rods = await _rodTypeService.GetRodsAsync(id);
        return _rodTypeMapperService.DomainModelToReadReelsDto(rods);
    }
}