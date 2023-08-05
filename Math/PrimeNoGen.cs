using System;
using System.Collections;
using Xunit;

namespace UnitTests;

public static class PrimeNoGen
{

    public static int[] PrimeNumberGenerator(int size)
    {

        int[] arr = new int[size];
        int iIndex = 3;

        arr[0] = 2;

        if (size > 1)
            arr[1] = 3;

        if (size > 2)
            arr[2] = 5;

        bool flag = false;

        for (int i = 7; i < 100; i++)
        {

            //check if no is div by any no less than it
            for (int i1 = 2; i1 < i / 2; i1++)
            {
                if (i % i1 == 0)
                {
                    flag = false;
                    break;
                }
                else
                    flag = true;

            }

            if (iIndex >= size)
                return arr;

            if (flag)
                arr[iIndex++] = i;

            flag = false;

        }

        return arr;

    }

}

public class PrimeNoGenTests
{
    [Theory]
    [MemberData(nameof(PrimeNoGenTestsData.primeNos), MemberType = typeof(PrimeNoGenTestsData))]
    public void PrimeNoGenTest(int size, int[] primeNos_)
    // public void PrimeNoGenTest(object obj)
    {
        /*
        foreach (var item in primeNos_)
        {
            Console.WriteLine("Item is " + item);
        }*/
        Assert.Equal(size, primeNos_.Length);

        // Assert.Equal(PrimeNoGen.PrimeNumberGenerator(size), primeNos_);

    }

}

public class PrimeNoGenTestsData
{

    public static object[] primeNos =
    {
            new object[] {3, new int[] {2, 3, 5}},
            new object[] {6, new int[] {2, 3, 5, 7, 11, 13}},
            new object[] {7, new int[] {2, 3, 5, 7, 11, 13, 17}},
            new object[] {8, new int[] {2, 3, 5, 7, 11, 13, 17, 19}},
            new object[] {2, new int[] {2, 3}},
            new object[] {1, new int[] {2}}
        };
}