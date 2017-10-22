using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_1_WorkingDays
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            long workDays = 0;
            bool isHoliday = false;

            DateTime[] holidays = new DateTime[] {
                new DateTime(1901, 01, 01),
                new DateTime(1901, 03, 03),
                new DateTime(1901, 05, 01),
                new DateTime(1901, 05, 06),
                new DateTime(1901, 05, 24),
                new DateTime(1901, 09, 06),
                new DateTime(1901, 09, 22),
                new DateTime(1901, 11, 01),
                new DateTime(1901, 12, 24),
                new DateTime(1901, 12, 25),
                new DateTime(1901, 12, 26)
            };

            for (DateTime i = startDate; i <= endDate; i=i.AddDays(1))
            {
                if (i.DayOfWeek != DayOfWeek.Saturday && i.DayOfWeek != DayOfWeek.Sunday)
                {
                    foreach (var holiDate in holidays)
                    {
                        if (holiDate.Day == i.Day && holiDate.Month == i.Month)
                        {
                            isHoliday = true;
                        }
                    }
                    if (!isHoliday)
                    {
                        workDays++;
                    }
                    isHoliday = false;
                }

            }
            Console.WriteLine(workDays);

        }
    }
}
