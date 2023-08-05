using System.Collections;
using System;
using Xunit;

namespace UnitTests;

	public static class NthRoot{

		public static int NthRoot_(int n, int number){
			/*
			   nth root of a number equals result

			   number to power of n
			   n V 9 = x
			   9 = x pow n
			   log 9 = n log x

			   Also,
			   log a to base a is 1
			   Now,
			   1 = n log x if base is 9

			   */

			//int x = 2;
			//int number = 8;
			//int n = 3;
			//Console.WriteLine((Math.Log(9, x)/2));

			//Console.WriteLine((Math.Log(number, x)/n));

			for(int i = 0; i < number/2; i++)
				if((Math.Log(number, i)/n) == 1.0000)
					return i;

			return 0;

		}

	}

	public class NthRootTests{

		[Theory]
		[MemberData(nameof(NthRootTestsData.data), MemberType = typeof(NthRootTestsData))]
		public void NthRootTest(int n, int number, int result)
        {
			Assert.Equal(NthRoot.NthRoot_(n, number), result);
		}

	}

	public class NthRootTestsData{

		public static object[] data = 

		{
			new object[] {3, 8, 2},
			new object[] {2, 64, 8},
			new object[] {3, 27, 3},
			new object[] {3, 1331, 11}
				/*
			new int[] {6}, new int[] {2, 3, 5, 7, 11, 13},
			new int[] {7}, new int[] {2, 3, 5, 7, 11, 13, 17}
			*/
		};
	}