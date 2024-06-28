using TestTask.Models;

namespace TestTask.Services
{
    class StrangeTest: ITest
    {
        private string _problem;
        public string Testing(Candidate candidate)
        {
            if (candidate.Name.ToLower().StartsWith("п"))
            {
                return "хорошо";
            }
            else if (candidate.Age > 68)
            {
                _problem = "Имя кандидата не начинается с буквы «П» и его возраст больше 68 лет (удовлетворительно)";
                return "удовлетворительно";
            }
            else
            {
                _problem = "Имя кандидата не начинается с буквы «П» и его возраст не больше 68 лет (неудовлетворительно)";
                return "неудовлетворительно";
            }
        }
        public string GetProblem()
        {
            return _problem;
        }
    }
}
