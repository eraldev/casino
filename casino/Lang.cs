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
            public static string ExitCancel; // Выводится при отмене выхода из программы
            public static string AboutMessage; // О программе
            public static string AboutAuthor; // Автор программы
            public static string UnknownCommand; // Выводится при вводе команды с ошибкой
            public static string Error; // Выводится при ошибке
            public static string HelpMessage; // Выводится при команде help
            public static string SelectLang; // Выводится при выборе языка
            public static string EmptyCommand; // Выводится при вводе пустой команды
            public static string Currency; // Валюта игры
            public static string NotEnoughMoney; // Выводится при нехватке денег
            public static string YourBalance; // Выводится при команде balance
            public static string GameMessage; // Выводится при команде play
            public static string GameBet; // Выводится после ввода суммы
            public static string GameWin; // Выводится при победе
            public static string GameLose; // Выводится при проигрыше
            public static string GetCash; // Выводится при снятии денег
            public static string SaveCash; // Выводится при сохранении денег
            public static string DepositMessage; // Выводится при команде deposit
        }

        public class Settings
        {
            public static void LangCommand()
            {
                Console.WriteLine(Lang.Locale.SelectLang);
                Console.Write("> ");
                int LangChoice = Convert.ToInt32(Console.ReadLine());
                string currentlang = Properties.Lang.DefaultLang;
                switch (LangChoice)
                {
                    case 1:
                        currentlang = "ru";
                        break;
                    case 2:
                        currentlang = "en";
                        break;
                    default:
                        Console.WriteLine(Lang.Locale.Error);
                        break;
                }
                Lang.Settings.SetLang(currentlang);
            }

            public static void SetLang(string language)
            {
                if (language == "ru")
                {
                    Lang.Locale.Welcome = Properties.App.Name + "\nЧтобы отобразить список команд, введите help.";
                    Lang.Locale.Error = "Ошибка";
                    Lang.Locale.ExitCancel = "Выход отменен.";
                    Lang.Locale.Exit = "Вы собираетесь выйти из игры, что сделать с вашим выигрышем?\n 1) Вывести\n 2) Сохранить\n 3) Отмена!";
                    Lang.Locale.NotEnoughMoney = "Не хватает денег.";
                    Lang.Locale.DepositMessage = "Введите сумму пополнения.";
                    Lang.Locale.UnknownCommand = "Неизвестная команда";
                    Lang.Locale.AboutAuthor = "Рамиль Адильбеков (c) 2017.";
                    Lang.Locale.AboutMessage = "О программе: Even-Odd Game.";
                    Lang.Locale.EmptyCommand = "Вы не ввели команду.";
                    Lang.Locale.Currency = "UNIT's";
                    Lang.Locale.GetCash = "Вы успешно вывели {0} {1} на вашу карту 4****7777. Ваш баланс {2} {1}";
                    Lang.Locale.GameBet = "Выберите на что ставить.\n 1) Нечетное\n 2) Четное";
                    Lang.Locale.GameWin = "Поздравляем, вы победили! Система создала число {3}. Вы выиграли {0} {2}, теперь ваш баланс составляет {1} {2}.";
                    Lang.Locale.GameLose = "К сожалению, вы проиграли! Система создала число {3}. Вы потеряли {0} {2}, теперь ваш баланс составляет {1} {2}.";
                    Lang.Locale.YourBalance = "Ваш баланс составляет {0} {1}";
                    Lang.Locale.SelectLang = "Выберите язык:\n1) Русский\n2) English";
                    Lang.Locale.SaveCash = "";
                    Lang.Locale.GameMessage = "Ваш баланс составляет {0} {1}.\n Введите сумму которую хотите поставить.";
                    Lang.Locale.HelpMessage = "Команды состоят только из строчных букв.\nСписок команд:\n play - Сделать ставку.\n balance - Проверка баланса.\n deposit - Пополнение счета.\n about - О программе.\n lang - Выбрать язык.\n exit - Выход.";
                }
                else if (language == "en")
                {
         /*           Lang.Locale.Welcome = Properties.AppName + "\nTo display the list of commands, enter help.";
                    Lang.Locale.error = "Error";
                    Lang.Locale.aboutauthor = "Ramil Adilbekov (c) 2017.";
                    Lang.Locale.aboutmessage = "About program: Even-Odd Game.";
                    Lang.Locale.emptycommand = "You not enter the command.";
                    Lang.Locale.selectlang = "Select language:\n1) Русский\n2) English";
                    Lang.Locale.helpmessage = "play - Play.\nbalance - Check balance.\nabout - About program.\nlang - Select language.\nexit - Exit.";
           */     }
                else
                {
                    if (Properties.Lang.DefaultLang == "ru" || Properties.Lang.DefaultLang == "en")
                    {
                        SetLang(Properties.Lang.DefaultLang);
                    }
                }
            }
        }
        
    }

}
