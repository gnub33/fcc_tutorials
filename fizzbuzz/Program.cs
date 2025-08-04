namespace fizzbuzz;

class Program
{
    /*
     *  Create a for loop from 1 to x (15)
     * 3 and 5 = FizzBuzz
     * 3 = Fizz
     * 5 = Buzz
     * else = number
     */
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int input = Convert.ToInt32(Console.ReadLine());

        bool threeDiv = false;
        bool fiveDiv = false;

        for (int i = 1; i < input + 1; i++)
        {
            // bool values; more efficient since only computed here
            threeDiv = i % 3 == 0;
            fiveDiv = i % 5 == 0;
            
            if (threeDiv && fiveDiv)
            { Console.WriteLine("FizzBuzz"); } 
            else if (fiveDiv)
            { Console.WriteLine("Buzz"); } 
            else if (threeDiv)
            { Console.WriteLine("Fizz"); }
            else { Console.WriteLine(i); }
        }

    }
}