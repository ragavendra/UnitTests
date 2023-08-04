using Xunit;
using System;
using System.Collections.Generic;

namespace UnitTests;

// using Class Fixture
public class QuickSortTests : IClassFixture<DataShare>
{
    // test
    public DataShare _dataShare; 

    public QuickSortTests(DataShare dataShare)
    {
        _dataShare = dataShare;
    }

    // Test to check if an array is sorted
    [Fact]
    public void CheckIfSorted()
    {
        QuickSort quickSort = new QuickSort();

        foreach(int[] arr in _dataShare.SortInput)
        {
            quickSort.QuickSort_(arr, 0, arr.Length - 1);

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
}