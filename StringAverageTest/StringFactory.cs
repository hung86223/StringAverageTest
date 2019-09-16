using System;
using System.Collections.Generic;

namespace StringAverageTest
{
    public class StringFactory
    {
        private string _answer = "";

        private readonly Dictionary<string, int> _stringToNumber = new Dictionary<string, int>()
        {
            {"zero",0},
            {"one",1},
            {"two",2},
            {"three",3},
            {"four",4},
            {"five",5},
            {"six",6},
            {"seven",7},
            {"eight",8},
            {"nine",9}
        };
        private readonly Dictionary<int, string> _numberDictionary = new Dictionary<int, string>()
        {
            {0,"zero"},
            {1,"one"},
            {2,"two"},
            {3,"three"},
            {4,"four"},
            {5,"five"},
            {6,"six"},
            {7,"seven"},
            {8,"eight"},
            {9,"nine"}
        };


        private int _numberAns;
        private int _count;

        public string AverageString(string question)
        {
            ParseNumber(question);
            GetAverageNum();
            _answer = _numberDictionary[_numberAns];
            return StringIsEmpty(question) ? "N/A" :_answer ;
        }

        private void ParseNumber(string question)
        {
            var numbers = question.Split(' ');
            foreach (var number in numbers)
            {
                _count++;
                if (!StringIsEmpty(number))
                {
                    _numberAns += _stringToNumber[number];
                }
            }
        }

        private void GetAverageNum()
        {
            _numberAns /= _count;
        }

        private static bool StringIsEmpty(string question)
        {
            return question.Equals("");
        }
    }
}