namespace reverse;

class Program
{
    /*
     * ask user to input message
     * print in order
     * print in reverse
     */
    static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string? input = Console.ReadLine();

        if (!string.IsNullOrEmpty(input))
        {
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i]);
                System.Threading.Thread.Sleep(100);
            }
            Console.WriteLine();

            for (int j = input.Length - 1; j >= 0; j--)
            {
                Console.Write(input[j]);
                System.Threading.Thread.Sleep(100);
            }
        }
    }
}