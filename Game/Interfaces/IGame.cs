

namespace Game.Interfaces
{
    public interface IGame
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public int GameRating { get; set; }
        public float GamePrize { get; set; }


    }
}
