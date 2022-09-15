using System;

namespace ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int[] arr1 = { 4, 5, 2, 6, 4, 3 };
            int a = 65;
            a += 70;
            //int[] arr2 = { 7, 4, 2, 76, 45, 65 };
            string[] test = { };

            int[] result = Different(arr1,test, a,7, 4, 2, 76,a, 45, 65,a);

            foreach (int item in result)
            {
                Console.WriteLine(item);
            }
        }

        static int[] Different(int[] arr1, string[] str,params int[] arr2)
        {
            int[] result = { };
            foreach (int item1 in arr1)
            {
                bool check = false;

                foreach (int item2 in arr2)
                {
                    if (item1 != item2)
                    {
                        //Array.Resize(ref result, result.Length + 1);
                        //result[result.Length - 1] = item1;

                        check = true;
                        break;
                    }
                }

                if (check == false)
                {
                    Array.Resize(ref result, result.Length + 1);
                    result[result.Length - 1] = item1;
                }
            }

            return result;
        }
    }
}
