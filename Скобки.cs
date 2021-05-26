using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;

namespace дз
{
    class Program
    {
        static bool Checking(string str)
        {
            string word = "[{(]})";
            Stack<char> stack = new Stack<char>();

            foreach (var x in word)
            {
                int vrb = word.IndexOf(x);

                if (vrb >= 0 && vrb <= 2)
                    stack.Push(x);

                if (vrb > 2)
                {
                    if (stack.Count == 0 || stack.Pop() != word[vrb - 3])
                        return false;
                }
            }
            if (stack.Count != 0)
                return false;

            return true;
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Console.WriteLine(Bracket_Checking(s) ? "Правильно" : "Не правильно");

        }
    }
}
