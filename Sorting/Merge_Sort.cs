using System;
using System.Collections.Generic;

namespace UnitTests.Sorting;

public class Merge_Sort
{
	public void MergeSort_(int[] den, int first, int last)
	{
		// Console.WriteLine("MergeSort");
		int mid = (first + last)/2;
		
		// Console.WriteLine("Info " + first + " " + last + " " + mid);
		
		if(mid <= 0)
		{
			// Console.WriteLine("Info" + mid);
			return;		
		}
		
		if((first < mid) || (mid < last))
		{
		}
		else	
		{
			return;
		}
		
		// Console.WriteLine("Info1" + mid);
		
		if(mid == 1)
		{
			if(mid != first)
			{
				if(den[mid] < den[first])
				{
					var temp = den[mid];
					den[mid] = den[first];
					den[first] = temp;
				}
			}
			
			if(mid != last)
			{
				if(den[last] < den[mid])
				{
					var temp = den[mid];
					den[mid] = den[last];
					den[last] = temp;
				}
			}
			return;
		}
		
		/*
		if((last - (mid + 1)) == 1)
		{
			if(den[mid + 1] < den[last])
			{
				var temp = den[mid + 1];
				den[mid + 1] = den[last];
				den[last] = temp;
			}
			// return;
		}*/
		
		// Console.WriteLine("Info " + first + " " + last + " " + mid);
		
		// Console.WriteLine("End 0");
		
		MergeSort_(den, first, mid);
		MergeSort_(den, mid + 1, last);
		
		// Console.WriteLine("End ");
		// Console.WriteLine("Info " + first + " " + last + " " + mid);
		
		Merge(den, first, mid, last);
	}
	
	private void Merge(int[] den, int first, int mid, int last)
	{
		/*
		for(int i = 0; i < last; i++)
		{
			Console.WriteLine("MergeB " + den[i]);
		}*/
		
		for(int i = first; i <= mid; i++)
		{
			for(int j = mid + 1; j < last; j++)
			{
				if(den[i] <= den[j])
				{}
				else
				{
					var temp = den[j];
					den[j] = den[i];
					den[i] = temp;
				}
			}
		}
		/*
		for(int i = 0; i < last; i++)
		{
			Console.WriteLine("Merge " + den[i]);
		}*/
	}
}