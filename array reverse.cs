using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[8] { 1, 2, 3, 4, 5, 6, 7,8 };

            makeReverse(arr);           

        }

        public static void makeReverse(int[] arr)
        {

            for (int i = (arr.Length - 1)/2; i >= 0; i--)
            {
                int last = arr[i];
                int first = arr[arr.Length -1 - i];

                arr[i] = first;
                arr[(arr.Length - 1) - i] = last;
            }
        }

    }
}
