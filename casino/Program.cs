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
            Lang.Settings.SetLang(Properties.Lang.DefaultLangCode);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = Properties.App.Name;
            Console.WriteLine(Lang.Locale.Welcome);
            if (Game.Player.Balance == -1)
            {
                Game.Player.Balance = Properties.Game.DefaultBalance;
            }
            MenuLoop();
        }
        static void Main(string[] args)
        {
            InitConsole();
        }
    }
}
