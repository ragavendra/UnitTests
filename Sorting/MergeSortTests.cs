using Xunit;
using UnitTests.Helpers;
namespace UnitTests.Sorting;

public class MergeSortTests
{
    [Theory]
    [MemberData(nameof(SortingTestsData.integerNos), MemberType = typeof(SortingTestsData))]
    public void CheckIfSorted_(int no, int[] arr)
    {
        MergeSort mergeSort = new MergeSort(arr);

        // mergeSort.MergeSort_(arr, 0, arr.Length);

        Assert.True(SortingHelper.CheckSorted(arr), "array is not sorted!");
    }

    // Test to check if an array is sorted
    [Theory]
    // [InlineData(_arr)]
    [InlineData(new int[] { 3, 8, 21, 98 })]
    [InlineData(new int[] { 1, 6, 24, 97 })]
    public void CheckIfSorted(int[] arr)
    {
        MergeSort mergeSort = new MergeSort(arr);

        // mergeSort.MergeSort_(arr, 0, arr.Length);

        Assert.True(SortingHelper.CheckSorted(arr), "array is not sorted!");
    }
}

// using Class Fixture
public class MergeSortTests_ : IClassFixture<DataShare>
{
    // test
    public DataShare _dataShare; 

    public MergeSortTests_(DataShare dataShare)
    {
        _dataShare = dataShare;
    }

    // Test to check if an array is sorted
    [Fact]
    public void CheckIfSorted()
    {

        foreach(int[] arr in _dataShare.SortInput)
        {
            MergeSort mergeSort = new MergeSort(arr);
            // mergeSort.MergeSort_(arr, 0, arr.Length);

            Assert.True(SortingHelper.CheckSorted(arr), "array is not sorted!");
        }
    }
}