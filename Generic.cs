using System;

namespace generic
{
    class VeryLongNumber : Number<int[]>
    {
        int[] arrayOfNumbers { get; set; }
        internal int[] array
        {
            set { arrayOfNumbers = value; }
            get { return arrayOfNumbers; }
        }
        internal VeryLongNumber() { }
        internal VeryLongNumber(int[] arrOfNum)
        {
            this.arrayOfNumbers = arrOfNum;
        }
        internal VeryLongNumber Add(Number<int[]> n)
        {
            for(int i=0;i<arrayOfNumbers.Length;i++)
            {
                this.arrayOfNumbers[i] += n.numbers;
            }
            return new VeryLongNumber(this.arrayOfNumbers);
        }
        internal VeryLongNumber Sub(Number<int[]> n)
        {
            for (int i=0;i<arrayOfNumbers.Length;i++)
            {
                try
                {
                    if (this.arrayOfNumbers[i] < n.numbers)
                        throw new Exception("NotNaturalNumberException");
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                this.arrayOfNumbers[i] -= n.numbers;
            }
            return new VeryLongNumber(this.arrayOfNumbers);
        }
        internal int CompareTo(Number<int[]> n)
        {
            int count = 0;
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                
                if (this.arrayOfNumbers[i] > n.numbers)
                    count = 1;
                else if (this.arrayOfNumbers[i] < n.numbers)
                    count = -1;
                else
                    count = 0;
            }
            return count;
        }
    }
    class SimpleLongNumber : Number<long>
    {
        long SimpleNumber { get; set; }
        internal long number
        {
            set { SimpleNumber = value; }
            get { return SimpleNumber; }
        }
        internal SimpleLongNumber() { }
        internal SimpleLongNumber(long simplenumbr)
        {
            this.number = simplenumbr;
        }
        internal SimpleLongNumber Add(Number<long> n)
        {
            return new SimpleLongNumber(this.SimpleNumber + n.numbers);
        }
        internal SimpleLongNumber Sub(Number<long> n)
        {
            try
            {
                if (this.SimpleNumber < n.numbers)
                    throw new Exception("NotNaturalNumberException");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return new SimpleLongNumber(this.SimpleNumber - n.numbers);
        }
        internal int CompareTo(Number<long> n)
        {
            int count = 0;
            if (this.SimpleNumber>n.numbers)
                count = 1;
            else if (this.SimpleNumber<n.numbers)
                count = -1;
            else
                count = 0;
            return count;
        }
    }
    class Number<T>
    {
        int number { get; set; }
        internal int numbers
        {
            set { number = value; }
            get { return number; }
        } 
        internal Number() { }
        internal Number(int numbr)
        {
            this.numbers = numbr;
        }
        internal Number<T> Add(Number<T> n)
        {
            return new Number<T>(this.number+n.number);
        }
        internal Number<T> Sub(Number<T> n)
        {
            try
            {
                if (this.number < n.number)
                    throw new Exception("NotNaturalNumberException");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return new Number<T>(this.number - n.number);
        }
        internal int CompareTo(Number<T> n)
        {
            int count = 0;
            if (this.number > n.number)
                count = 1;
            else if (this.number < n.number)
                count = -1;
            else
                count = 0;
            return count;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int quality = int.Parse(Console.ReadLine());
            SimpleLongNumber simpleNumers = new SimpleLongNumber();
            VeryLongNumber longNumbers = new VeryLongNumber();
            Number<long>[] numberSimple = new Number<long>[quality];
            for (int i = 0; i < numberSimple.Length / 2; i++)
            {
                numberSimple[i] = simpleNumers;
                numberSimple[i].Add(simpleNumers);
            }
            Number<int[]>[] numberLong = new Number<int[]>[quality];
            for (int i = quality / 2; i < numberLong.Length / 2; i++)
            {
                numberLong[i] = longNumbers;
                numberLong[i].Add(longNumbers);
            }
        }
    }
}
