using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casino
{
    public class Game
    {
        public class Player
        {
            public static int Balance;
        }
        public static void CheckBalance()
        {
            Console.WriteLine(Lang.Locale.YourBalance, Game.Player.Balance, Lang.Locale.Currency);
        }
        public static void GetCash(int cash)
        {
            Game.Player.Balance -= cash;
            Console.WriteLine(Lang.Locale.GetCash, cash, Lang.Locale.Currency, Game.Player.Balance);
        }
        public static void Deposit()
        {
            Console.WriteLine(Lang.Locale.DepositMessage);
            int summ;
            summ = Int32.Parse(Console.ReadLine());
            Game.Player.Balance += summ;
            Console.WriteLine(Lang.Locale.YourBalance, Game.Player.Balance, Lang.Locale.Currency);
        }
        public static int CheckParity(int number)
        {
            if(number % 2 == 0)
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }
        public static void Play()
        {
            Console.WriteLine(Lang.Locale.GameMessage, Game.Player.Balance, Lang.Locale.Currency);
            Console.Write("> ");
            int bet = Int32.Parse(Console.ReadLine());
            int sysgen;
            if (bet <= Game.Player.Balance)
            {
                Console.WriteLine(Lang.Locale.GameBet);
                int choice = Int32.Parse(Console.ReadLine()); // 1 нечет / 2 чет
                sysgen = NumberGen.Generate();
                if(CheckParity(sysgen) == choice)
                {
                    Game.Player.Balance += bet;
                    Console.WriteLine(Lang.Locale.GameWin, bet, Game.Player.Balance, Lang.Locale.Currency, sysgen);
                }
                else
                {
                    Game.Player.Balance -= bet;
                    Console.WriteLine(Lang.Locale.GameLose, bet, Game.Player.Balance, Lang.Locale.Currency, sysgen);
                }
            }
            else
            {
                Console.WriteLine("{0} : {1}", Lang.Locale.Error, Lang.Locale.NotEnoughMoney);
            }
        }
    }
}
