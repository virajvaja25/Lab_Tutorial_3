using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Tutorial_3
{
    //private data members
    class Clock
    {
        private int hour;
        private int min;
        private int sec;

        //constructor
        public Clock()
        {
            hour = 12;
            min = 0;
            sec = 0;
        }
        //parameterized constructor
        public Clock(int h, int m, int s)
        {
            hour = h;
            min = m;
            sec = s;
        }
        //method to increment second
        public void IncrementSecond()
        {
            sec++;
            if (sec >= 60)
            {
                sec = 0;
                min++;
                if (min == 60)
                {
                    min = 0;
                    hour++;

                    if (hour == 24)
                    {
                        hour = 0;
                    }
                }
            }
        }
        //method to display time
        public void Display()
        {
            Console.WriteLine($"{hour:D2}:{min:D2}:{sec:D2}");
        }
        //method to return hour
        public int GetHour()
        {
            return hour;
        }
        //method to return minute
        public int GetMinute()
        {
            return min;
        }
        //method to return second
        public int GetSecond()
        {
            return sec;
        }

    }
    //main class
    class Pro2
    {
        public static void _Pro2Main(string[] args)
        {
            //using no-argument constuctors
            Clock c1 = new Clock();
            Console.WriteLine("Default Time:");
            c1.Display();

            //using three-argument constructor
            Clock c2 = new Clock();
            Console.WriteLine("Intial Time:");
            c2.Display();


            //incrementing second
            c2.IncrementSecond();
            Console.Write("After 1 Second");
            c2.Display();

            c2.IncrementSecond();
            Console.WriteLine("After 2 Seconds");
            c2.Display();

            //Display individual value
            Console.WriteLine("Hour :" + c2.GetHour());
            Console.WriteLine("Minute :" + c2.GetMinute());
            Console .WriteLine("Second :" + c2.GetSecond());
        }
    }
}
