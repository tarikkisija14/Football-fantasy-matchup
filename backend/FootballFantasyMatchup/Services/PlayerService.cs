using FootballFantasyMatchup.DTOs;
using System.Text.Json;

namespace FootballFantasyMatchup.Services
{
    public class PlayerService
    {
        private readonly string _filePath = @"C:\Users\tarik\Desktop\Fantasy Matchup\backend\FootballFantasyMatchup\fm_players.json";
        private List<Player> _players;

        public PlayerService()
        {
            LoadPlayers();
        }

        private void LoadPlayers()
        {
           if (File.Exists(_filePath))
            {
                string json =File.ReadAllText(_filePath);
                _players=JsonSerializer.Deserialize<List<Player>>(json) ?? new List<Player>();
            }
            else
            {
                _players = new List<Player>();
            }
        }

        public List<Player> GetAllPlayers()
        {
            return _players;
        }

        public List<Player> GetPlayersByClub(string club)
        {
            return _players.Where(p => p.Club.Equals(club, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Player> GetPlayersByNation(string nation)
        {
            return _players.Where(p => p.Nation.Equals(nation, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public Player? GetPlayerByName(string name)
        {
            return _players.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public List<Player> GetPlayersByPositionSorted(string position)
        {
            return _players
                .Where(p => p.Position.Contains(position, StringComparison.OrdinalIgnoreCase))
                .OrderByDescending(p => p.Rating) 
                .ToList();
        }



    }
}
