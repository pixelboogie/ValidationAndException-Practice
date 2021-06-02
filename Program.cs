using System;

namespace Treehouse.PracticeSession
{
    class Program   
    {
        public static void Main()
        {
            // TODO Switch to using "continue" and "break" 
            // to control the flow of execution through the program.            
            while (true)
            {
                // TODO Update the text "Enter a number: " to 
                // "Enter a number between 1 and 1000: ".
                Console.Write("Enter a number between 1 and 1000: ");
                string entry = Console.ReadLine();
                
                // TODO Force the user's provided value for the "entry" variable 
                // to lowercase letters so the user can type the text "quit"
                // in any of the possible formats.
                if (entry.ToLower() == "quit")
                {
                    // keepGoing = false;
                    break;
                }
                    // TODO Add a try/catch statement to catch FormatException exceptions.
                    // Handle FormatException exceptions by displaying the text 
                    // "'[user's entry value]' is not a number!"
                    try
                    {

                        // TODO Allow the user to enter a fractional value.
                        double number = double.Parse(entry);

                        // TODO If the user enters a value less than or equal to "0"
                        // then display the message 
                        // "Please enter a number greater than '0'."
                        if(number <= 0){
                            Console.WriteLine("Please enter a number greater than '0'.");
                            continue;
                        }
                        // TODO If the user enters a value greater than "1000"
                        // then display the message 
                        // "Please enter a number less than or equal to '1000'."
                        else if(number > 1000){
                            Console.WriteLine("Please enter a number less than or equal to '1000'.");
                            continue;
                        }
                        double result = number * number;
                        Console.WriteLine(number + " multiplied by itself is equal to " + result + ".");
                    }
                    catch(FormatException)
                    {
                        Console.WriteLine("'"+ entry + "'" + " is not a number!");
                    }                   
            }
            Console.WriteLine("Goodbye!");
        }
    }
}