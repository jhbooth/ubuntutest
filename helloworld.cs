using System;
using System.Resources;
using System.Reflection;
using System.Threading;
using System.Globalization;
using helloworld.Properties;

namespace helloworld
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            string day;
            string year;
            string holiday;
            string celebrate;

            Console.WriteLine(Resources.langdefault);

            // Get the resource strings for the day, year, and holiday
            // using the current UI culture.
            day = Resources.day;
            year = Resources.year;
            holiday = Resources.holiday;
            celebrate = Resources.celebrate;
            Console.WriteLine(celebrate, holiday, day, year);


            // Now do es-MX culture
            Console.WriteLine(Resources.langesMX);
            CultureInfo esmx = new CultureInfo("es-MX");
            Resources.Culture = esmx;
            day = Resources.day;
            celebrate = Resources.celebrate;
            year = Resources.year;
            holiday = Resources.holiday;
            Console.WriteLine(celebrate, holiday, day, year);

            // Now do fr-CA culture.
            Console.WriteLine(Resources.langfrCA);
            CultureInfo frca = new CultureInfo("fr-CA");
            Resources.Culture = frca;
            day = Resources.day;
            celebrate = Resources.celebrate;
            year = Resources.year;
            holiday = Resources.holiday;
            Console.WriteLine(celebrate, holiday, day, year);

            Console.WriteLine(Resources.ztest);

            foreach (string x in args)
            {
                Console.WriteLine(x);
            }

#if NET50
            Console.WriteLine(Resources.zznet50);
#else
            Console.WriteLine(Resources.zznetcore);
#endif

        }
    }
}
