using System;
using Xunit;

namespace setours.jarvis.testing.xunit
{
    public class ProviderTest
    {
        [Fact]
        public void Add()
        {
            Assert.True(true);
            Assert.Equal(1, 1);
            Assert.Equal("Jose", "Jose", ignoreCase:true);
            Assert.Contains(" josE", "Jose", StringComparison.InvariantCultureIgnoreCase);
            Assert.StartsWith("Jo", "Jose");
            Assert.EndsWith("se", "Jose");

        }
    }
}
