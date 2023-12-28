namespace MillGame.Entities
{
    internal sealed class Player
    {
        public int PlayerId { get; set; }

        public string Name { get; set; }

        public int Wins { get; set; }

        public int Losses { get; set; }

        public int Draws { get; set; }

        public Color PlayerColor { get; init; }

        public int TurnsAmount { get; set; }
    }
}
