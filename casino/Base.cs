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
            Console.WriteLine(Lang.Locale.Exit);
            int Choice = Convert.ToInt32(Console.ReadLine());
            switch (Choice)
            {
                case 1:
                    Game.GetCash(-1);
                    Environment.Exit(0);
                    break;
                case 2:
                    Game.SaveCash();
                    Environment.Exit(0);
                    break;
                case 3:
                    Console.WriteLine(Lang.Locale.ExitCancel);
                    break;
                default:
                    Console.WriteLine(Lang.Locale.Error);
                    break;
            }
            
        }
        public static void Reload()
        {
            Console.Clear();
            Console.WriteLine(Lang.Locale.Welcome);
            Program.MenuLoop();
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
