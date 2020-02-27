//программа исследует функцию запросить с консоли коэффициенты а в с, область определения функции, минимум, максимум, шаг интегрирования 
//выполнить исследование (найти экстремумы в области определения, определенный интеграл посчитать, среднее значение на интервале, дисперсия значений
//вывести результаты на консоль

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double b = 0, a = 0, c = 0;
            Console.Write("Ввести коэффициент а: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ввести коэффициент b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ввести коэффициент c: ");
            c = Convert.ToDouble(Console.ReadLine());
            // извращения для записи уравнения
            string str = "";
            if (a == 0) 
                Console.WriteLine("Уравнение не является квадратным");
            else
            if (b == 0)
                Console.WriteLine("Уравнение не является квадратным");
            else
            if (a == 1) str += "x^2";
                else
                {
                    if (a == -1) str += "-x^2";
                    else str += a.ToString() + "x^2";
                }

            if (b == 1) str += "+x";
                else
                {
                    if (b == -1) str += "-x";
                    else str += b.ToString() + "x";
                }

            if (c == 0) str += "";
            else
            {
                if (c>0) str += "+"+ c.ToString();
                else  str += c.ToString();
             }
            
            Console.Write("уравнение:" + str);






        }
    }
}