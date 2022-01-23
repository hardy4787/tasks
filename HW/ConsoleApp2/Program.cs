using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        
        {
            int firstSide, secondSide, thirdSide;
            {
                Console.Write("Enter 1 side  ");
                
                firstSide = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter 2 side  ");
                secondSide = Convert.ToInt32(Console.ReadLine());

                Console.Write("Emter 3 side  ");
                thirdSide = Convert.ToInt32(Console.ReadLine());
            }

            bool desigion;
            {
                desigion = firstSide + secondSide > thirdSide & secondSide + thirdSide > firstSide & firstSide + thirdSide > secondSide;
                {
                    if (desigion)
                        Console.Write("Correct");
                    else
                        Console.Write("Mistake");

                }
            }


            bool ravnobedr, ravnostor, priamoug;
            {

                {
                    ravnobedr = firstSide == secondSide | firstSide == thirdSide | secondSide == thirdSide;
                    if (ravnobedr)
                        Console.WriteLine("Треугольник равнобедренный");
                }


                {
                    ravnostor = firstSide == secondSide & thirdSide == firstSide & secondSide == thirdSide;
                    if (ravnostor)
                        Console.WriteLine("Треугольник равносторонний");
                }


                {
                    priamoug = (firstSide * firstSide) + (secondSide * secondSide) == (thirdSide * thirdSide) | (secondSide * secondSide) + (thirdSide * thirdSide) ==
                        (firstSide * firstSide) | (firstSide * firstSide) + (thirdSide * thirdSide) == (secondSide * secondSide);
                    if (priamoug)
                        Console.WriteLine("Треугольник прямоугольный");
                }
            }

            Console.WriteLine(desigion);

            Console.ReadKey();
        }
    }
}

