using System;
using Xunit;

namespace Webtest
{
    public class WebTest
    {
        [Fact]
        public void DemoTest()
        {
            int i = 2;
            bool result = false;
            if (i == 2) result = true;
            Assert.True(result, "Value should be equal to 2");
        }
    }
}
