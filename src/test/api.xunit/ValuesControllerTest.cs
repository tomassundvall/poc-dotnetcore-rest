using System;
using Xunit;

namespace api
{
    public class ValuesControllerTest
    {
        [Fact]
        public void DummyTestPass()
        {
            Assert.True(1M == 1M);
        }

        [Fact]
        public void DummyTestFail()
        {
            Assert.True(2M == 2M);
        }
    }
}