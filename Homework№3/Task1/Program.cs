using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 10, 8, 49, 17, 5 };


            Console.WriteLine(Maxnumber(array));
        }

        public static int Maxnumber(int[] array)
        {
            int max = array[0];

            foreach (var item in array)
            {
                if (max < item)
                {
                    max = item;
                }
                
            }
            return max;
        }
           
    }
}
