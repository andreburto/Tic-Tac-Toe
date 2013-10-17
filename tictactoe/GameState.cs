using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe
{
    class GameState
    {
        private List<TLine> _states = new List<TLine>();

        // Check for a winning line
        public bool CheckBoardForWin(string[] sqrs)
        {
            foreach (TLine tl in _states)
            {
                if (sqrs[tl.A] == sqrs[tl.B] && sqrs[tl.B] == sqrs[tl.C])
                {
                    if (sqrs[tl.A] != "") { return true; }
                }
            }
            return false;
        }

        // Check for a full board
        public bool CheckBoardForFull(string[] sqrs)
        {
            int count = 0;
            foreach (string s in sqrs)
            {
                if (s != "") { count++; }
            }
            if (count == 9) { return true; }
            return false;
        }

        public GameState()
        {
            _states.Add(new TLine(0, 1, 2));
            _states.Add(new TLine(3, 4, 5));
            _states.Add(new TLine(6, 7, 8));
            _states.Add(new TLine(0, 3, 6));
            _states.Add(new TLine(1, 4, 7));
            _states.Add(new TLine(2, 5, 8));
            _states.Add(new TLine(0, 4, 8));
            _states.Add(new TLine(6, 4, 2));
        }
    }

    class TLine
    {
        private int _a;
        private int _b;
        private int _c;

        public int A
        {
            get { return _a; }
        }

        public int B
        {
            get { return _b; }
        }

        public int C
        {
            get { return _c; }
        }

        public TLine(int a, int b, int c)
        {
            _a = a;
            _b = b;
            _c = c;
        }
    }
}
