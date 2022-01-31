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
            Numbers One = new Numbers(stroka);
            //bool znak = true;
            char asd = '0';
            

            char[] sumbol = stroka.ToCharArray();
            for (int i = 0; i < stroka.Length; i++)
            {
                if (sumbol[i] == '>' || sumbol[i] == '<'|| sumbol[i] == '=')
                {
                    asd = sumbol[i];
                }
            }
            One.Znak(sumbol, asd);
            One.Znak_1(sumbol, asd);
            One.Znak_2(sumbol, asd);
           // One.Znak_3(sumbol, asd);

            //       znak = (int)sumbol[0] > (int)sumbol[2] ? true : false;

            //    } else if (sumbol[i] == '<')
            //    {
            //        Console.WriteLine("prov1");
            //        znak = (int)sumbol[0] < (int)sumbol[2] ? true : false;
            //    }

            //}


            Console.WriteLine(One.Print());
          
        }
    }
}
