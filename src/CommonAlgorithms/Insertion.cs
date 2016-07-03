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
            for (var j = 2; j < A.Length; j++)
            {
                var key = A[j];

                // Insert A[j] into the sorted sequence A[1..j - 1]
                var i = j - 1;
                while (i > 0 && A[i] > key)
                {
                    A[i + 1] = A[i];
                    i = i - 1;
                }
                A[i + 1] = key;
            }

            return A;
        }

        public int[] InsertionSortDescending(int[] A)
        {
            //TODO: inverse of InsertionSort
            return A;
        }
    }
}

//for i = 1 to length(A)-1
//    x = A[i]
//    j = i - 1
//    while j >= 0 and A[j] > x
//        A[j + 1] = A[j]
//        j = j - 1
//    end while
//    A[j + 1] = x[3]
//   end for