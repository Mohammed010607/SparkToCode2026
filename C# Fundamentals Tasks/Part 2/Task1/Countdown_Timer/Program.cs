namespace Countdown_Timer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an Integer: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Countdown: ");

            for (int i = num; i >= 0; i--) {
                Console.WriteLine(i);
            }
        }
    }
}
