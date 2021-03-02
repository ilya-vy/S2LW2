using System;
namespace Feb_17_LW_2_T_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> numbers = new MyList<int>();

            numbers.Add(6);
            numbers.Add(88);
            numbers.Add(8234);
            numbers.Add(734);

            for (int i = 0; i < numbers.ListLetgth; i++)
            {
                Console.WriteLine(numbers.GetElement(i));
            }
            Console.WriteLine(numbers.ListLetgth);
            Console.ReadKey();
        }
    }
    class MyList<T>
    {
        private T[] Array { get; set; }
        public int ListLetgth
        {
            get
            {
                return listLetgth;
            }
        }
        private int listLetgth;
        public int ArraySize = 1;
        public void Add(T item)
        {
            if (ListLetgth == 0)
            {
                Array = new T[ArraySize];
                Array[ListLetgth] = item;
                listLetgth++;
                ArraySize++;
            }
            else
            {
                T[] Darr = Array;
                Array = new T[ArraySize];
                for (int i = 0; i < Darr.Length; i++)
                {
                    Array[i] = Darr[i];
                }
                Array[ListLetgth] = item;
                listLetgth++;
                ArraySize++;
            }
           
        }
        public T GetElement(int index)
        {
            return Array[index];
        }
    }
    public static class CommonUtil
    {
        public static T[] ListToString(this MyList<T> list)
        {
            
        }
    }
}