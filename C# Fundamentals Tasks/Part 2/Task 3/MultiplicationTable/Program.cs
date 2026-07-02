namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an Integer: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++) {
                int result = num * i;
                Console.WriteLine(num +" * "+i+" = " + result);
            }
        }
    }
}
