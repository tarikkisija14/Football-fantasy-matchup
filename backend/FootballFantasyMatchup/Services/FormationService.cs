using FootballFantasyMatchup.DTOs;
using Microsoft.VisualBasic;
using System.Text.Json;

namespace FootballApi.Services
{
    public class FormationService
    {
        private readonly string _filePath = @"C:\Users\tarik\Desktop\Fantasy Matchup\backend\FootballFantasyMatchup\formations.json";
        private List<Formations> _formations;

        public FormationService() 
        {
            LoadFormations();
        }

        private void LoadFormations()
        {
            if (File.Exists(_filePath))
            {
                string json = File.ReadAllText(_filePath);

                var root = JsonSerializer.Deserialize<FormationsRoot>(json);
                _formations = root?.Formacije ?? new List<Formations>();
            }
            else
            {
                _formations = new List<Formations>();
            }



        }
        public List<Formations> GetAllFormations()
        {
            return _formations;
        }
        public Formations? GetFormationById(int id)
        {
            return _formations.FirstOrDefault(f => f.Id == id);
        }
        public Formations? GetFormationByName(string name)
        {
            return _formations.FirstOrDefault(f => f.Formacija.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

    }
}
