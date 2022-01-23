using System;

namespace HW
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.141593;
            const bool MY_CONST = true;

            Console.WriteLine("введите число ПИ");
            double pi;
            pi = Convert.ToDouble(Console.ReadLine());

            bool isConstBigger = PI == pi;
            bool result = MY_CONST & isConstBigger;

            Console.WriteLine($"Результат сравнения равен - {result}");
            Console.ReadKey();
        }
    }
}

//Напишите программу, в которой в теле метода Main создайте две константы - с именем PI,
//которой присвойте значение 3,141593, и с именем MY_CONST, которой присвойте значение
//true.
//Выполните сравнение того значения, которое ввел пользователь, с тем значением, которое
//хранится в константе PI и сохраните результат сравнения в переменную с именем
//iSConstBigger. Далее, проверьте на равенство значение переменной iSConstBigger со
//значением MY_CONST. Результат последнего сравнения выведите на экран консоли.

//Вопрос: почему при точке в консоле выдает ошибку, как уйти от этого.  При запятой норм. Хотя в консоле точка.