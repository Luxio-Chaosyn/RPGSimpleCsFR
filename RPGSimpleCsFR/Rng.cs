using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimpleCsFR
{
    public static class Rng
    {
        private static Random rand = new Random();
        public static int Roll(int min, int max)
        {
            return rand.Next(min, max);
        }
    }
}
