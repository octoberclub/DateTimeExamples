using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Now
            var d = DateTime.Now;
            Console.WriteLine("{0}, {1}", d, d.Kind);

            // Parse a Date
            var d1 = DateTime.Parse("2014-03-30 01:30", CultureInfo.CurrentCulture, DateTimeStyles.AssumeLocal);
            Console.WriteLine("{0}, {1}", d1, d.Kind);

            // Convert to Utc
            var dUtc = TimeZoneInfo.ConvertTimeToUtc(d, TimeZoneInfo.Local);
            Console.WriteLine("{0}, {1}", dUtc, dUtc.Kind);

            // Convert invalid date to Utc
            var d2Utc = TimeZoneInfo.ConvertTimeToUtc(d, TimeZoneInfo.Local);
            Console.WriteLine("{0}, {1}", d2Utc, d2Utc.Kind);

            // Arithmetic - eg. duration
            var d3 = DateTime.Parse("2014-03-30", CultureInfo.CurrentCulture, DateTimeStyles.AssumeLocal);
            var d4 = DateTime.Parse("2014-03-31", CultureInfo.CurrentCulture, DateTimeStyles.AssumeLocal);
            var duration = d4 - d3;
            Console.WriteLine("{0}, {1}, {2}", d3, d4, duration.TotalHours);

            // Show Hours
            var d5 = DateTime.Parse("2014-03-30", CultureInfo.CurrentCulture, DateTimeStyles.AssumeLocal);
            for (int hour = 0; hour < 24; hour++)
            {
                var d6 = d5.AddHours(hour);
                Console.WriteLine("{0}", d6);
                TimeZoneInfo.ConvertTimeToUtc(d6, TimeZoneInfo.Local);
            }
             
            // Show Last Day of month
            var d7 = DateTime.Parse("2014-01-31", CultureInfo.CurrentCulture, DateTimeStyles.AssumeLocal);
            for (int month = 0; month < 12; month++)
            {
                var d8 = d7.AddMonths(month);
                Console.WriteLine("{0}", d8);
            }
             
            Console.WriteLine("Press a key");
            Console.ReadKey();
        }
    }
}
