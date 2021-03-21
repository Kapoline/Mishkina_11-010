using System;

namespace делегаты
{
    class Program
    {
        delegate int Delegate(int[] array);
        static void Main(string[] args)
        {
            int sum=0;
            Delegate del = delegate (int[] array)
             {
                 for (int i = 0; i < array.Length; i++)
                 {
                     sum += array[i];
                 }
                 return sum / array.Length;
             };
            Console.WriteLine("Введите размер массива");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for(int i=0;i<arr.Length;i++)
            {
                Random rnd = new Random();
                arr[i] = rnd.Next(0, 10);
            }
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
            int variable = del(arr);
            Console.WriteLine("Ответ "+variable.ToString());
        }
    }
}
