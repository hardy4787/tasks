using System;
using System.Diagnostics;

namespace IF__ELSE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write 4 numbers: a,b,c,d  ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            //bool para = (a % 2 != 0) && (b % 2 != 0) && (c % 2 != 0) && (d % 2 != 0);
            //if (para) {; }

            if (a % 2 != 0)
            {
                a = -1;
            }
            if (b % 2 != 0)
            {
                b = -1;
            }
            if (c % 2 != 0)
            {
                c = -1;
            }
            if (d % 2 != 0)
            {
                d = -1;
            }
            if (a > b && a > c && a > d)
            {
                Console.WriteLine(a);
            }
            else if (b > a && b > c && b > d)
            {
                Console.WriteLine(b);
            }
            else if (c > a && c > b && c > d)
            {
                Console.WriteLine(c);
            }
            else if (d > a && d > b && d > c)
            {
                Console.WriteLine(d);
            }
            else
            {
                Console.WriteLine("Not found");
            }


            if (a > b && a > c && a > d)
            {
                Console.WriteLine(a);
            }
            else if (b > a && b > c && b > d)
            {
                Console.WriteLine(b);
            }
            else if (c > a && c > b && c > d)
            {
                Console.WriteLine(c);
            }
            else if (d > a && d > b && d > c)
            {
                Console.WriteLine(d);
            }
            else
            {
                Console.WriteLine("Not found");
            }

            Console.ReadKey();
        }
    }
}
#region Switch
//сумма вклада Switch
/*float discount5_PCT=0.05f;  //5%
float discount7_PCT=0.07f;// 7%
float discount10_PCT=0.10f; //10%
Console.WriteLine("Введите сумму вклада: ");
float sum = Convert.ToInt32 (Console.ReadLine());
int bonus = 15;
switch(sum)
{
    case ( >100): Console.WriteLine($"и в конце года ты получишь { sum += sum * discount5_PCT}"); break;
    case (<= 200): Console.WriteLine($"и в конце года ты получишь { sum += sum * discount7_PCT}"); break;
    default: Console.WriteLine($"и в конце года ты получишь { sum += sum * discount10_PCT}"); break;
}

sum += bonus;
Console.WriteLine($"Сумму вклада после начисления процентов и получения бонуса: {sum}"); */
#endregion
#region консольный калькулятор
/*float a, b; string znak;
{
    Console.WriteLine("КАЛЬКУЛЯТОР");
    Console.Write("введите пример первое число   ");
    a = Convert.ToInt32(Console.ReadLine());
    Console.Write("введи знак присвоения    ");
    znak = Console.ReadLine();
    Console.Write("введите второе число и ENTER  ");
    b = Convert.ToInt32(Console.ReadLine());

}

float result = 0;
{
    const string PLUS = "+", MINUS = "-", DELENIE = "/", OSTATOK = "%", UMNOZENIE = "*";
    switch (znak)
    {
        case PLUS: { result = a + b; break; }
        case MINUS: { result = a - b; break; }
        case DELENIE:
            {
                if (b == 0)
                {
                    Console.WriteLine("делить на ноль нельзя");
                    return;
                }
                else
                    result = a / b;
                break;
            }
        case OSTATOK: { result = a % b; break; }
        case UMNOZENIE: { result = a * b; break; }
        default:
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Неподходящий символ !!");
                break;
            }
    }

}

Console.WriteLine($"{a} {znak} {b} = {result}");*/

#endregion
#region Периметр, площадь
/*int sideA, sideB;
{
    Console.Write("Укажи стороны прямоугольника,  перва сторона равна - ");
    sideA = Convert.ToInt32(Console.ReadLine());
    Console.Write("Ввторая сторона равна - ");
    sideB = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Что вы хотите укзать: площадь или периметр");
int S = sideA * sideB;
int P = (sideA + sideB) * 2;
var prase = Console.ReadLine();

{
    if (prase == "площадь")
        Console.WriteLine("Площадь прямоугольника равна {0} м2", S);
    else if (prase == "периметр")
        Console.WriteLine("Периметр прямоугольника равен {0} м", P);
    else if (sideA == sideB)
        Console.WriteLine("прямоугольник также является квадратом");
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Неверная команда");
    }
}

if (sideA == sideB)
    Console.WriteLine("прямоугольник также является квадратом");
Напишите программу, в которой примите от пользователя значения двух длин сторон прямоугольника. Далее пользователь вводит строковую команду «площадь» или «периметр». Если пользователь ввел «площадь» - вывести на экран значение площади фигуры. Если пользователь ввел «периметр» - вывести на экран значение периметра. Если пользователь ввел какую-либо другую строку – выведите «Неверная команда!».
Если прямоугольник является квадратом – дополнительно выведите на экран фразу: «данный прямоугольник – квадрат».
 */
#endregion
#region сумма вклада задача 3
/*Console.WriteLine("Введите сумму вклада: ");
double sum = Convert.ToDouble(Console.ReadLine());

if (sum < 100)
{
    sum += sum * 0.05;
}
else if (sum <= 200)
{
    sum += sum * 0.07;
}
else
{
    sum += sum * 0.1;
}
sum += 15;
Console.WriteLine($"Сумму вклада после начисления процентов: {sum}");*/
#endregion
#region сравнение чисел задача 3
/*Console.WriteLine("просьба ввести число  ");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 5)
    Console.WriteLine("Введенное чсило равно 5");
else if (num == 10)
    Console.WriteLine("Введенное чсило равно 10");
else if (num > 5&&num<10)
    Console.WriteLine("Введенное чсило больше 5 и меньше 10");
else
    Console.WriteLine(num);*/
#endregion
#region сравнение чисел задача 2
/*int a, b;
{
    Console.Write("Введи 2 числа  ");
    a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Теперь вторую  ");
    b = Convert.ToInt32(Console.ReadLine());
}
if (a > b)
    Console.WriteLine("В результате сравнения оказалось, что {0} больше {1}", a, b);
else if (a < b)
    Console.WriteLine("В результате сравнения оказалось, что {0} меньше {1}", a, b);
else
{
    Console.WriteLine("В результате сравнения оказалось, что {0} равно {1}", a, b);
}


Console.WriteLine("первое число, которое ты ввел {0}", a);
Console.WriteLine("второе число, которые ты ввел {0}", b);*/
#endregion
#region Укажи число задача 1
/*uint number;
{
    Console.WriteLine("Укажи число");
    string stringNumber = Console.ReadLine();
    number = Convert.ToUInt32(stringNumber);
}

if (number > 3) number += 10;
else number *= 10;
Console.WriteLine(number);
// Delay
Console.ReadKey();*/
/*Напишите программу, в которой в теле метода Main примите от пользователя число.
С помощью конструкции if-else реализуйте алгоритм ветвления, в котором:
Если число больше 3 – нужно увеличить значение переменной, хранящей число, на 10. Иначе – увеличить эту переменную в 10 раз. Вывести значение переменной.*/
#endregion
