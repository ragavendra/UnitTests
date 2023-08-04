using Xunit;
using System;
using System.Collections.Generic;

namespace UnitTests;

public class DataShare
{

    public int[][] _sortInput = new int[][] 
                                {
                                    new int[] { 3, 8, 21, 98 },
                                    new int[] { 1, 6, 24, 97 }
                                };

    public int[][] SortInput { get => _sortInput; }


}

