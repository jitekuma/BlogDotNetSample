using Xunit;

namespace MyFirstDotNetCoreTests
{
    public class Class1
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2, 2));
			Assert.Equal(0, Subtract(2, 2));
			Assert.Equal(4, Multiply(2, 2));
			Assert.Equal(1, Divide(2, 2));
        }

        int Add(int x, int y)
        {
            return x + y;
        }
		
		int Subtract(int x, int y)
        {
            return x - y;
        }
		
		int Multiply(int x, int y)
        {
            return x * y;
        }
		
		int Divide(int x, int y)
        {
            return x / y;
        }
    }
}