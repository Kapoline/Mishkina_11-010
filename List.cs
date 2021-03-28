using System;
using System.Collections.Generic;
using System.Collections;

namespace list
{
    class List<T> 
    {
        T[] list  { get; set; }
        int Count { get;  set; }
        internal T[] lists
        {
            set { list = value; }
            get { return list; }
        }
        internal List() { }
        internal List(T[] newlist)
        {
            this.list = newlist;
        }
        internal void Add(T item)
        {
            for (int i = 0; i < this.list.Length; i++)
            {
                this.list[i] = item;
            }
        }
        internal void AddRange(ICollection<T> collection)
        {
            List<T> newList = (List<T>)collection;
            T[] array = new T[(int)Math.Pow(2, Math.Ceiling(Math.Log2(Count + collection.Count)))];
            int count = 0;
            for (int i = 0; i < Count; i++)
            {
                array[i] = this.list[i];
                count++;
            }
            for (int i = 0; i < collection.Count; i++)
            {
                array[count] = newList[i];
            }
            this.list = array;
        }
        internal int BinarySearch(T item)
        {
            for (int i = 0; i < this.list.Length - 1; i++)
            {
                for (int j = i + 1; j < this.list.Length; j++)
                {
                    if (Convert.ToInt32(this.list[i]) > Convert.ToInt32(this.list[j]))
                    {
                        T temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
            return BinarySearchAd(0, Count, item);
        }
        private int BinarySearchAd(int left, int right, T item)
        {
            int mid = left + (right - left) / 2;
            if (left >= right)
                return 1;
            if (Convert.ToInt32(this.list[mid]) == Convert.ToInt32(item))
                return mid;
            else if (Convert.ToInt32(this.list[mid]) > Convert.ToInt32(item))
                return BinarySearchAd(left, mid, item);
            else
                return BinarySearchAd(mid + 1, right, item);
        }
        internal void Sort()
        {

            for (int i = 0; i < this.list.Length - 1; i++)
            {
                for (int j = i + 1; j < this.list.Length; j++)
                {
                    if (Convert.ToInt32(this.list[i]) > Convert.ToInt32(this.list[j]))
                    {
                        T temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
        }
        internal int IndexOf(T item)
        {
            int count = 0;
            for(int i=0;i<this.list.Length;i++)
            {
                
                if (Convert.ToInt32(this.list[i]) == Convert.ToInt32(item))
                    count = i;
            }
            return count;
        }
        internal void Inset(int index, T item)
        {
            for(int i=0;i<this.list.Length;i++)
            {
                if (i == index)
                    this.list[i] = item;
            }
        }
        internal bool Remove(T item)
        {
            if (IndexOf(item) != -1)
            {
                int index = IndexOf(item);
                int count = 0;
                T[] array = new T[this.list.Length];
                for (int i = 0; i < Count; i++)
                {
                    if (i == index)
                    {
                        continue;
                    }
                    array[count] = this.list[i];
                    count++;
                }
                this.list = array;
                Count--;
                return true;
            }
            else
                return false;
        }
        internal void RemoveAt(int index)
        {
            T[] array = new T[Count];
            int count = 0;
            for(int i=0;i<Count; i++)
            {
                if(i==index)
                {
                    continue;
                }
                array[count] = this.list[i];
                count++;
            }
            Count--;
            this.list = array;
        }
        internal void ChangeMin()
        {
            int min = Int32.MaxValue;
            int max = Int32.MinValue;
            int indexMin = -1;
            int indexMax = -1;
            for (int i=0;i<Count;i++)
            {
                if (Convert.ToInt32(list[i]) > max)
                {
                    max = Convert.ToInt32(this.list[i]);
                    indexMax = i;
                }
                if(Convert.ToInt32(list[i]) < min)
                {
                    min = Convert.ToInt32(list[i]);
                    indexMin = i;
                }
            }
            T array = list[indexMax];
            list[indexMax] = list[indexMin];
            list[indexMin] = array;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
