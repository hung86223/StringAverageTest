﻿using System;
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
        public void give_one_string_include_three_numbers_get_a_average_number()
        {
            var actual = _stringFactory.AverageString("nine five two");

            Assert.AreEqual("five", actual);
        }

        [TestMethod]
        public void give_zero_zero_get_zero()
        {
            var actual = _stringFactory.AverageString("zero zero");

            Assert.AreEqual("zero", actual);
        }
    }
}
