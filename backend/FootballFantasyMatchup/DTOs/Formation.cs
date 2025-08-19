namespace FootballFantasyMatchup.DTOs
{
    public class Formation
    {
        public string Name { get; set; } = "";
        public List<FormationSpot> Spots { get; set; } = new();
    }

    public class FormationSpot
    {
        public string Position { get; set; } = "";
        public string X { get; set; }
        public string Y { get; set; }

    }

}
