using System;
using Xunit;
using AbsoluteDifference;
using System.Collections.Generic;

namespace test
{
    public class AbsoluteDifferenceTest
    {
        [Fact]
        public void GivenOrderedListWhereKthIntegerIsAvailable()
        {
            List<int> givenList = new List<int>{1,4,6,9};
            int k = 3;
            var result = Program.GetResult(k,givenList);
            Assert.Equal(result,7);
        }
        [Fact]
        public void GivenOrderedListWhereKthIntegerIsNotAvailable()
        {
            List<int> givenList = new List<int>{1,2};
            int k = 5;
            var result = Program.GetResult(k,givenList);
            Assert.Equal(result,-1);
        }
         [Fact]
        public void GivenOrderedListIsNull()
        {
            List<int> givenList = new List<int>();
            int k = 5;
            var result = Program.GetResult(k,givenList);
            Assert.Equal(result,-1);
        }
    }
}