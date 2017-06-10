using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolkoIKrzyzyk.Engine
{
    public interface IBoard
    {
        void Mark(int index1, int index2, Kind kind);
        Kind this[int index1, int index2] { get; }
    }
}
