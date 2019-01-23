using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode771JewelsAndStones
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NumJewelsInStonesTest_When_J_Is_aA_And_S_Is_aAAbbbb_Should_Be_3()
        {
            var solution = new Solution();
            var J = "aA";
            var S = "aAAbbbb";
            var actual = solution.NumJewelsInStones(J, S);
            var expected = 3;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NumJewelsInStonesTest_When_J_Is_z_And_S_Is_ZZ_Should_Be_0()
        {
            var solution = new Solution();
            var J = "z";
            var S = "ZZ";
            var actual = solution.NumJewelsInStones(J, S);
            var expected = 0;
            Assert.AreEqual(expected, actual);
        }
    }
}