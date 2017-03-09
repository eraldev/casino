using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace casino
{
    class Program
    {
        public static void MenuLoop()
        {
            Console.Write("> ");
            string g = Convert.ToString(Console.ReadLine());
            Interpreter.Command(g);
            MenuLoop();
        }
        public static void InitConsole()
        {
            Lang.Settings.SetLang(Properties.Lang.DefaultLang);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = Properties.App.Name;
            Console.WriteLine(Lang.Locale.Welcome);
            MenuLoop();
        }
        static void Main(string[] args)
        {
            Game.Player.Balance = Properties.Game.DefaultBalance;
            InitConsole();
        }
    }
}
