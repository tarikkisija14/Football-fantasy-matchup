namespace FootballFantasyMatchup.DTOs
{
    public class Formations
    {
        public string Name { get; set; } = "";
        public List<FormationSpot> Spots { get; set; } = new();
    }

    public class FormationSpot
    {
        public string Position { get; set; } = "";
        public int X { get; set; }
        public int Y { get; set; }

    }

}
