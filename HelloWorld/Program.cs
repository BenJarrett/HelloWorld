using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Howdy Y'all!!");
            Console.ReadKey(); // What happens if you run the app without this line?

            // decalres var "animals" as a string with animals below
            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };
            Random rand = new Random(); // new random string
            int index = rand.Next(animals.Length); // random selection of animals that fulfill earlier conditional

            // Console.ReadLine // 
            // Creates new string equal to 'name'
            // Console prompts user to enter name
            // declares that 'name' is eaqual to the user input
            // Console prints greeting and uses interpelation of 'name' to print the user entered name
            // While loops when the name is equal to name, then do not repeat 

            string name;
            
            do
            {
                Console.WriteLine("What shall I call you?");
                name = Console.ReadLine();
                Console.WriteLine($"Hello, {name}! Here are some of my favorite animals!");

            } while (name != name);

            // Loops through animals and returns all animals less than 5 characters long in length
            foreach (var animal in animals)
            {
                if (animal.Length > 5)
                
                {
                    Console.WriteLine(animal);
                }
            }

            // Asks user what their favorite color is and uses sets the FavColor var equal to the user input
            // Then it asks what the user if they would like their favColor of a random animal from the variable on line 16.
            // Line 17 and 18 are needed to help generate a random index from the variable holding the strings of the animals.
            string favColor;

             do
            {
                Console.WriteLine($"{name}, what is your favorite color?");
                favColor = Console.ReadLine();
                Console.WriteLine($"Would you like a {favColor} {animals[index]}?");

            } while (favColor != favColor);

            // Console.Read() // 

            // The Console.Read() method will detect one single character at a time and return the
            // numeric ASCII value of the character. You can use the Convert.ToChar() method to 
            // convert the integer value into its string representation (e.g. converts 107 to a lowercase k) //           

            // END //


            // ConsoleKeyInfo //

            // The Console.ReadKey() method, like the Read() method, reads one character at a time.
            // Instead of return the ASCII integer value, it returns a ConsoleKeyInfo object. To get the 
            //actual character, you can use the Key property, and convert it into a string.

            // Code Example // 

            //ConsoleKeyInfo enteredKey;

            //do
            //{
            //    enteredKey = Console.ReadKey();
            //    Console.WriteLine($"You pressed the {enteredKey.Key.ToString()} key");

            //} while (enteredKey.Key != ConsoleKey.Escape);

            //// Asks user to give a response to "greetings below
            //Console.Write("Waiting for User response...");

            // END //

            // Console.ReadLine() //
            // The Console.ReadLine() method, unlike the other two methods, will read in an entire line 
            // of characters. In a console application, what defines a line is the CRLF character. If you're 
            // typing in the console, and press Enter, that's considered a line. //

            // CODE EXAMPLE //

            //string sentence;

            //do
            //{
            //    Console.WriteLine("Type in a sentence. Press enter when done.");
            //    sentence = Console.ReadLine();
            //    Console.WriteLine($"You entered the sentence: {sentence}");

            //} while (sentence != "quit");

            // END //

            // Prints line for user to see //
            Console.WriteLine("Choose a greeting!");
            // Declares the value of the variable "greetings" to what the user types in the command line //
            var greetings = Console.ReadLine();
            
            // Passed 'greetings' into the switch case.
            // If the user inputs one of these cases, it prints the WriteLine according to which case the user chose
            // If the user does not enter an input and or inputs something other than these cases, it will print the default case, 'southern'
            switch (greetings)
            {
                case "northern":
                    Console.WriteLine("How are ya bud?");
                    break;
                default:
                case "southern":
                    Console.WriteLine("Howdy Y'all!!");
                    break;
                case "midwestern":
                    Console.WriteLine("Ope! How are ya bud?");
                    break;
            }

            // END // 


            //if (args.Length == 0)
            //{
            //    // Display message to user to provide parameters.
            //    System.Console.WriteLine("Please enter parameter values.");
            //    Console.Read();
            //}
            //else
            //{
            //    // Loop through array to list args parameters.
            //    for (int i = 0; i < args.Length; i++)
            //    {
            //        Console.Write(args[i] + Environment.NewLine);

            //    }
            //    // Keep the console window open after the program has run.
            //    Console.Read();
            //}
        }
    }
}
