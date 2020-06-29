using System;
using Xunit;
using HyphenSeparatedNumbers;

namespace test
{
    public class HyphenSeparatedNumbersTest
    {
        [Fact]
        public void GivenStringContainsNumbersAndHyphenWithDifferentIntervals()
        {
            var result = Program.GetResult("1-2-2-4-5");
            Assert.Equal(result,false);
        }
        [Fact]
        public void GivenStringContainsNumbersAndHyphenWithSameIntervals()
        {
            var result = Program.GetResult("3.758-4.758-5.758-6.758-7.758");
            Assert.Equal(result,true);
        }
        [Fact]
        public void GivenStringContainsDecimalNumbersAndHyphenWithDifferentIntervals()
        {
            var result = Program.GetResult("3.08-4.58-5.78-6.82-7.28");
            Assert.Equal(result,false);
        }
        [Fact]
        public void GivenStringContainsDecimalNumbersAndHyphenWithSameIntervals()
        {
            var result = Program.GetResult("3-4-5-6-7");
            Assert.Equal(result,true);
        }
        [Fact]
        public void GivenStringContainsNumbersCharactersAndHyphen()
        {
            var result = Program.GetResult("3-c-5-6-7");
            Assert.Equal(result,false);
        }
        [Fact]
        public void GivenStringIsAnEmptyString()
        {
            var result = Program.GetResult("");
            Assert.Equal(result,false);
        }
        [Fact]
        public void GivenStringContainsWhiteSpace()
        {
            var result = Program.GetResult("2-6- -0");
            Assert.Equal(result,false);
        }
        [Fact]
         public void GivenStringDoesNotContainHyphen()
        {
            var result = Program.GetResult("1/2/2/4/5");
            Assert.Equal(result,false);
        }
    }
}
