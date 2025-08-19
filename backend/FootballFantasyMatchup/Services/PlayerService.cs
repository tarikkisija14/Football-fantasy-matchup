using FootballFantasyMatchup.DTOs;

namespace FootballFantasyMatchup.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly FootballApiClient _client;

        public PlayerService(FootballApiClient client)
        {
            _client = client;
        }

        public Task<List<Player>> GetByPositionAsync(string position, CancellationToken ct = default)
        {
            return _client.GetPlayersByPositionAsync(position, ct);
        }
    }
}
