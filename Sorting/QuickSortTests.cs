using Xunit;
using UnitTests.Helpers;
namespace UnitTests.Sorting;

public class QuickSortTests_
{
    [Theory]
    [MemberData(nameof(SortingTestsData.integerNos), MemberType = typeof(SortingTestsData))]
    public void CheckIfSorted_(int no, int[] arr)
    {
        QuickSort quickSort = new QuickSort();

        quickSort.QuickSort_(arr, 0, arr.Length - 1);

        Assert.True(SortingHelper.CheckSorted(arr), "array is not sorted!");
    }
    
    // Test to check if an array is sorted
    [Theory]
    // [InlineData(_arr)]
    [InlineData(new int[] { 3, 8, 21, 98 })]
    [InlineData(new int[] { 1, 6, 24, 97 })]
    public void CheckIfSorted(int[] arr)
    {
        QuickSort quickSort = new QuickSort();

        quickSort.QuickSort_(arr, 0, arr.Length - 1);

        Assert.True(SortingHelper.CheckSorted(arr), "array is not sorted!");
    }
}


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

            Assert.True(SortingHelper.CheckSorted(arr), "array is not sorted!");
        }
    }
}