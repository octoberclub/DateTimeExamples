using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NodaTime;

namespace NodaTimeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Now Instance
            //var now = SystemClock.Instance.Now;
            //Console.WriteLine("{0}, {1}", now, now.GetType());

            //// Date to Utc LocalDateTime
            //var tz = DateTimeZoneProviders.Tzdb["Europe/London"];
            //var date=new LocalDateTime(2014, 3, 30, 1, 5);
            //var tzd1 = tz.AtLeniently(date);
            //var tzd2 = tzd1.ToInstant().ToDateTimeUtc();
            //Console.WriteLine("{0},{1}", tzd1, tzd2);

            //// Date Arithmetic Period
            //var d1 = new LocalDateTime(2014, 3, 30, 0, 0);
            //var d2 = new LocalDateTime(2014, 3, 31, 0, 0);
            //var duration = Period.Between(d1, d2).ToDuration();
            //Console.WriteLine("{0}, {1}", duration, duration.GetType());

            //// OffsetDateTime
            //var od = new OffsetDateTime(d1, Offset.FromHours(1));
            //Console.WriteLine(od.LocalDateTime);

            //http://www.timeanddate.com/time/change/uk/london
            // Show Hours
            //var tz = DateTimeZoneProviders.Tzdb["Europe/London"];
            //var date = new LocalDateTime(2014, 3, 30, 0, 0);
            //var tzd1=new ZonedDateTime(date, tz, Offset.FromHours(0));
            //for (int hour = 0; hour < 24; hour++)
            //{
            //    var d6 = tzd1.Plus(Duration.FromHours(hour));
            //    Console.WriteLine("{0}", d6);
            //}

            //// Show Last Day of month
            //var dm = new LocalDateTime(2014, 1, 31, 0, 0);
            //for (int month = 0; month < 12; month++)
            //{
            //    var d3 = dm.PlusMonths(month);
            //    Console.WriteLine("{0}", d3);
            //}

            Console.WriteLine("Press a key");
            Console.ReadKey();
        }
    }
}
