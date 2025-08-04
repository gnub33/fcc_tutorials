namespace passwordchecker;

class Program
{
    /*
     * Ask user to enter pswd, and store
     * ask user to enter pswd again and store
     * check if they both contain something
     *  if so, check if match
     *      yes = print "Passwords match"
     *      no = "No match"
     * if empty, prompt again for password
     */
    static void Main(string[] args)
    {
        

        bool bothPass = false;

        while (!bothPass)
        {
            Console.Write("Enter a password: ");
            string? pswd = Console.ReadLine();
            Console.Write("Enter again: ");
            string? dup = Console.ReadLine();
            
            if (!string.IsNullOrEmpty(pswd) && !string.IsNullOrEmpty(dup))  // if both are not null
            {
                if (pswd.Equals(dup)) // match
                {
                    bothPass = true;
                    Console.WriteLine("Passwords match.");
                }
                else // no match
                {
                    Console.WriteLine("Passwords do not match. Try again.");
                }
            }
            else // empty
            {
                Console.WriteLine("Please enter a Password.");
            }
        }

        
        
        
    }
}