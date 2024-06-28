using TestTask.Models;


namespace TestTask.Services
{
    class SmokingTest : ITest
    {
        private string _problem;
        public string Testing(Candidate candidate)
        {
            if (candidate.BadHabitsAndDiseases.Contains("курение"))
            {
                _problem = "Кандидат курит (неудовлетворительно)";
                return "неудовлетворительно";
            }
            else
            {
                return "хорошо";
            }
        }
        public string GetProblem()
        {
            return _problem;
        }
    }
}
