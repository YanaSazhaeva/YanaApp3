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
            double b, a, c, d1, d2;
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
            Console.Write("Ввести крайнюю левую точку: ");
            d1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ввести крайнюю правую точку: ");
            d2 = Convert.ToDouble(Console.ReadLine());
            
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
                Console.Write("Уравнение: " + str + "=0\n");

            string derivative = "";

                if (b>0) derivative += a*2 + "x" + "+" + b ;
                else{
                    if (b==0) derivative += a*2 + "x";
                    else {
                        derivative += a*2 + "x" + b ;
                    }
                }   
                Console.Write("Производная: " + derivative + "\n");
                

            double extr;
            if (b==0) extr = 0;
            else extr = -b/(2*a);
            Console.Write("Экстремум: " + extr + "\n");

            double integral;
            integral = ((a*d2*d2*d2)/3 + (b*d2*d2)/2 + c*d2) - ((a*d1*d1*d1)/3 + (b*d1*d1)/2 + c*d1);
            Console.Write("Определенный интеграл: " + Math.Round(integral, 3) + "\n");

            double middle;
            middle = integral/(d2-d1);
            Console.Write("Среднее значение: " + Math.Round(middle, 3) + "\n");
            }   

        }
    }
}