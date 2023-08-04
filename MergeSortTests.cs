using Xunit;
using System;
using System.Collections.Generic;

namespace UnitTests;

public class MergeSortTests
{

    // Test to check if an array is sorted
    [Theory]
    // [InlineData(_arr)]
    [InlineData(new int[] { 3, 8, 21, 98 })]
    [InlineData(new int[] { 1, 6, 24, 97 })]
    public void CheckIfSorted(int[] arr)
    {
        MergeSort mergeSort = new MergeSort();

        mergeSort.MergeSort_(arr, 0, arr.Length);

        int? prev = null;
        foreach (var item in arr)
        {
            if (prev != null)
            {
                Assert.True(prev <= item);
            }

            prev = item;
        }
    }
}