namespace FootballFantasyMatchup.DTOs
{
    public class Player
    {
        public int? Id { get; set; }
        public string Name { get; set; } = "";
        public string Position { get; set; } = "";
        public string? Club {  get; set; }
        public string? PhotoUrl {  get; set; }
    }
}
