namespace Times_Table;

class Program
{
    /*
     * Ask user for a number for the table
     * Write a for loop to print x times table
     * Add input validation with try/except
     */
    static void Main(string[] args)
    {
        int number = 0; // must be initialized
        bool success = false;
        while (!success)
        {
            Console.Write("Enter a number: ");
            string? inputNum = Console.ReadLine(); 

            if (int.TryParse(inputNum, out int num))
            {
                number = num;
                success = true; // break loop
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
        
        // once valid input is obtained
        Console.WriteLine("Here is the times table: ");
        for (int i = 1; i <= 12; i++)
        {
            Console.WriteLine("{0} x {1} = {2}", i, number, i * number);
        }
        
    }
}