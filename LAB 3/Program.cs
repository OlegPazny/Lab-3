using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Time t1 = new Time(03, 15, 36);
            Time t2 = new Time(05, 36, 55);
            Time t3 = new Time(08, 15, 06);
            Time t4 = new Time(11, 08, 10);
            Time t5 = new Time(12, 09, 54);
            Time t6 = new Time(15, 10, 41);
            Time t7 = new Time(20, 21, 20);
            Time t8 = new Time(23, 22, 22);
            Time[] mass = new Time[8];
            mass[0] = t1;
            mass[1] = t2;
            mass[2] = t3;
            mass[3] = t4;
            mass[4] = t5;
            mass[5] = t6;
            mass[6] = t7;
            mass[7] = t8;
            Time s1 = Time.GetInstance();
            Time s2 = Time.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("Time works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Time failed, variables contain different instances.");
            }
            double sec = t1.GetSeconds();
            t1.ReturnSec(ref sec);
            t1.ReturnMin(out double minutes);
            //вывод времени с заданным числом часов
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i].hours == 15)
                    Console.WriteLine($"Вывод времени с заданным числом часов: {mass[i]}");
            }
            //ночь 0-6, утро 7-11, день 12-16, вечер 17-24
            for (int i=0;i<mass.Length; i++)
            {
                if ((mass[i].hours > 0) && (mass[i].hours <= 6))
                    Console.WriteLine($"Ночное время: { mass[i]}");
                if ((mass[i].hours > 7) && (mass[i].hours <= 11))
                    Console.WriteLine($"Утреннее время: { mass[i]}");
                if ((mass[i].hours > 12) && (mass[i].hours <= 16))
                    Console.WriteLine($"Дневное время: { mass[i]}");
                if ((mass[i].hours > 17) && (mass[i].hours <= 24))
                    Console.WriteLine($"Вечернее время: { mass[i]}");
            }
            
            Console.ReadKey();
        }
    }
}
