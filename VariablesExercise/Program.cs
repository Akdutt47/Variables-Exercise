namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Declareing & Initialize variables
            string name = "Bob";
            int age = 31;
            char middleInitial = 'R';
            bool isOver18 = true;
            double currentTemp = 88.3;
            decimal currentPrice = 22.43m;

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Middle Initial: {middleInitial}");
            Console.WriteLine($"Is Over 18: {isOver18}");
            Console.WriteLine($"Current Temp: {currentTemp}");
            Console.WriteLine($"Current Price: {currentPrice}");
        }
    }
}
