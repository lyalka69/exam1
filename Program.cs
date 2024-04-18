using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////1.Написать программу, которая, реализует диалог с пользователем: запрашивает с клавиатуры два целых числа,
            ////и выводит на экран сумму данных чисел.

            //Console.Write("Привет! Введите пожалуйста 2 целых числа! \nx= ");
            //int x = int.Parse(Console.ReadLine());
            //Console.Write("y= ");
            //int y = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{x}+{y}={x+y}");
            //Console.ReadKey();

            ////2.Написать программу, которая, реализует диалог с пользователем: запрашивает с клавиатуры три целых числа,
            ////и выводит на экран сумму данных чисел.

            //Console.Write("Привет! Введите пожалуйста 3 целых числа! \nx= ");
            //int x1 = int.Parse(Console.ReadLine());
            //Console.Write("y= ");
            //int y2 = int.Parse(Console.ReadLine());
            //Console.Write("z= ");
            //int z3 = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{x1}+{y2}+{z3}={x1 + y2 + z3}");
            //Console.ReadKey();

            ////3.Написать программу, которая, реализует диалог с пользователем: запрашивает
            ////с клавиатуры два вещественных числа, и выводит на экран произведение данных чисел
            ////(вещественные числа выводятся с точностью до 1 знака после запятой).

            //Console.Write("Привет! Введите пожалуйста 2 вещественных числа! \nx= ");
            //double xx = double.Parse(Console.ReadLine());
            //Console.Write("y= ");
            //double yy = double.Parse(Console.ReadLine());
            //Console.WriteLine($"{xx:f1}*{yy:f1}={xx * yy:f1}");
            //Console.ReadKey();

            ////4.Написать программу, которая, реализует диалог с пользователем: запрашивает с клавиатуры два вещественных числа,
            ////и выводит на экран результат деления первого числа на второе(вещественные числа выводятся с точностью до 3 знаков после запятой):

            //Console.Write("Привет! Введите пожалуйста 2 вещественных числа! \nx= ");
            //double x2 = double.Parse(Console.ReadLine());
            //Console.Write("y= ");
            //double y2 = double.Parse(Console.ReadLine());
            //Console.WriteLine($"{x2:f3}/{y2:f3}={x2 / y2:f3}");
            //Console.ReadKey();

            ////5.Написать программу, которая, реализует диалог с пользователем: запрашивает с клавиатуры два целых числа,
            ////и выводит на экран сумму данных чисел в прямом и обратном порядке:

            //Console.Write("Привет! Введите пожалуйста 2 целых числа! \na= ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("b= ");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{a}+{b}={b}+{a} \nДля продолжения нажмите любую клавишу . . .");
            //Console.ReadKey();

            ////6.Написать программу, которая запрашивает с клавиатуры два целых числа,
            ////и выводит на экран результат их суммы, разности и произведения:

            //Console.Write("Привет! Введите пожалуйста 2 целых числа! \na= ");
            //int aa = int.Parse(Console.ReadLine());
            //Console.Write("b= ");
            //int bb = int.Parse(Console.ReadLine());
            //Console.WriteLine($"a+b={aa}+{bb}={bb + aa} \ta-b={aa}-{bb}={aa - bb} \ta*b={aa}*{bb}={aa * bb} \nДля продолжения нажмите любую клавишу . . .");
            //Console.ReadKey();

            ////7.Написать программу, которая, реализует диалог с пользователем:
            ////запрашивает с клавиатуры имя человека и его возраст, и выводит на экран следующее сообщение (текущий год – 2009):

            //Console.Write("Как тебя зовут?\t");
            //string name = Console.ReadLine();
            //Console.Write("Сколько тебе лет?\t");
            //double age = double.Parse(Console.ReadLine());
            //string genderMessage = (name.EndsWith("а") || name.EndsWith("я")) ? "родилась" : "родился";
            //Console.Write($"{name}, ты {genderMessage} в {2009 - age} году \nPress any key to continue");
            //Console.ReadKey();

            ////8.Написать программу, которая, реализует диалог с пользователем: запрашивает с клавиатуры номинал купюры и количество купюр,
            ////и выводит экран следующее сообщение:

            //Console.Write("Здравствуйте! Введите пожалуйста..\nНоминал купюры: ");
            //int banknote = int.Parse(Console.ReadLine());
            //Console.Write("Количество купюр: ");
            //int numberOfBanknotes = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Сумма денег: {banknote * numberOfBanknotes:f2}р. \nPress any key to continue");
            //Console.ReadKey();

            ////9.Написать программный код вычисления периметра квадрата со стороной а (P = 4*a).

            //№1
            //Console.Write("Привет! напиши значение для стороны квадрата:\na= ");
            //double a = double.Parse(Console.ReadLine());
            //Console.WriteLine($"P = 4*a \nP = {a * 4}");
            //Console.ReadKey();
            //№2
            //Random rnd = new Random();
            //int a = rnd.Next(1, 5000);
            //Console.WriteLine($"P = 4*a \nРандомное число: {a} \nP = {4 * a}");
            //Console.ReadKey();

            ////10.Написать программный код вычисления периметра прямоугольника со сторонами a и b (P=2*(a+b)).

            ////№1
            //Console.Write("Привет! напиши значение для сторон прямоугольника:\na= ");
            //double a = double.Parse(Console.ReadLine());
            //Console.Write("b= ");
            //double b = double.Parse(Console.ReadLine());
            //Console.WriteLine($"P = 2*(a+b) \nP = {2 * (a + b)}");
            //Console.ReadKey();
            ////№2
            //Random rnd = new Random();
            //int a = rnd.Next(1, 5000);
            //int b = rnd.Next(1, 5000);
            //Console.WriteLine($"P = 2*(a + b) \nРандомные числа: a={a} b={b} \nP = {2 * (a + b)}");
            //Console.ReadKey();

            ////11.Написать программный код вычисления длины окружности заданного радиуса R (L = 2*PI*R).

            ////№1
            //Console.Write("Привет! напиши значение радиуса окружности:\nr= ");
            //double r = double.Parse(Console.ReadLine());
            //Console.WriteLine($"L = 2*Pi*r \nP = {2 * Math.PI * r}");
            //Console.ReadKey();
            ////№2
            //Random rnd = new Random();
            //int R = rnd.Next(1, 5000);
            //Console.WriteLine($"L = 2*PI*R \nРандомные числа: a={R} \nP = {2 * Math.PI * R}");
            //Console.ReadKey();

            ////12.Пользователь указывает объем флэшки в Гб. Программа должна посчитать, сколько файлов размером в 820 Мб помещается на флэшку.

            //Console.Write("Привет! укажи объем флэшки в Гб:\nv= ");
            //int v = int.Parse(Console.ReadLine());
            //int gb = v * 1024;
            //int mb = gb / 820;
            //Console.WriteLine($"{mb} файлов размером в 820 Мб помещается на флэшку.");
            //Console.ReadKey();

            ////13.Вывести цифры двухзначного числа.

            //Console.Write("Привет! введите двухзначное число\nnum= ");
            //int num = int.Parse(Console.ReadLine());
            //if (num <= 99 && num >= 10)
            //{
            //    Console.WriteLine($"Первая цифра: {num / 10}\nВторая цифра: {num % 10}");
            //}
            //else
            //{
            //    Console.WriteLine("Вы ввели неправильное число");
            //}
            //Console.ReadKey();

            ////14.Вычислить значение функции при целых аргументах:
            //Console.Write("Привет! введите x: ");
            //int x = int.Parse(Console.ReadLine());
            //if (x >= 0)
            //{
            //    Console.WriteLine($"{Math.Sqrt(x) + (2 * Math.Sin(x)):f2}");
            //}
            //else if (x < 0)
            //{
            //    Console.WriteLine($"{6 - Math.Pow(x, 2):f2}");
            //}
            //Console.ReadKey();

            ////15.Вычислить значение функции при целых аргументах:

            //Console.Write("Привет! введите x: ");
            //int x = int.Parse(Console.ReadLine());
            //if (x <= -5)
            //{
            //    Console.WriteLine($"{Math.Pow(x, 2) + (15 * x)}");
            //}
            //else if (x >= 5)
            //{
            //    Console.WriteLine($"{((3 * x) + 1) / 5}");
            //}
            //else
            //{
            //    Console.WriteLine($"{Math.Sqrt(13 + x):f2}");
            //}
            //Console.ReadKey();

            ////16.Вычислить значение функции при целых аргументах:

            //Console.Write("hello! z= ");
            //int z = int.Parse(Console.ReadLine());
            //if (z >= 0)
            //{
            //    Console.WriteLine($"{2 + (3 * Math.Sqrt(z)):f2}");
            //}
            //else if (z < 0)
            //{
            //    Console.WriteLine($"{1 - (2 * Math.Pow(z, 2)):f2}");
            //}
            //Console.ReadKey();

            ////17.Вычислить значение функции при вещественных аргументах:

            //Console.Write("Привет! введите x: ");
            //int x = int.Parse(Console.ReadLine());
            //if (x <= -5)
            //{
            //    Console.WriteLine($"{Math.Sqrt(13 - x):f2}");
            //}
            //else if (x > -5 && x < 5)
            //{
            //    Console.WriteLine($"{Math.Abs((4 * x) - 5):f2}");
            //}
            //else if (x >= 5)
            //{
            //    Console.WriteLine($"{(3 * Math.Pow(x, 2)) - (5 * x):f2}");
            //}
            //Console.ReadKey();

            ////18.Дано целое число. Если оно является положительным, то прибавить к нему 1; в противном случае, вычесть из него 2. Вывести полученное число на экран.

            //Console.Write("Hi! num= ");
            //int num = int.Parse(Console.ReadLine());
            //if (num > 0)
            //    Console.WriteLine($"num + 1 = {num + 1}");
            //else
            //    Console.WriteLine($"num - 2 = {num - 2}");
            //Console.ReadKey();

            ////19.Дано целое число. Если оно является положительным, то прибавить к нему 1; если отрицательным, то вычесть из него 2; если нулевым, то заменить его на 10.Вывести полученное число.

            //Console.Write("Hi! num= ");
            //int num = int.Parse(Console.ReadLine());
            //if (num > 0)
            //    Console.WriteLine($"num + 1 = {num + 1}");
            //else if (num < 0)
            //    Console.WriteLine($"num - 2 = {num - 2}");
            //else
            //    Console.WriteLine(10);
            //Console.ReadKey();

            ////20.Определить, является ли число положительным, отрицательным или нулевым.

            //Console.Write("Hi! number= ");
            //double number = double.Parse(Console.ReadLine());
            //if (number > 0)
            //    Console.WriteLine("положительное");
            //else if (number < 0)
            //    Console.WriteLine("отрицательное");
            //else
            //    Console.WriteLine("нулевое");
            //Console.ReadKey();

            ////21.Определить, является ли треугольник со сторонами a, b, c равносторонним.
            //Console.Write("Введите строну треугольника a: ");
            //double a = double.Parse(Console.ReadLine());
            //Console.Write("Введите строну треугольника b: ");
            //double b = double.Parse(Console.ReadLine());
            //Console.Write("Введите строну треугольника c: ");
            //double c = double.Parse(Console.ReadLine());
            //if (a == b && b == c && c == a)
            //{
            //    Console.WriteLine("Треугольник равносторонний");
            //}
            //else
            //{
            //    Console.WriteLine("Треугольник не равносторонний");
            //}
            //Console.ReadKey();

            ////22.Составьте программу, определяющую, является ли данное число делителем числа 3.

            //Console.Write("здравствуй, введи пожалуйста число: ");
            //double n = double.Parse(Console.ReadLine());
            //if (n % 3 == 0)
            //{
            //    Console.WriteLine("является");
            //}
            //else
            //{
            //    Console.WriteLine("не является");
            //}
            //Console.ReadKey();

            ////23.Генерируется 10 случайных чисел в интервале (–30, 30). Выводятся эти числа и сообщения: отрицательное – положительное.

            //Random rnd = new Random();
            //for (int i = 1; i <= 10; i++)
            //{
            //    int a = rnd.Next(-30, 30);
            //    if (a >= 0)
            //        Console.WriteLine($"число {a} - положительное");
            //    else if (a < 0)
            //        Console.WriteLine($"число {a} - отрицательное");
            //}
            //Console.ReadKey();

            ////24.Генерируется 8 случайных чисел в интервале(–20, 30). Выводятся эти числа и сообщения: чётное – нечетное.

            ////Random rnd = new Random();
            ////for (int k = 0; k <= 8; k++)
            ////{
            ////    int d = rnd.Next(-20, 30);
            ////    if (d % 2 == 0)
            ////        Console.WriteLine($"число {d} - чётное");
            ////    else if (d % 2 != 0)
            ////        Console.WriteLine($"число {d} - нечётное");
            ////    else
            ////        Console.WriteLine($"число {d} - нулевое");
            ////}
            ////Console.ReadKey();

            ////25.Генерируется 10 случайных целых чисел в интервале (– 20, 20). Выводятся только положительные числа и сообщения: четное – нечетное (for, if).

            //Random rnd = new Random();
            //for (int k = 1; k <= 10; k++)
            //{
            //    int d = rnd.Next(-20, 20);
            //    if (d > 0 && d % 2 == 0)
            //        Console.WriteLine($"число {d} - чётное");
            //    else if (d > 0 && d % 2 != 0)
            //        Console.WriteLine($"число {d} - нечётное");
            //    else
            //        Console.WriteLine($"число {d} не прошло по условию");
            //}
            //Console.ReadKey();

            ////26.Найти максимальное число из двух целых чисел a и b.
            //Console.Write("приветствую, введите пожалуйста два целых числа:\na= ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("b= ");
            //int b = int.Parse(Console.ReadLine());
            //if (a == b)
            //{
            //    Console.WriteLine("введённые вами числа равны!");
            //}
            //else if (a > b)
            //{
            //    Console.WriteLine($"максимальное число {a} по сравнению с {b}");
            //}
            //else if (a < b)
            //{
            //    Console.WriteLine($"максимальное число {b} по сравнению с {a}");
            //}
            //Console.ReadKey();

            ////27.Дано целое число n, указывающее номер дня недели от 1 до 7. По указанному номеру n вывести название соответствующего дня недели.

            //Console.WriteLine("введите номер дня недели от 1 до 7: ");
            //byte day = byte.Parse(Console.ReadLine());
            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("понедельник");
            //        break;
            //    case 2:
            //        Console.WriteLine("вторник");
            //        break;
            //    case 3:
            //        Console.WriteLine("среда");
            //        break;
            //    case 4:
            //        Console.WriteLine("четверг");
            //        break;
            //    case 5:
            //        Console.WriteLine("пятница");
            //        break;
            //    case 6:
            //        Console.WriteLine("суббота");
            //        break;
            //    case 7:
            //        Console.WriteLine("воскресенье");
            //        break;
            //    default:
            //        Console.WriteLine("ошибка");
            //        break;
            //}
            //Console.ReadKey();

            ////28.Написать программный код вывода четных двузначных чисел.

            //for (int a = 10; a <= 99; a++)
            //{
            //    if (a % 2 == 0)
            //        Console.WriteLine(a);
            //}
            //Console.ReadKey();

            ////29.Написать программный код вывода нечетных двузначных чисел.

            //for (int a = 10; a <= 99; a++)
            //{
            //    if (a % 2 != 0)
            //        Console.WriteLine(a);
            //}
            //Console.ReadKey();

            ////30.Вывести в столбик десять раз слово «Привет!».
            //for (int a = 1; a <= 10; a++)
            //{
            //    Console.WriteLine("Привет!");
            //}
            //Console.ReadKey();

            ////31.Вывести в столбик n раз слово «Информатика».
            ////№1
            //Random rnd = new Random();
            //int n = rnd.Next(1, 17);
            //for (int num = 0; num < n; num++)
            //{
            //    Console.WriteLine("Информатика");
            //}
            //Console.ReadKey();
            ////№2
            //Console.Write("пожалуйста, введите значиение для числа n: ");
            //int n = int.Parse(Console.ReadLine()), num;
            //for (num = 1; num <= n; num++)
            //{
            //    Console.WriteLine("Информатика");
            //}
            //Console.ReadKey();

            ////32.	Вывести в столбик значения первых пяти натуральных чисел.

            //for (int a = 1; a <= 5; a++)
            //{
            //    Console.WriteLine(a);
            //}
            //Console.ReadKey();

            ////33.Вывести на экран горизонтальную строку из 18 символов.

            //int length = 18;
            //for (int i = 0; i < length; i++)
            //{
            //    Console.Write("%\t");
            //}
            //Console.WriteLine();
            //Console.ReadKey();

            ////34.Вывести в столбик первые десять натуральных чисел в обратном порядке.

            //for (int a = 10; a >= 1; a--)
            //{
            //    Console.WriteLine(a);
            //}
            //Console.ReadKey();

            ////35.Вывести на экран горизонтальную строку из 18 символов с использованием любого вида цикла.

            //int length = 18;
            //for (int i = 0; i < length; i++)
            //{
            //    Console.Write("%\t");
            //}
            //Console.WriteLine();
            //Console.ReadKey();

            ////36.Составьте таблицу значений функции y = 5x-2 на отрезке [1; 20] с шагом h = 2.

            //int w = 1;
            //for (w = 1; w <= 20; w += 2)
            //{
            //    Console.WriteLine($"x = {w} \ty= {(5 * w) - 2}");
            //}
            //Console.ReadKey();

            ////37.Составьте таблицу значений функции y = 4x - 5 на отрезке[1; 30] с шагом h = 3.

            //int x = 1;
            //for (x = 1; x <= 30; x += 3)
            //{
            //    Console.WriteLine($"x = {x} \ty= {(4 * x) - 5}");
            //}
            //Console.ReadKey();

            ////38.Составьте таблицу значений функции y = 5x² - 2x +1 на отрезке [-5; 5] с шагом h = 2.
            //int x = -5;
            //for (x = -5; x <= 5; x += 2)
            //{
            //    Console.WriteLine($"x = {x} \ty= {-5 * Math.Pow(x, 2) + 2 * x + 1}");
            //}
            //Console.ReadKey();

            ////2 cпособ

            //while (x <= 5)
            //{
            //    Console.WriteLine($"x = {x} \ty= {-5 * Math.Pow(x, 2) + 2 * x + 1}");
            //    x += 2;
            //}
            //Console.ReadKey();

            ////3 способ

            //do
            //{
            //    Console.WriteLine($"x = {x} \ty= {-5 * Math.Pow(x, 2) + 2 * x + 1}");
            //    x += 2;
            //}
            //while (x <= 5);
            //Console.ReadKey();

            ////39.Составьте таблицу значений функции y = 4x² + 5x - 10 на отрезке [-9; 9] с шагом h = 3.

            //int x = -9;
            //for (x = -9; x <= 9; x += 3)
            //{
            //    Console.WriteLine($"x = {x} \ty= {4 * Math.Pow(x, 2) + (5 * x) - 10}");
            //}
            //Console.ReadKey();

            ////40.Вывести на экран в строку следующие числа (через цикл): 1   5   7   9   11

            //for (int x = 1; x <= 11; x += 2)
            //{
            //    if (x != 3)
            //    {
            //        Console.Write($"x = {x}\t");
            //    }
            //}
            //Console.ReadKey();

            ////41.Вывести на экран в строку следующие числа (через цикл): 4   8   12   16   20

            //for (int x = 4; x <= 20; x += 4)
            //{
            //    Console.Write($"x = {x}\t");
            //}
            //Console.ReadKey();

            ////42.Вывести на экран в строку следующие числа (через цикл): 1   5   7   9   11

            //for (int x = 1; x <= 11; x += 2)
            //{
            //    if (x != 3)
            //    {
            //        Console.Write($"x = {x}\t");
            //    }
            //}
            //Console.ReadKey();

            ////43.Вывести двузначные натуральные числа, кратные 10.

            //for (int x = 10; x <= 99; x += 2)
            //{
            //    if (x % 10 == 0)
            //    {
            //        Console.WriteLine($"x = {x}");
            //    }
            //}
            //Console.ReadKey();

            ////44.Вывести на экран все целые числа от 100 до 200, кратные трем.

            //for (int x = 100; x <= 200; x += 2)
            //{
            //    if (x % 3 == 0)
            //    {
            //        Console.WriteLine($"x = {x}");
            //    }
            //}
            //Console.ReadKey();

            ////45.Одна штука некоторого товара стоит 20,4 руб. Напечатать таблицу стоимости 2, 3, ..., 20 штук этого товара.

            //for (int x = 2; x <= 20; x++)
            //{
            //    Console.Write($"x = {x * 20,4}\t");
            //}
            //Console.ReadKey();

            ////46.Напечатать ряд чисел 20 в виде: 20 20 20 20 20 20 20 20 20 20.

            //for (int x = 1; x <= 10; x++)
            //{
            //    Console.Write("20 ");
            //}
            //Console.ReadKey();

            ////47.Напечатать таблицу перевода 1, 2, ... 20 долларов США в рубли по текущему курсу (значение курса вводится с клавиатуры).
            //Console.Write("Привет! Введи пожалуйста текущий курс доллара: ");
            //double usdRate = double.Parse(Console.ReadLine());
            //for (int x = 1; x <= 20; x++)
            //{
            //    Console.Write($"{x} = {x * usdRate}\t");
            //}
            //Console.ReadKey();

            ////48.Найти сумму чисел, кратных 5, в пределах от 0 до 1000. 
            //int summa = 0;
            //for (int x = 0; x <= 1000; x++)
            //{
            //    if (x % 5 == 0)
            //    {
            //        //Console.WriteLine($"{x}");
            //        summa = summa + x;
            //    }
            //}
            //Console.Write(summa);
            //Console.ReadKey();


            ////49.Напечатать ряд чисел 10 в виде: 10 10 10 10 10 10 10 10 10 10.

            //for (int x = 1; x <= 10; x++)
            //{
            //    Console.Write("10 ");
            //}
            //Console.ReadKey();

            ////50.Вывести двузначные числа, кратные 11.

            //int summa = 0;
            //for (int x = 10; x <= 99; x++)
            //{
            //    if (x % 11 == 0)
            //    {
            //        Console.WriteLine(x);
            //    }
            //}
            //Console.ReadKey();
        }
    }
}
