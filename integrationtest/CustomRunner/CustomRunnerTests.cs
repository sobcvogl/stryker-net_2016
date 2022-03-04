using Xunit;

namespace CustomRunner
{
    public class CustomRunnerTests
    {
        [Fact]
        public void ShouldRunStrykerFromCode()
        {
            var runner = new StrykerRunner();
        }
    }
}
