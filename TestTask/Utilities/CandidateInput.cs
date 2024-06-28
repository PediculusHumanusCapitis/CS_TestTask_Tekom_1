using TestTask.Models;

namespace TestTask.Utilities
{
    class CandidateInput
    {
        public static Candidate InputCandidate()
        {
            try
            {
                Console.Write("Введите информацию о кандидате: ");
                Console.Write("\n\nИмя кандидата: ");
                string name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Имя не может быть пустым");
                    return null;
                }

                Console.Write("Вес в кг: ");
                int weight = int.Parse(Console.ReadLine());
                if (weight <= 0)
                {
                    Console.WriteLine("Вес должен быть положительным числом");
                    return null;
                }

                Console.Write("Рост в см: ");
                int height = int.Parse(Console.ReadLine());
                if (height <= 0)
                {
                    Console.WriteLine("Рост должен быть положительным числом");
                    return null;
                }

                Console.Write("Возраст: ");
                int age = int.Parse(Console.ReadLine());
                if (age <= 0)
                {
                    Console.WriteLine("Возраст должен быть положительным числом");
                    return null;
                }

                Console.Write("Зрение: ");
                float vision = float.Parse(Console.ReadLine());
                if (vision < 0 || vision > 1)
                {
                    Console.WriteLine("Зрение должно быть в диапазоне от 0 до 1");
                    return null;
                }

                Console.Write("Список вредных привычек и болезней через пробел: ");
                List<string> habitsAndIllnesses = Console.ReadLine().Split(' ').Select(s => s.ToLower()).ToList();

                return new Candidate(name, weight, height, age, vision, habitsAndIllnesses);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка ввода: {e.Message}");
                return null;
            }
        }

    }
}
