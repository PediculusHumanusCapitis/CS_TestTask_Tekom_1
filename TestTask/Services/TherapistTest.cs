using TestTask.Models;


namespace TestTask.Services
{
    class TherapistTest : ITest
    {
        private string _problem;
        public string Testing(Candidate candidate)
        {
            string[] illnesses = { "насморк", "бронхит", "вирусы", "аллергия", "ангина", "бессонница" };
            int countIllnesses = candidate.BadHabitsAndDiseases.Count(illnesses.Contains);
            if (countIllnesses > 2)
            {
                _problem = "У кандидата больше 2 терапевтических болезней";
                if (countIllnesses > 3)
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
