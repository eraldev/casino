using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casino
{
    public class NumberGen
    {
        public static int Generate()
        {
            Random Number = new Random();
            return Number.Next(Properties.NumberGen.MinValue, Properties.NumberGen.MaxValue);
        }
    }
}
