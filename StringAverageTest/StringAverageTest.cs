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

        [TestMethod]
        public void give_one_string_include_two_numbers_get_parsing()
        {
            var actual = _stringFactory.AverageString("one two");

            Assert.AreEqual("three", actual);
        }

        [TestMethod]
        public void give_one_string_include_three_numbers_which_parsing_more_than_nine_get_a_digit_number()
        {
            var actual = _stringFactory.AverageString("nine five two");

            Assert.AreEqual("six", actual);
        }
    }
}
