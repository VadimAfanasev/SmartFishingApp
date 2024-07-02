using SmartFishingApp.Dto.UserProfile.Rod;
using SmartFishingApp.Models.Rod;

namespace SmartFishingApp.Services.Interfaces.IRodServices;

/// <summary>
///     Сервис маппинга рыболовных удилищ.
/// </summary>
public interface IRodMapperService
{
    /// <summary>
    ///     Создание доменной модели <see cref="Rod" /> из <see cref="RodCreateDto" />.
    /// </summary>
    /// <param name="createDto"> Дто создаваемой сущности </param>
    /// <returns> <see cref="Rod" />. </returns>
    Rod CreationDtoToDomainModel(RodCreateDto createDto);
    
    /// <summary>
    ///     Создание ДТО модели <see cref="RodReadDto" /> из <see cref="Rod" />.
    /// </summary>
    /// <param name="rod"> Доменная модель удилища. </param>
    /// <returns> <see cref="RodReadDto" />. </returns>
    RodReadDto DomainModelToReadDto(Rod rod);
    
    /// <summary>
    ///     Создание списка ДТО моделей <see cref="RodReadDto" /> из списка <see cref="Rod" />.
    /// </summary>
    /// <param name="rods"> Список доменных моделей удилища. </param>
    /// <returns> Список <see cref="RodReadDto" />. </returns>
    List<RodReadDto> DomainModelToReadRodsDto(List<Rod> rods);
}
    