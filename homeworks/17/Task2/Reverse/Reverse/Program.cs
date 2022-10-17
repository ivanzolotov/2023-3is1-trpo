using System;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            reverse();
        }

        static void reverse()
        {
            string word;

            Console.WriteLine("Введите слово или предложение: ");
            word = Console.ReadLine();

            int len = word.Length;

            string quelse = "";

            char[] a = word.ToCharArray();
            
            for (int i = len - 1; i > -1; i--)
            {
                quelse = quelse + a[i];
            }

            Console.WriteLine(quelse);
        }
    }
}
