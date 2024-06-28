using TestTask.Models;

namespace TestTask.Services
{
    class HeightTest : ITest
    {
        private string _problem;
        public string Testing(Candidate candidate)
        {
            int height = candidate.Height;
            if (height < 170)
            {
                _problem = $"Рост кандидата меньше 170 см";
                if (height < 160)
                {
                    _problem += " (неудовлетворительно)";
                    return "неудовлетворительно";
                }
                else
                {
                    _problem += " (удовлетворительно)";
                    return "удовлетворительно";
                }
            }
            else if (height > 185)
            {
                _problem = $"Вес кандидата бульше 185 см";
                if (height > 190)
                {
                    _problem += " (неудовлетворительно)";
                    return "неудовлетворительно";
                }
                else
                {
                    _problem += " (удовлетворительно)";
                    return "удовлетворительно";
                }
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
