using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace casino
{
    public class Lang
    {
        public class Locale
        {
            public static string Welcome; // Выводится при запуске программы
            public static string Exit; // Выводится при выходе
            public static string CurrentLang; // Текущий язык
            public static string ExitCancel; // Выводится при отмене выхода из программы
            public static string AboutMessage; // О программе
            public static string AboutAuthor; // Автор программы
            public static string CommandNotFound; // Выводится при вводе команды с ошибкой
            public static string Error; // Выводится при ошибке
            public static string FormatException; // Выводится при исключении FormatException
            public static string HelpMessage; // Выводится при команде help
            public static string SelectLang; // Выводится при выборе языка
            public static string CommandIsEmpty; // Выводится при вводе пустой команды
            public static string Currency; // Валюта игры
            public static string NotEnoughMoney; // Выводится при нехватке денег
            public static string YourBalance; // Выводится при команде balance
            public static string GameMessage; // Выводится при команде play
            public static string GameBet; // Выводится после ввода суммы
            public static string GameWin; // Выводится при победе
            public static string GameLose; // Выводится при проигрыше
            public static string GetCash; // Выводится при снятии денег
            public static string GetCashAll; // Выводится при снятии всех денег
            public static string SaveCash; // Выводится при сохранении денег
            public static string DepositMessage; // Выводится при команде deposit
        }

        public class Settings
        {
            public static void SetLang(string language)
            {
                if (language == "ru")
                {
                    Properties.Lang.CurrentLangCode = "ru";

                    Lang.Locale.Welcome = Properties.App.Name + "\nЧтобы отобразить список команд, введите help.";
                    Lang.Locale.Error = "Ошибка";
                    Lang.Locale.CurrentLang = "Текущий язык: {0}.";
                    Lang.Locale.FormatException = "Входная строка имеет неверный формат.";
                    Lang.Locale.ExitCancel = "Выход отменен.";
                    Lang.Locale.Exit = "Вы собираетесь выйти из игры, что сделать с вашим выигрышем?\n 1) Вывести\n 2) Сохранить\n 3) Отмена!";
                    Lang.Locale.NotEnoughMoney = "Не хватает денег.";
                    Lang.Locale.DepositMessage = "Введите сумму пополнения.";
                    Lang.Locale.CommandNotFound = "{0}: Команда не найдена.";
                    Lang.Locale.AboutAuthor = "Adilbekov https://adilbekov.com/ (c) 2017.";
                    Lang.Locale.AboutMessage = "О программе: Even-Odd Game.";
                    Lang.Locale.CommandIsEmpty = "Вы не ввели команду.";
                    Lang.Locale.Currency = "UNIT";
                    Lang.Locale.GetCash = "Вы успешно вывели {0} {1} на вашу карту 4****7777. Ваш баланс {2} {1}";
                    Lang.Locale.GetCashAll = "Вы успешно вывели всю сумму ({0} {1}) на вашу карту 4****7777.";
                    Lang.Locale.GameBet = "Выберите на что ставить.\n 1) Нечетное\n 2) Четное";
                    Lang.Locale.GameWin = "Поздравляем, вы победили! Система создала число {3}. Вы выиграли {0} {2}, теперь ваш баланс составляет {1} {2}.";
                    Lang.Locale.GameLose = "К сожалению, вы проиграли! Система создала число {3}. Вы потеряли {0} {2}, теперь ваш баланс составляет {1} {2}.";
                    Lang.Locale.YourBalance = "Ваш баланс составляет {0} {1}.";
                    Lang.Locale.SelectLang = "Выберите язык:\n 1) Русский\n 2) English\n 3) Отмена";
                    Lang.Locale.SaveCash = "";
                    Lang.Locale.GameMessage = "Ваш баланс составляет {0} {1}.\n Введите сумму которую хотите поставить.";
                    Lang.Locale.HelpMessage = "Команды состоят только из строчных букв.\nСписок команд:\n play - Сделать ставку.\n balance - Проверка баланса.\n deposit - Пополнение счета.\n about - О программе.\n lang - Выбрать язык.\n exit - Выход.";
                }
                /* else if (language == "en")
                 {
                     Lang.Locale.Welcome = Properties.AppName + "\nTo display the list of commands, enter help.";
                     Lang.Locale.error = "Error";
                     Lang.Locale.aboutauthor = "Ramil Adilbekov (c) 2017.";
                     Lang.Locale.aboutmessage = "About program: Even-Odd Game.";
                     Lang.Locale.emptycommand = "You not enter the command.";
                     Lang.Locale.selectlang = "Select language:\n1) Русский\n2) English";
                     Lang.Locale.helpmessage = "play - Play.\nbalance - Check balance.\nabout - About program.\nlang - Select language.\nexit - Exit.";
                }*/
                else
                {
                    if (Properties.Lang.DefaultLangCode == "ru")
                    {
                        SetLang(Properties.Lang.DefaultLangCode);
                    }
                }

            }
            public static int Command()
            {
                Console.WriteLine(Lang.Locale.CurrentLang, Properties.Lang.CurrentLangName);
                Console.WriteLine(Lang.Locale.SelectLang);
                Console.Write("> ");
                string LangChoice = Convert.ToString(Console.ReadLine());
                string currentlang = Properties.Lang.DefaultLangCode;
                switch (LangChoice)
                {
                    case "1":
                        currentlang = "ru";
                        break;
                    case "2":
                        currentlang = "en";
                        break;
                    case "3":
                        //  Console.WriteLine(Lang.Locale.Cancel)
                        return 0;
                        //break;
                    default:
                        Console.WriteLine("{0}: {1}", Lang.Locale.Error, Lang.Locale.FormatException);
                        break;
                }
                Lang.Settings.SetLang(currentlang);
                return 0;
            }
        }
        
    }

}
