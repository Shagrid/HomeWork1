using System;
using System.IO;

namespace Homework1
{
    /*
     * Домашнее задание Максакова Сергей
     * Дан  целочисленный  массив  из 20 элементов.  Элементы  массива  могут принимать  целые  значения  от –10 000 до 10 000 включительно. Заполнить случайными числами.  Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2. 
     * Реализуйте задачу 1 в виде статического класса StaticClass;
     * а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
     * б) *Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
     * в)**Добавьте обработку ситуации отсутствия файла на диске.

     */
    static class StaticClass
    {
        
        public static int GetArrayResult(int[] array)
        {
            int[] tempArr;
            if (array.Length > 20)
            {
                tempArr = new int[20];
                for (var i = 0; i < 20; i++)
                {
                    tempArr[i] = array[i];
                }
            }
            else
            {
                tempArr = array;
            }

            var count = 0;

            for (var i = 1; i < tempArr.Length; i++)
            {
                var x1 = tempArr[i] % 3;
                var x2 = tempArr[i - 1] % 3;
                if ((x1 > 0 && x2 == 0) || (x1 == 0 && x2 > 0))
                    count++;
            }

            return count;
        }

        public static void GetArrayInFile(string file)
        {
            var array = new int[20];
            try
            {
                var sr = new StreamReader(file);
                var count = 0;
                while (!sr.EndOfStream)
                {
                    array[count] = int.Parse(sr.ReadLine());
                    count++;
                    if (count == 20) break;
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e}");
            }

            StaticClass.GetArrayResult(array);
        }
        
    }
    
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var array = new int[20];
            var rnd = new Random();
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-10000, 10000);
            }

            var result = StaticClass.GetArrayResult(array);
            Console.WriteLine($"Результат работы программы: {result}");
        }
    }
}