using TestTask.Models;

namespace TestTask.Services
{
    class PsychologistTest : ITest
    {
        private string _problem;
        public string Testing(Candidate candidate)
        {
            string[] illnesses = { "алкоголизм", "бессонница", "наркомания", "травмы" };
            int countIllnesses = candidate.BadHabitsAndDiseases.Count(illnesses.Contains);
            if (countIllnesses > 0)
            {
                _problem = "У кандидата присутсвтуют психологические болезни";
                if (countIllnesses > 1)
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
