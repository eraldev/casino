using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casino
{
    public class Interpreter
    {
        private static void EmptyCommand()
        {
            Console.WriteLine(Lang.Locale.EmptyCommand);
        }
        private static void UnknownCommand()
        {
            Console.WriteLine("{0} : {1}.", Lang.Locale.Error, Lang.Locale.UnknownCommand);
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
                case "deposit":
                    Game.Deposit();
                    break;
                case "balance":
                    Game.CheckBalance();
                    break;
                case "lang":
                    Lang.Settings.LangCommand();
                    break;
                case "play":
                    Game.Play();
                    break;
                case "exit":
                    Base.Exit();
                    break;
                case "":
                    Interpreter.EmptyCommand();
                    break;
                default:
                    Interpreter.UnknownCommand();
                    break;
            }
        }
    }
}
