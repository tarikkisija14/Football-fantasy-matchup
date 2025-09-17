namespace FootballFantasyMatchup.DTOs
{
    public class FormationsRoot
    {
        public List<Formations> formacije { get; set; } = new(); 
    }

    public class Formations
    {
        public int id { get; set; }
        public string formacija { get; set; } = string.Empty;
        public List<string> pozicije { get; set; } = new();
    }
}
