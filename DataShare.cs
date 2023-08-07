using Xunit;
using System;
using System.Collections.Generic;

namespace UnitTests;

public class DataShare
{

    public int[][] _sortInput = new int[][] 
                                {
                                    new int[] { new Random().Next(100), new Random().Next(100), new Random().Next(100), new Random().Next(100) },
                                    new int[] { new Random().Next(100), new Random().Next(100), new Random().Next(100), new Random().Next(100) }
                                };

    public int[][] SortInput { get => _sortInput; }


}

