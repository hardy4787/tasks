using System;

namespace _24_dificult_cod
{
    class Program
    {
        static void Main(string[] args)
        {
            double value;
            int g = 0, x = 1, y = 2, z = 3, k = 15, m = 4, s;
            const double PI = 3.1415926535897931;
            bool first, second;
            {
                Console.WriteLine("Укажи цифру ! - ");
                s = Convert.ToInt32(Console.ReadLine());
                
                first = x > y && s < k;
                second = z == y && z < m;
            }
                if (first)
                {
                    g = y;
                    value = g + PI;
                    Console.WriteLine("g={0}, значение value= {1}", g, value);
                }
                else
                {
                    if (second)
                        g = z;
                    value = g + PI * 2;
                    Console.WriteLine($"число g = {g}, значение value={value}");
                }
                Console.ReadKey();
            }
        }
        #region
        /*{double value;
    int g = 0;
    int x = 1;
    int y = 2;
    int z = 3;


        if (x>y && Convert.ToInt32(Console.ReadLine())<15)
        { g = y;
            value = g + 3.1415926535897931;
            Console.WriteLine("g={0}, значение value= {1}", g, value);
        }
        else
    {
    if (z == y && z < 4)
    g = z;
    value = g + 3.14159226535897931 * 2;
    Console.WriteLine($"число g = {g}, значение value={value}");
    }
    Console.ReadKey();
    }*/
        #endregion
    }
