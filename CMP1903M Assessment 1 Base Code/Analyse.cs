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
                // Build a list of vowels up front:
                var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };


                for (int i = 0; i < input.Length; i++)
                {
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
                // Build a list of consonants up front:
                var consonants = new HashSet<char> { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'x', 'z', 'w', 'y' };


                for (int i = 0; i < input.Length; i++)
                {
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
                // Build a list of sentence ends up front:
                var sentSplits = new HashSet<char> { '.', '?', '!' };


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
                int uppersTotal = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    if (char.IsUpper(input[i])) uppersTotal++;
                }
                return uppersTotal;
            }

            static int GetLowers(string input)
            {
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

