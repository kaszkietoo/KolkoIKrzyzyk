namespace KolkoIKrzyzyk.Engine
{
    public class Board : IBoard
    {
        public Board()
        {
            _board = new Kind[3, 3] { { Kind.Empty, Kind.Empty, Kind.Empty }, { Kind.Empty, Kind.Empty, Kind.Empty },
                                        { Kind.Empty, Kind.Empty, Kind.Empty } };          
        }

        private Kind[,] _board;
        public void Mark(int index1, int index2, Kind kind)
        {
            _board[index1, index2] = kind;
        }

        public Kind this[int index1, int index2]
        {
            get { return _board[index1, index2]; }
        }
    }
}
