using System;


namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Fac();
        }

        static void Fac()
        {
            int number;
            int quelse = 1;


            Console.WriteLine("Введите число: ");
            number = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i < number + 1; i++)
            {
                quelse = quelse * i;

          
            }

            Console.WriteLine("Факториал - " + quelse);
        }



      
    }
}
