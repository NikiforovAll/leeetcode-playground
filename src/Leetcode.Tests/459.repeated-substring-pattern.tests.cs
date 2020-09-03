using NUnit.Framework;
// using _977;
namespace _459
{
    public class Test
    {
        [Test]
        public void Test1()
        {
            var res = new Solution().RepeatedSubstringPattern("abab");
            Assert.IsTrue(res);
        }

        [Test]
        public void Test2()
        {
            var res = new Solution().RepeatedSubstringPattern("abcabcabcabc");
            Assert.IsTrue(res);
        }

        [Test]
        public void Test3()
        {
            var res = new Solution().RepeatedSubstringPattern("abac");
            Assert.IsFalse(res);
        }
    }
}
