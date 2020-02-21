using System;

namespace _4_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            string Check = Console.ReadLine();
            int UsersInput = Convert.ToInt32(Check);
           
            if (UsersInput <= 14)
                Console.WriteLine("Ваше число попадает в [0-14]");
            if (UsersInput > 14 && UsersInput <= 35)
                Console.WriteLine("Ваше число попадает в [15-35]");
            if (UsersInput > 35 && UsersInput <= 50)
                Console.WriteLine("Ваше число попадает в [36-50]");
            if (UsersInput > 51 && UsersInput <= 100)
                Console.WriteLine("Ваше число попадает в [51-100]");
            else Console.WriteLine("Число не содержится в промежутке [0-100]");
            Console.ReadKey(); //timeout
        }
    }
}
