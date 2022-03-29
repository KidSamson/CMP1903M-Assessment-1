using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {
        Analyse analyse = new Analyse();
        //Handles the reporting of the analysis
        //Maybe have different methods for different formats of output?
        //eg.   public void outputConsole(List<int>)

        public void outputConsole(List<int> Parameters)
        {
            Console.WriteLine("Sentences: " + Parameters[0]);
            Console.WriteLine("Vowels: " + Parameters[1]);
            Console.WriteLine("Consonants: " + Parameters[2]);
            Console.WriteLine("Uppercase letters " + Parameters[3]);
            Console.WriteLine("Lowercase letters " + Parameters[4]); 
        }

    }
}
