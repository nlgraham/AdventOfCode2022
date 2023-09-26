using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_RopeBridge
{
    internal class OrderedPair
    {
        public OrderedPair(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public void UpdateX(int addend)
        {
            X += addend;
        }
        public void UpdateY(int addend)
        {
            Y += addend;
        }

        public bool Equals(OrderedPair pair)
        {
            return X == pair.X && Y == pair.Y;
        }

        public int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode();
        }
    }
}
