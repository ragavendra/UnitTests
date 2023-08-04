using Xunit;
using System;
using System.Collections.Generic;

namespace UnitTests.Tests;

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
    // [InlineData(_arr)]
    [InlineData(new int[] { 3, 8, 21, 98 })]
    [InlineData(new int[] { 1, 6, 24, 97 })]
    public void CheckIfSorted(int[] arr)
    {
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

    // Test to check if a float array is sorted
    [Theory]
    [InlineData(new float[] { 0.3f, 0.8f, 0.1f, 0.21f, 0.98f, 0.24f })]
    [InlineData(new float[] { 0.3f, 0.8f, 0.21f, 0.98f })]
    public void CheckIfFloatSorted(float[] arr)
    {
        float? prev = null;
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