using Microsoft.VisualBasic;

namespace FootballFantasyMatchup.DTOs
{
    public class Formations
    {
        public int Id { get; set; }
        public string Formacija { get; set; } = string.Empty;
        public List<string> Pozicije { get; set; } = new();
    }

    public class FormationsRoot
    {
        public List<Formations> Formacije { get; set; } = new();
    }

}
