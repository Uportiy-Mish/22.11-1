using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._11_Практика_Задание_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Имя.");
            string name1 = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Введите Фамилию.");
            string name2 = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Имя: {name1}, Фамилия: {name2}");
            Console.ReadKey();

        }
    }
}
