using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {
        //Handles the analysis of text

        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        public List<int> analyseText(string input)
        {
            static int GetVow(string input)

            {

                int vowTotal = 0;
                // Define vowels:
                var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

                // Loops over characters in input to check against those in list and increments 
                // vowtotal when found
                for (int i = 0; i < input.Length; i++)
                {       //ToLower method is used to convert string, saves need of defining both upper and lose case vowels
                    if (vowels.Contains(input.ToLower()[i]))
                    {
                        vowTotal++;
                    }
                }
                return vowTotal;
            }

            static int GetCons(string input )

            {

                int consTotal = 0;
                // define consonants:
                var consonants = new HashSet<char> { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'x', 'z', 'w', 'y' };


                // Loops over characters in input to check against those in list and increments 
                // constotal when found
                for (int i = 0; i < input.Length; i++)
                {       //ToLower method is used to convert string, saves need of defining both upper and lose case consonants
                    if (consonants.Contains(input.ToLower()[i]))
                    {
                        consTotal++;
                    }
                }
                return consTotal;
            }

            static int GetSents(string input)

            {

                int sentsTotal = 0;
                // define ends of sentences:
                var sentSplits = new HashSet<char> { '.', '?', '!' };


                // Loops through characters in input to check against those in list and increments 
                // sentSplits when found
                for (int i = 0; i < input.Length; i++)
                {
                    if (sentSplits.Contains(input[i]))
                    {
                        sentsTotal++;
                    }
                }
                return sentsTotal;
            }

            static int GetUppers(string input)
            {

                // Loops through characters in input and uses static IsUpper method to check
                //  whether they are upper case, uppersTotal is incremented when upper case characters
                // are found
                int uppersTotal = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    if (char.IsUpper(input[i])) uppersTotal++;
                }
                return uppersTotal;
            }

            static int GetLowers(string input)
            {
                // Loops through characters in input and uses static IsLower method to check
                //  whether they are upper case, lowersTotal is incremented when upper case characters
                // are found
                int lowersTotal = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    if (char.IsLower(input[i])) lowersTotal++;
                }
                return lowersTotal;
            }

            //List of integers to hold the first five measurements:
            //1. Number of sentences
            //2. Number of vowels
            //3. Number of consonants
            //4. Number of upper case letters
            //5. Number of lower case letters
            List<int> values = new List<int>();
            //Initialise all the values in the list to '0'
            for(int i = 0; i<5; i++)
            {
                values.Add(0);
             
            }

            // Calls methods and assigns return values to "values" list
            values[0] = GetSents(input);
            values[1] = GetVow(input);
            values[2] = GetCons(input);
            values[3] = GetUppers(input);
            values[4] = GetLowers(input);
            
            Console.WriteLine(values);


            return values;
        }

       
    }
}

