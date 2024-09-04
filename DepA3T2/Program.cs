using System;
using System.Threading;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear(); // Clear the console screen
            Console.WriteLine("Current Date and Time:");
            
            // Display the current date and time
            Console.WriteLine(DateTime.Now.ToString("dddd, MMMM dd, yyyy hh:mm:ss tt"));
            
            Thread.Sleep(1000); // Pause for 1 second
        }
    }
}
