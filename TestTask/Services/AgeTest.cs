using TestTask.Models;


namespace TestTask.Services
{
    class AgeTest : ITest
    {
        private string _problem;
        public string Testing(Candidate candidate)
        {
            int age = candidate.Age;
            if (age < 25)
            {
                _problem = $"Возраст кандидата меньше 25 лет";
                if (age < 23)
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
            else if (age > 35)
            {
                _problem = $"Возраст кандидата бульше 35 лет";
                if (age > 37)
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
