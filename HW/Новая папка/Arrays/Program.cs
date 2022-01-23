using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] monthsYear = { "january", "february", "marth", "april", "may", "june", "july", "august", "september", "october", "november", "december" };
            int index = 0;
            while (index < 12)
            {
                string valueMonth;
                {
                    Console.WriteLine("Введите значение первого месяца");
                    valueMonth = Console.ReadLine();

                }
 
                
                string month = monthsYear[index];
                Console.WriteLine(month);
                index++;
            }
            Console.ReadKey();
            /*Напишите программу, в которой воспользуйтесь массивом строк из предыдущего задания.
Создайте цикл, в котором обратитесь к пользователю. Пользователь для первой итерации цикла должен 
            ввести строковое значение первого по порядку месяца, для второй итерации – строковое 
            значение второго месяца и так далее до конца массива. Если пользователь введет неправильно 
            текущее значение месяца – итерация цикла должна повториться с тем, чтобы пользователь попробовал 
            ввести значение еще раз. Если пользователь ошибется при вводе значения 5го месяца – цикл должен прекратить свою работу.*/
        }
    }
}
#region месяцы
//string[] monthsYear = { "january", "february", "marth", "april", "may", "june", "july", "august", "september", "october", "november", "december" };
//int index = 0;
//while (index < 12) 
//{
//    string month = monthsYear[index];
//    Console.WriteLine(month);
//    index++;
//} 
/*Напишите программу, в которой создайте массив строковых элементов. В блоке 
 * инициализатора заполните массив названиями месяцев по порядку. 
 * Далее создайте цикл, в котором выведите на экран консоли все содержимое массива строк.*/
#endregion
