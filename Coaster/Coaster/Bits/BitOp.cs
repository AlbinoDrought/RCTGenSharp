using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coaster.Bits // https://github.com/kevinburke/rct/blob/master/bits/bits.go
{
    public static class BitOp
    {
        public static bool On(int n, int pos)
        {
            int val = n & (1 << pos);

            return val > 0;
        }

        public static int Set(int n, int pos)
        {
            n |= (1 << pos);

            return n;
        }

        public static int SetCond(int n, int pos, bool question)
        {
            if(question)
            {
                n |= (1 << pos);
            }

            return n;
        }

        public static int Clear(int n, int pos)
        {
            int mask = 0^(1 << pos);
            n &= mask;
            
            return n;
        }
    }
}
