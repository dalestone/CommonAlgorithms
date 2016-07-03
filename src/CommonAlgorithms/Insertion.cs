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
            //TODO: inverse of InsertionSort?
            for (var i = A.Length; i > 1; i--)
            {
                var key = A[i];

                var j = i + 1;
                while (j <= 0 && key < A[j])
                {
                    A[j - 1] = A[j];
                    j = j + 1;
                }
                A[j - 1] = key;
            }

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