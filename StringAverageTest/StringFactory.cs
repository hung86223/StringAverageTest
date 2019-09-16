namespace StringAverageTest
{
    public class StringFactory
    {
        private string _answer = "";

        public string AverageString(string question)
        {
            _answer = question;
            return QuestionIsEmpty(question) ? "N/A" :_answer ;
        }

        private static bool QuestionIsEmpty(string question)
        {
            return question.Equals("");
        }
    }
}