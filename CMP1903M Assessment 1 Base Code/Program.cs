//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        static void Main()
        {
            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();

            //Create 'Input' object
            //Get either manually entered text, or text from a file
            Input textInput = new Input();
            string text = null;
            int menuChoice;
            string numMenuInput;
            bool validInput;
            bool menuProceed = true;
            
            while (menuProceed)
            {
                Console.WriteLine("What would you like to do? Enter 1 or 2");
                Console.WriteLine("1. Enter text from the keyboard");
                Console.WriteLine("2. Read in text from a file");
                numMenuInput = Console.ReadLine();

                Int32.TryParse(numMenuInput, out menuChoice);


                if (menuChoice == 1)
                {
                    menuProceed = false;
                    text = textInput.manualTextInput();
                }

                else if (menuChoice == 2)
                {
                    menuProceed= false;
                    Console.WriteLine("Enter a filepath:");
                    text = textInput.fileTextInput(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("You must enter 1 or 2 to proceed");
                }

            }
          
                
            //Create an 'Analyse' object
            //Pass the text input to the 'analyseText' method

            Analyse analyseSent = new Analyse();
            

            //Receive a list of integers back
            parameters = analyseSent.analyseText(text);


            //Report the results of the analysis
            Report report = new Report();
            report.outputConsole(parameters);
            

            //TO ADD: Get the frequency of individual letters?


        }
        
        
    
    }
}
