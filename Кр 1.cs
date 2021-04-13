using System;
using System.Collections.Generic;

namespace контрольная_работа
{
    class SetofStacks
    {
        List<int> stacks { get; set; }
        int capasity { get; set; }
        internal int capasitys
        {
            set { capasity = value; }
            get { return capasity; }
        }
        internal List<int> stackks
        {
            set { stacks = value; }
            get { return stacks; }
        }
        internal SetofStacks(List<int> list)
        {
            this.stacks = list;
        }
        internal void Push(int n)
        {
            Stack<int> stack = new Stack<int>();
            if (stack != null && Convert.ToInt32(stack) < capasity)
            {
                stack.Push(n);
                stacks.Add(Convert.ToInt32(stack));
            }
            else if (stack != null && Convert.ToInt32(stack)>=capasity)
            {
                Stack<int> newstack = new Stack<int>();
                newstack.Push(n);
                stacks.Add(Convert.ToInt32(newstack));
            }
        }
        internal void Pop()
        {
            Stack<int> stack = new Stack<int>();
            if(stack==null)
                throw new Exception("EmptyStackExseption");
            int temp = stack.Pop();
        }
        internal SetofStacks GetSetofStacks()
        {
            if(this.stacks==null)
                return null;
            return new SetofStacks(this.stacks.Count - 1);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
