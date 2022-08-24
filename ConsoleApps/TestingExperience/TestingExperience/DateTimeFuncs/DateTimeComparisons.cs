using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingExperience.DateTimeFuncs
{
    public class DateTimeComparisons
    {
        public static void AskUserForDate()
        {
            Console.WriteLine("Please enter a date in format MM/DD/YYYY");
            var date = Console.ReadLine();
            while (string.IsNullOrEmpty(date))
            {
                Console.WriteLine("Please enter a date in format MM/DD/YYYY");
                date = Console.ReadLine();
            }
            Console.WriteLine(IsDateBeforeNow(DateTime.Parse(date)));
        }
        
        public static bool IsDateBeforeNow(DateTime dateTime)
        {
            return dateTime.Ticks < DateTime.Now.Ticks;
        }
        public static bool IsDateAfterNow(DateTime dateTime)
        {
            return dateTime.Ticks > DateTime.Now.Ticks;
        }
        public static bool IsDateNow(DateTime dateTime)
        {
            return dateTime.Ticks == DateTime.Now.Ticks;
        }
    }
}
