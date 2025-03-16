namespace StartEndCodeFixingTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Rewrite the algorithm in C# bellow fixing the error
            // Show the test outputs for the test table in the Readme
            // Put your evidence where it says Do the coding task in C#

            bool validChoice = false;
            int difference = -1;
            int startyear = 9;
            int endyear = 2;
            do
            {
                Console.WriteLine("Enter a start year.");
                startyear = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter an end year.");
                endyear = Convert.ToInt32(Console.ReadLine());

                if (startyear >= endyear)
                {
                    Console.WriteLine("Start year must be before end year.");
                }
                if (startyear > 2000)
                {
                    Console.WriteLine("Start year must be beofre 2000.");
                }
                else 
                {
                    validChoice = true;
                }
            } while (validChoice == false);

            difference = endyear - startyear;
            Console.WriteLine("difference: " + difference);

        }
    }
}
