using FootballFantasyMatchup.DTOs;

namespace FootballFantasyMatchup.Services
{
    public interface IPlayerService
    {
        Task<List<Player>> GetByPositionAsync(string position, CancellationToken ct = default);
    }
}
