using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace LAB_3
{
    public class Time
    {
        public byte hours;
        private byte minutes;
        private byte seconds;
        private readonly Guid id;//поле только для чтения
        private const int year = 2021;
        static public int i = 0;

        public Time(byte hours, byte minutes, byte seconds)
        {
            this.id = Guid.NewGuid();
            if ((hours > 23 || hours < 0) || (minutes > 59 || minutes < 0) || (seconds > 59 || seconds < 0)) 
            {
                Console.WriteLine("error"); //генерация исключения
            }
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
            i++;
        }
        /*private Time(): this(0, 0, 0)
        {
            i++;
        } //конструктор с перенаправлением на конструктор с 3-мя параметрами*/
        public Time(byte hours=2, byte minutes=10)
        {
            this.id = Guid.NewGuid();
            seconds = 0;
            if ((hours > 23 || hours < 0) || (minutes > 59 || minutes < 0))
            {
                Console.WriteLine("error");
            }
            this.hours = hours;
            this.minutes = minutes;
            i++;
        }
        private Time()
        {
            this.id = Guid.NewGuid();//копирнуть во все констр
            i++;
        }

        private static Time instance;


        // Это статический метод, управляющий доступом к экземпляру одиночки.
        // При первом запуске, он создаёт экземпляр одиночки и помещает его в
        // статическое поле. При последующих запусках, он возвращает клиенту
        // объект, хранящийся в статическом поле.
        public static Time GetInstance()
        {
            if (instance == null)
            {
                instance = new Time();
            }
            return instance;
        }

        public void SetHours(byte value)
        {
            if ((hours > 23) || (hours < 0))
            {
                Console.WriteLine("error");
            }
            hours = value;
        }
        public double GetHours()
        {
            return hours;
        }

        public void SetMinutes(byte value)
        {
            if ((minutes > 59) || (minutes < 0))
            {
                Console.WriteLine("error");
            }
            minutes = value;
        }
        public double GetMinutes()
        {
            return minutes;
        }

        public void SetSeconds(byte value)
        {
            if ((seconds > 59) || (seconds < 0))
            {
                Console.WriteLine("error");
            }
            seconds = value;
        }
        public double GetSeconds()
        {
            return seconds;
        }
        //статический конструктор
        static Time()
        {
            i = 0;
            Console.WriteLine("Время: \n");
        }
        public void ReturnSec(ref double seconds)
        {
            seconds += 1;
        }
        public void ReturnMin(out double minutes)
        {
            minutes=this.minutes;
        }

        public override string ToString()
        {
            return string.Format("{0}:{1}:{2}", hours, minutes, seconds);
        }
        public static void SingletonInfo()
        {
            Console.WriteLine("SINGLETON {0}:{1}:{2}", instance.hours, instance.minutes, instance.seconds);
        }
        public override int GetHashCode()
        {
            return this.minutes.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;

            Time t = (Time)obj;
            return (this.hours == t.hours);
        }
    }
}
