using Ninject;

namespace KolkoIKrzyzyk.Engine
{
    public class Game
    {   
        [Inject, Named("cross")]        
        public IPlayer Player1 { get; set; }
        [Inject, Named("circle")]
        public IPlayer Player2 { get; set; }

        public IBoard Board { get; private set; }

        public IPlayer CurrentPlayer { get; private set; }

        public Game(IBoard board)
        {            
            Board = board;            
        }

        public void Start()
        {
            CurrentPlayer = Player1;
        }

        public void Mark(int index1, int index2)
        {
            Board.Mark(index1, index2, CurrentPlayer.Kind);

            if (CurrentPlayer == Player1)
                CurrentPlayer = Player2;
            else
                CurrentPlayer = Player1;                       
        }
    }
}
