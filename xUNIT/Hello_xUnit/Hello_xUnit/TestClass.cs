using Xunit;

namespace Hello_xUnit
{
    public class TestClass
    {

        // Facts are tests which are always true. They test invariant conditions. 
        [Fact]
        public void HappyTest()
        {
            Assert.Equal(4, Add(2, 2));
        }

        [Fact]
        public void UnHappyTest()
        {
            Assert.Equal(3, Add(2, 2));
        }

        int Add(int p1, int p2)
        {
            return p1 + p2;
        }
    }
}
