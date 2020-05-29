using NUnit.Framework;

namespace _547
{
    public class FriendCircles
    {
        [Test]
        public void Test1()
        {
            var text = @"
[[1,1,0],
 [1,1,1],
 [0,1,1]]";
            var res = new Solution().FindCircleNum(text.ParseAsArray());
            Assert.That(res, Is.EqualTo(1));
        }

        [Test]
        public void Test2()
        {
            var text = @"[[1,0,0,1],[0,1,1,0],[0,1,1,1],[1,0,1,1]]";
            var res = new Solution().FindCircleNum(text.ParseAsArray());
            Assert.That(res, Is.EqualTo(1));
        }
    }
}
