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
        public static void GetCash(int Cash)
        {
            if (Cash < 0)
            {
                Game.Player.Balance -= Game.Player.Balance;
                Console.WriteLine(Lang.Locale.GetCashAll, Cash, Lang.Locale.Currency);
            }
            else
            {
                Game.Player.Balance -= Cash;
                Console.WriteLine(Lang.Locale.GetCash, Cash, Lang.Locale.Currency, Game.Player.Balance);
            }
            
        }
        public static void SaveCash()
        {
            Console.WriteLine(Lang.Locale.SaveCash);
        }
        public static void Deposit()
        {
            Console.WriteLine(Lang.Locale.DepositMessage);
            int DepositSum;
            DepositSum = Int32.Parse(Console.ReadLine());
            Game.Player.Balance += DepositSum;
            Console.WriteLine(Lang.Locale.YourBalance, Game.Player.Balance, Lang.Locale.Currency);
        }
        public static int CheckParity(int Number)
        {
            if(Number % 2 == 0)
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }
        public static int Play()
        {
            Console.WriteLine(Lang.Locale.GameMessage, Game.Player.Balance, Lang.Locale.Currency);
            Console.Write("> ");
            int PlayerBet = 0, SystemGeneratedNumber;
            try
            {
                PlayerBet = Int32.Parse(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("{0} : {1}",Lang.Locale.Error,Lang.Locale.FormatException);
                return 1;
            }
            if (PlayerBet <= Game.Player.Balance)
            {
                Console.WriteLine(Lang.Locale.GameBet);
                int choice = Int32.Parse(Console.ReadLine()); // 1 нечет / 2 чет
                SystemGeneratedNumber = NumberGen.Generate();
                if(CheckParity(SystemGeneratedNumber) == choice)
                {
                    Game.Player.Balance += PlayerBet;
                    Console.WriteLine(Lang.Locale.GameWin, PlayerBet, Game.Player.Balance, Lang.Locale.Currency, SystemGeneratedNumber);
                }
                else
                {
                    Game.Player.Balance -= PlayerBet;
                    Console.WriteLine(Lang.Locale.GameLose, PlayerBet, Game.Player.Balance, Lang.Locale.Currency, SystemGeneratedNumber);
                }
            }
            else
            {
                Console.WriteLine("{0} : {1}", Lang.Locale.Error, Lang.Locale.NotEnoughMoney);
            }
            PlayerBet = 0;
            SystemGeneratedNumber = 0;
            return 0;
        }
    }
}
