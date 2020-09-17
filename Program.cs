/*
    Author: James Gaddis
    Date: 9/17/2020
    Comments: This C# Console application code deomstrates a Letter grade based on the integer that the user expects to get in this course
*/

using System;

namespace TechProj2b
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for input
            Console.WriteLine("Please enter the grade you expect to get ...");
            /*
                Use the try catch block to validate user input.
                If the user provides bad input, the catch block
                will handle the error and a message will be displayed.
            */
            try
            {
                // This variable will gather data from user input
                string input = Console.ReadLine();
                // This variable will be used to perform the conditional statements and is parsed as an integer
                int value_of_input = int.Parse(input);
                /*
                    This IF/ELSE IF/ELSE statement is used to conditionally
                    test the users input. Various options are available
                    depending on the amount entered by the user.
                */
                if (value_of_input < 59)
                {
                    Console.WriteLine("You have received a grade of F for ISM 4300 ...");
                    Console.WriteLine("Warning you have earned a grade lower than C- in a required course ...");
                    Console.WriteLine("Please contact an advisor to ensure you do not need to pursue major reselection ...");
                    Console.WriteLine("See you next semester!");
                }
                else if ((value_of_input >= 60) && (value_of_input <= 62))
                {
                    Console.WriteLine("You have received a grade of D- for ISM 4300 ...");
                    Console.WriteLine("Warning you have earned a grade lower than C- in a required course ...");
                    Console.WriteLine("Please contact an advisor to ensure you do not need to pursue major reselection ...");
                    Console.WriteLine("See you next semester!");
                }
                else if ((value_of_input >= 63) && (value_of_input <= 66))
                {
                    Console.WriteLine("You have received a grade of D for ISM 4300 ...");
                    Console.WriteLine("Warning you have earned a grade lower than C- in a required course ...");
                    Console.WriteLine("Please contact an advisor to ensure you do not need to pursue major reselection ...");
                    Console.WriteLine("See you next semester!");
                }
                else if ((value_of_input >= 67) && (value_of_input <= 69))
                {
                    Console.WriteLine("You have received a grade of D+ for ISM 4300 ...");
                    Console.WriteLine("Warning you have earned a grade lower than C- in a required course ...");
                    Console.WriteLine("Please contact an advisor to ensure you do not need to pursue major reselection ...");
                    Console.WriteLine("See you next semester!");
                }
                else if ((value_of_input >= 70) && (value_of_input <= 72))
                {
                    Console.WriteLine("You have received a grade of C- for ISM 4300 ...");
                    Console.WriteLine("You passed!");
                }
                else if ((value_of_input >= 73) && (value_of_input <= 76))
                {
                    Console.WriteLine("You have received a grade of C for ISM 4300 ...");
                    Console.WriteLine("You passed!");
                }
                else if ((value_of_input >= 77) && (value_of_input <= 79))
                {
                    Console.WriteLine("You have received a grade of C+ for ISM 4300 ...");
                    Console.WriteLine("You passed!");
                }
                else if ((value_of_input >= 80) && (value_of_input <= 82))
                {
                    Console.WriteLine("You have received a grade of B- for ISM 4300 ...");
                    Console.WriteLine("Well done you are slightly above average!");
                }
                else if ((value_of_input >= 83) && (value_of_input <= 86))
                {
                    Console.WriteLine("You have received a grade of B for ISM 4300 ...");
                    Console.WriteLine("Well done! ...");
                    Console.WriteLine("You did a good job in this class.");
                }
                else if ((value_of_input >= 87) && (value_of_input <= 89))
                {
                    Console.WriteLine("You have received a grade of B+ for ISM 4300 ...");
                    Console.WriteLine("Well done! ...");
                    Console.WriteLine("You did a very good job in this class.");
                }
                else if ((value_of_input >= 90) && (value_of_input <= 92))
                {
                    Console.WriteLine("You have received a grade of A- for ISM 4300 ...");
                    Console.WriteLine("Amazing! ...");
                    Console.WriteLine("A job well done this semeseter. Keep up the great work.");
                }
                else if ((value_of_input >= 93) && (value_of_input <= 100))
                {
                    Console.WriteLine("You have received a grade of A for ISM 4300 ...");
                    Console.WriteLine("Absolutely incredible! ...");
                    Console.WriteLine("You have received full credit to your GPA for this class ...");
                    Console.WriteLine("You were a joy to have in class and I am very proud of your achievement.");
                }
                else
                {
                    Console.WriteLine("Please enter a valid integer: 0-100 ...");
                    Console.WriteLine("Press any key to exit the program and try again ...");
                    Console.ReadKey(true);
                }
            } // end of try
            catch
            {
                Console.WriteLine("Please enter your grade using an integer data type next time ...");
                Console.WriteLine("Press any key to exit the program and try again ...");
                Console.ReadKey(true);
            } // end of catch
        } // end of Main
    } // end of class
} // end of namespace
