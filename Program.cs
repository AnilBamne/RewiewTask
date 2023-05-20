using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace ReviewTask
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");
            //Develop a program to get next day of a given date.
            //Expected Output:
            //Input a year: 2020
            //Input a month[1 - 12]: 08
            //Input a day[1 - 31]: 23
            //The next date is [yyyy - mm - dd] 2020 - 8 - 24
            Console.WriteLine("Ener year yyyy");
            int year=int.Parse(Console.ReadLine());

            Console.WriteLine("Ener month mm");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("Ener day dd");
            int day = int.Parse(Console.ReadLine());
            if (year != 0)
            {
                if (month <= 12)
                {
                    if(day <= 30)
                    {
                        Console.WriteLine("The next day is" + year + "-" + month + "-" + (day +1));
                    }
                    else
                    {
                        Console.WriteLine("Invalid day");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid month");
                }
            }
            else
            {
                Console.WriteLine("Invalid year");
            }

            int start = 1;
             int end = 100;
             PrintNumbers(start, end);
        }

        //Task 2 print 1 to 100 without loop
        public static void PrintNum()
        {
            int num = 1;
            if (num < 100)
            {
                int res=Increament(num);
                num=res;
            }
            Console.WriteLine(num);
        }
        public static int Increament(int num)
        {
            return num+1;
        }

        public static void PrintNumbers(int start, int end)
        {
            Console.WriteLine(start);
            if (start < end)
            {
                PrintNumbers(start + 1, end);
            }
        }

        //public static void Main(string[] args)
        //{
        //    int start = 1;
        //    int end = 100;
        //    PrintNumbers(start, end);
        //}
    }
}
