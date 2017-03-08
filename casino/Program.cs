using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
//using casino;

namespace casino
{
    class Program
    {
        public static void createMenu()
        {
            Console.Write("> ");
            string g = Convert.ToString(Console.ReadLine());
            Interpreter.Command(g);
            createMenu();
        }
        public static void initConsole()
        {
            Lang.Settings.SetLang(Properties.Lang.DefaultLang);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = Properties.App.Name;
            Console.WriteLine(Lang.Locale.Welcome);
            createMenu();
        }
        static void Main(string[] args)
        {
            Game.Player.Balance = Properties.Game.DefaultBalance;
            initConsole();
        }
    }
}
