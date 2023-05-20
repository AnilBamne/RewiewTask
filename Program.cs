using System;

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
        }
    }
}
