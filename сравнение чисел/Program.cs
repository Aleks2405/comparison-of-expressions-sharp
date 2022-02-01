using System;
using You;
/*Пользователь вводит в строку с клавиатуры логическое 
выражение. Например, 3>2 или 7<3. Программа должна 
посчитать результат введенного выражения и дать результат true или false. В строке могут быть только целые числа 
и операторы: <, >, <=, >=, ==, !=. Для обработки ошибок 
ввода используйте механизм исключений*/
namespace You
{
    class Program
    {
        static string myFunc(int x, int y) => x > y ? ">" : x < y ? "<" : "=";
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Ваше выражение");
            string stroka;
            stroka = Console.ReadLine();
            stroka = stroka.Replace(" ", "");
            Numbers One = new Numbers(stroka);
            char sim =' ';                  
            One.Metoddd(stroka, sim, One);

            //Вера Олеговна вообще беда с двойными знаками формат стринг считаю это не выход из ситуации
            
            
        }
    }
}