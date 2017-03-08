using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_03_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 3, 4, 7, 10, 15, 19, 23, 25, 40, 42};
            int[] arr2 = new int[] { 1, 2, 5, 20, 28, 30, 31, 32, 33, 43};
            int[] arrMerged = new int[20];

            int index1 = 0, index2 = 0, indexMerged = 0;

            while (index1 < arr1.Length&& index2 < arr2.Length)
            {
                if (arr1[index1] < arr2[index2])
                    arrMerged[indexMerged++] = arr1[index1++];
                else
                    arrMerged[indexMerged++] = arr2[index2++];
            }

            if (index1 < arr1.Length)
                while (index1 < arr1.Length)
                {
                    arrMerged[indexMerged++] = arr1[index1++];
                }
            else
                while (index2 < arr2.Length)
                {
                    arrMerged[indexMerged++] = arr2[index2++];
                }

            for (int i = 0;i<arrMerged.Length; i++)
            Console.WriteLine(arrMerged[i]);

        }
    }
}
