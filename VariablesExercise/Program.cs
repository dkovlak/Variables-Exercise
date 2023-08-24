namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string cityName; //Declaration syntax

            cityName = "New York"; //Initialized --- assigning a value

            int cityAge = 399; //Declaring and initializing

            char firstInitial = 'N';

            bool isUSA = true;

            double landArea = 302.6;

            decimal population = 8804190;

            Console.WriteLine($"Hey, do you want to visit {cityName} City in the USA? Its first initial {firstInitial}");
            Console.WriteLine($"This land was found {cityAge} years ago.");
            Console.WriteLine($"{cityName} spans {landArea} square miles, and moreover, the population is {population}. And yes it is {isUSA}");
        }
    }
}
