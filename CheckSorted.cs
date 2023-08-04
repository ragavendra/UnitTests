using Xunit;

namespace UnitTests;

public class CheckSorted
{
    // Test to check if a no is even
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    public void CheckEven(int no)
    {
        Assert.True((no % 2) == 0);
    }

    // Test to check if an array is sorted
    [Theory]
    [InlineData(new int[] { 3, 8, 1, 21, 98, 24 })]
    [InlineData(new int[] { 3, 8, 21, 98 })]
    public void CheckIfSorted(int[] arr)
    {
        int[] nos = { 1, 7, 9 };
        int[] nos_ = new int[] { 1, 7, 9 };

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

    [Fact]
    // [InlineData(10)]
    // [InlineData(-10)]
    public void CheckPositive()
    {
        Assert.True(1 > 0);
    }
}