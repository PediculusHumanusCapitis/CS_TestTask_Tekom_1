using TestTask.Models;

namespace TestTask.Services
{
    class WeightAndBadHabitsTest : ITest
    {
        private string _problem;
        public string Testing(Candidate candidate)
        {
            int weight = candidate.Weight;
            bool hasColdOrVirus = candidate.BadHabitsAndDiseases.Contains("простуда") || candidate.BadHabitsAndDiseases.Contains("вирус");
            if (candidate.BadHabitsAndDiseases.Contains("курение") && hasColdOrVirus && (weight > 120 || weight < 60))
            {
                _problem = "Кандидат курит, у кандидата простуда и/или вирусы, и его вес больше 120 кг или меньше 60 кг (неудовлетворительно)";
                return "неудовлетворительно";
            }
            else if (hasColdOrVirus && weight > 110)
            {
                _problem = "у кандидата есть простуда и/или вирусы, и его вес больше 110 кг (удовлетворительно)";
                return "удовлетворительно";
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
