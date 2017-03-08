using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casino
{
    public class Base
    {
        public static void Exit()
        {

            Game.GetCash
            Environment.Exit(0);
        }
        public static void Reload()
        {
            Console.Clear();
            Console.WriteLine(Lang.Locale.Welcome);
            Program.createMenu();
        }
        public static void Help()
        {
            Console.WriteLine(Lang.Locale.HelpMessage);
        }
        public static void About()
        {
            Console.WriteLine(Lang.Locale.AboutAuthor);
            Console.WriteLine(Lang.Locale.AboutMessage);
        }
    }
}
