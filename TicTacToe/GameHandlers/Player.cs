using IGameHandlers;

namespace GameHandlers
{
   public class Player: IPlayer
    {
        public string Name { set; get; }
        public  int Wins { get; set; }
        public string Tag { get; set; }
    }
}
