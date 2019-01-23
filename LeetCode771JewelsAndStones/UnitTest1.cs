using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode771JewelsAndStones
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var solution = new Solution();
            var J = "aA";
            var S = "aAAbbbb";
            var actual = solution.NumJewelsInStones(J, S);
            var expected = 3;
            Assert.AreEqual(3, actual);
        }
    }
}