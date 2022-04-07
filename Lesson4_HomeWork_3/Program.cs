using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_HomeWork_3
{
    internal class Program
    {
        enum SeasonYear
        {
            Winter,
            Spring,
            Summer,
            Autumn
        }

        /*
         метод, принимающий на вход значение порядкового номера месяца 
         и возвращающий значение из перечисления enum SeasonYear — Winter, Spring, Summer, Autumn
        */
        static SeasonYear GetSeasonYear(int iMonth)
        {
            SeasonYear outSeason = SeasonYear.Winter;
            switch (iMonth)
            {
                case 1: case 2: case 12: outSeason = SeasonYear.Winter; break;
                case 3: case 4: case 5: outSeason = SeasonYear.Spring; break;
                case 6: case 7: case 8: outSeason = SeasonYear.Summer; break;
                case 9: case 10: case 11: outSeason = SeasonYear.Autumn; break;
            }
            return outSeason;
        }

        /*
         метод, принимающий на вход значение из перечисления enum SeasonYear 
         и возвращающий название времени года (зима, весна, лето, осень)
        */
        static string GetNameSeasonByEnum(SeasonYear seasonYear)
        {
            string sNameSeason = "";
            switch (seasonYear)
            {
                case SeasonYear.Winter: sNameSeason = "Зима"; break;
                case SeasonYear.Spring: sNameSeason = "Весна"; break;
                case SeasonYear.Summer: sNameSeason = "Лето"; break;
                case SeasonYear.Autumn: sNameSeason = "Осень"; break;
            }
            return sNameSeason;
        }

        //метод: выводит корректный номер месяца года (от 1 до 12)
        static int GetNumberMonth()
        {
            int iMonth;

            //
            do
            {
                Console.Write("Введите номер месяца от 1 до 12 : ");
                iMonth = Convert.ToInt32(Console.ReadLine());
                if (iMonth < 1 || iMonth > 12) 
                    Console.WriteLine("Ошибка: введите число от 1 до 12");
                else 
                    break;
            }
            while (true);

            //
            return iMonth;
        }

        /*
         метод, принимающий на вход значение значение порядкового номера месяца
         и возвращающий название времени года (зима, весна, лето, осень)
        */
        static string GetNameSeasonByNumberMonth(int iMonth) => GetNameSeasonByEnum(GetSeasonYear(iMonth));


        static void Main(string[] args)
        {
            Console.WriteLine("Урок 4, домашнее задание № 3");

            //
            int iMonth = GetNumberMonth();
            Console.WriteLine($"Для месяца с номером {iMonth} время года : {GetNameSeasonByNumberMonth(iMonth)}");

            //
            Console.ReadLine();
        }
    }
}
