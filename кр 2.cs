using System;
using System.Collections.Generic;

namespace контрольная_работа_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int capasity = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            for(int i=0;i<capasity;i++)
            {
                list.Add(rnd.Next(0, 10));
            }
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 != 0  && list[i] % 5 != 0  &&  list[i] % 3 != 0)
                {
                    list.Add(list[i]);
                    int temp = list.IndexOf(list[i]);
                    for (int j = 0; j < list.Count; j++)
                    {
                        if(temp==j)
                        {
                            int count = list[j];
                            list[j] = list[i];
                            list[i] = count;
                        }
                    }   
                }
            }
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
