namespace Geography_Trivia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hi there. Welcome to Geography Trivia! Press any key to start.");
            Console.ReadKey(true);
            Console.WriteLine("Please enter your full name.");
            string name = Console.ReadLine();
            Console.WriteLine($"Okay, {name}, let's get started!");
           Console.WriteLine("What is the capital of Algeria?");

            string algeria = Console.ReadLine();

            if (algeria == "Algiers")
            {
                Console.WriteLine("Good! Next Question");
            }
            else
            {
                Console.WriteLine("Sorry! Game over.");
                Console.ReadKey();
            }

            Console.WriteLine("Is Zambia in Africa? Press Y for yes, N for no");

            ConsoleKeyInfo Keyinfo = Console.ReadKey();
            if (Keyinfo.KeyChar == 'Y')
            {
                Console.WriteLine("Good! Next Question.");
            }
            else if (Keyinfo.KeyChar == 'N')
            {
                Console.WriteLine("Sorry! Game over.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Invalid input. Ending game.");
                Console.ReadKey();
            }

            }
        }
}