using System;
using System.Runtime.InteropServices;

namespace Homework1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            PrintLine("Введите номер задания:");
            PrintLine("1. Задания 1 и 2 вместе.");
            PrintLine("2. Задание 3");
            PrintLine("3. Задание 4a");
            PrintLine("4. Задание 4b");
            PrintLine("5. Задание 5");
            var task = ReadInt();
            switch (task)
            {
                case 1 : Task1(); break;
                case 2 : Task3(); break;
                case 3 : Task4a(); break;
                case 4 : Task4b(); break;
                case 5 : Task5(); break;
                default: 
                    PrintLine("Такого задания не существует");
                    break;
            }
        }


        #region task 1 + 2

        private static void Task1()
        {
            Print("Введите ваше имя: ");
            var name = ReadText();
            Print("Введите вашу фамилию: ");
            var surname = ReadText();
            Print("Введите ваш возраст: ");
            var age = ReadInt();
            Print("Введите ваш рост(см): ");
            var height = ReadInt();
            Print("Введите ваш вес(кг): ");
            var weight = ReadInt();

            float imt = weight / (height/100 * height/100);
                
            PrintLine("Вас зовут: " + surname + " " + name + ". Ваш возраст: " + age + ", ваш рост: " + height +
                              ", ваш вес: " + weight);
            Console.WriteLine("Вас зовут: {0} {1}. Ваш возраст: {2}, ваш рост: {3}, ваш вес: {4}", surname,
                name, age, height, weight);
            PrintLine($"Вас зовут: {surname} {name}. Ваш возраст: {age}, ваш рост: {height}, ваш вес: {weight}");
            PrintLine("**********************************************");
            PrintLine($"Ваш индекс массы тела равен {imt}");
            
            Pause();
        }
        
        #endregion

        #region Task 3

        private static void Task3()
        {
            Print("Введите координату по оси X первой точки: ");
            var x1 = ReadInt();
            Print("Введите координату по оси Y первой точки: ");
            var y1 = ReadInt();
            Print("Введите координату по оси X второй точки: ");
            var x2 = ReadInt();
            Print("Введите координату по оси Y второй точки: ");
            var y2 = ReadInt();

            var distance = Distance(x1, y1, x2, y2);
            PrintLine( $"Расстояние между точками: {distance:F2}");
            Pause();
        }

        private static double Distance(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        #endregion

        #region Task 4

        private static void Task4a()
        {
            Print("Введите первое число: ");
            var x = ReadInt();
            Print("Введите второе число: ");
            var y = ReadInt();

            var temp = x;
            x = y;
            y = temp;
            PrintLine($"Первое число: {x}, второе число: {y}");
            Pause();
        }
        private static void Task4b()
        {
            Print("Введите первое число: ");
            var x = ReadInt();
            Print("Введите второе число: ");
            var y = ReadInt();
            x += y;
            y = x - y;
            x -= y;
            
            PrintLine($"Первое число: {x}, второе число: {y}");
            Pause();
        }

        #endregion

        #region Task 5

        private static void Task5()
        {
            Print("Введите ваше имя: ");
            var name = ReadText();
            Print("Введите вашу фамилию: ");
            var surname = ReadText();
            Print("Введите ваш город: ");
            var city = ReadText();
            Console.SetCursorPosition(Console.WindowWidth/2, Console.WindowHeight/2);
            PrintLine($"Вас зовут {surname} {name}. Вы из города {city}");
            Pause();
        }

        #endregion

        #region Task 6

        private static void Pause()
        {
            Console.ReadKey();
        }

        private static void PrintLine(string text)
        {
            Console.WriteLine(text);
        }
        
        private static void Print(string text)
        {
            Console.Write(text);
        }

        private static string ReadText()
        {
            return Console.ReadLine();
        }

        private static int ReadInt()
        {
            return int.Parse(ReadText());
        }

        #endregion
        
    }
}