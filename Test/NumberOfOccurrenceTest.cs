using System;
using Xunit;
using NumberOfOccurrence;

namespace test
{
    public class NumberOfOccurrenceTest
    {
        [Fact]
        public void GivenStringContainsNoRepeatingString()
        {
             var result = Program.FormatResult("code");
             Assert.Equal(result,"c1o1d1e1");
        }
        [Fact]
        public void GivenStringContainsRepeatingStrings()
        {
             var result = Program.FormatResult("programming");
             Assert.Equal(result,"p1r2o1g2a1m2i1n1");
        }
        [Fact]
        public void GivenStringContainsSomeUpperCaseSomeLowerCaseLettersAndNoRepeatingStrings()
        {
             var result = Program.FormatResult("TowEr");
             Assert.Equal(result,"t1o1w1e1r1");
        }
        [Fact]
         public void GivenStringContainsSomeUpperCaseSomeLowerCaseLettersAndRepeatingStrings()
        {
             var result = Program.FormatResult("OccuRRenCE");
             Assert.Equal(result,"o1c3u1r2e2n1");
        }
        [Fact]
         public void GivenStringContainsWhiteSpace()
        {
             var result = Program.FormatResult(" Business Consulting ");
             Assert.Equal(result,"b1u2s4i2n3e1c1o1l1t1g1");
        }
        [Fact]
         public void GivenStringContainsEmptyString()
        {
             var result = Program.FormatResult("");
             Assert.Equal(result,"");
        }
       
    }
}