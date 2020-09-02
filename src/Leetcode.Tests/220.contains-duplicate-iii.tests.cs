using NUnit.Framework;
// using _977;
namespace _220.Tests
{
    public class Test
    {
        [Test]
        public void Test1()
        {
            var res = new _220.Solution().ContainsNearbyAlmostDuplicate(
                new int[] { 1, 2, 3, 1 }, 3, 0);
            Assert.True(res);
        }
        [Test]
        public void Test2()
        {
            var res = new _220.Solution().ContainsNearbyAlmostDuplicate(
                new int[] { 2, 2 }, 3, 0);
            Assert.True(res);
        }

        [Test]
        public void Test3()
        {
            var res = new _220.Solution().ContainsNearbyAlmostDuplicate(
                new int[] { 2147483647, -2147483647 }, 1, 2147483647);
            Assert.False(res);
        }

        [Test]
        public void Test4()
        {
            var res = new _220.Solution().ContainsNearbyAlmostDuplicate(
                new int[] { 1, 5, 9, 1, 5, 9 }, 2, 3);
            Assert.False(res);
        }
        [Test]
        public void Test5()
        {
            var res = new _220.Solution().ContainsNearbyAlmostDuplicate(
                new int[] { 3, 6, 0, 2 }, 2, 2);
            Assert.True(res);
        }
    }
}
