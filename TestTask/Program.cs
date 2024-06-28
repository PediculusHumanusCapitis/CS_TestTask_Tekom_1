using TestTask.Models;
using TestTask.Utilities;

namespace TestTask
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Candidate candidate = CandidateInput.InputCandidate();
                Tester.TestCandidate(candidate);
                Console.WriteLine("\n\nПротестировать других кандидатов?");
                string inputLine = Console.ReadLine().ToLower();
                if (inputLine != "да")
                {
                    break;
                }
                Console.Clear();
            }
            
            
        }
    }
}
