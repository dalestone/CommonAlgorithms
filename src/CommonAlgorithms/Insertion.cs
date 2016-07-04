using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommonAlgorithms
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class Insertion
    {
        public Insertion()
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
            int[] ordered  = A.OrderByDescending(n => n).ToArray();

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
    }
}
