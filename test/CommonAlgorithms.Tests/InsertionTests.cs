using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace CommonAlgorithms.Tests
{
    public class SortingAlgorithmsTests
    {
        private readonly SortingAlgorithms _sorting;

        public SortingAlgorithmsTests()
        {
            _sorting = new SortingAlgorithms();
        }

        [Fact]
        public void ReturnSortedArrayAscending()
        {
            var A = new int[] { 5, 2, 4, 6, 1, 3 };
            var expected = new int[] { 1, 2, 3, 4, 5, 6 };
            var actual = _sorting.InsertionSort(A);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnSortedArrayAscendingUsingLINQ()
        {
            var A = new int[] { 5, 2, 4, 6, 1, 3 };
            var expected = new int[] { 1, 2, 3, 4, 5, 6 };
            var actual = A.OrderBy(n => n).ToArray();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnSortedArrayAscendingUsingArraySort()
        {
            var A = new int[] { 5, 2, 4, 6, 1, 3 };
            var expected = new int[] { 1, 2, 3, 4, 5, 6 };

            Array.Sort<int>(A,
                            new Comparison<int>(
                                (i1, i2) => i1.CompareTo(i2)
                            ));

            Assert.Equal(expected, A);
        }

        [Fact]
        public void ReturnSortedArrayDescending()
        {
            var A = new int[] { 5, 2, 4, 6, 1, 3 };
            var expected = new int[] { 6, 5, 4, 3, 2, 1 };
            var actual = _sorting.InsertionSortDescending(A);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnSortedArrayDescendingUsingLINQ()
        {
            var A = new int[] { 5, 2, 4, 6, 1, 3 };
            var expected = new int[] { 6, 5, 4, 3, 2, 1 };
            var actual = A.OrderByDescending(n => n).ToArray();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnSortedArrayDescendingUsingArraySort()
        {
            var A = new int[] { 5, 2, 4, 6, 1, 3 };
            var expected = new int[] { 6, 5, 4, 3, 2, 1 };
            var actual = A.OrderByDescending(n => n).ToArray();

            Array.Sort<int>(A,
                            new Comparison<int>(
                                (i1, i2) => i2.CompareTo(i1)
                            ));

            Assert.Equal(expected, A);
        }

        [Fact]
        public void ReturnIndexOfValueInList()
        {
            var A = new List<int> { 5, 2, 4, 6, 1, 3 };
            var v = 6;
            var expected = 3;
            var actual = A.IndexOf(v);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnIndexOfValueNotInList()
        {
            var A = new List<int> { 5, 2, 4, 6, 1, 3 };
            var v = 7;
            var expected = -1;
            var actual = A.IndexOf(v);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CLRS_2_1_1()
        {
            var A = new int[] { 31, 41, 59, 26, 41, 58 };
            var expected = new int[] { 26, 31, 41, 41, 58, 59 };
            var actual = _sorting.InsertionSort(A);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CLRS_2_1_2()
        {
            var A = new int[] { 31, 41, 59, 26, 41, 58 };
            var expected = new int[] { 59, 58, 41, 41, 31, 26 };
            var actual = _sorting.InsertionSortDescending(A);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CLRS_2_1_3()
        {
            var A = new int[] { 31, 41, 59, 26, 41, 58 };
            var v = 41;
            var expected = 1;
            var actual = _sorting.LinearSearch(A, v);

            Assert.Equal(expected, actual);

            #region pseudocode
            /* 
             * for i = 0 to A.length
             *  if A[i] == v
             *      return i
             *  return -1              
             * */
            #endregion
        }

        [Fact]
        public void CLRS_2_1_4()
        {

        }
    }
}
