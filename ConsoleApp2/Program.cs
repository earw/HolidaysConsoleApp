using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidaysConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv inn et år: ");
            int year = int.Parse(Console.ReadLine());

            DateTime easterSunday = EasterSunday(year);
            DateTime ascDay = AscensionDay(year);
            DateTime whitSunday = WhitSunday(year);
            DateTime newYearsDay = NewYearsDay(year);
            DateTime maundyThursday = MaundyThursday(year);
            DateTime goodFriday = GoodFriday(year);
            DateTime easterMonday = EasterMonday(year);
            DateTime labourDay = LabourDay(year);
            DateTime constitutionDay = ConstitutionDay(year);
            DateTime whitMonday = WhitMonday(year);
            DateTime christmasDay = ChristmasDay(year);
            DateTime boxingDay = BoxingDay(year);

            Console.WriteLine();
            Console.WriteLine(string.Format("Første nyttårsdag: {0}", newYearsDay.ToString("dd.MM.yyyy")));
            Console.WriteLine(string.Format("Skjærtorsdag: {0}", maundyThursday.ToString("dd.MM.yyyy")));
            Console.WriteLine(string.Format("Langfredag: {0}", goodFriday.ToString("dd.MM.yyyy")));
            Console.WriteLine(string.Format("Første påskedag: {0}", easterSunday.ToString("dd.MM.yyyy")));
            Console.WriteLine(string.Format("Andre påskedag: {0}", easterMonday.ToString("dd.MM.yyyy")));
            Console.WriteLine(string.Format("1. Mai: {0}", labourDay.ToString("dd.MM.yyyy")));
            Console.WriteLine(string.Format("Kristi Himmelfartsdag: {0}", ascDay.ToString("dd.MM.yyyy")));
            Console.WriteLine(string.Format("17. Mai: {0}", constitutionDay.ToString("dd.MM.yyyy")));
            Console.WriteLine(string.Format("Første pinsedag: {0}", whitSunday.ToString("dd.MM.yyyy")));
            Console.WriteLine(string.Format("Andre pinsedag: {0}", whitMonday.ToString("dd.MM.yyyy")));
            Console.WriteLine(string.Format("Første juledag: {0}", christmasDay.ToString("dd.MM.yyyy")));
            Console.WriteLine(string.Format("Andre juledag: {0}", boxingDay.ToString("dd.MM.yyyy")));


            Console.ReadLine();
        }

        public static void EasterSunday(int year, ref int month, ref int day)
        {
            int g = year % 19;
            int c = year / 100;
            int h = h = (c - (int)(c / 4) - (int)((8 * c + 13) / 25)
                                                + 19 * g + 15) % 30;
            int i = h - (int)(h / 28) * (1 - (int)(h / 28) *
                        (int)(29 / (h + 1)) * (int)((21 - g) / 11));

            day = i - ((year + (int)(year / 4) +
                          i + 2 - c + (int)(c / 4)) % 7) + 28;
            month = 3;

            if (day > 31)
            {
                month++;
                day -= 31;
            }
        }

        public static DateTime EasterSunday(int year)
        {
            int month = 0;
            int day = 0;
            EasterSunday(year, ref month, ref day);

            return new DateTime(year, month, day);
        }

        public static DateTime AscensionDay(int year)
        {
            return EasterSunday(year).AddDays(39);
        }

        public static DateTime WhitSunday(int year)
        {
            return EasterSunday(year).AddDays(49);
        }

        public static DateTime NewYearsDay(int year) => new DateTime(year, 1, 1);

        public static DateTime MaundyThursday(int year)
        {
            return EasterSunday(year).AddDays(-3);
        }

        public static DateTime GoodFriday(int year)
        {
            return EasterSunday(year).AddDays(-2);
        }

        public static DateTime EasterMonday(int year)
        {
            return EasterSunday(year).AddDays(1);
        }

        public static DateTime LabourDay(int year) => new DateTime(year, 5, 1);

        public static DateTime ConstitutionDay(int year) => new DateTime(year, 5, 17);

        public static DateTime WhitMonday(int year)
        {
            return EasterSunday(year).AddDays(50);
        }

        public static DateTime ChristmasDay(int year) => new DateTime(year, 12, 25);

        public static DateTime BoxingDay(int year) => new DateTime(year, 12, 26);
    }
}
