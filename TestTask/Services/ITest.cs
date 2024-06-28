using TestTask.Models;

namespace TestTask.Services
{
    interface ITest
    {
        string Testing(Candidate candidate);
        string GetProblem();
    }
}
