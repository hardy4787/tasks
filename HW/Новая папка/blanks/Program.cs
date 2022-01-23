using System;

namespace blanks
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            
            while (count<5)
            {
                count++;     
                Console.WriteLine(count);
            } 
                Console.ReadKey();
        } 
    }
}

#region счетчик 
/*while (true)
{
    uint oddNumbersCount = 0; //счетчик нечетный числа
    uint evenNumbersCount = 0; //счетчик четные числа

    int oddNumberSum = 0;
    int evenNumberSum = 0;

    Console.WriteLine("Введите первое число диапозона");
    var inputValue = Console.ReadLine();
    int currentValue = int.Parse(inputValue);

    Console.WriteLine("Введите верхнее число диапозона");
    int limit = int.Parse(Console.ReadLine());

    do
    {
        if (currentValue % 2 == 0)
        {
            evenNumbersCount++;
            evenNumberSum += currentValue; //= evenNumberSum + currentValue;
        }
        else
        {
            oddNumbersCount++;
            oddNumberSum += currentValue;
        }
        currentValue++;
    } while (currentValue <= limit);


        Console.WriteLine("Колличество нечетных чисел: " + oddNumbersCount);
    Console.WriteLine("Колличество четных чисел:  " + evenNumbersCount);
    Console.WriteLine("Сумма нечетных чисел:  " + oddNumberSum);
    Console.WriteLine("Сумма четных чисел:  " + evenNumberSum);
    Console.ReadKey();
}*/
#endregion