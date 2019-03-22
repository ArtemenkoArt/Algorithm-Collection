using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_RemoveDuplicatesFromSortedArray
{
    class Program
    {
        public static int removeDuplicates(ref int[] A)
        {
            if (A.Length < 2)
                return A.Length;

            int j = 0;
            int i = 1;
            while (i < A.Length)
            {
                if (A[i] != A[j])
                {
                    j++;
                    A[j] = A[i];
                }
                i++;
            }
            return j + 1;
        }

        static void PrintArray(int[] A, string message)
        {
            Console.WriteLine("");
            Console.Write("{0}", message);
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("{0}, ", A[i]);
            }
        }

        static void Main(string[] args)
        {
            int[] M = {1,1,1,2,2,3,4,4,6,8,7,7,2,2,2,7};
            int n = 0;
            PrintArray(M, "Array before change: ");
            n = removeDuplicates(ref M);
            // in the processed array, starting from the 9th index, the values ​​are not refilled
            PrintArray(M, "Array after change: ");
            Console.ReadKey();
        }
    }
}
