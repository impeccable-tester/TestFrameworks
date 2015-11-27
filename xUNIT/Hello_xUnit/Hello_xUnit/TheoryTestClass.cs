using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Hello_xUnit
{
    public class TheoryTestClass
    {
        //Theories are tests which are only true for a particular set of data

       [Theory]
       [InlineData(3)]
       [InlineData(4)]
       [InlineData(5)]
       [InlineData(6)]
       public void TestTheory(int i)
       {
           Assert.True(IsOdd(i));
       }

       bool IsOdd(int i)
       {
           return i % 2 == 1;
       }
    }
}
