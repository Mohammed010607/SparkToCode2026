namespace Number_Guessing_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fixedNum = 42; // The fixed number to guess
            int guess;
            int attempts = 0;
            do
            {
                Console.WriteLine("Guess a Number:");
                guess = int.Parse(Console.ReadLine());
                attempts++;

                if (guess > fixedNum) { 
                    Console.WriteLine("Too High Try Again.");

                }
                else if (guess < fixedNum)
                {
                    Console.WriteLine("Too Low Try Again.");
                }
                else
                {
                    Console.WriteLine("Correct. It took you "+attempts + " attempts.");
                }
            }
            while (guess != fixedNum);
        }
    }
}
