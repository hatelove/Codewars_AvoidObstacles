using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Codewars_AvoidObstacles
{
    [TestClass]
    public class UnitTest1
    {
        //Constraints: 1 ≤ inputArray[i] ≤ 100.
        [TestMethod]
        public void Obstacles_are_1_min_legnth_should_be_2()
        {
            var arr = new int[] { 1 };
            MinimalLengthOfJumpShouldBe(arr, 2);
        }

        private static void MinimalLengthOfJumpShouldBe(int[] arr, int expected)
        {
            Assert.AreEqual(expected, new Kata().AvoidObstacles(arr));
        }
    }

    public class Kata
    {
        public int AvoidObstacles(int[] arr)
        {
            return arr.Max() + 1;
        }
    }
}