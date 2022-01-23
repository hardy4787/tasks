using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            float catet1, catet2, gipot;
            {
                Console.WriteLine("Напиши длину первого катета");
                string stringCatet1 = Console.ReadLine();
                catet1 = Convert.ToInt32(stringCatet1);

                Console.WriteLine("Напиши длину второго катета");
                string stringCatet2 = Console.ReadLine();
                catet2 = Convert.ToInt32(stringCatet2);

                Console.WriteLine("Напиши длину гипотенузы");
                string stringGipot = Console.ReadLine();
                gipot = Convert.ToInt32(stringGipot);
            }

            bool triangle;//это треугольник? 
            {
                triangle = catet1 + catet2 > gipot & catet2 + gipot > catet1 & catet1 + gipot > catet2;
                if (triangle)
                {
                    Console.WriteLine("Это треугольнк");
                }
                else
                {
                    Console.WriteLine("Это не треугольник");
                }

            }

            bool isosceles, equilateral, rectangular;
            {
                if (triangle)
                {
                    Console.WriteLine($"Стороны треугольника 1 катет -  {catet1}; 2 катет - {catet2}; гипотенуза - {gipot}");
                    // равнобедренный треугольник - 2 стороны равны
                    {
                        isosceles = catet1 == catet2 || catet2 == gipot || catet1 == gipot;
                        if (isosceles)
                            Console.WriteLine("Это равнобедренный треугольник");
                    }
                    //равносторонний треугольник   - 3 стороны равны
                    {
                        equilateral = catet1 == catet2 & gipot == catet1 & catet2 == gipot;
                        if (equilateral)
                            Console.WriteLine("Это равносторонний треугольнк");
                    }
                    //прямоугольный треугольник 
                    {
                        rectangular = (catet1 * catet1) + (catet2 * catet2) == (gipot * gipot) |
                            (catet1 * catet1) + (gipot * gipot) == (catet2 * catet2) | (catet2 * catet2) + (gipot * gipot) == (catet1 * catet1);
                        if (rectangular)
                            Console.WriteLine("Это прямоугольный треугольник");
                    }
                }
                else
                {
                    Console.WriteLine("Укажи верные стороны");
                }
            }
            

            Console.ReadKey();
        }
    }
}

//Напишите программу, в которой в теле метода Main примите от пользователя три стороны треугольника. Далее:
//1.Проведите проверку – возможен ли треугольник с такими сторонами.
//2. Если возможен – проверьте, является ли треугольник прямоугольным, равносторонним и равнобедренным.
//3. Выведите информацию о треугольнике на экран.
//bool triangle = (Catet1>0)&(Catet2>0)&(Catet3 > 0);  ??