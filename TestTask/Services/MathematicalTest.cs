using TestTask.Models;

namespace TestTask.Services
{
    class MathematicalTest : ITest
    {
        private string _problem;
        public string Testing(Candidate candidate)
        {
            int height = candidate.Height;
            bool haveCold = candidate.BadHabitsAndDiseases.Contains("насморк");
            if (height % 3 == 0 && haveCold)
            {
                _problem = "Рост кандидата делится нацело на 3, и у него насморк (неудовлетворительно)";
                return "неудовлетворительно";
            }
            else if (height % 2 == 0)
            {
                return "хорошо";
            }
            else
            {
                _problem = "Рост кандидата не делится нацело ни на 3, ни на 2, и у него нет насморка (удовлетворительно).";
                return "удовлетворительно";
            }
        }
        public string GetProblem()
        {
            return _problem;
        }
    }
}
