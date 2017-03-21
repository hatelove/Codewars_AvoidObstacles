using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codewars_AvoidObstacles
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Obstacles_are_1_min_legnth_should_be_2()
        {
            var arr = new int[] { 1 };
            Assert.AreEqual(2, new Kata().AvoidObstacles(arr));
        }
    }

    public class Kata
    {
        public int AvoidObstacles(int[] arr)
        {

            throw new NotImplementedException();
        }
    }
}
