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
            public static string VersionName = "0.3";
            public static int VersionCode = 14;
        }
        public class Game
        {
            public static int DefaultBalance = 100;
        }
        public class Lang
        {
            public static string DefaultLangCode = "ru";
            public static string DefaultLangName = "русский";
            public static string CurrentLangCode = Properties.Lang.DefaultLangCode;
            public static string CurrentLangName = Properties.Lang.DefaultLangName;
        }
        public class NumberGen
        {
            public static int MinValue = 1;
            public static int MaxValue = 64;
        }

    }
}
