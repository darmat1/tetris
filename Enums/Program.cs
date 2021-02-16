using System;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Day day = Day.Tue;
            int i = 3;

            Day day3 = (Day)i;
            Console.WriteLine(day3);
            if(day == Day.Tue)
            {
                Console.WriteLine("Вторник");
                Console.WriteLine((int)day);
            }



            Console.ReadLine();
        }
    }
}
