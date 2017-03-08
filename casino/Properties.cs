using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casino
{
    public class Properties
    {
        public class App
        {
            public static string Name = "Even-Odd Game";
        }
        public class Game
        {
            public static int DefaultBalance = 100;
        }
        public class Lang
        {
            public static string DefaultLang = "ru";
        }
        public class NumberGen
        {
            public static int MinValue = 1;
            public static int MaxValue = 64;
        }

    }
}
