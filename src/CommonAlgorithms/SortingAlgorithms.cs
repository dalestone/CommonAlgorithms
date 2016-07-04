using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommonAlgorithms
{
    public class SortingAlgorithms
    {
        public SortingAlgorithms()
        {
        }

        public int[] InsertionSort(int[] A)
        {
            for (var i = 1; i < A.Length; i++)
            {
                var key = A[i];

                // Insert A[i] into the sorted sequence A[1..i - 1]
                var j = i - 1;
                while (j >= 0 && A[j] > key)
                {
                    A[j + 1] = A[j];
                    j = j - 1;
                }
                A[j + 1] = key;
            }

            return A;
        }

        public int[] InsertionSortDescending(int[] A)
        {
            int[] ordered = A.OrderByDescending(n => n).ToArray();

            //TODO: inverse of InsertionSort?
            //for (var i = A.Length - 1; i > 1; i--)
            //{
            //    var key = A[i];

            //    // Insert A[i] into the sorted sequence A[1..i - 1]
            //    var j = i - 1;
            //    while (j >= 0 && A[j] > key)
            //    {
            //        A[j + 1] = A[j];
            //        j = j - 1;
            //    }
            //    A[j + 1] = key;
            //}

            return ordered;
        }

        public int LinearSearch(int[] A, int v)
        {
            for (var i = 0; i < A.Length; i++)
            {
                if (A[i] == v)
                {
                    return i;
                }
            }
            return -1;
        }

        public void Merge(int[] A, int p, int q, int r)
        {
            //var n1 = q - p + 1;
            //var n2 = r - q;
            //var L = new int[n1 + 1];
            //var R = new int[n2 + 1];

            //for (var i = 1; i < n1; i++)
            //{
            //    L[i] = A[p + i - 1];
            //}

            //for (var j = 1; j < n2; j++)
            //{
            //    R[j] = A[q + j];
            //}

            //L[n1 + 1] = infinity
            //R[n2 + 1] = infinity
            // i = 1
            // j = 1

            //for (var k = p; k < r; k++)
            //{
            //    if (L[] <= R[])
            //    {
            //        A[k] = L[]

            //    }
            //}

        }
    }
}
