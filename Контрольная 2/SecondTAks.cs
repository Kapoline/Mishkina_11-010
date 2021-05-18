using System;
using System.Collections.Generic;

namespace кр
{
    class Point
    {
        private int x { get; set; }
        private int y { get; set; }
        private int N { get; set; }
        public Point(int newX, int newY)
        {
            this.x = newX;
            this.y = newY;
        }
        public Point SegmentX(int _y)
        {
            this.x = 0;
            this.y = _y;
            return new Point(this.x, this.y);
        }
        public Point SegmentY(int _x)
        {
            this.x = _x;
            this.y = 0;
            return new Point(this.x, this.y);
        }
        public void Intersection()
        {

        }
    }
    class SecondTask
    {
        private Stack<int> stack { get; set; }
        private int state { get; set; }
        public void Push()
        {
            stack.Push(1);
            state = 1;
        }
        public void Pop()
        {
            stack.Pop();
            state = 2;
        }
        public void RollBack(int _state)
        {
            if(_state==1)
            {
                Push();
            }
            else if(_state==2)
            {
                Pop();
            }
            else
            {
                RollBack(state);
            }
            state = 3;
        }
        public void Forget()
        {
            state = 0;
        }
    }
    class FirstTask
    {
        private int k { get; set; }
        private List<int> list { get; set; }
        private List<int> newList { get; set; }
        public FirstTask() { }
        public FirstTask(List<int> _list)
        {
            this.list = _list;
        }
        public void UnionLists()
        {
            int n = 0;
            for (int i = 0; i < k; i++)
            {
                newList.Add(Convert.ToInt32(list));
            }
            for (int i = 0; i < list.Count; i++)
            {
                newList.Sort();
            }
            for(int i=0;i<n;i++)
            {
                Console.WriteLine(list);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
