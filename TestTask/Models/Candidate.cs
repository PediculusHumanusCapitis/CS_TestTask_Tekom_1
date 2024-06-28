using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Models
{
    class Candidate
    {
        public string Name { get; private set; }
        public int Weight { get; private set; }
        public int Height { get; private set; }
        public int Age { get; private set; }
        public float Vision { get; private set; }
        public List<string> BadHabitsAndDiseases { get; private set; }

        public Candidate(string name, int weight, int height, int age, float vision, List<string> badHabitsAndDiseases)
        {
            Name = name;
            Weight = weight;
            Height = height;
            Age = age;
            Vision = vision;
            BadHabitsAndDiseases = badHabitsAndDiseases;
        }
        public Candidate()
        {

        }
    }
}
