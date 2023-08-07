
using System;

namespace UnitTests.Helpers;

public class SortingHelper
{
    public static object _lock = new object();
    
    // Test to check if an array is sorted
    public static bool CheckSorted(int[] arr)
    {
        lock(_lock)
        {
            int? prev = null;
            foreach (var item in arr)
            {
                if (prev != null)
                {
                    if(prev <= item)
                    {}
                    else
                    {
                        // throw new Exception("array is not sorted!");
                        return false;
                    }
                }

                prev = item;
            }

            return true;
        }
    }
}

public class SortingTestsData
{
    public static object[] integerNos =
    {
        new object[] { 1, new int[] { new Random().Next(100), new Random().Next(100), new Random().Next(100), new Random().Next(100), new Random().Next(100), new Random().Next(100) }},
        new object[] { 7, new int[] { new Random().Next(100), new Random().Next(100), new Random().Next(100), new Random().Next(100), new Random().Next(100), new Random().Next(100) }},
        new object[] { 6, new int[] { new Random().Next(100), new Random().Next(100), new Random().Next(100), new Random().Next(100), new Random().Next(100), new Random().Next(100) }}
    };
}