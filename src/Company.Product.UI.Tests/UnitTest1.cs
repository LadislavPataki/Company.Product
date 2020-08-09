using System;
using Xunit;

namespace Company.Product.UI.Tests
{
    public class UnitTest1
    {
        //[Fact]
        //public void TestShouldFail()
        //{
        //    var expected = 1;
        //    var actual = 0;

        //    Assert.Equal(expected, actual);
        //}

        [Fact]
        public void TestShouldPass()
        {
            var expected = 1;
            var actual = 1;

            Assert.Equal(expected, actual);
        }
    }
}
