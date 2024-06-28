using TestTask.Models;

namespace TestTask.Services
{
    class VisionTest : ITest
    {
        private string _problem;
        public string Testing(Candidate candidate)
        {
            float vision = candidate.Vision;
            if (vision == 1f)
            {
                return "хорошо";
            }
            else
            {
                _problem = "Зрение кандидата меньше 1 (неудовлетворительно)";
                return "неудовлетворительно";
            }
        }
        public string GetProblem()
        {
            return _problem;
        }
    }
}
