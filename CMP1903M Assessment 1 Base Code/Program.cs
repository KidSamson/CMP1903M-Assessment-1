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

            Input input = new Input();
            int menuChoice;
            string text = " ";

            Console.WriteLine(" 1: Do you want to enter the text via the keyboard? \n " +
                "2: Do you want to read in the text from a file?");
            menuChoice = Convert.ToInt32(Console.ReadLine());
            if (menuChoice == 1)
            {
                text = input.manualTextInput();
            }
            else if (menuChoice == 2)
                Console.WriteLine("Enter filename: ");
                text = input.fileTextInput(Console.ReadLine());

                
                
                
            //Create an 'Analyse' object
            //Pass the text input to the 'analyseText' method

            Analyse analyse = new Analyse();


            //Receive a list of integers back
            parameters = analyse.analyseText(text);


            //Report the results of the analysis
            Report report = new Report();
            report.outputConsole(parameters);
            

            //TO ADD: Get the frequency of individual letters?


        }
        
        
    
    }
}
