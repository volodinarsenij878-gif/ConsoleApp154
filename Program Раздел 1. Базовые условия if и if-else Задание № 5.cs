using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program5
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите число: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                if (n % 5 == 0)
                    Console.WriteLine("Делится на 5");
                else
                    Console.WriteLine("Не делится на 5");
            }
            else
            {
                Console.WriteLine("Ошибка ввода.");
            }
        }
    }
}