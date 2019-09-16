using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringAverageTest
{
    [TestClass]
    public class StringAverageTest
    {
        private readonly StringFactory _stringFactory = new StringFactory();

        [TestMethod]
        public void give_Empty_String_Get_NA()
        {
            var actual = _stringFactory.AverageString("");

            Assert.AreEqual("N/A",actual);
        }
        [TestMethod]
        public void give_One_Get_One()
        {
            var actual = _stringFactory.AverageString("one");

            Assert.AreEqual("one", actual);
        }
    }
}
