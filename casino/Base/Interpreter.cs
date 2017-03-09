using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casino
{
    public class Interpreter
    {
        private static void CommandIsEmpty()
        {
            //Console.WriteLine(Lang.Locale.CommandIsEmpty);
        }
        private static void CommandNotFound(string Command)
        {
            Console.WriteLine(Lang.Locale.CommandNotFound, Command);
        }
        public static void Command(string EnterCommand)
        {
            switch (EnterCommand)
            {
                case "about":
                    Base.About();
                    break;
                case "help":
                    Base.Help();
                    break;
                case "reload":
                    Base.Reload();
                    break;
                case "clear":
                    Base.Clear();
                    break;
                case "deposit":
                    Game.Deposit();
                    break;
                case "balance":
                    Game.CheckBalance();
                    break;
                case "lang":
                    Lang.Settings.Command();
                    break;
                case "play":
                    Game.Play();
                    break;
                case "exit":
                    Base.Exit();
                    break;
                case "":
                    Interpreter.CommandIsEmpty();
                    break;
                default:
                    Interpreter.CommandNotFound(EnterCommand);
                    break;
            }
        }
    }
}
