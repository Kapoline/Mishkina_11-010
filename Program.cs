using System;
using System.IO;

namespace данные
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] array = new int[250, 250];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(1, 10);
                }
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j]);
                }
                Console.WriteLine("\t\n");
            }
            string text = @"C:\Users\User\OneDrive\Рабочий стол\семестровка\250.txt";
            try
            {
                using (StreamWriter sw = new StreamWriter(text, true, System.Text.Encoding.Default))
                {
                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        for (int j = 0; j < array.GetLength(1); j++)
                        {
                            sw.WriteLine(array[i, j]);
                        }
                        Console.WriteLine("\t\n");
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
