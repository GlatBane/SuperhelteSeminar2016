using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperhelteSeminar2016
{
    class Program
    {
        static void Main(string[] args)
        {
            int weekday = 6; // 2016 er en søndag
            int remaining = 3; // hvor mange skal vi finde
            int year = 2017; // det næste år
            while(remaining != 0)
            {
                weekday = (weekday + DaysInYear(year)) % 7;
                switch(weekday)
                {
                    case 5: // Lørdag
                    case 6: // Søndag
                        Console.WriteLine("år {0} er en {1}dag", year, weekday==5?"Lør":"Søn");
                        remaining--;
                        break;
                }

                year++;
            }
        }

        static int DaysInYear(int year)
        {
            // helt sikkert ikke et skudår
            if(year % 4 != 0)
            {
                return 365;
            }

            if(year % 400== 0)
            {
                return 366;
            }

            // rammer modulo 100 reglen men ikke modulo 400
            if(year % 100 == 0)
            {
                return 365;
            }

            return 366;
        }
    }
}
