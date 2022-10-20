using System;

namespace EmployeePayRole
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int value = random.Next(0,2);//0 & 1 random number
            Console.WriteLine("Hello World!");
            
            if (value == 0)
            {
                Console.WriteLine("Present");
            }
            else
            {
                Console.WriteLine("absent");
            }

            switch(value)
            {
                case 0: Console.WriteLine("Present");break;
                default: Console.WriteLine("absent");break;
            }
        }
    }
}
