using TestTask.Models;

namespace TestTask.Services
{
    class WeightTest : ITest
    {
        private string _problem;
        public string Testing(Candidate candidate)
        {
            int weight = candidate.Weight;
            if (weight < 75)
            {
                _problem = $"Вес кандидата меньше 75 кг";
                if (weight < 70)
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
            else if (weight > 90)
            {
                _problem = $"Вес кандидата бульше 90кг";
                if (weight > 100)
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
