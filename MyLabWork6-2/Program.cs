using System;

namespace MyLabWork6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("a="); //просим пользователя ввести число
            a = Convert.ToInt32(Console.ReadLine()); //задание переменной целого типа
            Console.WriteLine("b="); //просим пользователя ввести число
            b = Convert.ToInt32(Console.ReadLine()); //задание переменной целого типа
            
            Console.WriteLine($"{a}+{b}={b}+{a}"); //вывод на экран суммы чисел и суммы чисел в обратном порядке
        }
    }
}
