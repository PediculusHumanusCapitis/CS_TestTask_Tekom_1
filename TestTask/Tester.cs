using TestTask.Models;
using TestTask.Services;

namespace TestTask
{
    internal class Tester
    {
        public static void TestCandidate(Candidate candidate)
        {
            List<ITest> tests = new List<ITest>
            {
                new WeightTest(),
                new HeightTest(),
                new AgeTest(),
                new VisionTest(),
                new SmokingTest(),
                new TherapistTest(),
                new PsychologistTest(),
                new WeightAndBadHabitsTest(),
                new StrangeTest(),
                new MathematicalTest()
            };
            Dictionary<string, int> resultsTests = new Dictionary<string, int>{
                { "хорошо", 0 },
                { "удовлетворительно", 0 },
                { "неудовлетворительно", 0 }
            };
            List<string> problems = new List<string>();

            foreach (var test in tests)
            {
                string result = test.Testing(candidate);
                resultsTests[result]++;
                if(result != "хорошо")
                {
                    problems.Add(test.GetProblem());
                }
            }
            if (resultsTests["неудовлетворительно"] > 0 || resultsTests["удовлетворительно"] >= 3)
            {
                Console.WriteLine($"\n\nКандидат {candidate.Name} не прошел тестирование. Проблемы:");
                foreach (var problem in problems)
                {
                    Console.WriteLine($"* {problem}");
                }
            }
            else
            {
                Console.WriteLine($"\n\nКандидат {candidate.Name} подходит");
            }
        }
    }
}
