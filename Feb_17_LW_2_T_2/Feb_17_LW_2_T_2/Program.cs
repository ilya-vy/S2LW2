using System;
namespace Feb_17_LW_2_T_2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int, string> dictionary = new MyList<int, string>();

            dictionary.Add(88, "String2");
            dictionary.Add(734, "String03FD");

            Console.WriteLine(dictionary.ListLetgth);
            Console.WriteLine(dictionary.GetElement(734));

            Console.ReadKey();
        }
    }
    class MyList<T,R>
    {
        private T[] KeyArray { get; set; }
        private R[] ValueArray { get; set; }

        public int ListLetgth
        {
            get
            {
                return listLetgth;
            }
        }
        private int listLetgth;
        public int ArraySize = 1;
        public void Add(T key, R value)
        {
            if (ListLetgth == 0)
            {
                KeyArray = new T[ArraySize];
                KeyArray[ListLetgth] = key;

                ValueArray = new R[ArraySize];
                ValueArray[ListLetgth] = value;

                listLetgth++;
                ArraySize++;
            }
            else
            {
                T[] DkeyArr = KeyArray;
                R[] DvalueArr = ValueArray;

                KeyArray = new T[ArraySize];
                ValueArray = new R[ArraySize];

                for (int i = 0; i < DkeyArr.Length; i++)
                {
                    KeyArray[i] = DkeyArr[i];
                    ValueArray[i] = DvalueArr[i];
                }
                KeyArray[ListLetgth] = key;
                ValueArray[ListLetgth] = value;

                listLetgth++;
                ArraySize++;
            }
        }
        public R GetElement(T value)
        {
            int index = Array.IndexOf(KeyArray, value);
            return ValueArray[index];
        }
    }
}
