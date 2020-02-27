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
            double b, a, c;
            Console.Write("Ввести коэффициент а: ");
            a = Convert.ToDouble(Console.ReadLine());
            if (a == 0) {
                Console.WriteLine("Уравнение не является квадратным");
                Environment.Exit(0);
            }
                
            else
            {               
            Console.Write("Ввести коэффициент b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ввести коэффициент c: ");
            c = Convert.ToDouble(Console.ReadLine());
            
            string str = "";

                str += a.ToString() + "x^2";
                if (b == 0)
                    str += "";
                else
                {
                    if (b>0)
                    str += " + " + b.ToString() + "x";
                    else {
                        str += b.ToString() + "x";
                    }
                }
                if (c == 0) 
                    str += "";
                else
                {
                    if (c>0) 
                        str += " + "+ c.ToString();
                    else {
                        str += c.ToString();
                    }
                }
                Console.Write("уравнение:" + str);
            }   

        }
    }
}