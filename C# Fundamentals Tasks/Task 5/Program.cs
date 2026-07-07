namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Task 1 (Fixed Grade Array)
            int[] grades = new int[5];
            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine("Enter Grade: " + (i + 1) + ": " );
                grades[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("");
            Console.WriteLine("Your Grades Are: ");
            foreach (int grade in grades) {
                
                Console.WriteLine(grade);
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            

            //Task 2 (Dynamic To-Do List)
            List<string>toDoList = new List<string>();

            for(int i = 0; i< 5; i++)
            {
                Console.WriteLine("Enter task " + (i + 1) + ": " );
                toDoList.Add(Console.ReadLine());
            }
            

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////


            // Task 3 (Browsing History Stack)
            Stack<string> history = new Stack<string>();
            Console.WriteLine("Enter 3 Website URLs: ");
            Console.WriteLine("");
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("URL "+(i + 1).ToString() + ": ");
                string URL = Console.ReadLine();
                history.Push(URL);
            }
            string prevPage = history.Pop();
            Console.WriteLine("Previous Page is: " + prevPage);
            */
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////


            // Task 4 (Customer Service Queue)
            Queue<string> waitingLine = new Queue<string>();
            Console.WriteLine("Enter 3 Customer Nmaes: ");
            Console.WriteLine("");
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Customer "+(i+1)+": ");
                waitingLine.Enqueue(Console.ReadLine());
            }
            Console.WriteLine("First Customer in Line is: "+ waitingLine.Dequeue());
        }
    }
}
