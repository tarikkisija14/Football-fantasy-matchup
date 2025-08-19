using FootballFantasyMatchup.DTOs;
using Microsoft.Extensions.Options;

namespace FootballFantasyMatchup
{
    public class FootballApiClient
    {
        private readonly HttpClient _httpClient;
        private readonly FootballApiSettings _settings;

        public FootballApiClient(HttpClient httpClient, IOptions<FootballApiSettings> settings)
        {
            _httpClient = httpClient;
            _settings = settings.Value;

            if(!string.IsNullOrWhiteSpace(_settings.BaseUrl) &&
                    !_httpClient.DefaultRequestHeaders.Contains("x-apisports-key"))
            {
                _httpClient.DefaultRequestHeaders.Add("x-apisports-key", _settings.ApiKey);
            }



        }
        public Task<List<Player>> GetPlayersByPositionAsync(string position, CancellationToken ct = default)
        {
            var demo = new List<Player>
            {
                new() { Name = "Casemiro", Position = "DM", Club = "Manchester United" },
                new() { Name = "Rodri",    Position = "DM", Club = "Manchester City" },
                new() { Name = "A. Tchouaméni", Position = "DM", Club = "Real Madrid" }
            };

            var filtered = demo
                .Where(p => string.Equals(p.Position, position, StringComparison.OrdinalIgnoreCase))
                .ToList();

            return Task.FromResult(filtered);
        }
    }
}
